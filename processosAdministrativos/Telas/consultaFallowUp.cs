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
    public partial class consultaFallowUp : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<int> codSit = new List<int>();
        List<string> sit = new List<string>();
        List<string> numOC = new List<string>();
        List<string> datPed = new List<string>();
        List<string> forn = new List<string>();
        List<string> CodForn = new List<string>();
        List<string> comp = new List<string>();
        List<string> CodComp = new List<string>();
        List<string> entreg = new List<string>();
        List<int> situac = new List<int>();
        List<string> alter = new List<string>();
        List<string> codAlt = new List<string>();
        string auxdata;
        public void preencheTabela()
        {
            Sql = "SELECT ocp_numero,  ocp_data as 'pedido', fnc_nome, fnc_codigo, cpr_nome, cpr_codigo, "+
                    "OCP_Prevent as 'entrega', fup_situacao, "+
                    "fup_dataAlteracao as 'alteracao' "+
                    "FROM ((ordcompra INNER JOIN fornecedores ON ordcompra.ocp_fornecedor = fornecedores.fnc_codigo) "+
                    "INNER JOIN compradores ON ordcompra.ocp_comprador = compradores.cpr_codigo) "+
                    "LEFT OUTER JOIN fallowup ON ordcompra.ocp_numero = fallowup.fup_ordCompra "+
                    " where ocp_situacao = 'p' ORDER BY OCP_Prevent, ocp_numero;";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader ordem = dao.Query.ExecuteReader();
            while (ordem.Read())
            {
                numOC.Add(ordem["ocp_numero"].ToString());
                datPed.Add(ordem["pedido"].ToString());
                forn.Add(ordem["fnc_nome"].ToString());
                CodForn.Add(ordem["fnc_codigo"].ToString());
                comp.Add(ordem["cpr_nome"].ToString());
                CodComp.Add(ordem["cpr_codigo"].ToString());
                entreg.Add(ordem["entrega"].ToString());
                if (ordem["fup_situacao"].ToString() != "")
                    situac.Add(Convert.ToInt32(ordem["fup_situacao"]));
                else
                    situac.Add(0);
                alter.Add(ordem["alteracao"].ToString());
            }
            ordem.Close();
            dao.desconecta();
            var tb = new DataTable();
            tb.Columns.Add("ocp_numero");
            tb.Columns.Add("pedido", typeof(DateTime));
            tb.Columns.Add("fnc_codigo");
            tb.Columns.Add("fnc_nome");
            tb.Columns.Add("cpr_codigo");
            tb.Columns.Add("cpr_nome");
            tb.Columns.Add("entrega", typeof(DateTime));
            tb.Columns.Add("fup_situacao", typeof(int));
            tb.Columns.Add("alteracao");

            for (int i = 0; i < numOC.Count; i++)
            {
                tb.Rows.Add(numOC[i], datPed[i], CodForn[i], forn[i], CodComp[i], comp[i], entreg[i], situac[i], alter[i]);
            }
            dataGridView1.DataSource = tb;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }
        public void limpaTabela()
        {
            numOC.Clear();
            datPed.Clear();
            forn.Clear();
            CodForn.Clear();
            comp.Clear();
            CodComp.Clear();
            entreg.Clear();
            situac.Clear();
            alter.Clear();
            codSit.Clear();
            sit.Clear();
            codAlt.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
        public void criaTabela()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn();
            um.HeaderText = "Núm. OC";
            um.Name = "ordCompra";
            um.ReadOnly = true;
            um.DataPropertyName = "ocp_numero";
            um.Width = 78;
            dataGridView1.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn();
            dois.HeaderText = "Data Pedido";
            dois.Name = "datap";
            dois.ReadOnly = true;
            dois.DataPropertyName = "pedido";
            dois.Width = 90;
            dataGridView1.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "codForn";
            tres.Name = "codForn";
            tres.ReadOnly = true;
            tres.DataPropertyName = "fnc_codigo";
            tres.Width = 120;
            dataGridView1.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "Fornecedor";
            quatro.Name = "fornecedor";
            quatro.ReadOnly = true;
            quatro.DataPropertyName = "fnc_nome";
            quatro.Width = 225;
            dataGridView1.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "codComp";
            cinco.Name = "codComp";
            cinco.ReadOnly = true;
            cinco.DataPropertyName = "cpr_codigo";
            cinco.Width = 70;
            dataGridView1.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn();
            seis.HeaderText = "Comprador";
            seis.Name = "comprador";
            seis.ReadOnly = true;
            seis.DataPropertyName = "cpr_nome";
            seis.Width = 70;
            dataGridView1.Columns.Add(seis);

            DataGridViewTextBoxColumn sete = new DataGridViewTextBoxColumn();
            sete.HeaderText = "Entrega";
            sete.Name = "dataEntrega";
            sete.ReadOnly = true;
            sete.DataPropertyName = "entrega";
            sete.Width = 70;
            dataGridView1.Columns.Add(sete);

            DataGridViewComboBoxColumn oito = new DataGridViewComboBoxColumn();
            oito.HeaderText = "Situação";
            oito.Name = "situacao";
            oito.ReadOnly = false;
            oito.DataPropertyName = "fup_situacao";
            oito.Width = 130;
            dataGridView1.Columns.Add(oito);

            DataGridViewTextBoxColumn nove = new DataGridViewTextBoxColumn();
            nove.HeaderText = "Alteração";
            nove.Name = "dataAlteracao";
            nove.ReadOnly = true;
            nove.DataPropertyName = "alteracao";
            nove.Width = 120;
            dataGridView1.Columns.Add(nove);

            Sql = "SELECT fups_codigo, fups_nome FROM fallowupsit";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader situacoes = dao.Query.ExecuteReader();
            while (situacoes.Read())
            {
                codSit.Add(Convert.ToInt32(situacoes["fups_codigo"]));
                sit.Add(situacoes["fups_nome"].ToString());
            }
            situacoes.Close();
            dao.desconecta();

            var s = new DataTable();
            s.Columns.Add("ID", typeof(int));
            s.Columns.Add("situacao");
            s.Rows.Add(0, "");
            for (int i = 0; i < codSit.Count; i++)
            {
                s.Rows.Add(codSit[i], sit[i]);
            }
            oito.ValueMember = "ID";
            oito.DisplayMember = "situacao";
            s.DefaultView.Sort = "situacao ASC";
            oito.DataSource = s;
        }
        public consultaFallowUp()
        {
            InitializeComponent();
            criaTabela();
            preencheTabela();
        }

        private void consultaFallowUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaConsultaFallowUp = 0;
            limpaTabela();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter da;
            string pesquisar = fornecedorTxt.Text.Replace('*', '%');

            BindingSource bs = new BindingSource();
            da = new MySqlDataAdapter("SELECT ocp_numero,  DATE_FORMAT(ocp_data, '%d/%m/%Y') as 'pedido', fnc_nome, cpr_nome, "+
                                        "DATE_FORMAT(OCP_Prevent, '%d/%m/%Y') as 'entrega', fups_nome, "+
                                        "DATE_FORMAT(fup_dataAlteracao, '%H:%i:%s - %d/%m/%Y') as 'alteracao' "+
                                        "FROM (((ordcompra INNER JOIN fornecedores ON ordcompra.ocp_fornecedor = fornecedores.fnc_codigo) "+
                                        "INNER JOIN compradores ON ordcompra.ocp_comprador = compradores.cpr_codigo) "+
                                        "LEFT OUTER JOIN fallowup ON ordcompra.ocp_numero = fallowup.fup_ordCompra) "+
                                        "LEFT OUTER JOIN fallowupsit ON fallowup.fup_ordCompra = fallowupsit.fups_codigo where ocp_situacao = 'p' AND fnc_nome like '" + pesquisar + "%' ORDER BY OCP_Prevent;", dao.Conexao);
            da.Fill(table);
            bs.DataSource = table;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataMtxt.Text == "  /  /  ")
            {
                MessageBox.Show("Nenhuma data informada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable table;
                MySqlDataAdapter da;
                BindingSource bs;

                table = new DataTable();
                bs = new BindingSource();
                da = new MySqlDataAdapter("SELECT ocp_numero,  DATE_FORMAT(ocp_data, '%d/%m/%Y') as 'pedido', fnc_nome, cpr_nome, "+
                                            "DATE_FORMAT(OCP_Prevent, '%d/%m/%Y') as 'entrega', fups_nome, "+
                                            "DATE_FORMAT(fup_dataAlteracao, '%H:%i:%s - %d/%m/%Y') as 'alteracao' "+
                                            "FROM (((ordcompra INNER JOIN fornecedores ON ordcompra.ocp_fornecedor = fornecedores.fnc_codigo) "+
                                            "INNER JOIN compradores ON ordcompra.ocp_comprador = compradores.cpr_codigo) "+
                                            "LEFT OUTER JOIN fallowup ON ordcompra.ocp_numero = fallowup.fup_ordCompra) "+
                                            "LEFT OUTER JOIN fallowupsit ON fallowup.fup_ordCompra = fallowupsit.fups_codigo where ocp_situacao = 'p' and DATE_FORMAT(OCP_Prevent, '%d/%m/%Y') = '" + dataMtxt.Text + "' ORDER BY OCP_Prevent;", dao.Conexao);
                da.Fill(table);

                bs.DataSource = table;
                dataGridView1.DataSource = bs;
            }
        }

        private void salvarBt_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            Sql = "SELECT fup_ordCompra FROM fallowup";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader ordens = dao.Query.ExecuteReader();
            while (ordens.Read())
            {
                codAlt.Add(ordens["fup_ordCompra"].ToString());
            }
            ordens.Close();
            dao.desconecta();

            controlFallowUp cf = new controlFallowUp();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Sql = "SELECT fup_situacao FROM fallowup where fup_ordCompra = " + dataGridView1.Rows[i].Cells["ordCompra"].Value.ToString() + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                MySqlDataReader auxSit = dao.Query.ExecuteReader();
                while (auxSit.Read())
                {
                    auxdata = auxSit["fup_situacao"].ToString(); ;
                }
                auxSit.Close();
                dao.desconecta();
                if (codAlt.Count() > 0)
                {
                    for (int y = 0; y < codAlt.Count(); y++)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells["situacao"].Value) > 0 && dataGridView1.Rows[i].Cells["ordCompra"].Value.ToString() != codAlt[y])
                        {
                            x = 0;
                        }
                        else
                        {
                            x = 1;
                            break;
                        }
                    }
                    if (x == 0)
                    {
                        cf.Fup_ordCompra = dataGridView1.Rows[i].Cells["ordCompra"].Value.ToString();
                        cf.Fup_dataPed = Convert.ToDateTime(dataGridView1.Rows[i].Cells["datap"].Value);
                        cf.Fup_fornecedor = dataGridView1.Rows[i].Cells["codForn"].Value.ToString(); ;
                        cf.Fup_comprador = dataGridView1.Rows[i].Cells["codComp"].Value.ToString(); ;
                        cf.Fup_dataEntrega = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dataEntrega"].Value.ToString());
                        cf.Fup_situacao = dataGridView1.Rows[i].Cells["situacao"].Value.ToString();
                        cf.Fup_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.cadastraFallowUp(cf);
                        x = 0;
                    }
                    else if (dataGridView1.Rows[i].Cells["situacao"].Value.ToString() != auxdata)
                    {
                        cf.Fup_situacao = dataGridView1.Rows[i].Cells["situacao"].Value.ToString();
                        cf.Fup_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.AlteraFallowUp(cf, dataGridView1.Rows[i].Cells["ordCompra"].Value.ToString());
                        x = 0;
                    }
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells["situacao"].Value) > 0)
                {
                    cf.Fup_ordCompra = dataGridView1.Rows[i].Cells["ordCompra"].Value.ToString();
                    cf.Fup_dataPed = Convert.ToDateTime(dataGridView1.Rows[i].Cells["datap"].Value);
                    cf.Fup_fornecedor = dataGridView1.Rows[i].Cells["codForn"].Value.ToString(); ;
                    cf.Fup_comprador = dataGridView1.Rows[i].Cells["codComp"].Value.ToString(); ;
                    cf.Fup_dataEntrega = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dataEntrega"].Value.ToString());
                    cf.Fup_situacao = dataGridView1.Rows[i].Cells["situacao"].Value.ToString();
                    cf.Fup_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraFallowUp(cf);
                }
            }
            codAlt.Clear();
            limpaTabela();
            criaTabela();
            preencheTabela();
        }
    }
}
