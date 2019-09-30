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
    public partial class etiquetaPreco : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> nome2 = new List<string>();
        List<string> codItem2 = new List<string>();
        List<string> codForn2 = new List<string>();
        List<string> codForAux = new List<string>();
        List<string> preco2 = new List<string>();
        List<string> nome3 = new List<string>();
        List<string> codItem3 = new List<string>();
        List<string> codForn3 = new List<string>();
        List<string> preco3 = new List<string>();
        class etique
        {
            public string cod { get; set; }
            public string prod { get; set; }
            public string qtdeProd { get; set; }
            public string prec { get; set; }

            public etique() { }
        }
        List<etique> et = new List<etique>();
        public void preencheTabEtique()
        {
            Sql = "SELECT itm_codigo, itm_descricao, itm_preco, itm_fornecedor FROM itens where itens.itm_codigo = "+codigoTxt.Text+"";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while (aux.Read())
            {
                codItem2.Add(aux["itm_codigo"].ToString());
                nome2.Add(aux["itm_descricao"].ToString());
                codForAux.Add(aux["itm_fornecedor"].ToString());
                preco2.Add(aux["itm_preco"].ToString());
            }
            aux.Close();
            dao.desconecta();
            et.Add(new etique()
            {
                cod = codItem2[codItem2.Count-1],
                prod = nome2[nome2.Count - 1],
                qtdeProd = QtdeTxt.Text,
                prec = string.Format("R$ {0:0,0.00}", Convert.ToDouble(preco2[preco2.Count - 1]))
            });

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = et;
            dataGridView2.Columns[0].HeaderText = "Código";
            dataGridView2.Columns[1].HeaderText = "Produto";
            dataGridView2.Columns[2].HeaderText = "Qtde";
            dataGridView2.Columns[3].HeaderText = "Preço";

            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 70;
            dataGridView2.Columns[3].Width = 70;

            limpaVar();
        }
        public void preencheTabela()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;

            table = new DataTable();
            bs = new BindingSource();

            da = new MySqlDataAdapter("SELECT itm_codigo, itm_descricao, itm_preco, itm_fornecedor FROM itens " +
                                        "where itens.itm_ultpreco between '" + inferior + "' and '" + superior + "' and ITM_EtiquetaPreco = 1 and itm_situacao = 'a' "+
                                        "Order by itens.itm_ultpreco desc;", dao.Conexao);
            da.Fill(table);
            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }
        public void limpaVar()
        {
            nome2.Clear();
            codItem2.Clear();
            codForn2.Clear();
            preco2.Clear();
            nome3.Clear();
            codItem3.Clear();
            codForn3.Clear();
            preco3.Clear();
        }
        public void limpaTab()
        {
            codForAux.Clear();
            et.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }
        public etiquetaPreco()
        {
            InitializeComponent();
        }

        private void etiquetaPreco_Load(object sender, EventArgs e)
        {
            inferiorMtxt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            superiorMtxt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            preencheTabela();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[selec.Name].Value = true;
            }
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void etiquetaPreco_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaEtiquetaPreco = 0;
        }

        private void imprimirBt_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (tabControl1.SelectedTab == precoAltTp)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (bool.Parse(dr.Cells["selec"].EditedFormattedValue.ToString()))
                    {
                        nome3.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        codItem3.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        codForn3.Add(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        preco3.Add(string.Format("R$ {0:0,0.00}", dataGridView1.Rows[i].Cells[3].Value));
                    }
                    i++;
                }

                imprimeEtiquetaPreco itp = new imprimeEtiquetaPreco(nome3, codItem3, codForn3, preco3);
                itp.ShowDialog();
                limpaVar();
            }
            else
            {
                i = 0;
                foreach (DataGridViewRow dr in dataGridView2.Rows)
                {
                    for (int y = 0; y < Convert.ToInt32(dataGridView2.Rows[i].Cells["qtdeProd"].Value); y++)
                    {
                        nome2.Add(dataGridView2.Rows[i].Cells["prod"].Value.ToString());
                        codItem2.Add(dataGridView2.Rows[i].Cells["cod"].Value.ToString());
                        codForn2.Add(codForAux[i]);
                        preco2.Add(string.Format("R$ {0:0,0.00}", dataGridView2.Rows[i].Cells["prec"].Value));
                    }
                    i++;
                }
                imprimeEtiquetaPreco itp = new imprimeEtiquetaPreco(nome2, codItem2, codForn2, preco2);
                itp.ShowDialog();
                limpaVar();
                limpaTab();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (codigoTxt.Text != string.Empty && QtdeTxt.Text != string.Empty)
            {
                Sql = "SELECT count(itm_codigo) FROM itens where itens.itm_codigo = " + codigoTxt.Text + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                object aux = dao.Query.ExecuteScalar();
                dao.desconecta();
                if (aux.ToString() != "0")
                {
                    preencheTabEtique();
                }
                else
                    MessageBox.Show("Produto não encontrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            codigoTxt.Text = string.Empty;
            QtdeTxt.Text = string.Empty;
            codigoTxt.Focus();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == precoAltTp)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[selec.Name].Value = true;
                }
            }
        }
    }
}
