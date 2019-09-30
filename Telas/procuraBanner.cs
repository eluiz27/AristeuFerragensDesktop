using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraBanner : Form
    {
        variaveis vat = new variaveis();

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            dataGridView1.DataSource = qdt.procura("SELECT banrot_codigo, banrot_campanha FROM banner_rotativo WHERE banrot_campanha like '%" + pesquisar + "%'");
        }

        public procuraBanner()
        {
            InitializeComponent();
        }

        private void procuraBanner_Load(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            vat.CodBanner = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }
    }
}
