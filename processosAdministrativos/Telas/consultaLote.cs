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
    public partial class ConsultaLote : Form
    {
        DAO dao = new DAO();
        public void tabela()
        {
            QueryDataTable dt = new QueryDataTable();

            dataGridView1.DataSource = dt.procura("SELECT ltv_codigo, ltv_numLote, ltv_codBarras, concat(itm_codigo, ' - ', itm_descricao) as 'produto', ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo ORDER BY ltv_numLote;");
        }
        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }

        public ConsultaLote()
        {
            InitializeComponent();
        }

        private void consultaLote_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            tabela();
            numLoteTxt.Focus();
        }

        private void consultaLote_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaConsultaLote = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            QueryDataTable dt = new QueryDataTable();
            string pesquisar = CorrecoesTexto(numLoteTxt.Text);

            dataGridView1.DataSource = dt.procura("SELECT ltv_codigo, ltv_numLote, ltv_codBarras, concat(itm_codigo, ' - ', itm_descricao) as 'produto', ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE ltv_numLote LIKE '%" + pesquisar + "%';");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryDataTable dt = new QueryDataTable();

            if (validadeMtxt.Text == "  /  /  ")
            {
                MessageBox.Show("Nenhuma data informada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = dt.procura("SELECT ltv_codigo, ltv_numLote, ltv_codBarras, concat(itm_codigo, ' - ', itm_descricao) as 'produto', ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE DATE_FORMAT(ltv_validade, '%d/%m/%Y') = '" + validadeMtxt.Text + "';");

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
                dao.DeletaLote(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dataGridView1.DataSource = null;
                tabela();
            }
        }
    }
}
