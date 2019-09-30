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
using System.Net;
using System.Net.NetworkInformation;

namespace processosAdministrativos.Telas
{
    public partial class campanhas : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> codCmak = new List<string>();
        List<string> camp = new List<string>();
        List<string> cod = new List<string>();
        List<string> prod = new List<string>();
        List<int> alc = new List<int>();
        List<int> curt = new List<int>();
        List<int> compart = new List<int>();
        List<int> grafiQtde = new List<int>();
        List<int> grafiValor = new List<int>();
        List<DateTime> dat = new List<DateTime>();
        List<DateTime> dat2 = new List<DateTime>();
        List<int> qtde = new List<int>();
        string pesquisaCamp = string.Empty;
        string pesquisaCod = string.Empty;
        string pesquisaProd = string.Empty;
        int codigoProd = 0;
        variaveis var = new variaveis();

        public void montaTabela()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn();
            um.HeaderText = "Campanha";
            um.Name = "camp";
            um.DataPropertyName = "cmak_campanha";
            um.ReadOnly = true;
            um.Width = 100;
            dataGridView1.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn();
            dois.HeaderText = "Código";
            dois.Name = "cod";
            dois.ReadOnly = true;
            dois.DataPropertyName = "cmak_produto";
            dois.Width = 60;
            dataGridView1.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "Produto";
            tres.Name = "prod";
            tres.ReadOnly = true;
            tres.DataPropertyName = "produto";
            tres.Width = 350;
            dataGridView1.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "Alcance";
            quatro.Name = "alc";
            quatro.DataPropertyName = "cmak_alcance";
            quatro.Width = 60;
            dataGridView1.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "Curtidas";
            cinco.Name = "curti";
            cinco.DataPropertyName = "cmak_curtidas";
            cinco.Width = 60;
            dataGridView1.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn();
            seis.HeaderText = "Compartiamentos";
            seis.Name = "comparti";
            seis.DataPropertyName = "cmak_compart";
            seis.Width = 100;
            dataGridView1.Columns.Add(seis);

            DataGridViewTextBoxColumn sete = new DataGridViewTextBoxColumn();
            sete.HeaderText = "Postagem";
            sete.Name = "posta";
            sete.ReadOnly = true;
            sete.DataPropertyName = "cmak_data";
            sete.Width = 80;
            dataGridView1.Columns.Add(sete);

            DataGridViewTextBoxColumn oito = new DataGridViewTextBoxColumn();
            oito.HeaderText = "codigo";
            oito.Name = "codigo";
            oito.Visible = false;
            oito.DataPropertyName = "cmak_codigo";
            oito.Width = 80;
            dataGridView1.Columns.Add(oito);
        }

        public void preecheTabela()
        {
            var tb = new DataTable();
            tb.Columns.Add("cmak_campanha");
            tb.Columns.Add("cmak_produto");
            tb.Columns.Add("produto");
            tb.Columns.Add("cmak_alcance", typeof(int));
            tb.Columns.Add("cmak_curtidas", typeof(int));
            tb.Columns.Add("cmak_compart", typeof(int));
            tb.Columns.Add("cmak_data", typeof(DateTime));
            tb.Columns.Add("cmak_codigo");

            for (int i = 0; i < camp.Count; i++)
            {
                tb.Rows.Add(camp[i], cod[i], prod[i], alc[i], curt[i], compart[i], dat[i], codCmak[i]);
            }
            dataGridView1.DataSource = tb;
        }

        public void localizaDados()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "SELECT cmak_codigo, cmak_campanha, cmak_item, if(cmak_produto = '' , itm_descricao, cmak_produto) as 'prod', cmak_alcance, cmak_curtidas, cmak_compart, DATE_FORMAT(cmak_data, '%d/%m/%Y') as 'data' " +
                    "FROM campanha_marketing left outer join itens on campanha_marketing.cmak_item = itens.itm_codigo where cmak_campanha like '%" + pesquisaCamp + "%' and cmak_item like '%" + pesquisaCod + "%' " +
                    "and (cmak_produto like '%" + pesquisaProd + "%' or itm_descricao like '%" + pesquisaProd + "%') and cmak_data between '" + inferior + "' and '" + superior + "'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader campa = dao.Query.ExecuteReader();
            while (campa.Read())
            {
                codCmak.Add(campa["cmak_codigo"].ToString());
                camp.Add(campa["cmak_campanha"].ToString());
                cod.Add(campa["cmak_item"].ToString());
                prod.Add(campa["prod"].ToString());
                alc.Add(Convert.ToInt32(campa["cmak_alcance"]));
                curt.Add(Convert.ToInt32(campa["cmak_curtidas"]));
                compart.Add(Convert.ToInt32(campa["cmak_compart"]));
                dat.Add(Convert.ToDateTime(campa["data"]));
            }
            campa.Close();
            dao.desconecta();
        }

        public void limpaTabela()
        {
            codCmak.Clear();
            camp.Clear();
            cod.Clear();
            prod.Clear();
            alc.Clear();
            curt.Clear();
            compart.Clear();
            dat.Clear();
            grafiQtde.Clear();
            grafiValor.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        public void grafico()
        {
            int aux = 0;
            Sql = "select round(if (cmak_campanha = 'OFERTA', sum(cmak_alcance) / 2, sum(cmak_alcance))) as 'valor' from campanha_marketing group by cmak_campanha; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader graf = dao.Query.ExecuteReader();
            while (graf.Read())
            {
                grafiValor.Add(Convert.ToInt32(graf["valor"]));
            }
            graf.Close();
            dao.desconecta();
            for (int i = 0; i < grafiValor.Count; i++)
            {
                aux = aux + grafiValor[i];
            }
            for (int i = 0; i < grafiValor.Count; i++)
            {
                grafiValor[i] = grafiValor[i] * 100 / aux;
            }
            chart1.Series[0].Points.AddY(grafiValor[1]);
            chart1.Series[1].Points.AddY(grafiValor[3]);
            chart1.Series[2].Points.AddY(grafiValor[2]);
            chart1.Series[3].Points.AddY(grafiValor[0]);

        }

        public void grafico2()
        {
            Sql = "select cmak_campanha, cmak_item, if(cmak_produto = '' , itm_descricao, cmak_produto) as 'prod', DATE_FORMAT(cmak_data, '%d/%m/%Y') as 'data' from campanha_marketing  left outer join itens on campanha_marketing.cmak_item = itens.itm_codigo where cmak_codigo = " + var.CodCamp + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader camp = dao.Query.ExecuteReader();
            while (camp.Read())
            {
                campanhaTxt.Text = camp["cmak_campanha"].ToString();
                produtoTxt.Text = camp["prod"].ToString();
                dataMtxt.Text = camp["data"].ToString();
                codigoProd = Convert.ToInt32(camp["cmak_item"]);
            }
            camp.Close();
            dao.desconecta();
            var.CodCamp = 0;

            DateTime aux1 = DateTime.Parse(dataMtxt.Text);
            inferior2Mtxt.Text = aux1.AddMonths(-1).ToString("dd/MM/yyyy");
            superior2Mtxt.Text = aux1.AddMonths(1).ToString("dd/MM/yyyy");
        } 

        public campanhas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastraBanner cb = new cadastraBanner();
            cb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroCampanha cc = new cadastroCampanha();
            cc.ShowDialog();
        }

        private void campanhas_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaCadBanner = 0;
        }

        private void campanhas_Load(object sender, EventArgs e)
        {
            inferiorMtxt.Text = "01/01/2001";
            superiorMtxt.Text = "01/01/2099";
            campanhaRb.Checked = true;
            pesquisarBt.Focus();
            limpaTabela();
            localizaDados();
            montaTabela();
            preecheTabela();
            dataGridView1.Sort(dataGridView1.Columns["posta"], ListSortDirection.Descending);
            grafico();
            var.AuxCampanha = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (campanhaRb.Checked)
            {
                pesquisaCamp = pesquisarTxt.Text;
                limpaTabela();
                pesquisarTxt.Focus();
                localizaDados();
                montaTabela();
                preecheTabela();
                dataGridView1.Sort(dataGridView1.Columns["posta"], ListSortDirection.Descending);
            }
            else if (codProdRb.Checked)
            {
                pesquisaCod = pesquisarTxt.Text;
                limpaTabela();
                pesquisarTxt.Focus();
                localizaDados();
                montaTabela();
                preecheTabela();
                dataGridView1.Sort(dataGridView1.Columns["posta"], ListSortDirection.Descending);
            }
            else if (produtoRb.Checked)
            {
                pesquisaProd = pesquisarTxt.Text;
                limpaTabela();
                pesquisarTxt.Focus();
                localizaDados();
                montaTabela();
                preecheTabela();
                dataGridView1.Sort(dataGridView1.Columns["posta"], ListSortDirection.Descending);
            }
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            limpaTabela();
            localizaDados();
            montaTabela();
            preecheTabela();
            dataGridView1.Sort(dataGridView1.Columns["posta"], ListSortDirection.Descending);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                controlCampanha cc = new controlCampanha();
                cc.Cmak_alcance = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cc.Cmak_curtidas = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cc.Cmak_compart = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                dao.alteraCampanha(cc, Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value));
                cc.Cmak_alcance = string.Empty;
                cc.Cmak_curtidas = string.Empty;
                cc.Cmak_compart = string.Empty;
            }
        }

        private void campanhas_Activated(object sender, EventArgs e)
        {
            if(var.AuxCampanha == 1)
            {
                limpaTabela();
                localizaDados();
                montaTabela();
                preecheTabela();
                dataGridView1.Sort(dataGridView1.Columns["posta"], ListSortDirection.Descending);
                grafico();
                var.AuxCampanha = 0;
            }
            if (var.CodCamp > 0)
            {
                grafico2();
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dat2.Clear();
            qtde.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            codigoProd = 0;
            campanhaTxt.Text = string.Empty;
            produtoTxt.Text = string.Empty;
            dataMtxt.Text = "  /  /   ";
            inferior2Mtxt.Text = "  /  /   ";
            superior2Mtxt.Text = "  /  /   ";
            procuraCampanha pc = new procuraCampanha();
            pc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            dat2.Clear();
            qtde.Clear();
            DateTime aux1 = DateTime.Parse(inferior2Mtxt.Text);
            DateTime aux2 = DateTime.Parse(superior2Mtxt.Text);
            String inferior2 = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior2 = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "select nt_data, mv_quantidade from movimentos a inner join notas b on a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                    "INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo where nt_data between '"+ inferior2 + "' and '"+superior2+"' and Tipomovi.tmv_grupo = 'V' and mv_item = "+codigoProd+"; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();

            MySqlDataReader vendas = dao.Query.ExecuteReader();
            while (vendas.Read())
            {
                dat2.Add(Convert.ToDateTime(vendas["nt_data"]));
                qtde.Add(Convert.ToInt32(vendas["mv_quantidade"]));
            }

            int antes = 0;
            int depois = 0;

            for (int i = 0; i < dat2.Count; i++)
            {
                if (dat2[i] < Convert.ToDateTime(dataMtxt.Text))
                    antes++;
                else if (dat2[i] >= Convert.ToDateTime(dataMtxt.Text))
                    depois++;
            }

            chart2.Series[0].Points.AddY(antes);
            chart2.Series[1].Points.AddY(depois);

            vendas.Close();
            dao.desconecta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dat2.Clear();
            qtde.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            codigoProd = 0;
            campanhaTxt.Text = string.Empty;
            produtoTxt.Text = string.Empty;
            dataMtxt.Text = "  /  /   ";
            inferior2Mtxt.Text = "  /  /   ";
            superior2Mtxt.Text = "  /  /   ";
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }        
    }
}
