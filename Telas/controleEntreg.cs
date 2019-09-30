using processosAdministrativos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using processosAdministrativos.Telas;
using processosAdministrativos.Classes;

namespace processosAdministrativos.Telas
{
    public partial class controleEntreg : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        public DateTime expedicao, aCaminho, entregue;
        controlTelaAberta cta = new controlTelaAberta();

        string vendedor = string.Empty;
        string cliente = string.Empty;
        string situacao = string.Empty;
        string exped = string.Empty;
        string aCam = string.Empty;
        string entreg = string.Empty;
        string pedido2 = string.Empty;
        string clietne = string.Empty;

        public bool existente()
        {
            Sql = "SELECT count(pedido_contEntre) FROM controle_entrega WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object pedido = dao.Query.ExecuteScalar();
            dao.desconecta();
            if (pedido.ToString() == "0")
            {
                return false;
            }
            else{
                return true;
            }
        }
        public void pedido()
        {
            if (existente() == true)
            {
                motoboyTxt.Enabled = true;
                try
                {
                    Sql = "SELECT vendedor_contEntre, cliente_contEntre, situacao_contEntre, dt_expedicao, dt_aCaminho, dt_entregue FROM controle_entrega WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
                    dao.Query = new MySqlCommand(Sql, dao.Conexao);
                    dao.conecta();                    
                    MySqlDataReader auxExped = dao.Query.ExecuteReader();
                    while (auxExped.Read())
                    {
                        vendedor = auxExped["vendedor_contEntre"].ToString();
                        cliente = auxExped["cliente_contEntre"].ToString();
                        situacao = auxExped["situacao_contEntre"].ToString();
                        exped = auxExped["dt_expedicao"].ToString();
                        aCam = auxExped["dt_aCaminho"].ToString();
                        entreg = auxExped["dt_entregue"].ToString();
                    }
                    auxExped.Close();
                    dao.desconecta();

                    vendedorTxt.Text = vendedor;
                    clienteTxt.Text = cliente;
                    if (situacao.ToString() == "Expedição")
                    {                      
                        expedicaoRd.Checked = true;
                        aCaminhoRd.Checked = false;
                        entregueRd.Checked = false;
                        expedicaoRd.Enabled = false;
                        aCaminhoRd.Enabled = true;
                        entregueRd.Enabled = false;
                        expedicao = Convert.ToDateTime(exped);
                        aCaminho = Convert.ToDateTime(aCam);
                        entregue = Convert.ToDateTime(entreg);
                    }
                    else
                    {
                        if (situacao.ToString() == "A caminho")
                        {
                            Sql = "SELECT trp_nome FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
                            dao.Query = new MySqlCommand(Sql, dao.Conexao);
                            dao.conecta();
                            object motoboy = dao.Query.ExecuteScalar();
                            motoboyTxt.Text = motoboy.ToString();
                            expedicaoRd.Checked = false;
                            aCaminhoRd.Checked = true;
                            entregueRd.Checked = false;
                            expedicaoRd.Enabled = false;
                            aCaminhoRd.Enabled = false;
                            entregueRd.Enabled = true;
                            expedicao = Convert.ToDateTime(exped);
                            aCaminho = Convert.ToDateTime(aCam);
                            entregue = Convert.ToDateTime(entreg);
                            dao.desconecta();
                        }
                        else
                        {
                            Sql = "SELECT trp_nome FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
                            dao.Query = new MySqlCommand(Sql, dao.Conexao);
                            dao.conecta();
                            object motoboy = dao.Query.ExecuteScalar();
                            motoboyTxt.Text = motoboy.ToString();
                            expedicaoRd.Checked = false;
                            aCaminhoRd.Checked = false;
                            entregueRd.Checked = true;
                            expedicaoRd.Enabled = false;
                            aCaminhoRd.Enabled = false;
                            entregueRd.Enabled = false;
                            expedicao = Convert.ToDateTime(exped);
                            aCaminho = Convert.ToDateTime(aCam);
                            entregue = Convert.ToDateTime(entreg);
                            dao.desconecta();
                        }
                    }
                }
                catch (MySqlException errro)
                {
                    MessageBox.Show(errro + " No Banco");
                }
            }
            else
            {
                try
                {
                    Sql = "SELECT vdd_nome, cli_nome FROM (pedidos inner join vendedores on pedidos.ped_vendedor = vendedores.vdd_codigo) inner join clientes on pedidos.ped_cliente = clientes.cli_codigo WHERE ped_numero = " + int.Parse(nPedidoTxt.Text);
                    dao.Query = new MySqlCommand(Sql, dao.Conexao);
                    dao.conecta();
                    MySqlDataReader cliPed = dao.Query.ExecuteReader();
                    while (cliPed.Read())
                    {
                        pedido2 = cliPed["vdd_nome"].ToString();
                        cliente = cliPed["cli_nome"].ToString();
                    }
                    cliPed.Close();
                    dao.desconecta();
                    vendedorTxt.Text = pedido2;
                    clienteTxt.Text = cliente;
                    expedicaoRd.Enabled = true;
                    aCaminhoRd.Enabled = false;
                    entregueRd.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Pedido não existente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampo();
                }
            }
            
        }

        public void limpaCampo()
        {
            nPedidoTxt.Text = string.Empty;
            vendedorTxt.Text = string.Empty;
            clienteTxt.Text = string.Empty;
            motoboyTxt.Text = string.Empty;
            string vendedor = string.Empty;
            string cliente = string.Empty;
            string situacao = string.Empty;
            string exped = string.Empty;
            string aCam = string.Empty;
            string entreg = string.Empty;
            string pedido2 = string.Empty;
            string clietne = string.Empty;
            expedicaoRd.Checked = false;
            aCaminhoRd.Checked = false;
            entregueRd.Checked = false;
            motoboyTxt.Enabled = false;
            expedicaoRd.Enabled = false;
            aCaminhoRd.Enabled = false;
            entregueRd.Enabled = false;
            nPedidoTxt.Focus();
        }
        public controleEntreg()
        {
            InitializeComponent();
        }

        private void nPedidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                if (e.KeyChar == 13)
                {
                    if (nPedidoTxt.Text != "")
                    {
                        motoboyTxt.Text = string.Empty;
                        pedido();
                    }
                    else
                    {
                        MessageBox.Show("Número do pedido não informado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }                     
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void relatorioBt_Click(object sender, EventArgs e)
        {
            if (cta.TelaProcEntre == 0)
            {
                procuraEntrega pe = new procuraEntrega();
                pe.Show();
                cta.TelaProcEntre = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["procuraEntrega"].BringToFront();
            }
        }

        private void gravaBt_Click_1(object sender, EventArgs e)
        {
            if (clienteTxt.Text != "" && nPedidoTxt.Text != "" && vendedorTxt.Text != "" && (expedicaoRd.Checked == true || aCaminhoRd.Checked == true || entregueRd.Checked == true))
            {
                controlEntreg cl = new controlEntreg();
                cl.Pedido_contEntre = int.Parse(nPedidoTxt.Text);
                cl.Vendedor_contEntre = vendedorTxt.Text;
                cl.Cliente_contEntre = clienteTxt.Text;
                if (string.Equals(motoboyTxt.Text, "darlan", StringComparison.OrdinalIgnoreCase) || string.Equals(motoboyTxt.Text, "d", StringComparison.OrdinalIgnoreCase))
                {
                    cl.Motoboy_contEntre = 39;
                }
                else
                {
                    if (string.Equals(motoboyTxt.Text, "nilson", StringComparison.OrdinalIgnoreCase) || string.Equals(motoboyTxt.Text, "n", StringComparison.OrdinalIgnoreCase))
                    {
                        cl.Motoboy_contEntre = 40;
                    }
                    else
                    {
                        if (string.Equals(motoboyTxt.Text, "richard", StringComparison.OrdinalIgnoreCase) || string.Equals(motoboyTxt.Text, "r", StringComparison.OrdinalIgnoreCase))
                        {
                            cl.Motoboy_contEntre = 41;
                        }
                        else
                        {
                            if (string.Equals(motoboyTxt.Text, "", StringComparison.OrdinalIgnoreCase) && expedicaoRd.Checked == true)
                            {
                                cl.Motoboy_contEntre = 42;
                            }
                            else
                            {
                                cl.Motoboy_contEntre = 5;
                            }
                        }
                    }
                }
                if (expedicaoRd.Checked == true)
                {
                    cl.Situacao_contEntre = "Expedição";
                    cl.Dt_expedicao = DateTime.Now;
                    cl.Dt_aCaminho = aCaminho;
                    cl.Dt_entregue = entregue;
                }
                else
                {
                    if (aCaminhoRd.Checked == true)
                    {
                        cl.Situacao_contEntre = "A caminho";
                        cl.Dt_expedicao = expedicao;
                        cl.Dt_aCaminho = DateTime.Now;
                        cl.Dt_entregue = entregue;
                    }
                    else
                    {
                        if (entregueRd.Checked == true)
                        {
                            cl.Situacao_contEntre = "Entregue";
                            cl.Dt_expedicao = expedicao;
                            cl.Dt_aCaminho = aCaminho;
                            cl.Dt_entregue = DateTime.Now;
                        }
                    }
                }

                if (existente() == false)
                {
                    dao.cadastraEntrega(cl);
                    MessageBox.Show("Situação Salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampo();
                }
                else
                {
                    if (existente() == true)
                    {
                        cl.Alterar = int.Parse(nPedidoTxt.Text);
                        dao.alteraEntrega(cl);
                        MessageBox.Show("Situação Salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCampo();
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Nem todos os campos foram preenchidos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            expedicao = Convert.ToDateTime("0001-01-01 00:00:00");
            aCaminho = Convert.ToDateTime("0001-01-01 00:00:00");
            entregue = Convert.ToDateTime("0001-01-01 00:00:00");

        }

        private void ControleEntreg_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaContEntre = 0;
            limpaCampo();
        }
    }
}
