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
    public partial class ProcuraCampanha : Form
    {
        string pesquisar = string.Empty;
        string pesquisar2 = string.Empty;
        string pesquisar3 = string.Empty;

        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }

        public void PreencheTabela()
        {
            QueryDataTable qdt = new QueryDataTable();

            if (campanhaRb.Checked)
                pesquisar = CorrecoesTexto(pesquisaTxt.Text);
            else if (codProdRb.Checked)
                pesquisar2 = CorrecoesTexto(pesquisaTxt.Text);
            else if (produtoRb.Checked)
                pesquisar3 = CorrecoesTexto(pesquisaTxt.Text);

            dataGridView1.DataSource = qdt.procura("SELECT cmak_codigo, cmak_campanha, cmak_item, if(cmak_produto = '' , itm_descricao, cmak_produto) as 'prod' FROM campanha_marketing left outer join itens on campanha_marketing.cmak_item = itens.itm_codigo WHERE cmak_campanha like '%" + pesquisar + "%' and cmak_item like '%" + pesquisar2 + "%' and if(cmak_produto = '' , itm_descricao, cmak_produto) like '%" + pesquisar3 + "%' order by cmak_data desc");

        }

        public ProcuraCampanha()
        {
            InitializeComponent();
        }

        private void procuraCampanha_Load(object sender, EventArgs e)
        {
            campanhaRb.Checked = true;
            PreencheTabela();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _ = new Variaveis
            {
                CodCamp = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            };
            Close();
        }
    }
}
