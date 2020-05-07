using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraOC : Form
    {
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

            if (ocRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT ocp_numero, ocp_nmfornecedor FROM gs_aristeus.ordcompra where ocp_situacao = 'p' AND ocp_numero like '%" + pesquisar + "%'");
            else if (fornecedorRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT ocp_numero, ocp_nmfornecedor FROM gs_aristeus.ordcompra where ocp_situacao = 'p' AND ocp_nmfornecedor like '%" + pesquisar + "%'");
        }

        public ProcuraOC()
        {
            InitializeComponent();
        }

        private void procuraOC_Load(object sender, EventArgs e)
        {
            ocRb.Checked = true;
            PreencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Variaveis vat = new Variaveis();
            vat.CodOrdemComp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vat.AuxFallowUp = 1;
            Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }
    }
}
