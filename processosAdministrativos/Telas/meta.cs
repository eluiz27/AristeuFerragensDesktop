using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class Meta : Form
    {
        ControlTelaAberta cta = new ControlTelaAberta();
        private string Sql = string.Empty;

        List<string> codVdd = new List<string>();
        List<string> nomeVdd = new List<string>();
        List<string> metaVdd = new List<string>();
        List<string> situacao = new List<string>();
        List<string> tipo = new List<string>();
        List<string> aux = new List<string>();

        DAO dao = new DAO();

        public void MontaTabela()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                Name = "cod",
                DataPropertyName = "vdd_codigo",
                ReadOnly = true,
                Width = 50
            };
            dataGridView1.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn
            {
                HeaderText = "Vendedor",
                Name = "vdd",
                DataPropertyName = "vdd_nome",
                ReadOnly = true,
                Width = 150
            };
            dataGridView1.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn
            {
                HeaderText = "Meta",
                Name = "meta",
                DataPropertyName = "vmet_meta",
                Width = 60
            };
            dataGridView1.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn
            {
                HeaderText = "Super Meta",
                Name = "sMeta",
                DataPropertyName = "superM",
                ReadOnly = true,
                Width = 60
            };
            dataGridView1.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn
            {
                HeaderText = "Sit",
                Name = "sit",
                DataPropertyName = "sitVdd",
                Width = 40
            };
            dataGridView1.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tip",
                Name = "tip",
                DataPropertyName = "vmet_tipo",
                Width = 60
            };
            dataGridView1.Columns.Add(seis);
        }

        public void PreencheTabela()
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

        public void ProcuraDados()
        {
            string pesquisar = pesquisarTxt.Text.Replace('*', '%');

            Sql = "select vdd_codigo, vdd_nome, if(vmet_meta is null, 0, vmet_meta) as 'vmet_meta', vmet_situacao, vmet_tipo from vendedores a left outer join valor_meta b on a.vdd_codigo = b.vmet_vendedor where (vdd_cttfuncao = 'VENDEDOR' OR vdd_cttfuncao = 'VENDEDORA') and vdd_situacao = 'A' and vdd_nome like '%"+pesquisar+"%'";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
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
            dao.Desconecta();
        }

        public void LimpaTabela()
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

        public void VddExiste()
        {
            Sql = "select vmet_vendedor from valor_meta";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader vdds = dao.Query.ExecuteReader();
            while (vdds.Read())
            {
                aux.Add(vdds["vmet_vendedor"].ToString());
            }
            vdds.Close();
            dao.Desconecta();
        }

        public Meta()
        {
            InitializeComponent();
        }

        private void meta_Load(object sender, EventArgs e)
        {
            ProcuraDados();
            MontaTabela();
            PreencheTabela();
            if (cta.TelaMeta == 1)
                dataGridView1.Columns[2].ReadOnly = true;
        }

        private void pesquisarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            LimpaTabela();
            ProcuraDados();
            MontaTabela();
            PreencheTabela();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            aux.Clear();
            VddExiste();

            int z = 0;

            if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value) * 1.10;
                    ControlMeta cm = new ControlMeta();

                    cm.Vmet_vendedor = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cm.Vmet_meta = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cm.Vmet_situacao = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cm.Vmet_tipo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                        cm.Vmet_periodo = DateTime.Now.AddMonths(1).ToString("MM");
                    else
                        cm.Vmet_periodo = DateTime.Now.ToString("MM");
                    if (aux.Count == 0)
                        dao.CadastraMeta(cm);
                    else
                    {
                        for (int i = 0; i < aux.Count; i++)
                        {
                            if (aux[i] == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                                z = 1;
                        }
                        if (z == 1)
                        {
                            dao.AlteraMeta(cm, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            z = 0;
                        }
                        else
                            dao.CadastraMeta(cm);
                    }
                }
            }
        }

        private void meta_FormClosing(object sender, FormClosingEventArgs e)
        {
            cta.TelaMeta = 0;
            Variaveis var = new Variaveis();
            var.AuxMapaVendas = 1;
        }
    }
}
