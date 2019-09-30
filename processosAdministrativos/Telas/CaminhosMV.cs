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
    public partial class CaminhosMV : Form
    {
        string caminhosMV = Path.GetFullPath("Caminhos\\MapaVendas.txt");
        string caminhosInd = Path.GetFullPath("Caminhos\\Indicadores.txt");
        StreamWriter x;
        StreamReader y;

        public void PreencherMV()
        {
            y = File.OpenText(caminhosMV);
            camMVTxt.Text = y.ReadLine();
            y.Close();
        }
        public void PreencherInd()
        {
            y = File.OpenText(caminhosInd);
            camIndTxt.Text = y.ReadLine();
            y.Close();
        }
        public void EscreverMV()
        {
            x = File.CreateText(caminhosMV);
            x.Write(camMVTxt.Text);
            x.Close();
        }
        public void EscreverInd()
        {
            x = File.CreateText(caminhosInd);
            x.Write(camIndTxt.Text);
            x.Close();
        }
        public CaminhosMV()
        {
            InitializeComponent();
        }
        private void CaminhosMV_Load(object sender, EventArgs e)
        {
            PreencherInd();
            PreencherMV();
        }

        private void TextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            camMVTxt.Text = openFileDialog1.FileName.Substring(0, (openFileDialog1.FileName.Length - 11));
        }

        private void TextBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            camIndTxt.Text = openFileDialog1.FileName.Substring(0, (openFileDialog1.FileName.Length - 11));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (camMVTxt.Text.Length != 0)
                EscreverMV();
            if (camIndTxt.Text.Length != 0)
                EscreverInd();

            MessageBox.Show("Caminhos salvos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
