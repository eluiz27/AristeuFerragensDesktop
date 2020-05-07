using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class OrdemCompra : Form
    {
        DAO dao = new DAO();
        private string Sql = string.Empty;
        List<string> codigos = new List<string>();
        List<string> qt = new List<string>();
        List<string> val = new List<string>();
        List<string> prod = new List<string>();
        List<string> unit = new List<string>();
        List<string> aliqipi = new List<string>();
        List<string> aliqsubtrib = new List<string>();
        string emp;
        string num;
        string forn;
        string aliquota;

        public void VerificaAliq()
        {
            Sql = "select icm_aliquota from icms INNER JOIN fornecedores ON icms.icm_estado = fornecedores.fnc_estado where fnc_codigo = "+forn+"";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            object existe = dao.Query.ExecuteScalar();
            aliquota = existe.ToString();
            dao.Desconecta();
        }
        public bool VerificaOC()
        {
            int x = 0;
            if (ocTxt.Text != "")
            {
                x = Convert.ToInt32(ocTxt.Text);
            }
            Sql = "SELECT COUNT(ocp_numero) FROM ordcompra WHERE ocp_numero = "+x+"";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            object existe = dao.Query.ExecuteScalar();

            if (Convert.ToInt32(existe) > 0)
            {
                dao.Desconecta();
                return true;
            }
            else
            {
                dao.Desconecta();
                return false;
            }
        }

        public void ValoresProd()
        {
            for (int i = 0; i < codigos.Count(); i++)
            {
                Sql = "SELECT itm_descricao, itm_unidade, itm_percipi, ITM_PercSubTrib FROM itens WHERE itm_codigo = "+codigos[i]+"";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.Conecta();
                MySqlDataReader valor1 = dao.Query.ExecuteReader();
                while (valor1.Read())
                {
                    prod.Add(valor1["itm_descricao"].ToString());
                    unit.Add(valor1["itm_unidade"].ToString());
                    aliqipi.Add(valor1["itm_percipi"].ToString());
                    aliqsubtrib.Add(valor1["ITM_PercSubTrib"].ToString());
                }
                valor1.Close();
                dao.Desconecta();
            }
        }
        public void ValoresOC()
        {
            Sql = "SELECT ocp_empresa, ocp_numero, ocp_fornecedor FROM ordcompra WHERE ocp_numero = " + ocTxt.Text + "";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader valor2 = dao.Query.ExecuteReader();
            while (valor2.Read())
            {
                emp = valor2["ocp_empresa"].ToString();
                num = valor2["ocp_numero"].ToString();
                forn = valor2["ocp_fornecedor"].ToString();
            }
            valor2.Close();
            dao.Desconecta();
        }
        class OrdCompra
        {
            public string Empresa { get; set; }
            public string Oc { get; set; }
            public string Sequencia { get; set; }
            public string Item { get; set; }
            public string Fornecedor { get; set; }
            public string Produto { get; set; }
            public string Uni { get; set; }
            public string Unest { get; set; }
            public string Qtde { get; set; }
            public string Estoq { get; set; }
            public string Precokg { get; set; }
            public string Preco { get; set; }
            public string Total { get; set; }
            public string Aliqip { get; set; }
            public string Valoripi { get; set; }
            public string Compri { get; set; }
            public string Larg { get; set; }
            public string Bitola { get; set; }
            public string Aliqsubtri { get; set; }
            public string Valorsubtrib { get; set; }
            public string Qtdefatu { get; set; }
            public string Obs { get; set; }
            public string Sitentreg { get; set; }
            public string Aliqicms { get; set; }

            public OrdCompra() { }
        }
        List<OrdCompra> aux = new List<OrdCompra>();

        public void PreencheTabela()
        {
            string w = "";
            for (int i = 0; i < codigos.Count(); i++)
            {
                double total = Convert.ToDouble(qt[i]) * Convert.ToDouble(val[i]);
                if(i < 8)
                    w = "00"+(i+2);
                else if(i>7 && i<98)
                    w = "0"+(i+2);
                else
                    w = (i+1).ToString();
                aux.Add(new OrdCompra()
                {
                    Empresa = emp,
                    Oc = num,
                    Sequencia = w,
                    Item = codigos[i],
                    Fornecedor = forn,
                    Produto = prod[i],
                    Uni = unit[i],
                    Unest = unit[i],
                    Qtde = qt[i].Replace(',','.'),
                    Estoq = qt[i].Replace(',', '.'),
                    Precokg = "0",
                    Preco = val[i].Replace(',', '.'),
                    Total = total.ToString().Replace(',', '.'),
                    Aliqip = aliqipi[i].Replace(',', '.'),
                    Valoripi = Math.Round(total * (Convert.ToDouble(aliqipi[i]) / 100), 2).ToString().Replace(',', '.'),
                    Compri = "0",
                    Larg = "0",
                    Bitola = "",
                    Aliqsubtri = aliqsubtrib[i].Replace(',', '.'),
                    Valorsubtrib = Math.Round(total * (Convert.ToDouble(aliqsubtrib[i]) / 100), 2).ToString().Replace(',', '.'),
                    Qtdefatu = "0",
                    Obs = "",
                    Sitentreg = "P",
                    Aliqicms = aliquota.Replace(',', '.')
                });
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = aux;
            dataGridView1.Columns[0].HeaderText = "Empresa";
            dataGridView1.Columns[1].HeaderText = "O.C.";
            dataGridView1.Columns[2].HeaderText = "Sequência";
            dataGridView1.Columns[3].HeaderText = "Item";
            dataGridView1.Columns[4].HeaderText = "Fornecedor";
            dataGridView1.Columns[5].HeaderText = "Produto";
            dataGridView1.Columns[6].HeaderText = "Un.";
            dataGridView1.Columns[7].HeaderText = "Unest.";
            dataGridView1.Columns[8].HeaderText = "Qtde.";
            dataGridView1.Columns[9].HeaderText = "Estoq.";
            dataGridView1.Columns[10].HeaderText = "Preço KG";
            dataGridView1.Columns[11].HeaderText = "Preço";
            dataGridView1.Columns[12].HeaderText = "Total";
            dataGridView1.Columns[13].HeaderText = "Aliq. IPI";
            dataGridView1.Columns[14].HeaderText = "Valor IPI";
            dataGridView1.Columns[15].HeaderText = "Comp.";
            dataGridView1.Columns[16].HeaderText = "Larg.";
            dataGridView1.Columns[17].HeaderText = "Bitola";
            dataGridView1.Columns[18].HeaderText = "Aliq. Sub. Trib.";
            dataGridView1.Columns[19].HeaderText = "Valor Sub. Trib.";
            dataGridView1.Columns[20].HeaderText = "Qtde. Fat.";
            dataGridView1.Columns[21].HeaderText = "Obs.";
            dataGridView1.Columns[22].HeaderText = "Sit. Entreg.";
            dataGridView1.Columns[23].HeaderText = "Aliq. ICMS";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 60;
            dataGridView1.Columns[10].Width = 80;
            dataGridView1.Columns[11].Width = 70;
            dataGridView1.Columns[12].Width = 70;
            dataGridView1.Columns[13].Width = 80;
            dataGridView1.Columns[14].Width = 80;
            dataGridView1.Columns[15].Width = 70;
            dataGridView1.Columns[16].Width = 70;
            dataGridView1.Columns[17].Width = 70;
            dataGridView1.Columns[18].Width = 110;
            dataGridView1.Columns[19].Width = 110;
            dataGridView1.Columns[20].Width = 80;
            dataGridView1.Columns[21].Width = 50;
            dataGridView1.Columns[22].Width = 90;
            dataGridView1.Columns[23].Width = 90;
        }
        public void LimpaTab()
        {
            aliqsubtrib.Clear();
            aliqipi.Clear();
            unit.Clear();
            prod.Clear();
            val.Clear();
            qt.Clear();
            codigos.Clear();
            emp = string.Empty;
            num = string.Empty;
            forn = string.Empty;
            aliquota = string.Empty;
            aux.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }
        public OrdemCompra()
        {
            InitializeComponent();
        }

        private void ordemCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaOdemCompra = 0;
        }

        private void excelBt_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (VerificaOC())
            {
                LimpaTab();
                openFileDialog1.Filter = "Excel|*.xlsx|Excel|*.xls";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    Excel ex = new Excel(openFileDialog1.FileName, "");
                    codigos = ex.ReadCell4();
                    qt = ex.ReadCell5();
                    val = ex.ReadCell6();
                    ex.Close();
                    ValoresOC();
                    ValoresProd();
                    VerificaAliq();
                    PreencheTabela();
                }
            }
            else
                MessageBox.Show("Número da OC. Não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ocTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                ControlOrdemCompra co = new ControlOrdemCompra();
                for(int i = 0; i < dataGridView1.RowCount; i++)
                {
                    co.Oci_empresa = dataGridView1.Rows[i].Cells["empresa"].Value.ToString();
                    co.Oci_numero = dataGridView1.Rows[i].Cells["oc"].Value.ToString();
                    co.Oci_sequencia = dataGridView1.Rows[i].Cells["sequencia"].Value.ToString();
                    co.Oci_item = dataGridView1.Rows[i].Cells["item"].Value.ToString();
                    co.Oci_fornecedor = dataGridView1.Rows[i].Cells["fornecedor"].Value.ToString();
                    co.Oci_descricao = dataGridView1.Rows[i].Cells["produto"].Value.ToString();
                    co.Oci_unidade = dataGridView1.Rows[i].Cells["uni"].Value.ToString();
                    co.Oci_unestoque = dataGridView1.Rows[i].Cells["unest"].Value.ToString();
                    co.Oci_quantidade = dataGridView1.Rows[i].Cells["qtde"].Value.ToString();
                    co.Oci_estoque = dataGridView1.Rows[i].Cells["estoq"].Value.ToString();
                    co.Oci_precokg = dataGridView1.Rows[i].Cells["precokg"].Value.ToString();
                    co.Oci_preco = dataGridView1.Rows[i].Cells["preco"].Value.ToString();
                    co.Oci_total = dataGridView1.Rows[i].Cells["total"].Value.ToString();
                    co.Oci_aliqipi = dataGridView1.Rows[i].Cells["aliqip"].Value.ToString();
                    co.Oci_valoripi = dataGridView1.Rows[i].Cells["valoripi"].Value.ToString();
                    co.Oci_comprimento = dataGridView1.Rows[i].Cells["compri"].Value.ToString();
                    co.Oci_largura = dataGridView1.Rows[i].Cells["larg"].Value.ToString();
                    co.Oci_bitola = dataGridView1.Rows[i].Cells["bitola"].Value.ToString();
                    co.Oci_aliqsubtrib = dataGridView1.Rows[i].Cells["aliqsubtri"].Value.ToString();
                    co.Oci_valorsubtrib = dataGridView1.Rows[i].Cells["valorsubtrib"].Value.ToString();
                    co.Oci_qtdfaturada = dataGridView1.Rows[i].Cells["qtdefatu"].Value.ToString();
                    co.Oci_Observacao = dataGridView1.Rows[i].Cells["obs"].Value.ToString();
                    co.Oci_sitentrega = dataGridView1.Rows[i].Cells["sitentreg"].Value.ToString();
                    co.Oci_aliqicms = dataGridView1.Rows[i].Cells["aliqicms"].Value.ToString();

                    dao.CadastraOrdemCompra(co);
                }
                MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaTab();
                ocTxt.Text = string.Empty;
            }
        }
    }
}
