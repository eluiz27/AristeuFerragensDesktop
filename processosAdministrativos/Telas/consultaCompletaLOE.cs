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
    public partial class consultaCompletaLOE : Form
    {
        DAO dao = new DAO();
        private string Sql, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7 = String.Empty;
        MySqlCommand cmd, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7;
        querys qr = new querys();
        List<string> dias = new List<string>();
        List<string> semana = new List<string>();
        List<string> idProdFalt = new List<string>();
        List<string> dataFalt = new List<string>();
        List<string> nomeProdFalt = new List<string>();
        List<string> saldoFalt = new List<string>();
        List<string> minimo = new List<string>();
        List<string> venddFalt = new List<string>();
        List<int> codVendedor = new List<int>();
        List<string> marcaFalt = new List<string>();
        List<string> sitCompra = new List<string>();
        List<string> comprFalt = new List<string>();
        List<string> vendFalt = new List<string>();
        List<string> inativo = new List<string>();
        List<string> qtde1 = new List<string>();
        int aux1 = 0;
        int aux2 = 0;
        int aux3 = 0;
        int aux4 = 0;
        int aux5 = 0;
        int cont1, cont2, cont3, cont4 = 0;
        List<int> vdds = new List<int>();
        List<int> estoque = new List<int>();
        List<int> contProdInex = new List<int>();
        List<string> situ = new List<string>();
        int auxProIne = 0;
        int auxPrecoElev = 0;
        int auxOutros = 0;

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
                                        "if(loe_comentario <> '', 'sim', 'não') as 'comentario' ,DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data' " +
                                        "FROM ((loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) " +
                                        "INNER JOIN loe_opcao ON loe.loe_opcao = loe_opcao.opcao_loe_codigo) " +
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
            qr.selcTotal(inferior1, superior2);
            vendasTxt.Text = qr.NVendasL;
        }

        public void listaData()
        {
            DateTime primeiDiaMes = DateTime.Parse("01" + "/" + inferior6Mtxt.Text);
            DateTime primeiDiaProxMes = primeiDiaMes.AddMonths(1);
            DateTime ultiDiaMes = primeiDiaProxMes.AddDays(-1);

            String x = ultiDiaMes.ToString("dd");
            for (int i = 1; i <= int.Parse(x); i++ )
            {
                if (i < 10)
                {
                    string y = "0" + i.ToString();
                    DateTime sema = DateTime.Parse(y + "/"+inferior6Mtxt.Text);
                    semana.Add(sema.ToString("ddd", new CultureInfo("pt-BR")));
                    dias.Add(y);
                }
                else
                {
                    DateTime sema = DateTime.Parse(i.ToString() + "/" + inferior6Mtxt.Text);
                    semana.Add(sema.ToString("ddd", new CultureInfo("pt-BR")));
                    dias.Add(i.ToString());
                }
            }
        }

        public void mes()
        {
            DateTime primeiDiaMes = DateTime.Parse("01" + DateTime.Now.ToString("/MM/yyyy"));
            DateTime primeiDiaProxMes = primeiDiaMes.AddMonths(1);
            DateTime ultiDiaMes = primeiDiaProxMes.AddDays(-1);

            DateTime inf = DateTime.Parse("01" + DateTime.Now.ToString("/MM/yyyy"));
            DateTime sup = DateTime.Parse(ultiDiaMes.ToString("dd") + DateTime.Now.ToString("/MM/yyyy"));

            inferior2Mtxt.Text = inf.ToString("dd-MM-yyyy");
            superior2MTxt.Text = sup.ToString("dd-MM-yyyy");
            inferior3Mtxt.Text = inf.ToString("dd-MM-yyyy");
            superior3Mtxt.Text = sup.ToString("dd-MM-yyyy");
            inferior4Mtxt.Text = inf.ToString("dd-MM-yyyy");
            superior4Mtxt.Text = sup.ToString("dd-MM-yyyy");
            inferior5Mtxt.Text = inf.ToString("dd-MM-yyyy");
            superior5Mtxt.Text = sup.ToString("dd-MM-yyyy");
            inferior6Mtxt.Text = inf.ToString("MM-yyyy");
        }

        public void limpaTabContJust()
        {
            dias.Clear();
            semana.Clear();
            cj.Clear();
            ContJustDgv.DataSource = null;
            ContJustDgv.Columns.Clear();
            ContJustDgv.Rows.Clear();
            ContJustDgv.Refresh();
        }
        public void limpaTabFaltProd()
        {
            cont1 = 0;
            cont2 = 0;
            cont3 = 0;
            cont4 = 0;
            graficoFaltProd.Series[0].Points.Clear();
            graficoFaltProd.Series[1].Points.Clear();
            graficoFaltProd.Series[2].Points.Clear();
            graficoFaltProd.Series[3].Points.Clear();
            dataFalt.Clear();
            idProdFalt.Clear();
            nomeProdFalt.Clear();
            saldoFalt.Clear();
            venddFalt.Clear();
            marcaFalt.Clear();
            comprFalt.Clear();
            vendFalt.Clear();
            sitCompra.Clear();
            inativo.Clear();
            ofe.Clear();
            faltaEstDgv.DataSource = null;
            faltaEstDgv.Columns.Clear();
            faltaEstDgv.Rows.Clear();
            faltaEstDgv.Refresh();
        }
        public void limpaTabProdInex()
        {
            pi.Clear();
            prodInexDgv.DataSource = null;
            prodInexDgv.Columns.Clear();
            prodInexDgv.Rows.Clear();
            prodInexDgv.Refresh();
            graficoVend.Series[0].Points.Clear();
            graficoVend.Series[1].Points.Clear();
            codVendedor.Clear();
            estoque.Clear();
            contProdInex.Clear();
            situ.Clear();
        }
        public void limpaTabPrecoElev()
        {
            pe.Clear();
            precoElevDgv.DataSource = null;
            precoElevDgv.Rows.Clear();
            precoElevDgv.Columns.Clear();
            precoElevDgv.Refresh();
        }
        public void limpaTabOutro()
        {
            ou.Clear();
            outrosDgv.DataSource = null;
            outrosDgv.Columns.Clear();
            outrosDgv.Rows.Clear();
            outrosDgv.Refresh();
        }
        class contJust
        {
            public string data { get; set; }
            public string dia { get; set; }
            public string venda { get; set; }
            public string precAlto { get; set; }
            public string falta { get; set; }
            public string naoTrab { get; set; }
            public string condPag { get; set; }
            public string troca { get; set; }
            public string retiMerc { get; set; }
            public string olhan { get; set; }
            public string quali { get; set; }
            public int total { get; set; }
            public string taxaC { get; set; }

            public contJust() { }
        }
        List<contJust> cj = new List<contJust>();

        public void tabelaContJust()
        {
            listaData();
            if(graficoCont.Series[0].Points.Count > 1)
            {
                graficoCont.Series[0].Points.Clear();
                graficoCont.Series[1].Points.Clear();
                graficoCont.Series[2].Points.Clear();
                graficoCont.Series[3].Points.Clear();
                graficoCont.Series[4].Points.Clear();
                graficoCont.Series[5].Points.Clear();
                graficoCont.Series[6].Points.Clear();
            }
            for (int i = 0; i < dias.Count; i++ )
            {
                DateTime aux = DateTime.Parse("01/"+inferior6Mtxt.Text);
                string op1, op2, op3, op4, op5, op6, op7, op8;
                int op9;
                double op10;
                int y = i + 1;
                if(i < 10)
                {
                    String inferior = aux.ToString("yyyy-MM-0" + y + " 00:00:00");
                    String superior = aux.ToString("yyyy-MM-0" + y + " 23:00:00");
                    qr.selcTotal(inferior, superior);
                    op1 = qr.selecJustific(inferior, superior, 1);
                    op2 = qr.selecJustific(inferior, superior, 2);
                    op3 = qr.selecJustific(inferior, superior, 3);
                    op4 = qr.selecJustific(inferior, superior, 4);
                    op5 = qr.selecJustific(inferior, superior, 5);
                    op6 = qr.selecJustific(inferior, superior, 6);
                    op7 = qr.selecJustific(inferior, superior, 7);
                    op8 = qr.selecJustific(inferior, superior, 8);
                    op9 = qr.selecJustificTot(inferior, superior);
                }
                else
                {
                    String inferior = aux.ToString("yyyy-MM-" + y + " 00:00:00");
                    String superior = aux.ToString("yyyy-MM-" + y + " 23:00:00");
                    qr.selcTotal(inferior, superior);
                    op1 = qr.selecJustific(inferior, superior, 1);
                    op2 = qr.selecJustific(inferior, superior, 2);
                    op3 = qr.selecJustific(inferior, superior, 3);
                    op4 = qr.selecJustific(inferior, superior, 4);
                    op5 = qr.selecJustific(inferior, superior, 5);
                    op6 = qr.selecJustific(inferior, superior, 6);
                    op7 = qr.selecJustific(inferior, superior, 7);
                    op8 = qr.selecJustific(inferior, superior, 8);
                    op9 = qr.selecJustificTot(inferior, superior);
                }
                if (qr.NVendasL != "0")
                {
                    op10 = (Convert.ToDouble(qr.NVendasL) / (op9 + Convert.ToDouble(qr.NVendasL))) * 100;
                }
                else
                {
                    op10 = 0;
                }
                cj.Add(new contJust()
                {
                    data = dias[i],
                    dia = semana[i].ToUpper(),
                    venda = qr.NVendasL,
                    precAlto = op1,
                    falta = op2,
                    naoTrab = op3,
                    condPag = op4,
                    troca = op5,
                    retiMerc = op6,
                    olhan = op7,
                    quali = op8,
                    total = op9 + Convert.ToInt32(qr.NVendasL),
                    taxaC = string.Format("{0:0,0.00}", op10)
                });
                graficoCont.Series[0].Points.AddXY(dias[i], op1);
                graficoCont.Series[1].Points.AddY(op2);
                graficoCont.Series[2].Points.AddY(op3);
                graficoCont.Series[3].Points.AddY(op4);
                graficoCont.Series[4].Points.AddY(op5);
                graficoCont.Series[5].Points.AddY(op7);
                graficoCont.Series[6].Points.AddY(op8);
            }
            ContJustDgv.DataSource = null;
            ContJustDgv.DataSource = cj;
            ContJustDgv.Columns[0].HeaderText = "Data";
            ContJustDgv.Columns[1].HeaderText = "Dia";
            ContJustDgv.Columns[2].HeaderText = "Vendas";
            ContJustDgv.Columns[3].HeaderText = "Preço Alto";
            ContJustDgv.Columns[4].HeaderText = "Falta";
            ContJustDgv.Columns[5].HeaderText = "Não Trabalha";
            ContJustDgv.Columns[6].HeaderText = "Condição Pagament.";
            ContJustDgv.Columns[7].HeaderText = "Troca";
            ContJustDgv.Columns[8].HeaderText = "Encomenda";
            ContJustDgv.Columns[9].HeaderText = "Olhando";
            ContJustDgv.Columns[10].HeaderText = "Outros";
            ContJustDgv.Columns[11].HeaderText = "Total";
            ContJustDgv.Columns[12].HeaderText = "Taxa Converção";

            ContJustDgv.Columns[0].Width = 38;
            ContJustDgv.Columns[1].Width = 35;
            ContJustDgv.Columns[2].Width = 50;
            ContJustDgv.Columns[3].Width = 60;
            ContJustDgv.Columns[4].Width = 50;
            ContJustDgv.Columns[5].Width = 60;
            ContJustDgv.Columns[6].Width = 60;
            ContJustDgv.Columns[7].Width = 50;
            ContJustDgv.Columns[8].Width = 70;
            ContJustDgv.Columns[9].Width = 60;
            ContJustDgv.Columns[10].Width = 60;
            ContJustDgv.Columns[11].Width = 50;
            ContJustDgv.Columns[12].Width = 70;
        }

        class opcaoFaltEst
        {
            public string data { get; set; }
            public string codProd { get; set; }
            public string nomeProd { get; set; }
            public string saldo { get; set; }
            public string vendedor { get; set; }
            public string situacao { get; set; }
            public string marca { get; set; }
            public string ultCompr { get; set; }
            public string ultVend { get; set; }

            public opcaoFaltEst() { }
        }
        List<opcaoFaltEst> ofe = new List<opcaoFaltEst>();
        public void tabelaFaltaEst()
        {
            int aux = 0;
            DateTime aux1 = DateTime.Parse(inferior2Mtxt.Text);
            DateTime aux2 = DateTime.Parse(superior2MTxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql2 = "select DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', loe_id_produto, itm_descricao, loe_qtde, "+
                    "ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) as 'Saldo', itm_minimo, " +
                    "vdd_nome, loe_id_vendedor, itm_fabricante, DATE_FORMAT(itm_ultcompra, '%d/%m/%Y') as 'ultCompr', "+
                    "DATE_FORMAT(itm_ultvenda, '%d/%m/%Y') as 'ultVend' from (itens INNER JOIN loe on loe.loe_id_produto = itens.itm_codigo) INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo " +
                    "WHERE loe_opcao = 2 AND loe_data between '" + inferior.ToString() + "' and '" + superior.ToString() + "'";

            Sql3 = "select distinct(loe_id_produto) FROM loe INNER JOIN ordcitem ON loe.loe_id_produto = ordcitem.oci_item where oci_sitentrega like 'p%'  AND loe_data between '" + inferior.ToString() + "' and '" + superior.ToString() + "'";

            Sql4 = "select distinct(loe_id_produto) FROM loe INNER JOIN itens ON loe.loe_id_produto = itens.itm_codigo where itm_situacao = 'I'  AND loe_data between '" + inferior.ToString() + "' and '" + superior.ToString() + "'";

            cmd2 = new MySqlCommand(Sql2, dao.Conexao);
            cmd3 = new MySqlCommand(Sql3, dao.Conexao);
            cmd4 = new MySqlCommand(Sql4, dao.Conexao);

            dao.conecta();
            MySqlDataReader falta = cmd2.ExecuteReader();

            while(falta.Read())
            {
                dataFalt.Add(falta["data"].ToString());
                idProdFalt.Add(falta["loe_id_produto"].ToString());
                nomeProdFalt.Add(falta["itm_descricao"].ToString());
                saldoFalt.Add(falta["Saldo"].ToString());
                minimo.Add(falta["itm_minimo"].ToString());
                venddFalt.Add(falta["vdd_nome"].ToString());
                codVendedor.Add(Convert.ToInt32(falta["loe_id_vendedor"]));
                marcaFalt.Add(falta["itm_fabricante"].ToString());
                comprFalt.Add(falta["ultCompr"].ToString());
                vendFalt.Add(falta["ultVend"].ToString());
                qtde1.Add(falta["loe_qtde"].ToString());
            }
            dao.desconecta();
            dao.conecta();
            MySqlDataReader compra = cmd3.ExecuteReader();

            while (compra.Read())
            {
                sitCompra.Add(compra["loe_id_produto"].ToString());
            }
            dao.desconecta();
            dao.conecta();
            MySqlDataReader ina = cmd4.ExecuteReader();

            while (ina.Read())
            {
                inativo.Add(ina["loe_id_produto"].ToString());
            }
            dao.desconecta();
            for (int i = 0; i < dataFalt.Count; i++)
            {

                string sit = "";
                int z = 0;
                
                if(z == 0)
                {
                    for (int a = 0; a < inativo.Count; a++)
                    {
                        if (idProdFalt[i] == inativo[a])
                        {
                            sit = "Sob Encomenda";
                            situ.Add(sit);
                            cont3++;
                            z = 0;
                            break;
                        }
                        else
                            z = 1;
                    }
                    if(inativo.Count == 0)
                        z = 1;
                }

                if (z == 1)
                {
                    for (int y = 0; y < sitCompra.Count; y++)
                    {
                        if (idProdFalt[i] == sitCompra[y])
                        {
                            sit = "Aguardando Chegada";
                            situ.Add(sit);
                            cont2++;
                            z = 0;
                            break;
                        }
                        else
                            z = 1;
                    }
                }

                if (z == 1)
                {
                    if (((Convert.ToDouble(saldoFalt[i]) >= Convert.ToDouble(minimo[i])) || (Convert.ToDouble(qtde1[i]) <= Convert.ToDouble(saldoFalt[i]))) && Convert.ToDouble(saldoFalt[i]) > 0)
                    {
                        sit = "Estoque";
                        situ.Add(sit);
                        cont4++;
                        z = 0;
                    }
                    else
                        z = 1;
                }

                if (z == 1)
                {
                    sit = "Verificando Mín.";
                    situ.Add(sit);
                    cont1++;
                    z = 0;
                }

                ofe.Add(new opcaoFaltEst()
                {
                    data = dataFalt[i],
                    codProd = idProdFalt[i],
                    nomeProd = nomeProdFalt[i],
                    saldo = saldoFalt[i],
                    vendedor = venddFalt[i],
                    marca = marcaFalt[i],
                    situacao = sit,
                    ultCompr = comprFalt[i],
                    ultVend = vendFalt[i]
                });
            }

            for (int b = 0; b < vdds.Count; b++)
            {
                for (int c = 0; c < dataFalt.Count; c++)
                {
                    if (vdds[b] == codVendedor[c])
                    {
                        aux++;
                    }
                }
                estoque.Add(aux);
                aux = 0;
            }

            if (dataFalt.Count == 0)
            {
                ofe.Add(new opcaoFaltEst()
                {
                    data = "",
                    codProd = "",
                    nomeProd = "",
                    saldo = "",
                    vendedor = "",
                    marca = "",
                    situacao = "",
                    ultCompr = "",
                    ultVend = ""
                });
            }

            graficoFaltProd.Series[0].Points.AddY(cont1);
            graficoFaltProd.Series[1].Points.AddY(cont2);
            graficoFaltProd.Series[2].Points.AddY(cont3);
            graficoFaltProd.Series[3].Points.AddY(cont4);

            faltaEstDgv.DataSource = null;
            faltaEstDgv.DataSource = ofe;
            designTabelaFaltaProd();
        }

        public void vendedores()
        {
            Sql6 = "select vdd_codigo from vendedores where vdd_codigo > 8 and vdd_codigo != 13 and vdd_situacao = 'A'";
            cmd6 = new MySqlCommand(Sql6, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdd = cmd6.ExecuteReader();
            while (vdd.Read())
            {
                vdds.Add(Convert.ToInt32(vdd["vdd_codigo"]));
            }
            dao.desconecta();
        }

        class prodInex
        {
            public string data { get; set; }
            public string produto { get; set; }
            public string vendedor { get; set; }
            public prodInex() { }
        }
        List<prodInex> pi = new List<prodInex>();

        public void tabelaProdInex()
        {
            int aux3 = 0;
            DateTime aux1 = DateTime.Parse(inferior3Mtxt.Text);
            DateTime aux2 = DateTime.Parse(superior3Mtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql5 = "SELECT DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', loe_id_produto, loe_id_vendedor, vdd_nome FROM loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo WHERE loe_opcao = 3 AND loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "'";
            cmd5 = new MySqlCommand(Sql5, dao.Conexao);

            dao.conecta();
            MySqlDataReader prodIne = cmd5.ExecuteReader();

            while (prodIne.Read())
            {
                pi.Add(new prodInex()
                {
                    data = prodIne["data"].ToString(),
                    produto = prodIne["loe_id_produto"].ToString(),
                    vendedor = prodIne["vdd_nome"].ToString()
                });
                contProdInex.Add(Convert.ToInt32(prodIne["loe_id_vendedor"]));
                auxProIne = 1;
            }
            dao.desconecta();

            for (int i = 0; i < vdds.Count; i++)
            {
                for (int c = 0; c < contProdInex.Count; c++)
                {
                    if (vdds[i] == contProdInex[c])
                    {
                        aux3++;
                    }
                }
                Sql7 = "SELECT count(loe_id_vendedor) FROM loe WHERE loe_id_vendedor = " + vdds[i] + " AND loe_opcao";
                cmd7 = new MySqlCommand(Sql7, dao.Conexao);
                dao.conecta();
                object aux = cmd7.ExecuteScalar();
                graficoVend.Series[0].Points.AddXY(vdds[i].ToString(), aux3);
                graficoVend.Series[1].Points.AddY(estoque[i]);
                dao.desconecta();
                aux3 = 0;
            }

            if (auxProIne == 0)
            {
                pi.Add(new prodInex()
                {
                    data = "",
                    produto = "",
                    vendedor = ""
                });
                auxProIne = 1;
            }

            prodInexDgv.DataSource = null;
            prodInexDgv.DataSource = pi;
            designTabelaProdInex();           
        }

        class precoElev
        {
            public string data { get; set; }
            public string produto { get; set; }
            public string preco { get; set; }
            public string vendedor { get; set; }
            public precoElev() { }
        }
        List<precoElev> pe = new List<precoElev>();
        public void tabelaPrecoElev()
        {
            DateTime aux1 = DateTime.Parse(inferior4Mtxt.Text);
            DateTime aux2 = DateTime.Parse(superior4Mtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql5 = "SELECT DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', itm_descricao, vdd_nome, loe_preco FROM (loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) INNER JOIN itens ON loe.loe_id_produto = itens.itm_codigo WHERE loe_opcao = 1 AND loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "'";
            cmd5 = new MySqlCommand(Sql5, dao.Conexao);

            dao.conecta();
            MySqlDataReader precoEle = cmd5.ExecuteReader();

            while (precoEle.Read())
            {
                pe.Add(new precoElev()
                {
                    data = precoEle["data"].ToString(),
                    produto = precoEle["itm_descricao"].ToString(),
                    preco = precoEle["loe_preco"].ToString(),
                    vendedor = precoEle["vdd_nome"].ToString()
                });
                auxPrecoElev = 1;
            }

            if (auxPrecoElev == 0)
            {
                pe.Add(new precoElev()
                {
                    data = "",
                    produto = "",
                    preco = "",
                    vendedor = ""
                });
                auxPrecoElev = 1;
            }

            precoEle.Close();
            dao.desconecta();

            precoElevDgv.DataSource = pe;
            designTabelaPrecoElev();
        }
        class outros
        {
            public string data { get; set; }
            public string coment { get; set; }
            public string opcao { get; set;  }
            public string vendedor { get; set; }
            public outros() { }
        }
        List<outros> ou = new List<outros>();
        public void tabelaOutros()
        {
            DateTime aux1 = DateTime.Parse(inferior5Mtxt.Text);
            DateTime aux2 = DateTime.Parse(superior5Mtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql7 = "SELECT DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data', loe_comentario, opcao_loe_descricao, vdd_nome FROM (loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) INNER JOIN loe_opcao ON loe.loe_opcao = loe_opcao.opcao_loe_codigo WHERE (loe_opcao = 4 OR loe_opcao = 6 OR loe_opcao = 7 OR loe_opcao = 8) AND loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "'";
            cmd7 = new MySqlCommand(Sql7, dao.Conexao);

            dao.conecta();
            MySqlDataReader outros = cmd7.ExecuteReader();

            while (outros.Read())
            {
                ou.Add(new outros()
                {
                    data = outros["data"].ToString(),
                    coment = outros["loe_comentario"].ToString(),
                    opcao = outros["opcao_loe_descricao"].ToString(),
                    vendedor = outros["vdd_nome"].ToString()
                });
                auxOutros = 1;
            }

            if (auxOutros == 0)
            {
                ou.Add(new outros()
                {
                    data = "",
                    coment = "",
                    opcao = "",
                    vendedor = ""
                });
                auxOutros = 1;
            }
            outros.Close();
            dao.desconecta();

            outrosDgv.DataSource = null;
            outrosDgv.DataSource = ou;
            designTabeaOutros();

        }
        public void designTabeaOutros()
        {
            outrosDgv.Columns[0].HeaderText = "Data";
            outrosDgv.Columns[1].HeaderText = "Comentário";
            outrosDgv.Columns[2].HeaderText = "Opções";
            outrosDgv.Columns[3].HeaderText = "Vendedor";

            outrosDgv.Columns[0].Width = 70;
            outrosDgv.Columns[2].Width = 200;
            outrosDgv.Columns[3].Width = 70;

            outrosDgv.Columns[1].Visible = false;
        }
        public void designTabelaPrecoElev()
        {
            precoElevDgv.Columns[0].HeaderText = "Data";
            precoElevDgv.Columns[1].HeaderText = "Produto";
            precoElevDgv.Columns[2].HeaderText = "Preço";
            precoElevDgv.Columns[3].HeaderText = "Vendedor";

            precoElevDgv.Columns[0].Width = 70;
            precoElevDgv.Columns[1].Width = 150;
            precoElevDgv.Columns[2].Width = 50;
            precoElevDgv.Columns[3].Width = 70;
        }
        public void designTabelaProdInex()
        {
            prodInexDgv.Columns[0].HeaderText = "Data";
            prodInexDgv.Columns[1].HeaderText = "Produto";
            prodInexDgv.Columns[2].HeaderText = "Vendedor";

            prodInexDgv.Columns[0].Width = 70;
            prodInexDgv.Columns[1].Width = 300;
            prodInexDgv.Columns[2].Width = 150;
        }
        public void designTabelaFaltaProd()
        {
            faltaEstDgv.Columns[0].HeaderText = "Data";
            faltaEstDgv.Columns[1].HeaderText = "Cód Prod";
            faltaEstDgv.Columns[2].HeaderText = "Produto";
            faltaEstDgv.Columns[3].HeaderText = "Saldo";
            faltaEstDgv.Columns[4].HeaderText = "Vendedor";
            faltaEstDgv.Columns[5].HeaderText = "Situação";
            faltaEstDgv.Columns[6].HeaderText = "Marca";
            faltaEstDgv.Columns[7].HeaderText = "Ult Compra";
            faltaEstDgv.Columns[8].HeaderText = "Ult Venda";

            faltaEstDgv.Columns[0].Width = 70;
            faltaEstDgv.Columns[1].Width = 60;
            faltaEstDgv.Columns[2].Width = 162;
            faltaEstDgv.Columns[3].Width = 40;
            faltaEstDgv.Columns[4].Width = 80;
            faltaEstDgv.Columns[5].Width = 107;
            faltaEstDgv.Columns[6].Width = 70;
            faltaEstDgv.Columns[7].Width = 70;
            faltaEstDgv.Columns[8].Width = 70;
        }
        public consultaCompletaLOE()
        {
            InitializeComponent();
        }

        private void consultaCompletaLOE_Load(object sender, EventArgs e)
        {
            DateTime inf = DateTime.Now;
            DateTime sup = DateTime.Now;
            inferiorMtxt.Text = inf.ToString("dd-MM-yyyy");
            superiorMtxt.Text = sup.ToString("dd-MM-yyyy");
            vendedorRb.Checked = true;
            dataInfSup();
            mes();
            vendas();
            graficoCont.ChartAreas[0].AxisX.Interval = 1;
            graficoCont.ChartAreas[0].AxisY.Interval = 5;
            graficoVend.ChartAreas[0].AxisX.Interval = 1;
            vendedores();
            tabelaContJust();
            tabelaFaltaEst();
            tabelaProdInex();
            limpaTabPrecoElev();
            tabelaPrecoElev();
            tabelaOutros();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Sql = "SELECT loe_comentario FROM loe WHERE loe_codigo =  " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            cmd = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            object coment = cmd.ExecuteScalar();

            comentarioTxt.Text = coment.ToString();
            dao.desconecta();
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
                                        "if(loe_comentario <> '', 'sim', 'não') as 'comentario' ,DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data' " +
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
                                        "if(loe_comentario <> '', 'sim', 'não') as 'comentario' ,DATE_FORMAT(loe_data, '%d/%m/%Y') as 'data' " +
                                        "FROM ((loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo) " +
                                        "INNER JOIN loe_opcao ON loe.loe_opcao = loe_opcao.opcao_loe_codigo) " +
                                        "LEFT OUTER JOIN itens ON loe.loe_id_produto = itens.itm_codigo WHERE loe_data between '" + inferior.ToString() + "' AND '" + superior.ToString() + "' AND opcao_loe_descricao like '" + pesquisar + "%';", dao.Conexao);
                    da.Fill(table);

                    bs.DataSource = table;
                    dataGridView1.DataSource = bs;
                }
            }
        }

        private void consultaCompletaLOE_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaConsultLOEComple = 0;
            limpaTabFaltProd();
            limpaTabContJust();
            limpaTabProdInex();
            limpaTabPrecoElev();
            limpaTabOutro();
        }

        private void contagem_Enter(object sender, EventArgs e)
        {

        }

        private void ContJustDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                ContJustDgv.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
            }
            if (e.Value.Equals("DOM"))
            {
                ContJustDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private void faltaEstDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.Equals("Estoque"))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Blue;
            }
            if (e.Value.Equals("Aguardando Chegada"))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Green;
            }
            if (e.Value.Equals("Verificando Mín."))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Red;
            }
            if (e.Value.Equals("Sob Encomenda"))
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.DarkViolet;
            }
        }

        private void faltaEstDgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "data")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.data).ThenBy(m => m.data).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.data).ThenBy(m => m.data).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "codProd")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.codProd).ThenBy(m => m.codProd).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.codProd).ThenBy(m => m.codProd).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "nomeProd")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.nomeProd).ThenBy(m => m.nomeProd).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.nomeProd).ThenBy(m => m.nomeProd).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "saldo")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.saldo).ThenBy(m => m.saldo).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.saldo).ThenBy(m => m.saldo).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "vendedor")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "situacao")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.situacao).ThenBy(m => m.situacao).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.situacao).ThenBy(m => m.situacao).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "marca")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.marca).ThenBy(m => m.marca).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.marca).ThenBy(m => m.marca).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "ultCompr")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.ultCompr).ThenBy(m => m.ultCompr).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.ultCompr).ThenBy(m => m.ultCompr).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
            if (faltaEstDgv.Columns[e.ColumnIndex].Name == "ultVend")
            {
                faltaEstDgv.DataSource = null;
                faltaEstDgv.Columns.Clear();
                faltaEstDgv.Rows.Clear();
                faltaEstDgv.Refresh();
                if (aux1 == 1)
                {
                    ofe = ofe.OrderBy(m => m.ultVend).ThenBy(m => m.ultVend).ToList();
                    aux1 = 0;
                }
                else
                {
                    ofe = ofe.OrderByDescending(m => m.ultVend).ThenBy(m => m.ultVend).ToList();
                    aux1 = 1;
                }
                faltaEstDgv.DataSource = ofe;
                designTabelaFaltaProd();
            }
        }

        private void prodInexDgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(prodInexDgv.Columns[e.ColumnIndex].Name == "data")
            {
                prodInexDgv.DataSource = null;
                prodInexDgv.Columns.Clear();
                prodInexDgv.Rows.Clear();
                prodInexDgv.Refresh();
                if (aux2 == 1)
                {
                    pi = pi.OrderBy(m => m.data).ThenBy(m => m.data).ToList();
                    aux2 = 0;
                }
                else
                {
                    pi = pi.OrderByDescending(m => m.data).ThenBy(m => m.data).ToList();
                    aux2 = 1;
                }
                prodInexDgv.DataSource = pi;
                designTabelaProdInex();
            }
            if(prodInexDgv.Columns[e.ColumnIndex].Name == "produto")
            {
                prodInexDgv.DataSource = null;
                prodInexDgv.Columns.Clear();
                prodInexDgv.Rows.Clear();
                prodInexDgv.Refresh();
                if (aux2 == 1)
                {
                    pi = pi.OrderBy(m => m.produto).ThenBy(m => m.produto).ToList();
                    aux2 = 0;
                }
                else
                {
                    pi = pi.OrderByDescending(m => m.produto).ThenBy(m => m.produto).ToList();
                    aux2 = 1;
                }
                prodInexDgv.DataSource = pi;
                designTabelaProdInex();
            }
            if(prodInexDgv.Columns[e.ColumnIndex].Name == "vendedor")
            {
                prodInexDgv.DataSource = null;
                prodInexDgv.Columns.Clear();
                prodInexDgv.Rows.Clear();
                prodInexDgv.Refresh();
                if (aux2 == 1)
                {
                    pi = pi.OrderBy(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux2 = 0;
                }
                else
                {
                    pi = pi.OrderByDescending(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux2 = 1;
                }
                prodInexDgv.DataSource = pi;
                designTabelaProdInex();
            }
        }
        private void precoElevDgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (precoElevDgv.Columns[e.ColumnIndex].Name == "data")
            {
                precoElevDgv.DataSource = null;
                precoElevDgv.Columns.Clear();
                precoElevDgv.Rows.Clear();
                precoElevDgv.Refresh();
                if (aux4 == 1)
                {
                    pe = pe.OrderBy(m => m.data).ThenBy(m => m.data).ToList();
                    aux4 = 0;
                }
                else
                {
                    pe = pe.OrderByDescending(m => m.data).ThenBy(m => m.data).ToList();
                    aux4 = 1;
                }
                precoElevDgv.DataSource = pe;
                designTabelaPrecoElev();
            }
            if (precoElevDgv.Columns[e.ColumnIndex].Name == "produto")
            {
                precoElevDgv.DataSource = null;
                precoElevDgv.Columns.Clear();
                precoElevDgv.Rows.Clear();
                precoElevDgv.Refresh();
                if (aux4 == 1)
                {
                    pe = pe.OrderBy(m => m.produto).ThenBy(m => m.produto).ToList();
                    aux4 = 0;
                }
                else
                {
                    pe = pe.OrderByDescending(m => m.produto).ThenBy(m => m.produto).ToList();
                    aux4 = 1;
                }
                precoElevDgv.DataSource = pe;
                designTabelaPrecoElev();
            }
            if (precoElevDgv.Columns[e.ColumnIndex].Name == "preco")
            {
                precoElevDgv.DataSource = null;
                precoElevDgv.Columns.Clear();
                precoElevDgv.Rows.Clear();
                precoElevDgv.Refresh();
                if (aux4 == 1)
                {
                    pe = pe.OrderBy(m => m.preco).ThenBy(m => m.preco).ToList();
                    aux4 = 0;
                }
                else
                {
                    pe = pe.OrderByDescending(m => m.preco).ThenBy(m => m.preco).ToList();
                    aux4 = 1;
                }
                precoElevDgv.DataSource = pe;
                designTabelaPrecoElev();
            }
            if (precoElevDgv.Columns[e.ColumnIndex].Name == "vendedor")
            {
                precoElevDgv.DataSource = null;
                precoElevDgv.Columns.Clear();
                precoElevDgv.Rows.Clear();
                precoElevDgv.Refresh();
                if (aux4 == 1)
                {
                    pe = pe.OrderBy(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux4 = 0;
                }
                else
                {
                    pe = pe.OrderByDescending(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux4 = 1;
                }
                precoElevDgv.DataSource = pe;
                designTabelaPrecoElev();
            }
        }
        private void outrosDgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (outrosDgv.Columns[e.ColumnIndex].Name == "data")
            {
                outrosDgv.DataSource = null;
                outrosDgv.Columns.Clear();
                outrosDgv.Rows.Clear();
                outrosDgv.Refresh();
                if (aux4 == 1)
                {
                    ou = ou.OrderBy(m => m.data).ThenBy(m => m.data).ToList();
                    aux4 = 0;
                }
                else
                {
                    ou = ou.OrderByDescending(m => m.data).ThenBy(m => m.data).ToList();
                    aux4 = 1;
                }
                outrosDgv.DataSource = ou;
                designTabeaOutros();
            }
            if (outrosDgv.Columns[e.ColumnIndex].Name == "opcao")
            {
                outrosDgv.DataSource = null;
                outrosDgv.Columns.Clear();
                outrosDgv.Rows.Clear();
                outrosDgv.Refresh();
                if (aux4 == 1)
                {
                    ou = ou.OrderBy(m => m.opcao).ThenBy(m => m.opcao).ToList();
                    aux4 = 0;
                }
                else
                {
                    ou = ou.OrderByDescending(m => m.opcao).ThenBy(m => m.opcao).ToList();
                    aux4 = 1;
                }
                outrosDgv.DataSource = ou;
                designTabeaOutros();
            }
            if (outrosDgv.Columns[e.ColumnIndex].Name == "preco")
            {
                outrosDgv.DataSource = null;
                outrosDgv.Columns.Clear();
                outrosDgv.Rows.Clear();
                outrosDgv.Refresh();
                if (aux4 == 1)
                {
                    ou = ou.OrderBy(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux4 = 0;
                }
                else
                {
                    ou = ou.OrderByDescending(m => m.vendedor).ThenBy(m => m.vendedor).ToList();
                    aux4 = 1;
                }
                outrosDgv.DataSource = ou;
                designTabeaOutros();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpaTabFaltProd();
            tabelaFaltaEst();
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            limpaTabFaltProd();
            limpaTabProdInex();
            tabelaFaltaEst();
            tabelaProdInex();
        }
        private void pesquisa4Bt_Click(object sender, EventArgs e)
        {
            limpaTabPrecoElev();
            tabelaPrecoElev();
        }

        private void pesquisa5Bt_Click(object sender, EventArgs e)
        {
            limpaTabOutro();
            tabelaOutros();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            limpaTabContJust();
            tabelaContJust();
        }
        private void outrosDgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (outrosDgv.CurrentRow != null)
            {
                comentTxt.Text = outrosDgv.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpaTabContJust();
            limpaTabFaltProd();
            limpaTabProdInex();
            limpaTabPrecoElev();
            limpaTabOutro();
            tabelaContJust();
            tabelaFaltaEst();
            tabelaProdInex();
            tabelaPrecoElev();
            tabelaOutros();
        }
    }
}
