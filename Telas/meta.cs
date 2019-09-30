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
    public partial class meta : Form
    {
        controlTelaAberta cta = new controlTelaAberta();
        private string Sql = String.Empty;

        List<string> codVdd = new List<string>();
        List<string> nomeVdd = new List<string>();
        List<string> metaVdd = new List<string>();
        List<string> situacao = new List<string>();
        List<string> tipo = new List<string>();
        List<string> aux = new List<string>();

        DAO dao = new DAO();

        public void montaTabela()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn();
            um.HeaderText = "Código";
            um.Name = "cod";
            um.DataPropertyName = "vdd_codigo";
            um.ReadOnly = true;
            um.Width = 50;
            dataGridView1.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn();
            dois.HeaderText = "Vendedor";
            dois.Name = "vdd";
            dois.DataPropertyName = "vdd_nome";
            dois.ReadOnly = true;
            dois.Width = 150;
            dataGridView1.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "Meta";
            tres.Name = "meta";
            tres.DataPropertyName = "vmet_meta";
            tres.Width = 60;
            dataGridView1.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "Super Meta";
            quatro.Name = "sMeta";
            quatro.DataPropertyName = "superM";
            quatro.ReadOnly = true;
            quatro.Width = 60;
            dataGridView1.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "Sit";
            cinco.Name = "sit";
            cinco.DataPropertyName = "sitVdd";
            cinco.Width = 40;
            dataGridView1.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn();
            seis.HeaderText = "Tip";
            seis.Name = "tip";
            seis.DataPropertyName = "vmet_tipo";
            seis.Width = 60;
            dataGridView1.Columns.Add(seis);
        }

        public void preencheTabela()
        {
            int totMeta = 0;
            var tb = new DataTable();
            tb.Columns.Add("vdd_codigo");
            tb.Columns.Add("vdd_nome");
            tb.Columns.Add("vmet_meta");
            tb.Columns.Add("superM");
            tb.Columns.Add("sitVdd");
            tb.Columns.Add("vmet_tipo");

            for (int i = 0; i < codVdd.Count; i++)
            {
                tb.Rows.Add(codVdd[i], nomeVdd[i], metaVdd[i], (Convert.ToDouble(metaVdd[i]) * 1.10), situacao[i], tipo[i]);
            }
            for(int i = 0; i < codVdd.Count; i++)
            {
                totMeta = totMeta + Convert.ToInt32(metaVdd[i]);
            }
            tb.Rows.Add("TOTAL","LOJA",totMeta, (Convert.ToDouble(totMeta) * 1.10), "", "");
            dataGridView1.DataSource = tb;

            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].ReadOnly = true;
        }

        public void procuraDados()
        {
            string pesquisar = pesquisarTxt.Text.Replace('*', '%');

            Sql = "select vdd_codigo, vdd_nome, if(vmet_meta is null, 0, vmet_meta) as 'vmet_meta', vmet_situacao, vmet_tipo from vendedores a left outer join valor_meta b on a.vdd_codigo = b.vmet_vendedor where (vdd_cttfuncao = 'VENDEDOR' OR vdd_cttfuncao = 'VENDEDORA') and vdd_situacao = 'A' and vdd_nome like '%"+pesquisar+"%'";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdds = dao.Query.ExecuteReader();
            while (vdds.Read())
            {
                codVdd.Add(vdds["vdd_codigo"].ToString());
                nomeVdd.Add(vdds["vdd_nome"].ToString());
                metaVdd.Add(vdds["vmet_meta"].ToString());
                situacao.Add(vdds["vmet_situacao"].ToString());
                tipo.Add(vdds["vmet_tipo"].ToString());
            }
            vdds.Close();
            dao.desconecta();
        }

        public void limpaTabela()
        {
            codVdd.Clear();
            nomeVdd.Clear();
            metaVdd.Clear();
            situacao.Clear();
            tipo.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        public void vddExiste()
        {
            Sql = "select vmet_vendedor from valor_meta";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdds = dao.Query.ExecuteReader();
            while (vdds.Read())
            {
                aux.Add(vdds["vmet_vendedor"].ToString());
            }
            vdds.Close();
            dao.desconecta();
        }

        public meta()
        {
            InitializeComponent();
        }

        private void meta_Load(object sender, EventArgs e)
        {
            procuraDados();
            montaTabela();
            preencheTabela();
            if (cta.TelaMeta == 1)
                dataGridView1.Columns[2].ReadOnly = true;
        }

        private void pesquisarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            limpaTabela();
            procuraDados();
            montaTabela();
            preencheTabela();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            aux.Clear();
            vddExiste();

            int z = 0;

            if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value) * 1.10;
                    controlMeta cm = new controlMeta();

                    cm.Vmet_vendedor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cm.Vmet_meta = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cm.Vmet_situacao = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cm.Vmet_tipo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                        cm.Vmet_periodo = DateTime.Now.AddMonths(1).ToString("MM");
                    else
                        cm.Vmet_periodo = DateTime.Now.ToString("MM");
                    if (aux.Count == 0)
                        dao.cadastraMeta(cm);
                    else
                    {
                        for (int i = 0; i < aux.Count; i++)
                        {
                            if (aux[i] == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                                z = 1;
                        }
                        if (z == 1)
                        {
                            dao.alteraMeta(cm, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            z = 0;
                        }
                        else
                            dao.cadastraMeta(cm);
                    }
                }
            }
        }

        private void meta_FormClosing(object sender, FormClosingEventArgs e)
        {
            cta.TelaMeta = 0;
            variaveis var = new variaveis();
            var.AuxMapaVendas = 1;
        }
    }
}
