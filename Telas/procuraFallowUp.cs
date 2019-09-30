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
    public partial class procuraFallowUp : Form
    {
        DAO dao = new DAO();
        public procuraFallowUp()
        {
            InitializeComponent();
        }

        private void procuraFallowUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gs_aristeusDataSet.procuraFalowUp' table. You can move, or remove it, as needed.
            this.procuraFalowUpTableAdapter.Fill(this.gs_aristeusDataSet.procuraFalowUp);
            ocRb.Checked = true;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            variaveis vat = new variaveis();
            vat.CodFalowUp = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            vat.CodOrdemComp = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            table = new DataTable();
            bs = new BindingSource();
            if (ocRb.Checked)
            {
                da = new MySqlDataAdapter("SELECT fup_codigo, fup_ordCompra, fnc_nome FROM gs_aristeus.fallowup inner join fornecedores on fallowup.fup_fornecedor = fornecedores.fnc_codigo WHERE fup_ordCompra like '%" + pesquisar + "%';", dao.Conexao);
                da.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
            }
            else
            {
                if (fornecedorRb.Checked)
                {
                    da = new MySqlDataAdapter("SELECT fup_codigo, fup_ordCompra, fnc_nome FROM gs_aristeus.fallowup inner join fornecedores on fallowup.fup_fornecedor = fornecedores.fnc_codigo WHERE fnc_nome like '%" + pesquisar + "%';", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
            }
        }
    }
}
