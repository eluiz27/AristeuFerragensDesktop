using System;
using System.IO;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class Gatilho : Form
    {
        string enviarMV = Path.GetFullPath("EnviarMV\\Usuario.txt");
        StreamWriter x;
        public static string[] linhas;

        public void PreencherArq()
        {
            linhas = File.ReadAllLines(enviarMV);
            usuarioTxt.Text = linhas[0];
            compTxt.Text = linhas[1];
            if (linhas[2] == "0")
                ativoCb.Checked = false;
            else
                ativoCb.Checked = true;
            horarioTxt.Text = linhas[3];
            horario2Txt.Text = linhas[4];
        }
        public void EscreverArq()
        {
            x = File.CreateText(enviarMV);
            x.WriteLine(usuarioTxt.Text);
            x.WriteLine(compTxt.Text);
            if (ativoCb.Checked == true)
                x.WriteLine(1);
            else
                x.WriteLine(0);
            x.WriteLine(horarioTxt.Text);
            x.WriteLine(horario2Txt.Text);
            x.Close();
        }
        public Gatilho()
        {
            InitializeComponent();
            PreencherArq();
        }

        private void preencherBt_Click(object sender, EventArgs e)
        {
            compTxt.Text = Environment.MachineName.ToLower();
            usuarioTxt.Text = Environment.UserName.ToLower();
        }

        private void gravarBt_Click(object sender, EventArgs e)
        {
            if (compTxt.Text != string.Empty && usuarioTxt.Text != string.Empty && horarioTxt.Text.Length != 4)
            {
                EscreverArq();
                MessageBox.Show("Usuário Salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void horarioTxt_Leave(object sender, EventArgs e)
        {
            horario2Txt.Text = Convert.ToDateTime(horarioTxt.Text).ToString("HH:mm:05");
        }
    }
}
