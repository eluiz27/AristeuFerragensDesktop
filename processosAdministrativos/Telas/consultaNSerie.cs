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
    public partial class consultaNSerie : Form
    {
        DAO dao = new DAO();
        public consultaNSerie()
        {
            InitializeComponent();
        }

        private void consultaNSerie_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaConsultaNSerie = 0;
        }

        private void consultaNSerie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gs_aristeusDataSet.nSerie' table. You can move, or remove it, as needed.
            this.nSerieTableAdapter.Fill(this.gs_aristeusDataSet.nSerie);

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = textBox1.Text.Replace('*', '%');

            table = new DataTable();
            bs = new BindingSource();
            da = new MySqlDataAdapter("SELECT ns_produto, itm_descricao, ns_nSerie, ns_pedido, DATE_FORMAT(ns_data, '%d/%m/%Y') as 'data' FROM (n_serie INNER JOIN itens ON n_serie.ns_produto = itens.itm_codigo) INNER JOIN notas ON concat('01-', n_serie.ns_pedido) = notas.nt_pedido WHERE nt_documento like '%" + pesquisar + "%';", dao.Conexao);
            da.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }
    }
}
