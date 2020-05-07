using System;
using System.IO;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class MesesCotacao : Form
    {
        string caminho = Path.GetFullPath("Compras\\CotacaoAlzira.txt");
        StreamWriter x;
        public static string[] linhas;

        public void Preencher()
        {
            linhas = File.ReadAllLines(caminho);
            textBox1.Text = linhas[0];
            textBox2.Text = linhas[1];
        }

        public void Escrever()
        {
            x = File.CreateText(caminho);
            x.WriteLine(textBox1.Text);
            x.WriteLine(textBox2.Text);
            x.Close();
        }

        public MesesCotacao()
        {
            InitializeComponent();
            Preencher();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text != string.Empty && Convert.ToInt32(textBox1.Text) > 0) && (textBox2.Text != string.Empty || Convert.ToInt32(textBox2.Text) > 0))
            {
                Escrever();
                MessageBox.Show("Salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios e não podem ser menor que zero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
