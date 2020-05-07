using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraEstoquista : Form
    {
        Variaveis vat = new Variaveis();

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

            dataGridView1.DataSource = qdt.procura("SELECT est_codigo, est_nome FROM estoquista WHERE est_nome LIKE '%" + pesquisar + "%' ORDER BY est_nome");
        }

        public ProcuraEstoquista()
        {
            InitializeComponent();
        }

        private void nomeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            vat.CodEstoquista = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Close();
        }

        private void alterarEstoquista_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }
    }
}
