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
    public partial class controleEst : Form
    {
        DAO dao = new DAO();
        public controleEst()
        {
            InitializeComponent();
        }

        private void controleEst_Load(object sender, EventArgs e)
        {
            codigoRb.Checked = true;
            produtoTxt.Focus();
        }

        private void produtoTxt_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = produtoTxt.Text.Replace('*', '%');

            table = new DataTable();
            bs = new BindingSource();
            if (codigoRb.Checked)
            {
                da = new MySqlDataAdapter("SELECT est_nome as 'Estoquista', clg_descricao as 'Classe', itm_descricao as 'Produto', itm_codigo as 'Codigo' FROM ((classes INNER JOIN itens ON classes.clg_codigo = itens.itm_classe) " +
                                          "INNER JOIN classes_estoque ON classes.clg_codigo = classes_estoque.cles_classe) INNER JOIN estoquista ON estoquista.est_codigo = classes_estoque.cles_estoquista " +
                                          "where itm_codigo like '%" + pesquisar + "%';", dao.Conexao);
                da.Fill(table);

               bs.DataSource = table;
               dataGridView1.DataSource = bs;
            }
            else
            {
                if (descricaoRb.Checked)
                {
                    da = new MySqlDataAdapter("SELECT est_nome as 'Estoquista', clg_descricao as 'Classe', itm_descricao as 'Produto', itm_codigo as 'Codigo' FROM ((classes INNER JOIN itens ON classes.clg_codigo = itens.itm_classe) " +
                                              "INNER JOIN classes_estoque ON classes.clg_codigo = classes_estoque.cles_classe) INNER JOIN estoquista ON estoquista.est_codigo = classes_estoque.cles_estoquista " +
                                              "where itm_descricao like '%" + pesquisar + "%';", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
                else
                {
                    if (codigoBarrasRb.Checked)
                    {
                        da = new MySqlDataAdapter("est_nome as 'Estoquista', clg_descricao as 'Classe', itm_descricao as 'Produto', itm_codigo as 'Codigo' FROM ((classes INNER JOIN itens ON classes.clg_codigo = itens.itm_classe) " +
                                                  "INNER JOIN classes_estoque ON classes.clg_codigo = classes_estoque.cles_classe) INNER JOIN estoquista ON estoquista.est_codigo = classes_estoque.cles_estoquista " +
                                                  "where itm_codbarras like '%" + pesquisar + "%';", dao.Conexao);
                        da.Fill(table);

                        bs.DataSource = table;
                        dataGridView1.DataSource = bs;
                    }
                }
            }
            if (produtoTxt.Text == "")
            {
                dataGridView1.DataSource = null;
            }
        }

        private void controleEst_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaContEstoq = 0;
        }
    }
}
