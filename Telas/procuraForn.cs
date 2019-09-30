using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraForn : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        variaveis vat = new variaveis();

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            if (codigoRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select fnc_codigo, fnc_nome from fornecedores where fnc_pessoa = 'J' and fnc_cgc <> '__.___.___/____-__' and fnc_inscricao <> '' and fnc_nome not like 'trans%' and fnc_situacao = 'N' and fnc_codigo like '%" + pesquisar + "%'");
            else if (nomeRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select fnc_codigo, fnc_nome from fornecedores where fnc_pessoa = 'J' and fnc_cgc <> '__.___.___/____-__' and fnc_inscricao <> '' and fnc_nome not like 'trans%' and fnc_situacao = 'N' and fnc_nome like '%" + pesquisar + "%'");
        }

        public procuraForn()
        {
            InitializeComponent();
        }

        private void fornecedores_Load(object sender, EventArgs e)
        {
            codigoRb.Checked = true;
            preencheTabela();
        }

        private void nomeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vat.CodForn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vat.NomeFornAssistTec = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
