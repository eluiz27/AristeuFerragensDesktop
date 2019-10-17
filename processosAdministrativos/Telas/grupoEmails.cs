using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class grupoEmails : Form
    {
        int aux = 0;
        int codi = 0;
        DAO dao = new DAO();
        public void tabela()
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;

            table = new DataTable();
            bs = new BindingSource();

            da = new MySqlDataAdapter("SELECT grpe_codigo, grpe_dono, grpe_grupo, grpe_email FROM grupo_emails ORDER BY grpe_dono, grpe_grupo, grpe_email;", dao.Conexao);
            da.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }
        public grupoEmails()
        {
            InitializeComponent();
        }

        private void grupoEmails_Load(object sender, EventArgs e)
        {
            tabela();
            donoRb.Checked = true;
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (donoTxt.Text != string.Empty && grupoTxt.Text != string.Empty && emailTxt.Text != string.Empty)
            {
                controlGruposEmail cg = new controlGruposEmail();
                cg.Grpe_dono = donoTxt.Text;
                cg.Grpe_grupo = grupoTxt.Text;
                cg.Grpe_email = emailTxt.Text;
                if (aux == 0)
                    dao.cadastraGrupoEmail(cg);
                else
                {
                    dao.alteraGrupoEmail(cg, codi);
                    aux = 0;
                    codi = 0;
                }

                dataGridView1.DataSource = null;
                tabela();
                donoTxt.Text = string.Empty;
                grupoTxt.Text = string.Empty;
                emailTxt.Text = string.Empty;
            }
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            donoTxt.Text = string.Empty;
            grupoTxt.Text = string.Empty;
            emailTxt.Text = string.Empty;
            aux = 0;
            codi = 0;
            dataGridView1.DataSource = null;
            tabela();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            codi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            donoTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            grupoTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            aux = 1;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            table = new DataTable();
            bs = new BindingSource();
            if (donoRb.Checked)
            {
                da = new MySqlDataAdapter("SELECT grpe_codigo, grpe_dono, grpe_grupo, grpe_email FROM grupo_emails WHERE grpe_dono like '"+pesquisar+"%' ORDER BY grpe_dono, grpe_grupo, grpe_email;", dao.Conexao);
                da.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
            }
            else
            {
                if (grupoRb.Checked)
                {
                    da = new MySqlDataAdapter("SELECT grpe_codigo, grpe_dono, grpe_grupo, grpe_email FROM grupo_emails WHERE grpe_grupo like '" + pesquisar + "%' ORDER BY grpe_dono, grpe_grupo, grpe_email;", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                codi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                dao.deletaGrupoEmail(codi);
                codi = 0;
                dataGridView1.DataSource = null;
                tabela();
                donoTxt.Text = string.Empty;
                grupoTxt.Text = string.Empty;
                emailTxt.Text = string.Empty;
            }
        }
    }
}
