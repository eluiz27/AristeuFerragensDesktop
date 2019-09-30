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
    public partial class consultaLote : Form
    {
        DAO dao = new DAO();
        public void tabela()
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;

            table = new DataTable();
            bs = new BindingSource();
            da = new MySqlDataAdapter("SELECT ltv_codigo, ltv_numLote, ltv_codBarras, concat(itm_codigo, ' - ', itm_descricao) as 'produto', ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo ORDER BY ltv_numLote;", dao.Conexao);
            da.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }
        public consultaLote()
        {
            InitializeComponent();
        }

        private void consultaLote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gs_aristeusDataSet.consulta_lote' table. You can move, or remove it, as needed.
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            tabela();
            numLoteTxt.Focus();
        }

        private void consultaLote_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaConsultaLote = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = numLoteTxt.Text.Replace('*', '%');

            table = new DataTable();
            bs = new BindingSource();
            da = new MySqlDataAdapter("SELECT ltv_codigo, ltv_numLote, ltv_codBarras, concat(itm_codigo, ' - ', itm_descricao) as 'produto', ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE ltv_numLote LIKE '%" + pesquisar + "%';", dao.Conexao);
            da.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validadeMtxt.Text == "  /  /  ")
            {
                MessageBox.Show("Nenhuma data informada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable table;
                MySqlDataAdapter da;
                BindingSource bs;

                table = new DataTable();
                bs = new BindingSource();
                da = new MySqlDataAdapter("SELECT ltv_codigo, ltv_numLote, ltv_codBarras, concat(itm_codigo, ' - ', itm_descricao) as 'produto', ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE DATE_FORMAT(ltv_validade, '%d/%m/%Y') = '" + validadeMtxt.Text + "';", dao.Conexao);
                da.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
            }
        }

        private void validadeMtxt_Enter(object sender, EventArgs e)
        {
            numLoteTxt.Text = string.Empty;
            tabela();
        }

        private void numLoteTxt_Enter(object sender, EventArgs e)
        {
            validadeMtxt.Text = string.Empty;
            tabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DAO dao = new DAO();
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.deletaLote(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = null;
                tabela();
            }
        }
    }
}
