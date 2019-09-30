using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraGrupo : Form
    {
        private string Sql = String.Empty;
        variaveis vat = new variaveis();

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            if (codigoRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select grp_codigo, grp_descricao from grupos where grp_codigo like '%" + pesquisar + "%'");
            else if (nomeRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select grp_codigo, grp_descricao from grupos where grp_descricao like '%" + pesquisar + "%'");
        }
        public procuraGrupo()
        {
            InitializeComponent();
        }

        private void nomeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vat.CodGrupo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void procuraGrupo_Load(object sender, EventArgs e)
        {
            codigoRb.Checked = true;
            preencheTabela();
        }
    }
}
