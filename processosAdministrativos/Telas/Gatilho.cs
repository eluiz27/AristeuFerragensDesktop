using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        public void EscreverArq()
        {
            x = File.CreateText(enviarMV);
            x.WriteLine(usuarioTxt.Text);
            x.WriteLine(compTxt.Text);
            x.Close();
        }
        public Gatilho()
        {
            InitializeComponent();
            PreencherArq();
            usuarioTxt.Text = linhas[0];
            compTxt.Text = linhas[1];
        }

        private void preencherBt_Click(object sender, EventArgs e)
        {
            compTxt.Text = Environment.MachineName.ToLower();
            usuarioTxt.Text = Environment.UserName.ToLower();
        }

        private void gravarBt_Click(object sender, EventArgs e)
        {
            if (compTxt.Text != string.Empty && usuarioTxt.Text != string.Empty)
            {
                EscreverArq();
                MessageBox.Show("Usuário Salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
