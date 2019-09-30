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
    public partial class codificacao : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        variaveis vat = new variaveis();
        String numNot;
        String codFor;
        string situ;

        class preencheNota
        {
            public string numNota{ get; set; }
            public string codProd { get; set; }
            public string nomeProd { get; set; }
            public string unid { get; set; }
            public double qtde { get; set; }
            public string codForn { get; set; }
            public string sit { get; set; }

            public preencheNota() { }
        }
        List<preencheNota> aux2 = new List<preencheNota>();

        public bool maisDeUm()
        {
            int qtde = 0;
            Sql = "select count(nt_documento) as 'nt_documento' from notas where nt_documento = " + notaTxt.Text + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader qtdeNota = dao.Query.ExecuteReader();
            while (qtdeNota.Read())
            {
                qtde = Convert.ToInt32(qtdeNota["nt_documento"]);
            }
            qtdeNota.Close();
            dao.desconecta();

            if (qtde == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void preencheTabela()
        {           
            Sql = "SELECT mv_documento, mv_item, MV_Descricao, mv_unidade, mv_quantidade, itm_identificacao, codf_situacao " +
                    "FROM (((movimentos INNER JOIN notas ON notas.nt_documento = movimentos.mv_documento " +
                    "AND notas.nt_empresa = movimentos.mv_empresa and notas.nt_agente =  movimentos.mv_agente) " +
                    "INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo)INNER JOIN itens ON movimentos.mv_item = itens.itm_codigo) LEFT OUTER JOIN codificacao ON notas.nt_documento = codificacao.codf_nota WHERE mv_documento = " + notaTxt.Text + " and Tipomovi.tmv_grupo = 'c'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader nota = dao.Query.ExecuteReader();
            while (nota.Read())
            {
                aux2.Add(new preencheNota()
                {
                    numNota = nota["mv_documento"].ToString(),
                    codProd = nota["mv_item"].ToString(),
                    nomeProd = nota["MV_Descricao"].ToString(),
                    unid = nota["mv_unidade"].ToString(),
                    qtde = Convert.ToDouble(nota["mv_quantidade"]),
                    codForn = nota["itm_identificacao"].ToString(),
                    sit = nota["codf_situacao"].ToString()
                });
                numNot = nota["mv_documento"].ToString();
                codFor = nota["itm_identificacao"].ToString();
                situ = nota["codf_situacao"].ToString();
            }
            nota.Close();
            dao.desconecta();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aux2;
            dataGridView1.Columns[0].HeaderText = "Nº Nota";
            dataGridView1.Columns[1].HeaderText = "Cód. Prod.";
            dataGridView1.Columns[2].HeaderText = "Produto";
            dataGridView1.Columns[3].HeaderText = "Unid.";
            dataGridView1.Columns[4].HeaderText = "Qtde";
            dataGridView1.Columns[5].HeaderText = "Cod. Forn.";
            dataGridView1.Columns[6].HeaderText = "Situação";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 258;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 60;

            if (situ != string.Empty)
            {
                estoq1Cb.Enabled = false;
                estoq2Cb.Enabled = false;
                codificaCb.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                estoq1Cb.Enabled = true;
                codificaCb.Enabled = true;
                button1.Enabled = true;
            }
        }

        public void preecheCombo2()
        {
            Sql = "SELECT est_codigo, est_nome FROM estoquista";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader estoq1 = dao.Query.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(estoq1);
            DataRow row = table1.NewRow();
            row["est_nome"] = "";
            table1.Rows.InsertAt(row, 0);

            estoq1Cb.DataSource = table1;
            estoq1Cb.DisplayMember = "est_nome";
            estoq1Cb.ValueMember = "est_codigo";
            estoq1.Close();
            dao.desconecta();
        }
        public void preecheCombo1()
        {
            Sql = "SELECT est_codigo, est_nome FROM estoquista";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader estoq2 = dao.Query.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(estoq2);
            DataRow row = table2.NewRow();
            row["est_nome"] = "";
            table2.Rows.InsertAt(row, 0);

            estoq2Cb.DataSource = table2;
            estoq2Cb.DisplayMember = "est_nome";
            estoq2Cb.ValueMember = "est_codigo";
            estoq2.Close();
            dao.desconecta();
        }

        public void limpaTabela()
        {
            aux2.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        public void limpa()
        {
            estoq1Cb.SelectedIndex = 0;
            estoq2Cb.SelectedIndex = 0;
            codificaCb.Checked = false;
            vat.AuxCodifica = 0;
            vat.NumNota = string.Empty;
        }
        public codificacao()
        {
            InitializeComponent();
        }

        private void codificacao_Load(object sender, EventArgs e)
        {
            preecheCombo1();
            preecheCombo2();
        }

        private void codificacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaCodificacao = 0;
            limpaTabela();
            limpa();
        }

        private void notaTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            procuraNota pn = new procuraNota();
            pn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int z = 0;
                string[,] x = new string[dataGridView1.RowCount, 5];

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
                    ex2.writeCell3(1, 0, 0, "Cód. Prod.");
                    ex2.writeCell3(1, 0, 1, "Produto");
                    ex2.writeCell3(1, 0, 2, "Un.");
                    ex2.writeCell3(1, 0, 3, "Qtde");
                    ex2.writeCell3(1, 0, 4, "Cód. Forn.");


                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        x[z, 0] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        x[z, 1] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        x[z, 2] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        x[z, 3] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        x[z, 4] = dataGridView1.Rows[i].Cells[5].Value.ToString();

                        z++;
                    }

                    ex2.writeRange(2, 1, dataGridView1.RowCount + 1, 5, 1, x);
                    ex2.ajustarColunas(1, "A", "E");
                    ex2.negrito(1, "A1:E1");
                    ex2.Save();
                    ex2.Close();
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            else
                MessageBox.Show("Nada na tabela!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void codificacao_Activated(object sender, EventArgs e)
        {
            if (vat.AuxCodifica == 1)
            {
                limpaTabela();
                notaTxt.Text = vat.NumNota;
                preencheTabela();

                vat.AuxCodifica = 0;
            }
        }

        private void notaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                if (notaTxt.Text != string.Empty)
                {
                    if (e.KeyChar == 13)
                    {
                        if(maisDeUm() == true)
                        {
                            limpaTabela();
                            preencheTabela();
                        }
                        else
                        {
                            procuraNota pn = new procuraNota();
                            variaveis vari = new variaveis();
                            vari.DocCodific = notaTxt.Text;
                            pn.ShowDialog();
                        }
                    }
                }
            }  
        }

        private void estoq1Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (estoq1Cb.SelectedIndex > 0)
            {
                estoq2Cb.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (notaTxt.Text != string.Empty && dataGridView1.RowCount > 0 && estoq1Cb.SelectedIndex > 0 && codificaCb.Checked == true)
            {
                controlCodifica cc = new controlCodifica();
                cc.Codf_nota = numNot;
                cc.Codf_codForn = codFor;
                cc.Codf_codEstoquista1 = estoq1Cb.SelectedValue.ToString();

                if (estoq2Cb.SelectedIndex > 0)
                    cc.Codf_codEstoquista2 = estoq2Cb.SelectedValue.ToString();
                else
                    cc.Codf_codEstoquista2 = "0";

                cc.Codf_situacao = "OK";
                cc.Codf_data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dao.cadastraCodifica(cc);
                MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaTabela();
                limpa();
                preencheTabela();
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
