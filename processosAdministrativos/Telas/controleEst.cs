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
    public partial class ControleEst : Form
    {
        DAO dao = new DAO();

        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }

        public ControleEst()
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
            QueryDataTable dt = new QueryDataTable();
            string pesquisar = CorrecoesTexto(produtoTxt.Text);
            if (codigoRb.Checked)
            {
                dataGridView1.DataSource = dt.procura("SELECT est_nome as 'Estoquista', clg_descricao as 'Classe', itm_descricao as 'Produto', itm_codigo as 'Codigo' FROM ((classes INNER JOIN itens ON classes.clg_codigo = itens.itm_classe) " +
                                          "INNER JOIN classes_estoque ON classes.clg_codigo = classes_estoque.cles_classe) INNER JOIN estoquista ON estoquista.est_codigo = classes_estoque.cles_estoquista " +
                                          "where itm_codigo like '%" + pesquisar + "%';");
            }
            else
            {
                if (descricaoRb.Checked)
                {
                    dataGridView1.DataSource = dt.procura("SELECT est_nome as 'Estoquista', clg_descricao as 'Classe', itm_descricao as 'Produto', itm_codigo as 'Codigo' FROM ((classes INNER JOIN itens ON classes.clg_codigo = itens.itm_classe) " +
                                              "INNER JOIN classes_estoque ON classes.clg_codigo = classes_estoque.cles_classe) INNER JOIN estoquista ON estoquista.est_codigo = classes_estoque.cles_estoquista " +
                                              "where itm_descricao like '%" + pesquisar + "%';");
                }
                else
                {
                    if (codigoBarrasRb.Checked)
                    {
                        dataGridView1.DataSource = dt.procura("est_nome as 'Estoquista', clg_descricao as 'Classe', itm_descricao as 'Produto', itm_codigo as 'Codigo' FROM ((classes INNER JOIN itens ON classes.clg_codigo = itens.itm_classe) " +
                                                  "INNER JOIN classes_estoque ON classes.clg_codigo = classes_estoque.cles_classe) INNER JOIN estoquista ON estoquista.est_codigo = classes_estoque.cles_estoquista " +
                                                  "where itm_codbarras like '%" + pesquisar + "%';");
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
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaContEstoq = 0;
        }
    }
}
