using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraProd : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        Variaveis vat = new Variaveis();
        ControlTelaAberta cta = new ControlTelaAberta();

        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }
        public void PreencheTabela()
        {
            QueryDataTable qdt = new QueryDataTable();

            string pesquisar = CorrecoesTexto(pesquisaTxt.Text);

            if (codigoRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select itm_codigo, itm_descricao from itens where itm_codigo like '%" + pesquisar + "%'");
            else if (nomeRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select itm_codigo, itm_descricao from itens where itm_descricao like '%" + pesquisar + "%'");
            else if (codigoBarrasRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select itm_codigo, itm_descricao from itens where itm_codbarras like '%" + pesquisar + "%'");
        }

        public ProcuraProd()
        {
            InitializeComponent();
        }

        private void procuraProd_Load(object sender, EventArgs e)
        {
            if (cta.TelaCadLote == 1)
                codigoBarrasRb.Checked = true;
            else
                codigoRb.Checked = true;

            pesquisaTxt.Focus();
            PreencheTabela();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (vat.Aux1AssistTec == 1)
            {
                Sql = "SELECT nome_assistTec, telefone_assistTec, endereco_assistTec, fnc_nome, itm_descricao, lat_assistTec, long_assistTec FROM (itens INNER JOIN assistencias_tecnicas ON itens.itm_fornecedor = assistencias_tecnicas.fornecedor_assistTec) INNER JOIN fornecedores ON assistencias_tecnicas.fornecedor_assistTec = fornecedores.fnc_codigo WHERE itm_codigo = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.Conecta();
                MySqlDataReader assistTec = dao.Query.ExecuteReader();

                if (assistTec.Read())
                {
                    vat.CodProdAssistTec = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    vat.Aux1AssistTec = 0;
                }
                else
                {
                    MessageBox.Show("Produto sem assistência técnica!", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dao.Desconecta();
            }
            else if(vat.AuxLote2 == 1)
            {
                vat.CodProdLote = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vat.NomeProdLote = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (vat.AuxArmaze == 1)
            {
                vat.CodProdArmaze = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                vat.NomeProdArmaze = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (vat.AuxLOE1 == 1)
            {
                vat.CodProdLOE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vat.NomeProdLOE = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (vat.AuxLOE2 == 1)
            {
                vat.CodProdLOE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vat.NomeProdLOE = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if (vat.AuxLOE3 == 1)
            {
                vat.CodProdLOE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vat.NomeProdLOE = dataGridView1.CurrentRow.Cells[1].Value.ToString(); ;
            }
            else if (vat.AuxLOE4 == 1)
            {
                vat.CodProdLOE = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vat.NomeProdLOE = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else if(vat.AuxCampanha == 1)
            {
                vat.CodCampanha = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                vat.ProdCampanha = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            Close();
        }

        private void procuraProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            vat.AuxLote = 0;
        }
    }
}
