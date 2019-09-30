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
    public partial class consultaCodificacao : Form
    {
        DAO dao = new DAO();
        public consultaCodificacao()
        {
            InitializeComponent();
        }

        private void consultaCodificacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gs_aristeusDataSet.consultCodificacao' table. You can move, or remove it, as needed.
            this.consultCodificacaoTableAdapter.Fill(this.gs_aristeusDataSet.consultCodificacao);
            notaRb.Checked = true;
        }

        private void consultaCodificacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaConsCodif = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            table = new DataTable();
            bs = new BindingSource();
            if (notaRb.Checked)
            {
                da = new MySqlDataAdapter("SELECT codf_nota, fnc_nome, a.est_nome AS 'estoq1', b.est_nome AS 'estoq2', DATE_FORMAT(codf_data, '%d/%m/%Y') AS 'data' "+
                                            "FROM((codificacao INNER JOIN fornecedores ON codificacao.codf_codForn = fornecedores.fnc_codigo) "+
                                            "LEFT OUTER JOIN estoquista as a ON codificacao.codf_codEstoquista1 = a.est_codigo) "+
                                            "LEFT OUTER JOIN estoquista as b ON codificacao.codf_codEstoquista2 = b.est_codigo WHERE codf_nota LIKE '%" + pesquisar + "%';", dao.Conexao);
                da.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
            }
            else
            {
                if (fornecedorRb.Checked)
                {
                    da = new MySqlDataAdapter("SELECT codf_nota, fnc_nome, a.est_nome AS 'estoq1', b.est_nome AS 'estoq2', DATE_FORMAT(codf_data, '%d/%m/%Y') AS 'data' " +
                                                                "FROM((codificacao INNER JOIN fornecedores ON codificacao.codf_codForn = fornecedores.fnc_codigo) " +
                                                                "LEFT OUTER JOIN estoquista as a ON codificacao.codf_codEstoquista1 = a.est_codigo) " +
                                                                "LEFT OUTER JOIN estoquista as b ON codificacao.codf_codEstoquista2 = b.est_codigo WHERE fnc_nome LIKE '%" + pesquisar + "%';", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    if (estoquistaRb.Checked)
                    {
                        da = new MySqlDataAdapter("SELECT codf_nota, fnc_nome, a.est_nome AS 'estoq1', b.est_nome AS 'estoq2', DATE_FORMAT(codf_data, '%d/%m/%Y') AS 'data' " +
                                                                    "FROM((codificacao INNER JOIN fornecedores ON codificacao.codf_codForn = fornecedores.fnc_codigo) " +
                                                                    "LEFT OUTER JOIN estoquista as a ON codificacao.codf_codEstoquista1 = a.est_codigo) " +
                                                                    "LEFT OUTER JOIN estoquista as b ON codificacao.codf_codEstoquista2 = b.est_codigo WHERE a.est_nome LIKE '%" + pesquisar + "%' OR b.est_nome LIKE '%" + pesquisar + "%';", dao.Conexao);
                        da.Fill(table);

                        bs.DataSource = table;
                        dataGridView1.DataSource = bs;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inferiorMtxt.Text.Replace("/", "").Trim().Length == 8 && superiorMtxt.Text.Replace("/", "").Trim().Length == 8)
            {
                if (Convert.ToDateTime(inferiorMtxt.Text) <= Convert.ToDateTime(superiorMtxt.Text))
                {
                    DateTime aux1 = Convert.ToDateTime(inferiorMtxt.Text);
                    DateTime aux2 = Convert.ToDateTime(superiorMtxt.Text);
                    string inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
                    string superior = aux2.ToString("yyyy-MM-dd 23:00:00");


                    DataTable table;
                    MySqlDataAdapter da;
                    BindingSource bs;
                    string pesquisar = pesquisaTxt.Text.Replace('*', '%');

                    table = new DataTable();
                    bs = new BindingSource();

                    da = new MySqlDataAdapter("SELECT codf_nota, fnc_nome, a.est_nome AS 'estoq1', b.est_nome AS 'estoq2', DATE_FORMAT(codf_data, '%d/%m/%Y') AS 'data' " +
                                                                    "FROM((codificacao INNER JOIN fornecedores ON codificacao.codf_codForn = fornecedores.fnc_codigo) " +
                                                                    "LEFT OUTER JOIN estoquista as a ON codificacao.codf_codEstoquista1 = a.est_codigo) " +
                                                                    "LEFT OUTER JOIN estoquista as b ON codificacao.codf_codEstoquista2 = b.est_codigo WHERE codf_data between '" + inferior + "' AND '" + superior + "';", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
                else
                    MessageBox.Show("Data inferior maior que a superio!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Campos de data obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
