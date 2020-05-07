using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos
{
    public partial class NSerie : Form
    {
        DAO dao = new DAO();
        private string Sql = string.Empty;

        public bool VerificaPedido()
        {
            Sql = "SELECT count(ped_numero) FROM pedidos where ped_numero = " + pedidoTxt.Text + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            object pedido = dao.Query.ExecuteScalar();
            dao.Desconecta();

            Sql = "SELECT count(pdi_item) FROM peditem where pdi_numero = " + pedidoTxt.Text + " AND pdi_item = " + produtoTxt.Text + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            object produto = dao.Query.ExecuteScalar();
            dao.Desconecta();

            if (Convert.ToInt32(pedido) > 0)
            {
                if (Convert.ToInt32(produto) > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado no pedido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Pedido Inválido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public void LimpaCampo()
        {
            pedidoTxt.Text = string.Empty;
            produtoTxt.Text = string.Empty;
            nSerieTxt.Text = string.Empty;
        }

        public NSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nSerieTxt.Text != string.Empty && pedidoTxt.Text != string.Empty && produtoTxt.Text != string.Empty)
            {
                if (VerificaPedido() == true)
                {
                    DAO dao = new DAO();
                    ControlNSerie cn = new ControlNSerie();
                    cn.Ns_pedido = pedidoTxt.Text;
                    cn.Ns_produto = produtoTxt.Text;
                    cn.Ns_nSerie = nSerieTxt.Text;
                    cn.Ns_data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    dao.CadastraNSerie(cn);
                    MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampo();
                }
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaNSerie = 0;
        }
    }
}
