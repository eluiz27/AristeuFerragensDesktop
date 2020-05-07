using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraLote : Form
    {
        DAO dao = new DAO();
        Variaveis vat = new Variaveis();
        private string Sql = String.Empty;

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

            dataGridView1.DataSource = qdt.procura("SELECT ltv_numLote, itm_descricao FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE itm_descricao like '%" + pesquisar + "%'");
        }

        public ProcuraLote()
        {
            InitializeComponent();
        }

        private void procuraLote_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Sql = "SELECT ltv_codigo FROM lote_validade WHERE ltv_numLote = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            object aux = dao.Query.ExecuteScalar();
            vat.CodLote = aux.ToString();
            vat.AuxLote = 1;
            dao.Desconecta();
            Close();
        }
    }
}
