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
    public partial class comprasFunc : Form
    {
        DAO dao = new DAO();
        int situacao = 0;
        List<string> doc = new List<string>();
        List<string> fun = new List<string>();
        List<string> parc = new List<string>();
        List<string> valor1 = new List<string>();
        public comprasFunc()
        {
            InitializeComponent();
        }

        public void tabelaFunc()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd");
            String superior = aux2.ToString("yyyy-MM-dd");

            DataTable table = new DataTable();
            MySqlDataAdapter da;
            BindingSource bs = new BindingSource();
            string pesquisar = nomeTxt.Text.Replace('*', '%');

            if(emAbertoCb.Checked == true)
                situacao = 0;
            else
                situacao = 1;

            da = new MySqlDataAdapter("SELECT rec_documento, cli_nome, rec_parcela, format(rec_valor, 2) as 'rec_valor' "+
                                        "FROM ctrparcelas INNER JOIN clientes ON ctrparcelas.REC_Cliente = clientes.cli_codigo "+
                                        "WHERE (CLI_Observacao = 'FUNCIONÁRIO' OR CLI_Observacao = 'CHEFE') AND rec_baixado = " + situacao + " AND rec_vencimento between '" + inferior + "' AND '"+superior+"' AND cli_nome like '" + pesquisar + "%' order by cli_nome, rec_documento;", dao.Conexao);
            da.Fill(table);
            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }

        public void salvaDados()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                doc.Add(dataGridView1.Rows[i].Cells["documento"].Value.ToString());
                fun.Add(dataGridView1.Rows[i].Cells["nome"].Value.ToString());
                parc.Add(dataGridView1.Rows[i].Cells["parcela"].Value.ToString());
                valor1.Add(dataGridView1.Rows[i].Cells["valor"].Value.ToString());
            }
        }

        public void tabelaTodos()
        {
            DateTime aux = DateTime.Parse(inferiorMtxt.Text);
            String data = aux.ToString("yyyy-MM-dd");

            DataTable table = new DataTable();
            MySqlDataAdapter da;
            BindingSource bs = new BindingSource();
            string pesquisar = nomeTxt.Text.Replace('*', '%');

            if(emAbertoCb.Checked == true)
                situacao = 0;
            else
                situacao = 1;

            da = new MySqlDataAdapter("SELECT rec_documento, cli_nome, rec_parcela, format(rec_valor, 2) as 'rec_valor' " +
                                        "FROM ctrparcelas INNER JOIN clientes ON ctrparcelas.REC_Cliente = clientes.cli_codigo " +
                                        "WHERE rec_vencimento = '" + data + "' AND cli_nome like '" + pesquisar + "%' AND rec_baixado = "+situacao+" order by cli_nome, rec_documento;", dao.Conexao);
            da.Fill(table);
            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }

        private void comprasFunc_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaComprasFunc = 0;
        }

        private void comprasFunc_Load(object sender, EventArgs e)
        {
            DateTime aux1 = DateTime.Now;
            DateTime aux2 = DateTime.Now;
            inferiorMtxt.Text = aux1.ToString("10/MM/yyyy");
            superiorMtxt.Text = aux2.ToString("10/MM/yyyy");
            funcionarioCb.Checked = true;
            emAbertoCb.Checked = true;
            tabelaFunc();
        }

        private void funcionarioCb_CheckedChanged(object sender, EventArgs e)
        {
            if (funcionarioCb.Checked == true)
                tabelaFunc();
            else
                tabelaTodos();
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            if (funcionarioCb.Checked == true)
                tabelaFunc();
            else
                tabelaTodos();
        }

        private void nomeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (funcionarioCb.Checked == true)
                tabelaFunc();
            else
                tabelaTodos();
        }

        private void emAbertoCb_CheckedChanged(object sender, EventArgs e)
        {
            if (funcionarioCb.Checked == true)
                tabelaFunc();
            else
                tabelaTodos();
        }

        private void excelBt_Click(object sender, EventArgs e)
        {
            salvaDados();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel|*.xlsx";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                excel ex = new excel();
                ex.createFile();
                ex.SavaAs(sfd.FileName);
                ex.Close();
                excel ex2 = new excel(sfd.FileName, "");
                ex2.writeCell3(1, 0, 0, "Documento");
                ex2.writeCell3(1, 0, 1, "Nome");
                ex2.writeCell3(1, 0, 2, "Parcela");
                ex2.writeCell3(1, 0, 3, "Valor");
                for (int i = 0; i < doc.Count; i++)
                {
                    ex2.writeCell3(1, i + 1, 0, doc[i]);
                    ex2.writeCell3(1, i + 1, 1, fun[i]);
                    ex2.writeCell3(1, i + 1, 2, parc[i]);
                    ex2.writeCell3(1, i + 1, 3, valor1[i]);
                }
                ex2.ajustarColunas(1, "A", "D");
                ex2.Save();
                ex2.Close();
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            doc.Clear();
            fun.Clear();
            parc.Clear();
            valor1.Clear();
        }
    }
}
