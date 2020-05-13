using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraUsuarios : Form
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

            string pesquisar = CorrecoesTexto(pesquisarTxt.Text);

            if (codigoRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT sen_acesso, sen_usuario, res_senha FROM senhas a left outer join restricoes b on a.sen_acesso = b.res_usuario WHERE sen_acesso like '%" + pesquisar+"%' order by sen_acesso desc");
            else
                dataGridView1.DataSource = qdt.procura("SELECT sen_acesso, sen_usuario, res_senha FROM senhas a left outer join restricoes b on a.sen_acesso = b.res_usuario WHERE sen_usuario like '%" + pesquisar+"%' order by sen_acesso desc");
        }
        public ProcuraUsuarios()
        {
            InitializeComponent();
        }

        private void procuraUsuarios_Load(object sender, EventArgs e)
        {
            codigoRb.Checked = true;
            PreencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Variaveis var = new Variaveis();
            var.CodUsuario = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var.AuxSenha = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var.AuxUsuario = 1;
            Close();
        }

        private void pesquisarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }
    }
}
