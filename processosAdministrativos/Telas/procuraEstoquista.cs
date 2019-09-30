using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraEstoquista : Form
    {
        variaveis vat = new variaveis();

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            dataGridView1.DataSource = qdt.procura("SELECT est_codigo, est_nome FROM estoquista WHERE est_nome LIKE '%" + pesquisar + "%' ORDER BY est_nome");
        }

        public procuraEstoquista()
        {
            InitializeComponent();
        }

        private void nomeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            vat.CodEstoquista = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void alterarEstoquista_Load(object sender, EventArgs e)
        {
            preencheTabela();
        }
    }
}
