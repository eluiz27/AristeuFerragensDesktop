using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraLote : Form
    {
        DAO dao = new DAO();
        variaveis vat = new variaveis();
        private string Sql = String.Empty;

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            dataGridView1.DataSource = qdt.procura("SELECT ltv_numLote, itm_descricao FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE itm_descricao like '%" + pesquisar + "%'");
        }

        public procuraLote()
        {
            InitializeComponent();
        }

        private void procuraLote_Load(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Sql = "SELECT ltv_codigo FROM lote_validade WHERE ltv_numLote = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object aux = dao.Query.ExecuteScalar();
            vat.CodLote = aux.ToString();
            vat.AuxLote = 1;
            dao.desconecta();
            this.Close();
        }
    }
}
