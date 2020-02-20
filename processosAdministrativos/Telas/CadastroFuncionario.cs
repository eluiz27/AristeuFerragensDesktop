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

    public partial class CadastroFuncionario : Form
    {
        string caminho = Path.GetFullPath("Txts\\vendedores.txt");
        StreamWriter x;
        public static string[] linhas;

        public void EscreverArq()
        {
            string[] aux = File.ReadAllLines(caminho);
            List<string> auxList = new List<string>();
            for(int i = 0; i< aux.Count(); i++)
            {
                auxList.Add(aux[i]);
            }

            auxList.Add(nomeTxt.Text);

            x = File.CreateText(caminho);

            foreach(string y in auxList)
            {
                x.WriteLine(y);
            }
            x.Close();
        }

        public void PreencheGrid()
        {
            linhas = File.ReadAllLines(caminho);

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Nome");

            for (int i = 0; i < linhas.Count(); i++)
            {
                tabela.Rows.Add();
                tabela.Rows[i]["Nome"] = linhas[i];
            }

            dataGridView1.DataSource = tabela;

            dataGridView1.Columns["Nome"].Width = 250;
        }
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void CadastrarVendedor_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscreverArq();
            nomeTxt.Text = string.Empty;
            nomeTxt.Focus();
            PreencheGrid();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            x = File.CreateText(caminho);

            List<string> aux = new List<string>();

            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                aux.Add(dataGridView1.Rows[i].Cells["Nome"].Value.ToString());
            }

            foreach (string y in aux)
            {
                x.WriteLine(y);
            }
            x.Close();
        }

        private void nomeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EscreverArq();
                nomeTxt.Text = string.Empty;
                nomeTxt.Focus();
                PreencheGrid();
            }
        }
    }
}
