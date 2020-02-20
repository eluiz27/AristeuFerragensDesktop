using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class LOE : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<int> vdds = new List<int>();
        TabPage tab1, tab2, tab3, tab4, tab5, tab6, tab7, tab8;
        variaveis vat = new variaveis();
        int aux1, aux2, aux3, aux4, aux5, aux6, aux7, aux8 = 0;
        String codProdPrecoElev, codProdFaltaEst, codProdInex, CodProdTroc;
        List<string> listProd1 = new List<string>();
        List<string> listPreco = new List<string>();
        List<string> listQtde1 = new List<string>();
        List<string> listComentPreco = new List<string>();
        List<string> listProd2 = new List<string>();
        List<string> listQtde2 = new List<string>();
        List<string> listComentFalt = new List<string>();
        List<string> listProd3 = new List<string>();
        List<string> listQtde3 = new List<string>();
        List<string> listComentIne = new List<string>();
        List<string> listProd4 = new List<string>();
        List<string> listComentTroca = new List<string>();
        List<string> listComent1 = new List<string>();
        List<string> listComent2 = new List<string>();
        List<string> listComent3 = new List<string>();
        List<string> listComent4 = new List<string>();
        private static bool precoControle = false;

        public static bool PrecoControle
        {
            get { return precoControle; }
            set { precoControle = value; }
        }

        public static void formatoPreco(ref TextBox txt)
        {
            String n;
            float v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(",", "");
                if (n.Equals(""))
                {
                    n = "";
                }
                n = n.PadLeft(3, '0');
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                {
                    n.Substring(1, n.Length - 1);
                }
                v = float.Parse(n) / 100;
                txt.Text = String.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception) { }
        }
        public void limpaCampo()
        {
            codigoVddTxt.Text = string.Empty;
            nomeVddTxt.Text = string.Empty;
            aux1 = 0;
            aux2 = 0;
            aux3 = 0;
            aux4 = 0;
            aux5 = 0;
            aux6 = 0;
            aux7 = 0;
            aux8 = 0;
        }
        public void limpaList()
        {
            listComent1.Clear();
            listProd1.Clear();
            listPreco.Clear();
            listQtde1.Clear();
            listComent2.Clear();
            listComent3.Clear();
            listComent4.Clear();
            listProd2.Clear();
            listQtde2.Clear();
            listProd3.Clear();
            listQtde3.Clear();
            listProd4.Clear();
        }
        public void limpaComent()
        {
            coment1Txt.Text = string.Empty;
            coment2Txt.Text = string.Empty;
            coment3Txt.Text = string.Empty;
            coment4Txt.Text = string.Empty;

        }
        public void limpaPrecoElev()
        {
            prodPrecElevTxt.Text = string.Empty;
            qtdePrecElevTxt.Text = string.Empty;
            precPrecElevTxt.Text = string.Empty;
            comentPrecoTxt.Text = string.Empty;
            codProdPrecoElev = string.Empty;
        }
        public void limpaFaltaEst()
        {
            prodFaltEstTxt.Text = string.Empty;
            qtdeFaltEstTxt.Text = string.Empty;
            comentEstTxt.Text = string.Empty;
            codProdFaltaEst = string.Empty;
        }
        public void limpaProdInex()
        {
            prodProdInexTxt.Text = string.Empty;
            qtdeProdInexTxt.Text = string.Empty;
            comentIneTxt.Text = string.Empty;
            codProdInex = string.Empty;
        }
        public void limpaTrocProd()
        {
            prodTrocProdTxt.Text = string.Empty;
            comentTrocaTxt.Text = string.Empty;
            CodProdTroc = string.Empty;
        }
        public void limpaGridPrecElev()
        {
            precoElevDgv.DataSource = null;
            precoElevDgv.Columns.Clear();
            precoElevDgv.Rows.Clear();
            precoElevDgv.Refresh();
            pE.Clear();
        }
        public void limpaGridFaltEst()
        {
            faltEstDgv.DataSource = null;
            faltEstDgv.Columns.Clear();
            faltEstDgv.Rows.Clear();
            faltEstDgv.Refresh();
            fE.Clear();
        }
        public void limpaGridProdInex()
        {
            prodInexDgv.DataSource = null;
            prodInexDgv.Columns.Clear();
            prodInexDgv.Rows.Clear();
            prodInexDgv.Refresh();
            pI.Clear();
        }
        public void limpaGridTrocProd()
        {
            TrocProdDgv.DataSource = null;
            TrocProdDgv.Columns.Clear();
            TrocProdDgv.Rows.Clear();
            TrocProdDgv.Refresh();
            tP.Clear();
        }
        public void removeTabPage()
        {
            tab1 = precoElevTp;
            tab2 = faltaEstTp;
            tab3 = prodInexistTp;
            tab4 = trocaProdTp;
            tab5 = condPagTp;
            tab6 = retEncomendTp;
            tab7 = conheOlhanTp;
            tab8 = defQualiOutTp;
            this.tabControl1.TabPages.Remove(precoElevTp);
            this.tabControl1.TabPages.Remove(faltaEstTp);
            this.tabControl1.TabPages.Remove(prodInexistTp);
            this.tabControl1.TabPages.Remove(trocaProdTp);
            this.tabControl1.TabPages.Remove(condPagTp);
            this.tabControl1.TabPages.Remove(retEncomendTp);
            this.tabControl1.TabPages.Remove(conheOlhanTp);
            this.tabControl1.TabPages.Remove(defQualiOutTp);
            condPagRb.Checked = false;
            conheOlhanRb.Checked = false;
            defQualiOutRb.Checked = false;
            faltaEstRb.Checked = false;
            precoEleRb.Checked = false;
            prodInexistRb.Checked = false;
            retEncomenRb.Checked = false;
            trocProdRb.Checked = false;
        }
        public void tabPag1()
        {
            this.tabControl1.TabPages.Add(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab7);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag2()
        {
            this.tabControl1.TabPages.Add(tab2);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab7);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag3()
        {
            this.tabControl1.TabPages.Add(tab3);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab7);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag4()
        {
            this.tabControl1.TabPages.Add(tab4);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab7);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag5()
        {
            this.tabControl1.TabPages.Add(tab5);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab7);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag6()
        {
            this.tabControl1.TabPages.Add(tab6);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab7);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag7()
        {
            this.tabControl1.TabPages.Add(tab7);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab8);
        }
        public void tabPag8()
        {
            this.tabControl1.TabPages.Add(tab8);
            this.tabControl1.TabPages.Remove(tab1);
            this.tabControl1.TabPages.Remove(tab2);
            this.tabControl1.TabPages.Remove(tab3);
            this.tabControl1.TabPages.Remove(tab4);
            this.tabControl1.TabPages.Remove(tab5);
            this.tabControl1.TabPages.Remove(tab6);
            this.tabControl1.TabPages.Remove(tab7);
        }
        private bool IsNumeric(int Val)
        {
            return ((Val >= 48 && Val <= 57) || (Val == 8) || (Val == 46) || (Val >= 48 && Val <= 57));
        }
        class precoElevado
        {
            public string nomeProd { get; set; }
            public string precoProd { get; set; }
            public string qtdeProd { get; set; }

            public precoElevado() { }
        }
        List<precoElevado> pE= new List<precoElevado>();
        class faltaEstoque
        {
            public string nomeProd { get; set; }
            public string qtdeProd { get; set; }

            public faltaEstoque() { }
        }
        List<faltaEstoque> fE = new List<faltaEstoque>();
        class produtoInexistente
        {
            public string nomeProd { get; set; }
            public string qtdeProd { get; set; }

            public produtoInexistente() { }
        }
        List<produtoInexistente> pI = new List<produtoInexistente>();
        class trocaProduto
        {
            public string nomeProd { get; set; }
            public string pedProd { get; set; }

            public trocaProduto() { }
        }
        List<trocaProduto> tP = new List<trocaProduto>();
        public LOE()
        {
            InitializeComponent();
            removeTabPage();
        }

        private void LOE_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaLOE = 0;
            cta.TelaCadastraLoe = 0;
            limpaCampo();
            limpaFaltaEst();
            limpaPrecoElev();
            limpaList();
            limpaProdInex();
            limpaTrocProd();
            limpaGridPrecElev();
            limpaGridFaltEst();
            limpaGridProdInex();
            limpaGridTrocProd();
            limpaComent();
            removeTabPage();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int aux = 0;
            Sql = "SELECT vdd_codigo FROM vendedores WHERE vdd_situacao = 'A'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdd = dao.Query.ExecuteReader();
            while (vdd.Read())
            {
                vdds.Add(Convert.ToInt32(vdd["vdd_codigo"]));
            }
            vdd.Close();
            dao.desconecta();
            for (int i = 0; i < vdds.Count; i++)
            {
                if (codigoVddTxt.Text == vdds[i].ToString())
                {
                    Sql = "SELECT vdd_nome FROM vendedores WHERE vdd_codigo = " + codigoVddTxt.Text;
                    dao.Query = new MySqlCommand(Sql, dao.Conexao);
                    dao.conecta();
                    object vendedor = dao.Query.ExecuteScalar();
                    nomeVddTxt.Text = vendedor.ToString();
                    dao.desconecta();
                    aux = 1;
                }
            }
            if (aux == 0)
            {
                MessageBox.Show("Vendedor não cadastrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampo();
                codigoVddTxt.Focus();
            }
        }

        private void precoEleRb_CheckedChanged(object sender, EventArgs e)
        {
            if (precoEleRb.Checked == true)
            {
                tabPag1();
                aux1 = 1;
            }
        }

        private void faltaEstRb_CheckedChanged(object sender, EventArgs e)
        {
            if (faltaEstRb.Checked == true)
            {
                tabPag2();
                aux2 = 1;
            }
        }

        private void prodInexistRb_CheckedChanged(object sender, EventArgs e)
        {
            if (prodInexistRb.Checked == true)
            {
                tabPag3();
                aux3 = 1;
            }
        }

        private void trocProdRb_CheckedChanged(object sender, EventArgs e)
        {
            if (trocProdRb.Checked == true)
            {
                tabPag4();
                aux4 = 1;
            }
        }

        private void condPagRb_CheckedChanged(object sender, EventArgs e)
        {
            if (condPagRb.Checked == true)
            {
                this.tabControl1.TabPages.Remove(tab5);
                tabPag5();
                aux5 = 1;
            }
        }

        private void retEncomenRb_CheckedChanged(object sender, EventArgs e)
        {
            if (retEncomenRb.Checked == true)
            {
                this.tabControl1.TabPages.Remove(tab6);
                tabPag6();
                aux6 = 1;
            }
        }

        private void conheOlhanRb_CheckedChanged(object sender, EventArgs e)
        {
            if (conheOlhanRb.Checked == true)
            {
                this.tabControl1.TabPages.Remove(tab7);
                tabPag7();
                aux7 = 1;
            }
        }

        private void defQualiOutRb_CheckedChanged(object sender, EventArgs e)
        {
            if (defQualiOutRb.Checked == true)
            {
                this.tabControl1.TabPages.Remove(tab8);
                tabPag8();
                aux8 = 1;
            }
        }

        private void prodPrecElevTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            limpaPrecoElev();
            vat.AuxLOE1 = 1;
            procuraProd pp = new procuraProd();
            pp.ShowDialog();
        }
        private void prodFaltEstTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            limpaFaltaEst();
            vat.AuxLOE2 = 1;
            procuraProd pp = new procuraProd();
            pp.ShowDialog();
        }
        private void prodProdInexTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        private void prodTrocProdTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            limpaProdInex();
            vat.AuxLOE4 = 1;
            procuraProd pp = new procuraProd();
            pp.ShowDialog();
        }
        private void LOE_Activated(object sender, EventArgs e)
        {
            if (vat.AuxLOE1 == 1)
            {
                prodPrecElevTxt.Text = vat.NomeProdLOE;
                codProdPrecoElev = vat.CodProdLOE;
                qtdePrecElevTxt.Focus();
                vat.AuxLOE1 = 0;
            }
            else if(vat.AuxLOE2 == 1){
                prodFaltEstTxt.Text = vat.NomeProdLOE;
                codProdFaltaEst = vat.CodProdLOE;
                qtdeFaltEstTxt.Focus();
                vat.AuxLOE2 = 0;
            }
            else if (vat.AuxLOE3 == 1)
            {
                prodProdInexTxt.Text = vat.NomeProdLOE;
                codProdInex = vat.CodProdLOE;
                qtdeProdInexTxt.Focus();
                vat.AuxLOE3 = 0;
            }
            else if (vat.AuxLOE4 == 1)
            {
                prodTrocProdTxt.Text = vat.NomeProdLOE;
                CodProdTroc = vat.CodProdLOE;
                vat.AuxLOE4 = 0;
            }
        }

        private void maisPrecElevBt_Click(object sender, EventArgs e)
        {
            if (prodPrecElevTxt.Text != string.Empty && precPrecElevTxt.Text != string.Empty && qtdePrecElevTxt.Text != string.Empty)
            {
                pE.Add(new precoElevado()
                {
                    nomeProd = prodPrecElevTxt.Text,
                    precoProd = precPrecElevTxt.Text,
                    qtdeProd = qtdePrecElevTxt.Text
                });
                precoElevDgv.DataSource = null;
                precoElevDgv.DataSource = pE;
                precoElevDgv.Columns[0].HeaderText = "Produto";
                precoElevDgv.Columns[1].HeaderText = "Preço";
                precoElevDgv.Columns[2].HeaderText = "Qtde";

                precoElevDgv.Columns[0].Width = 390;
                precoElevDgv.Columns[1].Width = 60;
                precoElevDgv.Columns[2].Width = 40;
                listProd1.Add(vat.CodProdLOE);
                listPreco.Add(precPrecElevTxt.Text);
                listQtde1.Add(qtdePrecElevTxt.Text);
                listComentPreco.Add(comentPrecoTxt.Text);
                limpaPrecoElev();
                vat.NomeProdLOE = string.Empty;
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maisFaltEstBt_Click(object sender, EventArgs e)
        {
            if (prodFaltEstTxt.Text != string.Empty && qtdeFaltEstTxt.Text != string.Empty)
            {
                fE.Add(new faltaEstoque()
                {
                    nomeProd = prodFaltEstTxt.Text,
                    qtdeProd = qtdeFaltEstTxt.Text
                });
                faltEstDgv.DataSource = null;
                faltEstDgv.DataSource = fE;
                faltEstDgv.Columns[0].HeaderText = "Produto";
                faltEstDgv.Columns[1].HeaderText = "Qtde";

                faltEstDgv.Columns[0].Width = 450;
                faltEstDgv.Columns[1].Width = 40;
                listProd2.Add(vat.CodProdLOE);
                listQtde2.Add(qtdeFaltEstTxt.Text);
                listComentFalt.Add(comentEstTxt.Text);
                limpaFaltaEst();
                vat.NomeProdLOE = string.Empty;
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maisProdInexBt_Click(object sender, EventArgs e)
        {
            if (prodProdInexTxt.Text != string.Empty && qtdeProdInexTxt.Text != string.Empty)
            {
                pI.Add(new produtoInexistente()
                {
                    nomeProd = prodProdInexTxt.Text,
                    qtdeProd = qtdeProdInexTxt.Text
                });
                prodInexDgv.DataSource = null;
                prodInexDgv.DataSource = pI;
                prodInexDgv.Columns[0].HeaderText = "Produto";
                prodInexDgv.Columns[1].HeaderText = "Qtde";

                prodInexDgv.Columns[0].Width = 450;
                prodInexDgv.Columns[1].Width = 40;
                listProd3.Add(prodProdInexTxt.Text);
                listQtde3.Add(qtdeProdInexTxt.Text);
                listComentIne.Add(comentIneTxt.Text);
                limpaProdInex();
                vat.NomeProdLOE = string.Empty;
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maisTrocProdBt_Click(object sender, EventArgs e)
        {
            if (prodTrocProdTxt.Text != string.Empty)
            {
                tP.Add(new trocaProduto()
                {
                    nomeProd = prodTrocProdTxt.Text,
                });
                TrocProdDgv.DataSource = null;
                TrocProdDgv.DataSource = tP;
                TrocProdDgv.Columns[0].HeaderText = "Produto";
                TrocProdDgv.Columns[1].HeaderText = "Pedido";

                TrocProdDgv.Columns[0].Width = 430;
                TrocProdDgv.Columns[1].Width = 60;
                listProd4.Add(vat.CodProdLOE);
                listComentTroca.Add(comentTrocaTxt.Text);
                limpaTrocProd();
                vat.NomeProdLOE = string.Empty;
            }
            else
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            if (precoEleRb.Checked == true)
            {
                limpaGridPrecElev();
                limpaPrecoElev();
            }
            else if (faltaEstRb.Checked == true)
            {
                limpaGridFaltEst();
                limpaFaltaEst();
            }
            else if (prodInexistRb.Checked == true)
            {
                limpaGridProdInex();
                limpaProdInex();
            }
            else if (trocProdRb.Checked == true)
            {
                limpaGridTrocProd();
                limpaTrocProd();
            }
            else if (condPagRb.Checked == true)
            {
                coment1Txt.Text = string.Empty;
            }
            else if (retEncomenRb.Checked == true)
            {
                coment2Txt.Text = string.Empty;
            }
            else if (conheOlhanRb.Checked == true)
            {
                coment3Txt.Text = string.Empty;
            }
            else if (defQualiOutRb.Checked == true)
            {
                coment4Txt.Text = string.Empty;
            }
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            controlLoe cl = new controlLoe();
            int x1 = 1, x2 = 1, x3 = 1, x4 = 1, x5 = 1, x8 = 1;
            if (aux1 == 1)
            {
                aux1 = 0;
                if (precoElevDgv.RowCount > 0)
                {
                    for (int i = 0; i < listProd1.Count; i++)
                    {
                        cl.Id_vendedor_loe = codigoVddTxt.Text;
                        cl.Opcao_loe = 1;
                        cl.Id_produto = listProd1[i];
                        cl.Qtade_loe = listQtde1[i].Replace(',', '.');
                        cl.Preco_loe = float.Parse(listPreco[i]);
                        cl.Comentario_loe = listComentPreco[i];
                        cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.cadastraLoe(cl);
                        x1 = 1;
                    }
                    MessageBox.Show("Preço elevado salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaPrecoElev();
                    limpaGridPrecElev();
                    listComent1.Clear();
                    listProd1.Clear();
                    listPreco.Clear();
                    listQtde1.Clear();
                    aux1 = 1;
                }
                else if (prodPrecElevTxt.Text != string.Empty && precPrecElevTxt.Text != string.Empty && qtdePrecElevTxt.Text != string.Empty)
                {
                    cl.Id_vendedor_loe = codigoVddTxt.Text;
                    cl.Opcao_loe = 1;
                    cl.Id_produto = codProdPrecoElev;
                    cl.Qtade_loe = qtdePrecElevTxt.Text.Replace(',', '.');
                    cl.Preco_loe = float.Parse(precPrecElevTxt.Text);
                    cl.Comentario_loe = comentPrecoTxt.Text;
                    cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraLoe(cl);
                    MessageBox.Show("Preço elevado salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaPrecoElev();
                    limpaGridPrecElev();
                    listComent1.Clear();
                    listProd1.Clear();
                    listPreco.Clear();
                    listQtde1.Clear();
                    aux1 = 1;
                    x1 = 1;
                }
                else
                {
                    MessageBox.Show("Opção - Preço Elevado - não preenchida corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x1 = 0;
                    aux1 = 1;
                }
            }
            if (aux2 == 1)
            {
                aux2 = 0;
                if (faltEstDgv.RowCount > 0)
                {
                    for (int i = 0; i < listProd2.Count; i++)
                    {
                        cl.Id_vendedor_loe = codigoVddTxt.Text;
                        cl.Opcao_loe = 2;
                        cl.Id_produto = listProd2[i];
                        cl.Qtade_loe = listQtde2[i].Replace(',', '.');
                        cl.Preco_loe = 0;
                        cl.Comentario_loe = listComentFalt[i];
                        cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.cadastraLoe(cl);
                        x2 = 1;
                        aux2 = 1;
                    }
                    MessageBox.Show("Falta de estoque salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaFaltaEst();
                    limpaGridFaltEst();
                    listComent2.Clear();
                    listProd2.Clear();
                    listQtde2.Clear();
                }
                else if (prodFaltEstTxt.Text != string.Empty && qtdeFaltEstTxt.Text != string.Empty)
                {
                    cl.Id_vendedor_loe = codigoVddTxt.Text;
                    cl.Opcao_loe = 2;
                    cl.Id_produto = codProdFaltaEst;
                    cl.Qtade_loe = qtdeFaltEstTxt.Text.Replace(',', '.');
                    cl.Preco_loe = 0;
                    cl.Comentario_loe = comentEstTxt.Text;
                    cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraLoe(cl);
                    MessageBox.Show("Falta de estoque salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaFaltaEst();
                    limpaGridFaltEst();
                    listComent2.Clear();
                    listProd2.Clear();
                    listQtde2.Clear();
                    x2 = 1;
                    aux2 = 1;
                }
                else
                {
                    MessageBox.Show("Opção - Falta no Estoque - não preenchida corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x2 = 0;
                    aux2 = 1;
                }
            }
            if (aux3 == 1)
            {
                aux3 = 0;
                if (prodInexDgv.RowCount > 0)
                {
                    for (int i = 0; i < listProd3.Count; i++)
                    {
                        cl.Id_vendedor_loe = codigoVddTxt.Text;
                        cl.Opcao_loe = 3;
                        cl.Id_produto = listProd3[i];
                        cl.Qtade_loe = listQtde3[i].Replace(',', '.');
                        cl.Preco_loe = 0;
                        cl.Comentario_loe = listComentIne[i];
                        cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.cadastraLoe(cl);
                        x3 = 1;
                        aux3 = 1;
                    }
                    MessageBox.Show("Produto inexistente salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaProdInex();
                    limpaGridProdInex();
                    listComent3.Clear();
                    listProd3.Clear();
                    listQtde3.Clear();
                }
                else if (prodProdInexTxt.Text != string.Empty && qtdeProdInexTxt.Text != string.Empty)
                {
                    cl.Id_vendedor_loe = codigoVddTxt.Text;
                    cl.Opcao_loe = 3;
                    cl.Id_produto = prodProdInexTxt.Text;
                    cl.Qtade_loe = qtdeProdInexTxt.Text.Replace(',', '.');
                    cl.Preco_loe = 0;
                    cl.Comentario_loe = comentIneTxt.Text;
                    cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraLoe(cl);
                    MessageBox.Show("Produto inexistente salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaProdInex();
                    limpaGridProdInex();
                    listComent3.Clear();
                    listProd3.Clear();
                    listQtde3.Clear();
                    x3 = 1;
                    aux3 = 1;
                }
                else
                {
                    MessageBox.Show("Opção - Produto Inexistente - não preenchida corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x3 = 0;
                    aux3 = 1;
                }
            }
            if (aux4 == 1)
            {
                aux4 = 0;
                if (TrocProdDgv.RowCount > 0)
                {
                    for (int i = 0; i < listProd4.Count; i++)
                    {
                        cl.Id_vendedor_loe = codigoVddTxt.Text;
                        cl.Opcao_loe = 5;
                        cl.Id_produto = listProd4[i];
                        cl.Qtade_loe = "0";
                        cl.Preco_loe = 0;
                        cl.Comentario_loe = listComentTroca[i];
                        cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dao.cadastraLoe(cl);
                        x4 = 1;
                        aux4 = 1;
                    }
                    MessageBox.Show("Troca de produto salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTrocProd();
                    limpaGridTrocProd();
                    listComent4.Clear();
                    listProd4.Clear();
                }
                else if (prodTrocProdTxt.Text != string.Empty)
                {
                    cl.Id_vendedor_loe = codigoVddTxt.Text;
                    cl.Opcao_loe = 5;
                    cl.Id_produto = CodProdTroc;
                    cl.Qtade_loe = "0";
                    cl.Preco_loe = 0;
                    cl.Comentario_loe = comentTrocaTxt.Text;
                    cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraLoe(cl);
                    MessageBox.Show("Troca de produto salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTrocProd();
                    limpaGridTrocProd();
                    listComent4.Clear();
                    listProd4.Clear();
                    x4 = 1;
                    aux4 = 1;
                }
                else
                {
                    MessageBox.Show("Opção - Troca de produto - não preenchida corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x4 = 0;
                    aux4 = 1;
                }
            }
            if (aux5 == 1)
            {
                aux5 = 0;
                if (coment1Txt.Text != string.Empty)
                {
                    cl.Id_vendedor_loe = codigoVddTxt.Text;
                    cl.Opcao_loe = 4;
                    cl.Id_produto = "0";
                    cl.Qtade_loe = "0";
                    cl.Preco_loe = 0;
                    cl.Comentario_loe = coment1Txt.Text;
                    cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraLoe(cl);
                    x5 = 1;
                    MessageBox.Show("Condição de pagamento salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    coment1Txt.Text = string.Empty;
                    x5 = 1;
                    aux5 = 1;
                }
                else
                {
                    MessageBox.Show("Opção - Condição de pagamento - não preenchida corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x5 = 0;
                    aux5 = 1;
                }
                    
            }
            if (aux6 == 1)
            {
                aux6 = 0;
                cl.Id_vendedor_loe = codigoVddTxt.Text;
                cl.Opcao_loe = 6;
                cl.Id_produto = "0";
                cl.Qtade_loe = "0";
                cl.Preco_loe = 0;
                cl.Comentario_loe = coment2Txt.Text;
                cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dao.cadastraLoe(cl);
                MessageBox.Show("Retirada de encomenda salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                coment2Txt.Text = string.Empty;
                aux6 = 1;
            }
            if (aux7 == 1)
            {
                aux7 = 0;
                cl.Id_vendedor_loe = codigoVddTxt.Text;
                cl.Opcao_loe = 7;
                cl.Id_produto = "0";
                cl.Qtade_loe = "0";
                cl.Preco_loe = 0;
                cl.Comentario_loe = coment3Txt.Text;
                cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dao.cadastraLoe(cl);
                MessageBox.Show("Conhecendo/Olhando salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                coment3Txt.Text = string.Empty;
                aux7 = 1;
            }
            if (aux8 == 1)
            {
                aux8 = 0;
                if (coment4Txt.Text != string.Empty)
                {
                    cl.Id_vendedor_loe = codigoVddTxt.Text;
                    cl.Opcao_loe = 8;
                    cl.Id_produto = "0";
                    cl.Qtade_loe = "0";
                    cl.Preco_loe = 0;
                    cl.Comentario_loe = coment4Txt.Text;
                    cl.Data_loe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.cadastraLoe(cl);
                    MessageBox.Show("Outros salvo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    coment4Txt.Text = string.Empty;
                    aux8 = 1;
                }
                else
                {
                    MessageBox.Show("Opção - Outros - não preenchida corretamente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    x8 = 0;
                    aux8 = 1;
                }                  
            }
            if (x1 == 1 && x2 == 1 && x3 == 1 && x4 == 1 && x5 == 1 && x8 == 1)
            {
                //MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpaCampo();
                limpaPrecoElev();
                limpaGridPrecElev();
                limpaFaltaEst();
                limpaGridFaltEst();
                limpaProdInex();
                limpaGridProdInex();
                limpaTrocProd();
                limpaGridTrocProd();
                limpaList();
                limpaComent();
                removeTabPage();
                aux1 = 0;
                aux2 = 0;
                aux3 = 0;
                aux4 = 0;
                aux5 = 0;
                aux6 = 0;
                aux7 = 0;
                aux8 = 0;
            }
        }

        private void precPrecElevTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar == '.') && (e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void precPrecElevTxt_TextChanged(object sender, EventArgs e)
        {
            if (precoControle == false)
            {
                formatoPreco(ref precPrecElevTxt);
            } 
        }
    }
}
