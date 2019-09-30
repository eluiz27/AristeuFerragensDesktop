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
    public partial class consultaLOE : Form
    {
        DAO dao = new DAO();
        private string Sql, Sql2 = String.Empty;
        List<string> vendc = new List<string>();
        List<string> opc = new List<string>();
        List<string> prodc = new List<string>();
        List<string> prec = new List<string>();
        List<string> qtdeSis = new List<string>();
        List<string> comentc = new List<string>();
        controlTelaAberta cta = new controlTelaAberta();

        public void dataInfSup()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;

            table = new DataTable();
            bs = new BindingSource();

            da = new MySqlDataAdapter("SELECT loe_codigo, vdd_nome, opcao_loe_descricao, if(loe_id_produto regexp '[a-z]', loe_id_produto, concat(itm_codigo, ' - ', itm_descricao)) as 'produt', loe_qtde, loe_preco, " +
                                        "if(loe_comentario <> '', 'sim', 'não') as 'comentario' ,DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', ROUND((itens.ITM_Anterior+itens.ITM_Entradas+itens.ITM_Compras-itens.ITM_Saidas-itens.ITM_Vendas),2) as 'qtdeSist' " +
                                        "FROM ((loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) "+
                                        "INNER JOIN loe_opcao ON loe.loe_opcao = loe_opcao.opcao_loe_codigo) "+
                                        "LEFT OUTER JOIN itens ON loe.loe_id_produto = itens.itm_codigo WHERE loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "';", dao.Conexao);
            da.Fill(table);

            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }

        public void vendas()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior1 = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior2 = aux2.ToString("yyyy-MM-dd 23:00:00");
            querys qr = new querys();
            qr.selcTotal(inferior1, superior2);
            vendasTxt.Text = qr.NVendasL;
        }
        public void salvaDados()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["opcao"].Value.ToString() == "FALTA DE ESTOQUE" || dataGridView1.Rows[i].Cells["opcao"].Value.ToString() == "PRODUTO INEXISTENTE" || dataGridView1.Rows[i].Cells["opcao"].Value.ToString() == "PREÇO ELEVADO")
                {
                    Sql = "SELECT loe_comentario FROM loe WHERE loe_codigo =  " + dataGridView1.Rows[i].Cells["codigo"].Value.ToString() + "";
                    dao.Query = new MySqlCommand(Sql, dao.Conexao);
                    dao.conecta();
                    object coment = dao.Query.ExecuteScalar();
                    dao.desconecta();
                    vendc.Add(dataGridView1.Rows[i].Cells["vendedor"].Value.ToString());
                    opc.Add(dataGridView1.Rows[i].Cells["opcao"].Value.ToString());
                    prodc.Add(dataGridView1.Rows[i].Cells["produto"].Value.ToString());
                    qtdeSis.Add(dataGridView1.Rows[i].Cells["qtdeSistema"].Value.ToString());
                    prec.Add(dataGridView1.Rows[i].Cells["preco"].Value.ToString());
                    comentc.Add(coment.ToString());
                }
            }
        }
        public consultaLOE()
        {
            InitializeComponent();
        }

        private void consultaLOE_Load(object sender, EventArgs e)
        {
            vendedorRb.Checked = true;
            DateTime inf = DateTime.Now;
            DateTime sup = DateTime.Now;
            if (cta.TelaConsultaLOE == 1)
            {
                if (inf.DayOfWeek.ToString() == "Monday")
                {
                    inferiorMtxt.Text = inf.AddDays(-2).ToString("dd-MM-yyyy");
                    superiorMtxt.Text = sup.AddDays(-2).ToString("dd-MM-yyyy");
                }
                else
                {
                    inferiorMtxt.Text = inf.AddDays(-1).ToString("dd-MM-yyyy");
                    superiorMtxt.Text = sup.AddDays(-1).ToString("dd-MM-yyyy");
                }
            }
            else
            {
                inferiorMtxt.Text = inf.ToString("dd-MM-yyyy");
                superiorMtxt.Text = sup.ToString("dd-MM-yyyy");
            }
            dataInfSup();
            vendas();
        }

        private void consultaLOE_FormClosing(object sender, FormClosingEventArgs e)
        {
            cta.TelaConsultaLOE = 0;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Sql = "SELECT loe_comentario FROM loe WHERE loe_codigo = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object coment = dao.Query.ExecuteScalar();
            dao.desconecta();
            comentarioTxt.Text = coment.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataInfSup();
            vendas();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table;
            MySqlDataAdapter da;
            BindingSource bs;
            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            table = new DataTable();
            bs = new BindingSource();
            if (vendedorRb.Checked)
            {
                da = new MySqlDataAdapter("SELECT loe_codigo, vdd_nome, opcao_loe_descricao, if(loe_id_produto regexp '[a-z]', loe_id_produto, concat(itm_codigo, ' - ', itm_descricao)) as 'produt', loe_qtde, loe_preco, " +
                                        "if(loe_comentario <> '', 'sim', 'não') as 'comentario' ,DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', ROUND((itens.ITM_Anterior+itens.ITM_Entradas+itens.ITM_Compras-itens.ITM_Saidas-itens.ITM_Vendas),2) as 'qtdeSist' " +
                                        "FROM ((loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) " +
                                        "INNER JOIN loe_opcao ON loe.loe_opcao = loe_opcao.opcao_loe_codigo) " +
                                        "LEFT OUTER JOIN itens ON loe.loe_id_produto = itens.itm_codigo WHERE loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "' AND vdd_nome like '" + pesquisar + "%';", dao.Conexao);
                da.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
            }
            else
            {
                if (opcaoRb.Checked)
                {
                    da = new MySqlDataAdapter("SELECT loe_codigo, vdd_nome, opcao_loe_descricao, if(loe_id_produto regexp '[a-z]', loe_id_produto, concat(itm_codigo, ' - ', itm_descricao)) as 'produt', loe_qtde, loe_preco, " +
                                        "if(loe_comentario <> '', 'sim', 'não') as 'comentario' ,DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', ROUND((itens.ITM_Anterior+itens.ITM_Entradas+itens.ITM_Compras-itens.ITM_Saidas-itens.ITM_Vendas),2) as 'qtdeSist' " +
                                        "FROM ((loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) " +
                                        "INNER JOIN loe_opcao ON loe.loe_opcao = loe_opcao.opcao_loe_codigo) " +
                                        "LEFT OUTER JOIN itens ON loe.loe_id_produto = itens.itm_codigo WHERE loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "' AND opcao_loe_descricao like '" + pesquisar + "%';", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void excelTb_Click(object sender, EventArgs e)
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
                ex2.writeCell3(1, 0, 0, "Vendedor");
                ex2.writeCell3(1, 0, 1, "Opção");
                ex2.writeCell3(1, 0, 2, "Produto");
                ex2.writeCell3(1, 0, 3, "Qtde");
                ex2.writeCell3(1, 0, 4, "Preço");
                ex2.writeCell3(1, 0, 5, "Comentário");
                for (int i = 0; i < vendc.Count; i++)
                {
                    ex2.writeCell3(1, i + 1, 0, vendc[i]);
                    ex2.writeCell3(1, i + 1, 1, opc[i]);
                    ex2.writeCell3(1, i + 1, 2, prodc[i]);
                    ex2.writeCell3(1, i + 1, 3, qtdeSis[i]);
                    ex2.writeCell3(1, i + 1, 4, prec[i]);
                    ex2.writeCell3(1, i + 1, 5, comentc[i]);
                }
                ex2.ajustarColunas(1, "A", "F");
                ex2.Save();
                ex2.Close();
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            vendc.Clear();
            opc.Clear();
            prodc.Clear();
            qtdeSis.Clear();
            prec.Clear();
            comentc.Clear();
        }
    }
}
