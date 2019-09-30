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
    public partial class mediaVendas : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> cod1 = new List<string>();
        List<string> cod2 = new List<string>();
        List<string> cod3 = new List<string>();
        List<string> prod = new List<string>();
        List<string> uni = new List<string>();
        List<double> sald = new List<double>();
        List<double> tresM = new List<double>();
        List<double> seteM = new List<double>();
        List<double> tot = new List<double>();
        List<double> med = new List<double>();

        public void valores()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "select pdi_item, PDI_Descricao, itm_unidade, ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) as 'saldo', "+
                    "sum(pdi_quantidade) as 'qtde' from (peditem a left outer join pedidos b ON  a.pdi_empresa = b.ped_empresa and a.pdi_numero = b.ped_numero) "+
                    "left outer join itens c on a.pdi_item = c.itm_codigo where ped_data between '"+inferior+"' and '"+superior+"' group by pdi_item";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader val = dao.Query.ExecuteReader();
            while (val.Read())
            {
                cod1.Add(val["pdi_item"].ToString());
                prod.Add(val["PDI_Descricao"].ToString());
                uni.Add(val["itm_unidade"].ToString());
                sald.Add(Convert.ToDouble(val["saldo"]));
                tot.Add(Convert.ToDouble(val["qtde"]));
            }
            dao.desconecta();
        }

        public void valoresTres()
        {
            List<string> auxList1 = new List<string>();
            List<double> auxList2 = new List<double>();
            int w = 0;
            DateTime aux1 = DateTime.Parse(superiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            DateTime x = aux1.AddMonths(-3);
            string inferior1 = x.ToString("yyyy-MM-01 00:00:00");
            string superior1 = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "select pdi_item, sum(pdi_quantidade) as 'qtde' from (peditem a left outer join pedidos b ON  a.pdi_empresa = b.ped_empresa and a.pdi_numero = b.ped_numero) " +
                    "left outer join itens c on a.pdi_item = c.itm_codigo where ped_data between '" + inferior1 + "' and '" + superior1 + "' group by pdi_item";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader treM = dao.Query.ExecuteReader();
            while (treM.Read())
            {
                auxList1.Add(treM["pdi_item"].ToString());
                auxList2.Add(Convert.ToDouble(treM["qtde"]));
            }
            for (int i = 0; i < cod1.Count; i++)
            {
                if (cod1[i] == auxList1[w])
                {
                    tresM.Add(auxList2[w]);
                    w++;
                }
                else
                    tresM.Add(0);
            }
            auxList1.Clear();
            auxList2.Clear();
            treM.Close();
            dao.desconecta();
        }
        public void valoresSete()
        {
            List<string> auxList1 = new List<string>();
            List<double> auxList2 = new List<double>();
            int w = 0;
            DateTime aux1 = DateTime.Parse(superiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            DateTime x = aux1.AddMonths(-7);
            string inferior2 = x.ToString("yyyy-MM-01 00:00:00");
            string superior2 = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "select pdi_item, sum(pdi_quantidade) as 'qtde' from (peditem a left outer join pedidos b ON  a.pdi_empresa = b.ped_empresa and a.pdi_numero = b.ped_numero) " +
                    "left outer join itens c on a.pdi_item = c.itm_codigo where ped_data between '" + inferior2 + "' and '" + superior2 + "' group by pdi_item";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader setM = dao.Query.ExecuteReader();
            while (setM.Read())
            {
                auxList1.Add(setM["pdi_item"].ToString());
                auxList2.Add(Convert.ToDouble(setM["qtde"]));
            }
            setM.Read();
            for(int i = 0; i < cod1.Count; i ++)
            {
                if (cod1[i] == auxList1[w])
                {
                    seteM.Add(auxList2[w]);
                    w++;
                }
                else
                    seteM.Add(0);
            }
            auxList1.Clear();
            auxList2.Clear();
            setM.Close();
            dao.desconecta();
        }
        public void medias()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            int x = Convert.ToInt32(aux2.ToString("MM")) - Convert.ToInt32(aux1.ToString("MM"));
            for (int i = 0; i < cod1.Count; i++)
            {
                med.Add((Convert.ToDouble(tot[i]) / x));
            }
        }
        class medVend
        {
            public string codigo { get; set; }
            public string produto { get; set; }
            public string unidade { get; set; }
            public string saldo { get; set; }
            public string tresMes { get; set; }
            public string seteMes { get; set; }
            public string total { get; set; }
            public string media { get; set; }

            public medVend() { }
        }
        List<medVend> mv = new List<medVend>();

        public void preencheTabela()
        {
            
            for (int i = 0; i < cod1.Count(); i++)
            {
                mv.Add(new medVend()
                {
                    codigo = cod1[i],
                    produto = prod[i],
                    unidade = uni[i],
                    saldo = String.Format("{0:0.00}", sald[i]),
                    tresMes = String.Format("{0:0.00}", tresM[i]),
                    seteMes = String.Format("{0:0.00}", seteM[i]),
                    total = String.Format("{0:0.00}", tot[i]),
                    media = String.Format("{0:0.00}", med[i])
                });
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mv;

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Produto";
            dataGridView1.Columns[2].HeaderText = "Un.";
            dataGridView1.Columns[3].HeaderText = "Saldo";
            dataGridView1.Columns[4].HeaderText = "3 Meses";
            dataGridView1.Columns[5].HeaderText = "7 Meses";
            dataGridView1.Columns[6].HeaderText = "Total";
            dataGridView1.Columns[7].HeaderText = "Média";

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 70;
        }
        public mediaVendas()
        {
            InitializeComponent();
        }

        private void mediaVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaMediaVenda = 0;
        }

        private void mediaVendas_Load(object sender, EventArgs e)
        {
            DateTime aux1 = DateTime.Now;
            DateTime aux2 = DateTime.Now;
            inferiorMtxt.Text = aux1.AddMonths(-7).ToString("01/MM/yyyy");
            superiorMtxt.Text = aux2.ToString("dd/MM/yyyy");
            backgroundWorker1.RunWorkerAsync();
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            mv.Clear();
            cod1.Clear();
            cod2.Clear();
            cod3.Clear();
            tresM.Clear();
            seteM.Clear();
            prod.Clear();
            uni.Clear();
            sald.Clear();
            tot.Clear();
            med.Clear();
            valores();
            valoresTres();
            valoresSete();
            medias();
            preencheTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] x = new string[cod1.Count, 8];
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
                ex2.writeCell3(1, 0, 0, "Código");
                ex2.writeCell3(1, 0, 1, "Produto");
                ex2.writeCell3(1, 0, 2, "Un.");
                ex2.writeCell3(1, 0, 3, "Saldo");
                ex2.writeCell3(1, 0, 4, "3 Meses");
                ex2.writeCell3(1, 0, 5, "7 Meses");
                ex2.writeCell3(1, 0, 6, "Total");
                ex2.writeCell3(1, 0, 7, "Média");
                for (int i = 0; i < cod1.Count; i++)
                {
                    x[i, 0] = cod1[i];
                    x[i, 1] = prod[i];
                    x[i, 2] = uni[i];
                    x[i, 3] = String.Format("{0:0.00}", sald[i]);
                    x[i, 4] = String.Format("{0:0.00}", tresM[i]);
                    x[i, 5] = String.Format("{0:0.00}", seteM[i]);
                    x[i, 6] = String.Format("{0:0.00}", tot[i]);
                    x[i, 7] = String.Format("{0:0.00}", med[i]);
                }
                ex2.writeRange(2, 1, cod1.Count + 1, 8, 1, x);
                ex2.ajustarColunas(1, "A", "H");
                ex2.Save();
                ex2.Close();
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            valores();
            valoresTres();
            valoresSete();
            medias();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preencheTabela();
        }
    }
}
