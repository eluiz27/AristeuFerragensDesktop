using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ConsultaNSerie : Form
    {
        DAO dao = new DAO();

        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }

        public void PreencheTabela()
        {
            QueryDataTable dt = new QueryDataTable();
            string pesquisar = CorrecoesTexto(textBox1.Text);
            
            dataGridView1.DataSource = dt.procura("SELECT ns_produto, itm_descricao, ns_nSerie, ns_pedido, DATE_FORMAT(ns_data, '%d/%m/%Y') as 'data' FROM (n_serie INNER JOIN itens ON n_serie.ns_produto = itens.itm_codigo) INNER JOIN notas ON concat('01-', n_serie.ns_pedido) = notas.nt_pedido WHERE nt_documento like '%" + pesquisar + "%';");
        }

        public ConsultaNSerie()
        {
            InitializeComponent();
        }

        private void consultaNSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaConsultaNSerie = 0;
        }

        private void consultaNSerie_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }
    }
}
