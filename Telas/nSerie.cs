using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos
{
    public partial class nSerie : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;

        public bool verificaPedido()
        {
            Sql = "SELECT count(ped_numero) FROM pedidos where ped_numero = " + pedidoTxt.Text + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object pedido = dao.Query.ExecuteScalar();
            dao.desconecta();

            Sql = "SELECT count(pdi_item) FROM peditem where pdi_numero = " + pedidoTxt.Text + " AND pdi_item = " + produtoTxt.Text + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object produto = dao.Query.ExecuteScalar();
            dao.desconecta();

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

        public void limpaCampo()
        {
            pedidoTxt.Text = string.Empty;
            produtoTxt.Text = string.Empty;
            nSerieTxt.Text = string.Empty;
        }

        public nSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nSerieTxt.Text != string.Empty && pedidoTxt.Text != string.Empty && produtoTxt.Text != string.Empty)
            {
                if (verificaPedido() == true)
                {
                    DAO dao = new DAO();
                    controlNSerie cn = new controlNSerie();
                    cn.Ns_pedido = pedidoTxt.Text;
                    cn.Ns_produto = produtoTxt.Text;
                    cn.Ns_nSerie = nSerieTxt.Text;
                    cn.Ns_data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    dao.cadastraNSerie(cn);
                    MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaCampo();
                }
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaNSerie = 0;
        }
    }
}
