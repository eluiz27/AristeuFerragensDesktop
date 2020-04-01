using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class indicadoresVendas : Form
    {
        DAO dao = new DAO();
        DataTable tb = new DataTable();

        private string Sql = String.Empty;
        List<string> vdds = new List<string>();
        List<string> vddsNome = new List<string>();
        List<string> qtdeDev = new List<string>();
        List<string> qtdeCan = new List<string>();
        List<string> qtdePed = new List<string>();
        List<string> qtdeAtend = new List<string>();
        List<string> qtdeItens = new List<string>();
        List<string> dev = new List<string>();
        List<string> desc = new List<string>();
        List<string> vtl = new List<string>();
        querys qr = new querys();
        progresso pg = new progresso();

        string caminhosMVTxt = Path.GetFullPath("Caminhos\\MapaVendas.txt");
        string caminhosIndTxt = Path.GetFullPath("Caminhos\\IndVend.txt");
        StreamReader arquivo;
        string caminhoMV;
        string caminhoInd;
        public void preencheMV()
        {
            arquivo = File.OpenText(caminhosMVTxt);
            caminhoMV = arquivo.ReadLine();
            arquivo.Close();
        }

        public void preencheInd()
        {
            arquivo = File.OpenText(caminhosIndTxt);
            caminhoInd = arquivo.ReadLine();
            arquivo.Close();
        }

        public void vendedores()
        {
            Sql = "select vdd_codigo, vdd_nome from vendedores inner join valor_meta on vendedores.vdd_codigo = valor_meta.vmet_vendedor where (vdd_cttfuncao = 'VENDEDOR' or vdd_cttfuncao = 'VENDEDORA') and vdd_situacao = 'A' and vmet_situacao = 1";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdd = dao.Query.ExecuteReader();
            vdds.Add("0");
            vddsNome.Add("LOJA");
            while (vdd.Read())
            {
                vdds.Add(vdd["vdd_codigo"].ToString());
                vddsNome.Add(vdd["vdd_nome"].ToString());
            }
            vdd.Close();
            dao.desconecta();
        }

        public void montaTabela()
        {
            tb.Columns.Add("no");
            tb.Columns.Add("nD");
            tb.Columns.Add("nC");
            tb.Columns.Add("qA");
            tb.Columns.Add("qP");
            tb.Columns.Add("qI");
            tb.Columns.Add("de");
            tb.Columns.Add("des");
            tb.Columns.Add("tQ");

        }

        public void preencheTabela()
        {
            for(int i = 0; i < vdds.Count; i++)
            {
                tb.Rows.Add(vddsNome[i], qtdeDev[i], qtdeCan[i], qtdeAtend[i], qtdePed[i], qtdeItens[i], dev[i], desc[i], vtl[i]);
            }
            dataGridView1.DataSource = tb;

        }

        public void localizaDados()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");
            querys q = new querys();

            qr.indcaLoja(inferior, superior, 0, 99);
            qr.selcTotal(inferior, superior);

            qtdeDev.Add(qr.NDevolu.ToString());
            qtdeCan.Add(qr.NCancelado.ToString());
            qtdeAtend.Add((Convert.ToInt32(qr.NAtendL) + Convert.ToInt32(qr.NVendasL)).ToString());
            qtdePed.Add(qr.NVendasL);
            qtdeItens.Add(qr.NItensLoja);
            dev.Add(Math.Floor(qr.Cancelado + qr.Devolu).ToString());
            desc.Add(Math.Floor(qr.DescIten + qr.DescPed).ToString());
            vtl.Add(Math.Floor(Convert.ToDouble(qr.VendasL) + qr.OrcamL).ToString());

            for (int i = 1; i < vdds.Count; i++)
            {
                double totaldesc = 0;
                double totaldev = 0;
                double totalLiq = 0;
                q.indcaLoja(inferior, superior, int.Parse(vdds[i]), int.Parse(vdds[i]));
                q.selecao(inferior, superior, int.Parse(vdds[i]));

                totaldesc = q.DescIten + q.DescPed;
                totaldev = q.Cancelado + q.Devolu;
                totalLiq = Convert.ToDouble(q.Vendas) + q.Orcam;

                qtdeDev.Add(q.NDevolu);
                qtdeCan.Add(q.NCancelado);
                qtdeAtend.Add((Convert.ToInt32(q.NAtend) + Convert.ToInt32(q.NVendas)).ToString());
                qtdePed.Add(q.NVendas);
                qtdeItens.Add(q.NItens);
                dev.Add(Math.Floor(totaldev).ToString());
                desc.Add(Math.Floor(totaldesc).ToString());
                vtl.Add(Math.Floor(totalLiq).ToString());
            }
        }

        public void preenchePlanilha()
        {
            preencheMV();
            preencheInd();
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");
            int mes = Convert.ToInt32(aux2.ToString("MM"));
            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();
            string mesDefi = mesExtenso.Substring(0,1).ToUpper()+""+mesExtenso.Substring(1);

            excel ex = new excel(@"" + caminhoInd + "" + mesExtenso.Substring(0, 3).ToUpper() + "_"+aux2.ToString("yy")+".xlsx", "");

            excel e = new excel(@"" + caminhoMV + "" + mesExtenso.Substring(0, 3).ToUpper() + "_" + aux2.ToString("yy") + ".xlsx", "123");
            ex.createSheet(mesDefi+"_"+aux2.ToString("yy"));

            int qtdePlan = ex.contaPastas() - 1;
            querys q = new querys();
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string meta = e.ReadCell(4, 39, i + 1);
                ex.writeCell2(qtdePlan, 3, 2, dataGridView1.Rows[i].Cells[1].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 3, dataGridView1.Rows[i].Cells[2].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 4, dataGridView1.Rows[i].Cells[3].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 5, dataGridView1.Rows[i].Cells[4].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 8, dataGridView1.Rows[i].Cells[5].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 12, dataGridView1.Rows[i].Cells[6].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 13, dataGridView1.Rows[i].Cells[7].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 14, dataGridView1.Rows[i].Cells[8].Value.ToString(), vddsNome[i]);
                ex.writeCell2(qtdePlan, 3, 15, meta, vddsNome[i]);
            }

            ex.Save();
            e.Close();
            ex.Close();
            String strCaminhoNomeArquivo = @"" + caminhoInd + "" + mesExtenso.Substring(0, 3).ToUpper() + "_"+aux2.ToString("yy")+".xlsx";
            System.Diagnostics.Process.Start(strCaminhoNomeArquivo);
        }

        public void limpar()
        {
            tb.Clear();
            vdds.Clear();
            vddsNome.Clear();
            qtdeDev.Clear();
            qtdeCan.Clear();
            qtdePed.Clear();
            qtdeAtend.Clear();
            qtdeItens.Clear();
            dev.Clear();
            desc.Clear();
            vtl.Clear();
        }

        public indicadoresVendas()
        {
            InitializeComponent();
        }
        private void indicadoresVendas_Load(object sender, EventArgs e)
        {
            DateTime inf = DateTime.Now;
            DateTime sup = DateTime.Now;
            inferiorMtxt.Text = inf.AddMonths(-1).ToString("26-MM-yyyy");
            superiorMtxt.Text = sup.ToString("25-MM-yyyy");
            montaTabela();
            backgroundWorker1.RunWorkerAsync();
            pg.ShowDialog();

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vendedores();
            localizaDados();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pg.X = 1;
            preencheTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            preenchePlanilha();
        }

        private void indicadoresVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaIndicVendas = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pg.X = 0;
            limpar();
            backgroundWorker1.RunWorkerAsync();
            pg.ShowDialog();
        }
    }
}
