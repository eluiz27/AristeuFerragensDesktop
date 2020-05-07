using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraAssistTec : Form
    {
        DAO dao = new DAO();
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

            if (codFornRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("SELECT codigo_assistTec, nome_assistTec, fnc_nome FROM assistencias_tecnicas INNER JOIN fornecedores ON assistencias_tecnicas.fornecedor_assistTec = fornecedores.fnc_codigo WHERE fnc_codigo like '%" + pesquisar + "%'");
            else if (nomeFornRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("SELECT codigo_assistTec, nome_assistTec, fnc_nome FROM assistencias_tecnicas INNER JOIN fornecedores ON assistencias_tecnicas.fornecedor_assistTec = fornecedores.fnc_codigo WHERE fnc_nome like '%" + pesquisar + "%'");
            else if (assistenciaRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("SELECT codigo_assistTec, nome_assistTec, fnc_nome FROM assistencias_tecnicas INNER JOIN fornecedores ON assistencias_tecnicas.fornecedor_assistTec = fornecedores.fnc_codigo WHERE nome_assistTec like '%" + pesquisar + "%'");
        }

        public ProcuraAssistTec()
        {
            InitializeComponent();
        }

        private void procuraAssistTec_Load(object sender, EventArgs e)
        {
            codFornRb.Checked = true;
            PreencheTabela();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            vat.CodAssistTec = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            vat.Aux2AssistTec = 1;
            vat.Aux3AssistTec = 1;
            Close();
        }
    }
}

