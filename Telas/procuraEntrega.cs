using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraEntrega : Form
    {
        DAO dao = new DAO();

        private string Sql = String.Empty;
        public DateTime aCaminhoVar, entregueVar;
        controlTelaAberta cta = new controlTelaAberta();

        string vendedorVar = string.Empty;
        string clienteVar = string.Empty;
        string situacaoVar = string.Empty;
        string aCamVar = string.Empty;
        string entregVar = string.Empty;
        string pedido2Var = string.Empty;
        string clienteVar2 = string.Empty;

        public void bloqueios()
        {
            nPedidoTxt.Enabled = false;
            motoboyTxt.Enabled = false;
            comboBox1.Enabled = false;
            limparBt.Enabled = false;
            gravaBt.Enabled = false;
        }

        public bool existente()
        {
            Sql = "SELECT count(pedido_contEntre) FROM controle_entrega WHERE pedido_contEntre = '" + int.Parse(nPedidoTxt.Text)+"'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object pedido = dao.Query.ExecuteScalar();
            dao.desconecta();
            if (pedido.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void pedidoClass()
        {
            if (existente() == true)
            {
                motoboyTxt.Enabled = true;
                try
                {
                    Sql = "SELECT vendedor_contEntre, cliente_contEntre, situacao_contEntre, dt_aCaminho, dt_entregue FROM controle_entrega WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
                    dao.Query = new MySqlCommand(Sql, dao.Conexao);
                    dao.conecta();
                    MySqlDataReader auxExped = dao.Query.ExecuteReader();
                    while (auxExped.Read())
                    {
                        vendedorVar = auxExped["vendedor_contEntre"].ToString();
                        clienteVar = auxExped["cliente_contEntre"].ToString();
                        situacaoVar = auxExped["situacao_contEntre"].ToString();
                        aCamVar = auxExped["dt_aCaminho"].ToString();
                        entregVar = auxExped["dt_entregue"].ToString();
                    }
                    auxExped.Close();
                    dao.desconecta();

                    vendedorTxt.Text = vendedorVar;
                    clienteTxt.Text = clienteVar;

                    if (situacaoVar == "A caminho") comboBox1.SelectedIndex = 0;
                    else if (situacaoVar == "Entregue") comboBox1.SelectedIndex = 1;

                    if (situacaoVar.ToString() == "A caminho")
                    {
                        Sql = "SELECT trp_nome FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
                        dao.Query = new MySqlCommand(Sql, dao.Conexao);
                        dao.conecta();
                        object motoboy = dao.Query.ExecuteScalar();
                        motoboyTxt.Text = motoboy.ToString();
                        comboBox1.SelectedIndex = 0;
                        aCaminhoVar = Convert.ToDateTime(aCamVar);
                        entregueVar = Convert.ToDateTime(entregVar);
                        dao.desconecta();
                    }
                    else
                    {
                        Sql = "SELECT trp_nome FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE pedido_contEntre = " + int.Parse(nPedidoTxt.Text);
                        dao.Query = new MySqlCommand(Sql, dao.Conexao);
                        dao.conecta();
                        object motoboy = dao.Query.ExecuteScalar();
                        motoboyTxt.Text = motoboy.ToString();
                        comboBox1.SelectedIndex = 1;
                        aCaminhoVar = Convert.ToDateTime(aCamVar);
                        entregueVar = Convert.ToDateTime(entregVar);
                        dao.desconecta();
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
                        pedido2Var = cliPed["vdd_nome"].ToString();
                        clienteVar = cliPed["cli_nome"].ToString();
                    }
                    cliPed.Close();
                    dao.desconecta();
                    if (pedido2Var != string.Empty)
                    {
                        vendedorTxt.Text = pedido2Var;
                        clienteTxt.Text = clienteVar;
                    }
                    else
                    {
                        MessageBox.Show("Pedido não existente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpaCampo();
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

        }

        public void limpaCampo()
        {
            nPedidoTxt.Text = string.Empty;
            vendedorTxt.Text = string.Empty;
            clienteTxt.Text = string.Empty;
            motoboyTxt.Text = string.Empty;
            vendedorVar = string.Empty;
            clienteVar = string.Empty;
            situacaoVar = string.Empty;
            aCamVar = string.Empty;
            entregVar = string.Empty;
            pedido2Var = string.Empty;
            clienteVar2 = string.Empty;
            nPedidoTxt.Focus();
            comboBox1.SelectedIndex = -1;
        }

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            if (pedidoRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT pedido_contEntre, vendedor_contEntre, cliente_contEntre, trp_nome, dt_aCaminho, dt_entregue FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE pedido_contEntre LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY pedido_contEntre");
            else if (vendedorRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT pedido_contEntre, vendedor_contEntre, cliente_contEntre, trp_nome, dt_aCaminho, dt_entregue FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE vendedor_contEntre LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY pedido_contEntre");
            else if (clienteRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT pedido_contEntre, vendedor_contEntre, cliente_contEntre, trp_nome, dt_aCaminho, dt_entregue FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE cliente_contEntre LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY pedido_contEntre");
            else if (motoboyRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT pedido_contEntre, vendedor_contEntre, cliente_contEntre, trp_nome, dt_aCaminho, dt_entregue FROM controle_entrega inner join transportadoras on controle_entrega.motoboy_contEntre = transportadoras.trp_codigo WHERE trp_nome LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY pedido_contEntre");
        }
        public procuraEntrega()
        {
            InitializeComponent();
        }

        private void procuraEntrega_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gs_aristeusDataSet.controle_entrega' table. You can move, or remove it, as needed.
            pedidoRb.Checked = true;
            inferiorMtxt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            superiorMtxt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            preencheTabela();
            if(cta.TelaEntrega == 1)
            {
                bloqueios();
            }
        }

        private void pesqusiarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void sairBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void nPedidoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (nPedidoTxt.Text != "")
                    {
                        comboBox1.SelectedIndex = -1;
                        motoboyTxt.Text = string.Empty;
                        pedidoClass();
                        motoboyTxt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Número do pedido não informado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void nPedidoTxt_Leave(object sender, EventArgs e)
        {
            if (nPedidoTxt.Text != "")
            {
                comboBox1.SelectedIndex = -1;
                motoboyTxt.Text = string.Empty;
                pedidoClass();
                motoboyTxt.Focus();
            }
        }

        private void gravaBt_Click(object sender, EventArgs e)
        {
            if (clienteTxt.Text != "" && nPedidoTxt.Text != "" && vendedorTxt.Text != "" && comboBox1.SelectedIndex >= 0)
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
                            cl.Motoboy_contEntre = 5;
                        }
                    }
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    cl.Situacao_contEntre = "A caminho";
                    cl.Dt_aCaminho = DateTime.Now;
                    cl.Dt_entregue = DateTime.MinValue;
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        cl.Situacao_contEntre = "Entregue";
                        cl.Dt_aCaminho = aCaminhoVar;
                        cl.Dt_entregue = DateTime.Now;
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
                MessageBox.Show("Nem todos os campos foram preenchidos", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            preencheTabela();
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void procuraEntrega_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            if (cta.TelaEntrega == 1) cta.TelaEntrega = 0;
            else cta.TelaContEntre = 0;
            limpaCampo();
        }
    }
}
