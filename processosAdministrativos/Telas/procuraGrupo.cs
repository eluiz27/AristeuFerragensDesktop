using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraGrupo : Form
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

            if (codigoRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select grp_codigo, grp_descricao from grupos where grp_codigo like '%" + pesquisar + "%'");
            else if (nomeRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select grp_codigo, grp_descricao from grupos where grp_descricao like '%" + pesquisar + "%'");
        }
        public ProcuraGrupo()
        {
            InitializeComponent();
        }

        private void nomeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vat.CodGrupo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Close();
        }

        private void procuraGrupo_Load(object sender, EventArgs e)
        {
            codigoRb.Checked = true;
            PreencheTabela();
        }
    }
}
