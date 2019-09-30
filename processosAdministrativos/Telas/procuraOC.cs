using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraOC : Form
    {
        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            if (ocRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT ocp_numero, ocp_nmfornecedor FROM gs_aristeus.ordcompra where ocp_situacao = 'p' AND ocp_numero like '%" + pesquisar + "%'");
            else if (fornecedorRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT ocp_numero, ocp_nmfornecedor FROM gs_aristeus.ordcompra where ocp_situacao = 'p' AND ocp_nmfornecedor like '%" + pesquisar + "%'");
        }

        public procuraOC()
        {
            InitializeComponent();
        }

        private void procuraOC_Load(object sender, EventArgs e)
        {
            ocRb.Checked = true;
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            variaveis vat = new variaveis();
            vat.CodOrdemComp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vat.AuxFallowUp = 1;
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }
    }
}
