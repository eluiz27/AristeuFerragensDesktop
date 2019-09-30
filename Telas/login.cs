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
    public partial class login : Form
    {
        private string Sql = String.Empty;
        DAO dao = new DAO();
        string nome = string.Empty;
        string senha = string.Empty;

        public void validaLogin()
        {
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                if (textBox3.Text == senha)
                {
                    processosAdm pa = new processosAdm();
                    pa.CodUsuario = textBox2.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Senha incorreta", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Usuário ou senha não informados", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public login()
        {
            InitializeComponent();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.TextLength > 0)
            {
                if (textBox2.TextLength == 1)
                    textBox2.Text = "000" + textBox2.Text;
                else if (textBox2.TextLength == 2)
                    textBox2.Text = "00" + textBox2.Text;
                else if (textBox2.TextLength == 3)
                    textBox2.Text = "0" + textBox2.Text;

                Sql = "select sen_usuario, res_senha from restricoes left outer join senhas on restricoes.res_usuario = senhas.sen_acesso where res_usuario like '" + textBox2.Text + "'";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                MySqlDataReader usu = dao.Query.ExecuteReader();
                while (usu.Read())
                {
                    nome = usu["sen_usuario"].ToString();
                    senha = usu["res_senha"].ToString();
                }
                if (nome != string.Empty)
                    textBox1.Text = nome;
                else
                {
                    MessageBox.Show("Usuário inexistente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Focus();
                }
                usu.Close();
                dao.desconecta();
            }
            else
            {
                nome = string.Empty;
                senha = string.Empty;
                textBox2.Text = string.Empty;
                textBox1.Text = string.Empty;
                textBox3.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void entrarBt_Click(object sender, EventArgs e)
        {
            validaLogin();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validaLogin();
            }
        }
    }
}
