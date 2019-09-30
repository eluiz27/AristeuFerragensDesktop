using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class metaPercent : Form
    {
        private string Sql = string.Empty;
        DAO dao = new DAO();
        controlTmpMeta ctm = new controlTmpMeta();
        List<string> dias = new List<string>();
        List<string> semana = new List<string>();
        List<string> metas = new List<string>();
        List<string> feriados = new List<string>();

        public void preencheTabela()
        {
            DateTime aux;
            var tb = new DataTable();
            tb.Columns.Add("dia");
            tb.Columns.Add("sema");
            tb.Columns.Add("meta");
            tb.Columns.Add("feriado");

            int x = 0;
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) < 25)
            {
                aux = DateTime.Parse(DateTime.Now.AddMonths(-1).ToString("26/MM/yyyy"));
                while (aux < DateTime.Parse(DateTime.Now.ToString("26/MM/yyyy")))
                {
                    if (dias.Count > 0)
                    {
                        if (feriados[x] == "0")
                            tb.Rows.Add(dias[x], semana[x], metas[x], false);
                        else
                            tb.Rows.Add(dias[x], semana[x], metas[x], true);
                        x++;
                    }
                    else
                    {
                        if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "dom")
                            tb.Rows.Add(aux.ToString("dd/MM"), aux.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(), "NADA", false);
                        else if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "sáb")
                            tb.Rows.Add(aux.ToString("dd/MM"), aux.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(), 0, false);
                        else
                            tb.Rows.Add(aux.ToString("dd/MM"), aux.ToString("ddd", new CultureInfo("pt-BR")).ToUpper());
                    }
                    aux = aux.AddDays(+1);
                }
                dataGridView1.DataSource = tb;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "SÁB" || dataGridView1.Rows[i].Cells[1].Value.ToString() == "DOM")
                    {
                        dataGridView1.Rows[i].ReadOnly = true;
                    }
                }
            }
            else
            {
                aux = DateTime.Parse(DateTime.Now.ToString("26/MM/yyyy"));
                while (aux < DateTime.Parse(DateTime.Now.AddMonths(1).ToString("26/MM/yyyy")))
                {
                    if (dias.Count > 0)
                    {
                        if (feriados[x] == "0")
                            tb.Rows.Add(dias[x], semana[x], metas[x], false);
                        else
                            tb.Rows.Add(dias[x], semana[x], metas[x], true);
                        x++;
                    }
                    else
                    {
                        if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "dom")
                            tb.Rows.Add(aux.ToString("dd/MM"), aux.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(), "NADA", false);
                        else if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "sáb")
                            tb.Rows.Add(aux.ToString("dd/MM"), aux.ToString("ddd", new CultureInfo("pt-BR")).ToUpper(), 0, false);
                        else
                            tb.Rows.Add(aux.ToString("dd/MM"), aux.ToString("ddd", new CultureInfo("pt-BR")).ToUpper());
                    }
                    aux = aux.AddDays(+1);
                }
                dataGridView1.DataSource = tb;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "SÁB" || dataGridView1.Rows[i].Cells[1].Value.ToString() == "DOM")
                    {
                        dataGridView1.Rows[i].ReadOnly = true;
                    }
                }
            }
        }

        public void localizaDados()
        {
            Sql = "select tmet_dia, tmet_semana, tmet_meta, tmet_feriado from tmp_meta";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader tmp = dao.Query.ExecuteReader();
            while (tmp.Read())
            {
                dias.Add(tmp["tmet_dia"].ToString());
                semana.Add(tmp["tmet_semana"].ToString());
                metas.Add(tmp["tmet_meta"].ToString());
                feriados.Add(tmp["tmet_feriado"].ToString());
            }
            tmp.Close();
            dao.desconecta();
        }

        public void salvaDados(int coluna)
        {
            int aux = 0;
            dias.Clear();
            metas.Clear();
            feriados.Clear();
            localizaDados();
            if (coluna == 2|| coluna == 3)
            {
                for (int i = 0; i < dias.Count; i++)
                {
                    if (dias[i] == dataGridView1.CurrentRow.Cells[0].Value.ToString())
                    {
                        aux = 1;
                        break;
                    }
                }
                if (aux == 0)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (bool.Parse(dataGridView1.Rows[i].Cells[3].FormattedValue.ToString()) == true)
                            ctm.Tmet_feriado = "1";
                        else
                            ctm.Tmet_feriado = "0";
                        ctm.Tmet_dia = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        ctm.Tmet_semana = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        ctm.Tmet_meta = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        dao.cadastraTmpMeta(ctm);
                    }
                }
                else
                {
                    if (bool.Parse(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString()) == true)
                        ctm.Tmet_feriado = "1";
                    else
                        ctm.Tmet_feriado = "0";
                    ctm.Tmet_meta = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dao.alteraTmpMeta(ctm, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    aux = 0;
                }
                ctm.Tmet_feriado = string.Empty;
                ctm.Tmet_meta = string.Empty;
                ctm.Tmet_dia = string.Empty;
            }
        }

        public metaPercent()
        {
            InitializeComponent();
        }

        private void metaPercent_Load(object sender, EventArgs e)
        {
            localizaDados();
            if(dias.Count > 0)
            {
                string aux = dias[dias.Count - 1];
                if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25 && aux.Substring(aux.Length - 2, 2) == DateTime.Now.ToString("MM"))
                {
                    dao.deletaTmpMeta();
                    dias.Clear();
                    metas.Clear();
                    feriados.Clear();
                    localizaDados();
                }
            }
            preencheTabela();
        }

        private void novoPeriBt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            salvaDados(e.ColumnIndex);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if (bool.Parse(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString()) == false)
                {
                    dataGridView1.CurrentRow.Cells[2].Value = "FERIADO";
                    salvaDados(e.ColumnIndex);
                }
                else
                {
                    dataGridView1.CurrentRow.Cells[2].Value = "";
                    salvaDados(e.ColumnIndex);
                }
            }
        }

        private void metaPercent_FormClosing(object sender, FormClosingEventArgs e)
        {
            int aux = 0;
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == string.Empty)
                {
                    aux = 1;
                    break;
                }
                else
                {
                    aux = 0;
                    break;
                }
            }
            if (aux == 0)
            {
                variaveis var = new variaveis();
                var.AuxMapaVendas = 1;
            }
            else
                e.Cancel = true;
        }
    }
}
