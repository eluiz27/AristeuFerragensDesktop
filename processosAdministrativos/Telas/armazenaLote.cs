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
    public partial class armazenaLote : Form
    {
        MySqlConnection sqlConn = null;
        private string strConn = "server=10.0.0.210;userid=Luiz;password=GEN@#0996;database=gs_aristeus";
        private string Sql1, Sql2, Sql3 = String.Empty;
        MySqlCommand cmd1, cmd2, cmd3;
        variaveis vat = new variaveis();
        String numLote1 = string.Empty;
        String qtde1 = string.Empty;
        int qtdeNova = 0;
        DateTime dtCricao;
        List<int> qtdeProd = new List<int>();
        int aux3 = 0;
        class loteArmazem
        {
            public string numLote { get; set; }
            public string produto { get; set; }
            public string qtde { get; set; }
            public string validade { get; set; }

            public loteArmazem() { }
        }
        List<loteArmazem> aux2 = new List<loteArmazem>();

        public void preencheTabela()
        {
            sqlConn = new MySqlConnection(strConn);
            Sql1 = "SELECT ltv_numLote, itm_descricao, ltv_qtde, ltv_validade FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE ltv_validade = (SELECT MIN(ltv_validade) FROM lote_validade WHERE ltv_produto = " + vat.CodProdArmaze + ") AND ltv_produto = " + vat.CodProdArmaze + "";
            cmd1 = new MySqlCommand(Sql1, sqlConn);
            sqlConn.Open();
            MySqlDataReader lote = cmd1.ExecuteReader();
            lote.Read();
            DateTime data = Convert.ToDateTime(lote["ltv_validade"]);
            aux2.Add(new loteArmazem()
            {
                numLote = lote["ltv_numLote"].ToString(),
                produto = lote["itm_descricao"].ToString(),
                qtde = lote["ltv_qtde"].ToString(),
                validade = data.ToString("dd/MM/yyyy")
            });
            sqlConn.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aux2;
            dataGridView1.Columns[0].HeaderText = "Núm. Lote";
            dataGridView1.Columns[1].HeaderText = "Produto";
            dataGridView1.Columns[2].HeaderText = "Qtde";
            dataGridView1.Columns[3].HeaderText = "Validade";

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 70;
        }

        public void verificaQtde()
        {
            sqlConn = new MySqlConnection(strConn);
            Sql3 = "SELECT ltv_numLote, ltv_qtde, ltv_dataAlteracao FROM lote_validade INNER JOIN itens ON lote_validade.ltv_produto = itens.itm_codigo WHERE ltv_validade = (SELECT MIN(ltv_validade) FROM lote_validade WHERE ltv_produto = " + vat.CodProdArmaze + ") AND ltv_produto = " + vat.CodProdArmaze + "";
            cmd3 = new MySqlCommand(Sql3, sqlConn);
            sqlConn.Open();
            MySqlDataReader lote2 = cmd3.ExecuteReader();
            lote2.Read();
            numLote1 = lote2["ltv_numLote"].ToString();
            qtde1 = lote2["ltv_qtde"].ToString();
            dtCricao = Convert.ToDateTime(lote2["ltv_dataAlteracao"]);

            sqlConn = new MySqlConnection(strConn);
            Sql2 = "SELECT movimentos.mv_quantidade FROM movimentos INNER JOIN notas ON movimentos.mv_empresa = notas.nt_empresa AND movimentos.mv_agente = notas.nt_agente AND movimentos.mv_documento = notas.nt_documento INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo WHERE concat(nt_data, ' ',nt_hora) > '" + dtCricao.ToString("yyyy-MM-dd HH:mm:ss") + "' AND notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'V' and mv_item = " + vat.CodProdArmaze + "";
            cmd2 = new MySqlCommand(Sql2, sqlConn);
            sqlConn.Open();
            MySqlDataReader aux = cmd2.ExecuteReader();
            while (aux.Read())
            {
                qtdeProd.Add(Convert.ToInt32(aux["mv_quantidade"]));
                aux3++;
            }
            for (int i = 0; i < aux3; i++)
            {
                qtdeNova = qtdeNova + qtdeProd[i];
            }
            if (qtdeProd.Count > 0)
            {
                qtdeNova = int.Parse(qtde1) - qtdeNova;
            }
            sqlConn.Close();
        }

        public void limparVar()
        {
            aux2.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            vat.AuxArmaze = 0;
            vat.CodProdArmaze = 0;
            vat.NomeProdArmaze = string.Empty;
            produtoTxt.Text = string.Empty;
            situacaoTxt.Text = string.Empty;
            situacaoTxt.BackColor = Color.Empty;
            mensagemTxt.Text = string.Empty;
            numLote1 = string.Empty;
            qtde1 = string.Empty;
            qtdeNova = 0;
            qtdeProd.Clear();
            aux3 = 0;
        }
        public armazenaLote()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            limparVar();
            vat.AuxArmaze = 1;
            procuraProd pp = new procuraProd();
            pp.ShowDialog();
        }

        private void armazenaLote_Activated(object sender, EventArgs e)
        {
            if (vat.CodProdArmaze > 0)
            {
                sqlConn = new MySqlConnection(strConn);
                Sql1 = "select count(ltv_codigo) from lote_validade where ltv_qtde > 0 and ltv_produto = " + vat.CodProdArmaze + "";
                cmd1 = new MySqlCommand(Sql1, sqlConn);
                sqlConn.Open();
                object qtde = cmd1.ExecuteScalar();
                if (qtde.ToString() == "1")
                {
                    produtoTxt.Text = vat.NomeProdArmaze;
                    situacaoTxt.Text = "LIBERADO";
                    situacaoTxt.BackColor = Color.Green;
                }
                else if (qtde.ToString() == "0")
                {
                    mensagemTxt.Text = "LOTE NÃO CADASTRADO, FAVOR CONTACTAR O SETOR DE COMPRAS!";
                    situacaoTxt.Text = "NÃO ENCONTRADO";
                    situacaoTxt.BackColor = Color.Yellow;
                }
                else
                {
                    produtoTxt.Text = vat.NomeProdArmaze;
                    situacaoTxt.Text = "BLOQUEADO";
                    mensagemTxt.Text = "PARA LIBERAÇÃO, FAVOR CONTACTAR O SETOR DE COMPRAS!";
                    situacaoTxt.BackColor = Color.Red;
                    verificaQtde();
                    if (qtdeNova != 0)
                    {
                        DAO dao = new DAO();
                        controlLote cl = new controlLote();
                        cl.Ltv_qtde = qtdeNova;
                        cl.Ltv_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.alteraQtdeLote(cl, numLote1);
                    }
                    preencheTabela();
                }
                sqlConn.Close();
                vat.AuxArmaze = 0;
                situacaoTxt.Focus();
            }
        }

        private void armazenaLote_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaArmazanagem = 0;
            limparVar();
        }
    }
}
