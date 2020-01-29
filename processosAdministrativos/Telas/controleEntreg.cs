using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using processosAdministrativos.Classes;
using System.Text.RegularExpressions;

namespace processosAdministrativos.Telas
{
    public partial class controleEntreg : Form
    {
        DAO dao = new DAO();
        variaveis var = new variaveis();
        private string Sql = String.Empty;

        List<int> codMotoBoy = new List<int>();
        List<String> nomeMotoBoy = new List<string>();
        List<int> vendedor = new List<int>();
        List<String> entregue = new List<String>();
        List<int> codigo = new List<int>();

        int nPed = 0;
        string dataPed = string.Empty;
        string cliPed = string.Empty;
        int alterar = 0;
        string verifica = "^[0-9]";

        public bool PedidoACaminho()
        {
            int x = 0;
            Sql = "SELECT COUNT(pedido_contEntre) as 'cont', if(COUNT(pedido_contEntre) = 1, situacao_contEntre, 0) as 'situ' FROM controle_entrega WHERE pedido_contEntre = '" + nPedidoTxt.Text + "' and pedido_contEntre != '0'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while (aux.Read())
            {
                x = Convert.ToInt32(aux["cont"]);
                entregue.Add(aux["situ"].ToString());
            }
            dao.desconecta();
            if (x == 1)
                return true;
            else
                return false;
        }

        class motoboy
        {
            public int codigo { get; set; }
            public string nome { get; set; }
        }

        List<motoboy> listaMotoboy = new List<motoboy>();
        public void PreencheComboBox()
        {
            Sql = "SELECT trp_codigo, trp_nome FROM transportadoras WHERE trp_atuacao LIKE '%ENTREGA INTERNA%'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader auxMotoBoy = dao.Query.ExecuteReader();
            while (auxMotoBoy.Read())
            {
                codMotoBoy.Add(Convert.ToInt32(auxMotoBoy["trp_codigo"]));
                nomeMotoBoy.Add(auxMotoBoy["trp_nome"].ToString());
            }
            auxMotoBoy.Close();
            dao.desconecta();
            for(int i = 0; i < codMotoBoy.Count; i++)
                listaMotoboy.Add(new motoboy { codigo = codMotoBoy[i], nome = nomeMotoBoy[i]});

            motoBoyCb.DataSource = listaMotoboy;
            motoBoyCb.DisplayMember = "nome";
            motoBoyCb.ValueMember = "codigo";
        }

        public bool EncontraPedido()
        {
            try
            {
                Sql = "select ped_numero, date_format(ped_data, '%d/%m/%Y') as 'data', ped_nmcliente, ped_vendedor from pedidos where ped_numero like '%" + Convert.ToInt32(nPedidoTxt.Text) + "%'";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                MySqlDataReader auxPed = dao.Query.ExecuteReader();
                while (auxPed.Read())
                {
                    nPed = Convert.ToInt32(auxPed["ped_numero"]);
                    dataPed = auxPed["data"].ToString();
                    cliPed = auxPed["ped_nmcliente"].ToString();
                    vendedor.Add(Convert.ToInt32(auxPed["ped_vendedor"]));
                }
                auxPed.Close();
                dao.desconecta();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Pedido não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        class preenchePedido
        {
            public int numero { get; set; }
            public string data { get; set; }
            public string cliente { get; set; }
            public string obs { get; set; }
        }

        List<preenchePedido> ped = new List<preenchePedido>();

        public void PreencheTabela()
        {
            if (Regex.IsMatch(nPedidoTxt.Text, verifica))
            {
                ped.Add(new preenchePedido()
                {
                    numero = nPed,
                    data = dataPed,
                    cliente = cliPed,
                    obs = ""
                });
            }
            else
            {
                ped.Add(new preenchePedido()
                {
                    numero = 0,
                    data = "",
                    cliente = "Apanho",
                    obs = ""
                });
            }

            pedidosGv.DataSource = null;
            pedidosGv.DataSource = ped;
            pedidosGv.Columns[0].HeaderText = "N° Pedido";
            pedidosGv.Columns[1].HeaderText = "Data";
            pedidosGv.Columns[2].HeaderText = "Cliente";
            pedidosGv.Columns[3].HeaderText = "Obs.";

            pedidosGv.Columns[0].Width = 90;
            pedidosGv.Columns[1].Width = 70;
            pedidosGv.Columns[2].Width = 120;
            pedidosGv.Columns[3].Width = 120;

            pedidosGv.Columns[0].ReadOnly = true;
            pedidosGv.Columns[1].ReadOnly = true;
            pedidosGv.Columns[2].ReadOnly = true;
        }

        public void Limpar()
        {
            codMotoBoy.Clear();
            nomeMotoBoy.Clear();
            vendedor.Clear();
            codigo.Clear();
            nPed = 0;
            dataPed = string.Empty;
            cliPed = string.Empty;
            entregue.Clear();
            pedidosGv.DataSource = null;
            ped.Clear();
            alterar = 0;
        }

        public void Salvar()
        {
            controlEntreg cl = new controlEntreg();
            for (int i = 0; i < pedidosGv.RowCount; i++)
            {
                if (entregue[i] == "A caminho")
                {
                    cl.Situacao_contEntre = "Entregue";
                    cl.Dt_entregue = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    dao.alteraEntrega(cl, Convert.ToInt32(pedidosGv.Rows[i].Cells[0].Value));
                }
                else if (entregue[i] == "0")
                {
                    cl.Pedido_contEntre = Convert.ToInt32(pedidosGv.Rows[i].Cells[0].Value);
                    cl.Cliente_contEntre = pedidosGv.Rows[i].Cells[2].Value.ToString();
                    if (pedidosGv.Rows[i].Cells[2].Value.ToString() == "Apanho")
                        cl.Vendedor_contEntre = 0;
                    else
                        cl.Vendedor_contEntre = vendedor[i];
                    cl.Motoboy_contEntre = Convert.ToInt32(motoBoyCb.SelectedValue);
                    cl.Situacao_contEntre = "A caminho";
                    cl.Dt_aCaminho = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cl.Dt_entregue = "2000-01-01 00:00:00";
                    cl.Obs_contEntre = pedidosGv.Rows[i].Cells[3].Value.ToString();
                    dao.cadastraEntrega(cl);
                }

            }
            timer1.Stop();
            Limpar();
        }

        public void Alterar()
        {
            controlEntreg cl = new controlEntreg();
            for (int i = 0; i < pedidosGv.RowCount; i++)
            {
                if (entregue[i] == "A caminho")
                {
                    cl.Situacao_contEntre = "Entregue";
                    cl.Dt_entregue = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    dao.alteraEntrega(cl, Convert.ToInt32(pedidosGv.Rows[i].Cells[0].Value));
                }
            }
            timer1.Stop();
            Limpar();
        }

        public controleEntreg()
        {
            InitializeComponent();
        }
        private void ControleEntreg_Load(object sender, EventArgs e)
        {
            motoBoyCb.Focus();
            PreencheComboBox();
        }

        private void ControleEntreg_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaContEntre = 0;
        }

        private void MotoBoyCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                nPedidoTxt.Focus();
        }

        private void NPedidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = 0;
            if (e.KeyChar == 13)
            {
                if (Regex.IsMatch(nPedidoTxt.Text, verifica))
                {
                    for(int i = 0; i < pedidosGv.RowCount; i++)
                    {
                        if (pedidosGv.Rows[i].Cells[0].Value.ToString() == nPedidoTxt.Text)
                        {
                            x = 1;
                            break;
                        }
                    }
                    if (x == 0)
                    {
                        if (EncontraPedido() == true)
                        {
                            if (PedidoACaminho() == true)
                                alterar = 1;

                            timer1.Stop();
                            PreencheTabela();
                            nPedidoTxt.Text = string.Empty;
                            timer1.Start();
                        }
                    }
                    else
                        nPedidoTxt.Text = string.Empty;
                }
                else
                {
                    entregue.Add("0");
                    timer1.Stop();
                    PreencheTabela();
                    nPedidoTxt.Text = string.Empty;
                    timer1.Start();
                }
            }
        }

        private void GravaBt_Click(object sender, EventArgs e)
        {
            if(nPedidoTxt.Text == string.Empty)
            {
                Salvar();
                motoBoyCb.Focus();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (nPedidoTxt.Text == string.Empty)
            {
                Salvar();
                motoBoyCb.Focus();
            }
        }

        private void PedidosGv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            timer1.Stop();
        }

        private void PedidosGv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                timer1.Start();
            }
        }

        private void PedidosGv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                timer1.Start();
                nPedidoTxt.Focus();
            }
        }

        private void RelatorioBt_Click(object sender, EventArgs e)
        {
            procuraEntrega pe = new procuraEntrega();
            pe.Show();
        }

        private void ControleEntreg_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void ControleEntreg_Activated_1(object sender, EventArgs e)
        {
            if(var.FechaTela == 1)
            {
                motoBoyCb.Focus();
                var.FechaTela = 0;
            }
        }
    }
}