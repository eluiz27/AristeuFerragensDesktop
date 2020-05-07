using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraBanner : Form
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

            dataGridView1.DataSource = qdt.procura("SELECT banrot_codigo, banrot_campanha FROM banner_rotativo WHERE banrot_campanha like '%" + pesquisar + "%'");
        }

        public ProcuraBanner()
        {
            InitializeComponent();
        }

        private void procuraBanner_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            vat.CodBanner = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }
    }
}
