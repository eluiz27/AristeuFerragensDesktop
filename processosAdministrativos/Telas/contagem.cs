using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class Contagem : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> nomes = new List<string>();
        List<double> qtdeAux = new List<double>();
        List<double> qtdeAtual = new List<double>();
        List<double> qtde = new List<double>();
        List<double> contado = new List<double>();
        List<double> real = new List<double>();

        public void preecheTabela()
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;

            table = new DataTable();
            bs = new BindingSource();

            if (prefixProdTxt.Text != string.Empty)
                da = new MySqlDataAdapter("SELECT itm_codigo, itm_descricao FROM itens WHERE itm_descricao like '" + prefixProdTxt.Text + "%'", dao.Conexao);
            else
                da = new MySqlDataAdapter("SELECT itm_codigo, itm_descricao FROM itens WHERE itm_descricao like ''", dao.Conexao);
            
            da.Fill(table);
            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }
        public void comecarContar()
        {
            dao.Conecta();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                nomes.Add(dataGridView1.Rows[i].Cells["codigo"].Value.ToString());
                Sql = "SELECT SUM(ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2)) AS 'Saldo' FROM itens WHERE itm_codigo = " + nomes[i] + "";

                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                object qtde = dao.Query.ExecuteScalar();
                qtdeAtual.Add(Convert.ToDouble(qtde));
            }
            dao.Desconecta();
        }
        public bool verificaContar()
        {
            int x = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["qtdeCont"].Value != null)
                {
                    x++;
                }
            }

            if(x == dataGridView1.RowCount)
                return true;
            else
                return false;
        }
        public void acabarContar()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                contado.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells["qtdeCont"].Value));
            }
        }
        public Contagem()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(prefixProdTxt);
            sList.Add("Ex.: paraf");
            SetCueBanner(ref tList, sList);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }
        private void iniciarBt_Click(object sender, EventArgs e)
        {
            if (prefixProdTxt.Text != string.Empty)
            {
                comecarContar();
                pararBt.Enabled = true;
                prefixProdTxt.Enabled = false;
                iniciarBt.Enabled = false;
            }
            else
                MessageBox.Show("Campo Prefixo produto obrigatório!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pararBt_Click(object sender, EventArgs e)
        {
            if (prefixProdTxt.Text != string.Empty && verificaContar() == true)
            {
                for(int i = 0; i < qtdeAtual.Count; i++)
                {
                    qtdeAux.Add(qtdeAtual[i]);
                }
                qtdeAtual.Clear();
                comecarContar();
                acabarContar();
                for(int i = 0; i < qtdeAux.Count; i++)
                {
                    qtde.Add(qtdeAux[i] - qtdeAtual[i]);
                    real.Add(contado[i] - qtde[i]);
                    dataGridView1.Rows[i].Cells["qtdeReal"].Value = real[i];
                }
                dataGridView1.Refresh();
                ControlContagem cc = new ControlContagem();
                DAO dao = new DAO();

                cc.Cont_produto = prefixProdTxt.Text;
                cc.Cont_data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dao.CadastraContagem(cc);
            }
            else
                MessageBox.Show("Campo Prefixo Produto e Qtde Contada obrigatório!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            prefixProdTxt.Text = string.Empty;
            qtdeAtual.Clear();
            qtdeAux.Clear();
            nomes.Clear();
            real.Clear();
            qtde.Clear();
            contado.Clear();
            preecheTabela();
            pararBt.Enabled = false;
            prefixProdTxt.Enabled = true;
            iniciarBt.Enabled = true;
        }

        private void contagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                MessageBox.Show("Favor terminar a contagem!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                ControlTelaAberta cta = new ControlTelaAberta();
                cta.TelaContagem = 0;
                qtdeAtual.Clear();
                qtdeAux.Clear();
                nomes.Clear();
                real.Clear();
                qtde.Clear();
                contado.Clear();
                preecheTabela();
            }
        }

        private void prefixProdTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preecheTabela();
        }
    }
}
