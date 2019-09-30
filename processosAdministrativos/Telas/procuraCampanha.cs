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
    public partial class procuraCampanha : Form
    {
        string pesquisar = string.Empty;
        string pesquisar2 = string.Empty;
        string pesquisar3 = string.Empty;

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            if (campanhaRb.Checked)
                pesquisar = pesquisaTxt.Text.Replace('*', '%');
            else if (codProdRb.Checked)
                pesquisar2 = pesquisaTxt.Text.Replace('*', '%');
            else if (produtoRb.Checked)
                pesquisar3 = pesquisaTxt.Text.Replace('*', '%');

            dataGridView1.DataSource = qdt.procura("SELECT cmak_codigo, cmak_campanha, cmak_item, if(cmak_produto = '' , itm_descricao, cmak_produto) as 'prod' FROM campanha_marketing left outer join itens on campanha_marketing.cmak_item = itens.itm_codigo WHERE cmak_campanha like '%" + pesquisar + "%' and cmak_item like '%" + pesquisar2 + "%' and if(cmak_produto = '' , itm_descricao, cmak_produto) like '%" + pesquisar3 + "%' order by cmak_data desc");

        }

        public procuraCampanha()
        {
            InitializeComponent();
        }

        private void procuraCampanha_Load(object sender, EventArgs e)
        {
            campanhaRb.Checked = true;
            preencheTabela();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            variaveis vat = new variaveis();
            vat.CodCamp = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
