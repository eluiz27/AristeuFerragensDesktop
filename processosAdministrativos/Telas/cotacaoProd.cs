﻿using MySql.Data.MySqlClient;
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
    public partial class CotacaoProd : Form
    {
        string caminho = Path.GetFullPath("Compras\\CotacaoAlzira.txt");

        private string Sql = String.Empty;
        DAO dao = new DAO();
        ControlCompNComp ccnc = new ControlCompNComp();
        Variaveis var = new Variaveis();
        List<string> y = new List<string>();
        List<string> codP = new List<string>();
        List<string> prodP = new List<string>();
        List<string> unP = new List<string>();
        List<string> minP = new List<string>();
        List<string> maxP = new List<string>();
        List<string> saldoP = new List<string>();
        List<string> compraP = new List<string>();
        List<string> seteMP = new List<string>();
        List<string> seteMPAux = new List<string>();
        List<string> tresMP = new List<string>();
        List<string> saldVendP = new List<string>();
        List<string> ultCP = new List<string>();
        List<string> embP = new List<string>();
        List<string> codFornP = new List<string>();
        List<string> comprarP = new List<string>();
        List<string> ultVP = new List<string>();
        List<string> precoProd = new List<string>();
        List<string> grupoProd = new List<string>();
        List<string> fornProd = new List<string>();
        List<string> posiCrit = new List<string>();
        List<string> posiNorm = new List<string>();
        List<string> ocP = new List<string>();
        int grupoInf = 0;
        int grupoSup = 10000;
        int fornInf = 0;
        int fornSup = 10000;
        string fornNull = " or itm_fornecedor is null)";
        int aux = 0;
        int contaTab1;

        public void LimpaTabela()
        {
            codP.Clear();
            prodP.Clear();
            unP.Clear();
            minP.Clear();
            maxP.Clear();
            saldoP.Clear();
            compraP.Clear();
            seteMP.Clear();
            seteMPAux.Clear();
            tresMP.Clear();
            saldVendP.Clear();
            ultCP.Clear();
            embP.Clear();
            codFornP.Clear();
            comprarP.Clear();
            ultVP.Clear();
            precoProd.Clear();
            grupoProd.Clear();
            fornProd.Clear();
            posiCrit.Clear();
            posiNorm.Clear();
            ocP.Clear();
            dataGridView3.DataSource = null;
            dataGridView3.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
        }
        public void MontaTabelaProduto()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                Name = "codProd",
                DataPropertyName = "itm_codigo",
                ReadOnly = true,
                Width = 60
            };
            dataGridView3.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn
            {
                HeaderText = "Produto",
                Name = "prod",
                ReadOnly = true,
                DataPropertyName = "itm_descricao",
                Width = 250
            };
            dataGridView3.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn
            {
                HeaderText = "Un.",
                Name = "uniProd",
                ReadOnly = true,
                DataPropertyName = "itm_unidade",
                Width = 40
            };
            dataGridView3.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn
            {
                HeaderText = "Mín.",
                Name = "minProd",
                ReadOnly = true,
                DataPropertyName = "itm_minimo",
                Width = 50
            };
            dataGridView3.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn
            {
                HeaderText = "Máx.",
                Name = "maxProd",
                ReadOnly = true,
                DataPropertyName = "itm_maximo",
                Width = 50
            };
            dataGridView3.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn
            {
                HeaderText = "Saldo",
                Name = "saldoProd",
                ReadOnly = true,
                DataPropertyName = "saldo",
                Width = 60
            };
            seis.DefaultCellStyle.BackColor = Color.Yellow;
            dataGridView3.Columns.Add(seis);

            DataGridViewTextBoxColumn sete = new DataGridViewTextBoxColumn
            {
                HeaderText = "Qtd",
                Name = "compProd",
                DataPropertyName = "compra",
                Width = 60
            };
            dataGridView3.Columns.Add(sete);

            DataGridViewTextBoxColumn oito = new DataGridViewTextBoxColumn
            {
                HeaderText = "+ Meses",
                Name = "seteMProd",
                ReadOnly = true,
                DataPropertyName = "seteMes",
                Width = 70
            };
            dataGridView3.Columns.Add(oito);

            DataGridViewTextBoxColumn nove = new DataGridViewTextBoxColumn
            {
                HeaderText = "- Meses",
                Name = "tresMProd",
                ReadOnly = true,
                DataPropertyName = "tresMes",
                Width = 70
            };
            dataGridView3.Columns.Add(nove);

            DataGridViewTextBoxColumn dez = new DataGridViewTextBoxColumn
            {
                HeaderText = "Sald-Vend7",
                Name = "saldVend7Prod",
                ReadOnly = true,
                DataPropertyName = "vendSald7",
                Width = 85
            };
            dataGridView3.Columns.Add(dez);

            DataGridViewTextBoxColumn onze = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ult. Compra",
                Name = "ultCompProd",
                ReadOnly = true,
                DataPropertyName = "itm_ultcompra",
                Width = 60
            };
            dataGridView3.Columns.Add(onze);

            DataGridViewTextBoxColumn dose = new DataGridViewTextBoxColumn
            {
                HeaderText = "Emb.",
                Name = "embProd",
                ReadOnly = true,
                DataPropertyName = "ITM_Embalagem",
                Width = 50
            };
            dataGridView3.Columns.Add(dose);

            DataGridViewTextBoxColumn trese = new DataGridViewTextBoxColumn
            {
                HeaderText = "Cód. Forn.",
                Name = "codFornProd",
                ReadOnly = true,
                DataPropertyName = "itm_identificacao",
                Width = 80
            };
            dataGridView3.Columns.Add(trese);

            DataGridViewTextBoxColumn quatorze = new DataGridViewTextBoxColumn
            {
                HeaderText = "Comprar?",
                Name = "comprarProd",
                ReadOnly = true,
                DataPropertyName = "comprar",
                Width = 100
            };
            dataGridView3.Columns.Add(quatorze);

            DataGridViewTextBoxColumn quinze = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ult. Venda",
                Name = "ultVendProd",
                ReadOnly = true,
                DataPropertyName = "itm_ultvenda",
                Width = 60
            };
            dataGridView3.Columns.Add(quinze);

            DataGridViewTextBoxColumn deseseis = new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço",
                Name = "precoProd",
                ReadOnly = true,
                DataPropertyName = "itm_precocusto",
                Width = 50
            };
            dataGridView3.Columns.Add(deseseis);

            DataGridViewTextBoxColumn desesete = new DataGridViewTextBoxColumn
            {
                HeaderText = "grupo",
                Name = "grupoProd",
                Visible = false,
                DataPropertyName = "itm_grupo",
                Width = 50
            };
            dataGridView3.Columns.Add(desesete);

            DataGridViewTextBoxColumn desoito = new DataGridViewTextBoxColumn
            {
                HeaderText = "fornecedor",
                Name = "fornProd",
                Visible = false,
                DataPropertyName = "itm_fornecedor",
                Width = 50
            };
            dataGridView3.Columns.Add(desoito);

            DataGridViewTextBoxColumn desenove = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ord. C.",
                Name = "ordProd",
                DataPropertyName = "ordCompra",
                Width = 50
            };
            dataGridView3.Columns.Add(desenove);
        }
        public void PreecheTabelaProd()
        {
            var tb = new DataTable();
            tb.Columns.Add("itm_codigo");
            tb.Columns.Add("itm_descricao");
            tb.Columns.Add("itm_unidade");
            tb.Columns.Add("itm_minimo", typeof(decimal));
            tb.Columns.Add("itm_maximo", typeof(decimal));
            tb.Columns.Add("saldo", typeof(decimal));
            tb.Columns.Add("compra");
            tb.Columns.Add("seteMes", typeof(decimal));
            tb.Columns.Add("tresMes", typeof(decimal));
            tb.Columns.Add("vendSald7", typeof(decimal));
            tb.Columns.Add("itm_ultcompra", typeof(DateTime));
            tb.Columns.Add("ITM_Embalagem");
            tb.Columns.Add("itm_identificacao");
            tb.Columns.Add("comprar");
            tb.Columns.Add("itm_ultvenda", typeof(DateTime));
            tb.Columns.Add("itm_precocusto", typeof(decimal));
            tb.Columns.Add("itm_grupo");
            tb.Columns.Add("itm_fornecedor");
            tb.Columns.Add("ordCompra", typeof(decimal));

            for (int i = 0; i < codP.Count; i++)
            {
                if (ultVP[i] != "" && ultCP[i] != "")
                    tb.Rows.Add(codP[i], prodP[i], unP[i], minP[i], maxP[i], saldoP[i], compraP[i], seteMP[i], tresMP[i], saldVendP[i], ultCP[i], embP[i], codFornP[i], comprarP[i], ultVP[i], precoProd[i], grupoProd[i], fornProd[i], ocP[i]);
                else if (ultVP[i] == "" && ultCP[i] != "")
                    tb.Rows.Add(codP[i], prodP[i], unP[i], minP[i], maxP[i], saldoP[i], compraP[i], seteMP[i], tresMP[i], saldVendP[i], ultCP[i], embP[i], codFornP[i], comprarP[i], "01/01/01 00:00:00", precoProd[i], grupoProd[i], fornProd[i], ocP[i]);
                else if (ultCP[i] == "")
                    tb.Rows.Add(codP[i], prodP[i], unP[i], minP[i], maxP[i], saldoP[i], compraP[i], seteMP[i], tresMP[i], saldVendP[i], "01/01/01 00:00:00", embP[i], codFornP[i], comprarP[i], "01/01/01 00:00:00", precoProd[i], grupoProd[i], fornProd[i], ocP[i]);

            }
            dataGridView3.DataSource = tb;
        }

        public void Total()
        {
            List<decimal> x = new List<decimal>();
            decimal y = 0;
            for(int i = 0; i < dataGridView3.RowCount; i++)
            {
                if(dataGridView3.Rows[i].Cells["compProd"].Value.ToString() != "")
                {
                    x.Add(Convert.ToDecimal(dataGridView3.Rows[i].Cells["compProd"].Value) * Convert.ToDecimal(dataGridView3.Rows[i].Cells["precoProd"].Value));
                }
            }

            for(int i = 0; i < x.Count; i++)
            {
                y = y + x[i];
            }
            valorTxt.Text = "R$ "+y.ToString();
        }

        public void ComprarProd()
        {
            for (int i = 0; i < codFornP.Count; i++)
            {
                if (Convert.ToDouble(saldoP[i]) < Convert.ToDouble(minP[i]))
                    comprarP.Add("Crítico");
                else if (Convert.ToDouble(saldoP[i]) <= Convert.ToDouble(maxP[i]))
                    comprarP.Add("Normal");
                else if (Convert.ToDouble(saldoP[i]) > Convert.ToDouble(maxP[i]))
                    comprarP.Add("Não comprar");
            }
        }

        public void DadosBancoProd()
        {
            Sql = "select itm_codigo, itm_descricao, itm_grupo, itm_fornecedor, itm_unidade, round(itm_minimo, 2) as 'itm_minimo', round(itm_maximo, 2) as 'itm_maximo', ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) as 'saldo', " +
                    "itm_ultcompra, ITM_Embalagem, itm_identificacao, itm_ultvenda, round(itm_precocusto, 2) as 'itm_precocusto' from itens " +
                    "where itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between " + grupoInf + " and " + grupoSup + " and (itm_fornecedor between " + fornInf + " and " + fornSup + "" + fornNull + " and itm_kit != 'S' order by itm_codigo";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader produtos = dao.Query.ExecuteReader();
            while (produtos.Read())
            {
                codP.Add(produtos["itm_codigo"].ToString());
                prodP.Add(produtos["itm_descricao"].ToString());
                unP.Add(produtos["itm_unidade"].ToString());
                minP.Add(produtos["itm_minimo"].ToString());
                maxP.Add(produtos["itm_maximo"].ToString());
                saldoP.Add(produtos["saldo"].ToString());
                ultCP.Add(produtos["itm_ultcompra"].ToString());
                embP.Add(produtos["ITM_Embalagem"].ToString());
                codFornP.Add(produtos["itm_identificacao"].ToString());
                ultVP.Add(produtos["itm_ultvenda"].ToString());
                precoProd.Add(produtos["itm_precocusto"].ToString());
                grupoProd.Add(produtos["itm_grupo"].ToString());
                fornProd.Add(produtos["itm_fornecedor"].ToString());
            }
            produtos.Close();
            dao.Desconecta();
        }
        public void ValoresTresP()
        {
            string[] linhas;
            linhas = File.ReadAllLines(caminho);

            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                    "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                    "INNER JOIN itens on a.mv_item = itens.itm_codigo where nt_data between '" + DateTime.Now.AddMonths(- Convert.ToInt32(linhas[1])).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and nt_cancelada = 0  and " +
                    "Tipomovi.tmv_grupo = 'V' and itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between " + grupoInf + " and " + grupoSup + " and (itm_fornecedor between " + fornInf + " and " + fornSup + "" + fornNull + " and itm_kit != 'S' group by mv_item order by mv_item";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader treM = dao.Query.ExecuteReader();
            while (treM.Read())
            {
                auxList1.Add(treM["mv_item"].ToString());
                auxList2.Add(treM["qtde"].ToString());
            }
            for (int i = 0; i < codP.Count; i++)
            {
                if (auxList1.Count != 0)
                {
                    if (codP[i] == auxList1[w])
                    {
                        tresMP.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        tresMP.Add("0");
                }
                else
                    tresMP.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            treM.Close();
            dao.Desconecta();
        }
        public void ValoresSeteP()
        {
            string[] linhas;
            linhas = File.ReadAllLines(caminho);

            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                    "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                    "INNER JOIN itens on a.mv_item = itens.itm_codigo where nt_data between '" + DateTime.Now.AddMonths(- Convert.ToInt32(linhas[0])).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and nt_cancelada = 0  and " +
                    "Tipomovi.tmv_grupo = 'V' and itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between " + grupoInf + " and " + grupoSup + " and (itm_fornecedor between "+fornInf+" and "+fornSup+""+fornNull+ " and itm_kit != 'S' group by mv_item order by mv_item";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader seteM = dao.Query.ExecuteReader();
            while (seteM.Read())
            {
                auxList1.Add(seteM["mv_item"].ToString());
                auxList2.Add(seteM["qtde"].ToString());
            }
            for (int i = 0; i < codP.Count; i++)
            {
                if (auxList1.Count != 0)
                {
                    if (codP[i] == auxList1[w])
                    {
                        seteMP.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        seteMP.Add("0");
                }
                else
                    seteMP.Add("0");
            }

            auxList1.Clear();
            auxList2.Clear();
            seteM.Close();
            dao.Desconecta();
        }

        public void ValoresSetePAux()
        {
            string[] linhas;
            linhas = File.ReadAllLines(caminho);

            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                    "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                    "INNER JOIN itens on a.mv_item = itens.itm_codigo where nt_data between '" + DateTime.Now.AddMonths(-7).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and nt_cancelada = 0  and " +
                    "Tipomovi.tmv_grupo = 'V' and itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between " + grupoInf + " and " + grupoSup + " and (itm_fornecedor between " + fornInf + " and " + fornSup + "" + fornNull + " and itm_kit != 'S' group by mv_item order by mv_item";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader seteM = dao.Query.ExecuteReader();
            while (seteM.Read())
            {
                auxList1.Add(seteM["mv_item"].ToString());
                auxList2.Add(seteM["qtde"].ToString());
            }
            for (int i = 0; i < codP.Count; i++)
            {
                if (auxList1.Count != 0)
                {
                    if (codP[i] == auxList1[w])
                    {
                        seteMPAux.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        seteMPAux.Add("0");
                }
                else
                    seteMPAux.Add("0");
            }

            auxList1.Clear();
            auxList2.Clear();
            seteM.Close();
            dao.Desconecta();
        }
        public void Comprando()
        {
            Sql = "SELECT cnc_item FROM compra_naocompra";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while (aux.Read())
            {
                y.Add(aux["cnc_item"].ToString());
            }
            dao.Desconecta();
        }

        public void Composicao7()
        {
            string[] linhas;
            linhas = File.ReadAllLines(caminho);

            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            List<string> auxList3 = new List<string>();
            List<string> auxList4 = new List<string>();
            List<string> auxList5 = new List<string>();
            List<string> auxList6 = new List<string>();

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) "+
                    "INNER JOIN movimentos a ON a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente "+
                    "INNER JOIN itens on a.mv_item = itens.itm_codigo where nt_data between '" + DateTime.Now.AddMonths(- Convert.ToInt32(linhas[0])).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and nt_cancelada = 0 and " +
                    "Tipomovi.tmv_grupo = 'V' and itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between  "+ grupoInf + " and " + grupoSup + " and(itm_fornecedor between "+fornInf+" and "+fornSup+""+fornNull+" and itm_kit = 'S' group by mv_item order by mv_item; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while (aux.Read())
            {
                auxList1.Add(aux["mv_item"].ToString());
                auxList2.Add(aux["qtde"].ToString());
            }
            dao.Desconecta();

            Sql = "select cps_item, cps_componente from itens INNER JOIN composicao on itens.itm_codigo = composicao.cps_item " +
                    "where itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between " + grupoInf + " and " + grupoSup + " and(itm_fornecedor between "+fornInf+" and "+fornSup+""+fornNull+ " and itm_kit = 'S' order by cps_componente; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux2 = dao.Query.ExecuteReader();
            while (aux2.Read())
            {
                auxList3.Add(aux2["cps_item"].ToString());
                auxList4.Add(aux2["cps_componente"].ToString());
            }
            dao.Desconecta();

            for (int i = 0; i < auxList3.Count; i++)
            {
                for(int y = 0; y < auxList1.Count; y++)
                {
                    if(auxList1[y] == auxList3[i])
                    {
                        auxList5.Add(auxList2[y]);
                        auxList6.Add(auxList4[i]);
                    }
                }
            }
            for (int i = 0; i < auxList6.Count; i++)
            {
                for (int y = 0; y < codP.Count; y++)
                {
                    if (auxList6[i] == codP[y])
                    {
                        seteMP[y] = (Convert.ToDecimal(seteMP[y]) + Convert.ToDecimal(auxList5[i])).ToString();
                    }
                }
            }

            for (int i = 0; i < seteMPAux.Count; i++)
            {
                saldVendP.Add(string.Format("{0:0,0.00}", (Convert.ToDouble(saldoP[i]) - Convert.ToDouble(seteMPAux[i]))));
            }

            auxList1.Clear();
            auxList2.Clear();
            auxList3.Clear();
            auxList4.Clear();
            auxList5.Clear();
            auxList6.Clear();
        }

        public void Composicao3()
        {
            string[] linhas;
            linhas = File.ReadAllLines(caminho);

            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            List<string> auxList3 = new List<string>();
            List<string> auxList4 = new List<string>();
            List<string> auxList5 = new List<string>();
            List<string> auxList6 = new List<string>();

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                    "INNER JOIN movimentos a ON a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                    "INNER JOIN itens on a.mv_item = itens.itm_codigo where nt_data between '" + DateTime.Now.AddMonths(- Convert.ToInt32(linhas[1])).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and " +
                    "Tipomovi.tmv_grupo = 'V' and itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between  " + grupoInf + " and " + grupoSup + " and(itm_fornecedor between " + fornInf + " and " + fornSup + "" + fornNull + " and itm_kit = 'S' group by mv_item order by mv_item; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while (aux.Read())
            {
                auxList1.Add(aux["mv_item"].ToString());
                auxList2.Add(aux["qtde"].ToString());
            }
            dao.Desconecta();

            Sql = "select cps_item, cps_componente from itens INNER JOIN composicao on itens.itm_codigo = composicao.cps_item " +
                    "where itm_grupo != 0096 and itm_grupo != 0167 and itm_situacao = 'A' and itm_grupo between " + grupoInf + " and " + grupoSup + " and(itm_fornecedor between " + fornInf + " and " + fornSup + "" + fornNull + " and itm_kit = 'S' order by cps_componente; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux2 = dao.Query.ExecuteReader();
            while (aux2.Read())
            {
                auxList3.Add(aux2["cps_item"].ToString());
                auxList4.Add(aux2["cps_componente"].ToString());
            }
            dao.Desconecta();

            for (int i = 0; i < auxList3.Count; i++)
            {
                for (int y = 0; y < auxList1.Count; y++)
                {
                    if (auxList1[y] == auxList3[i])
                    {
                        auxList5.Add(auxList2[y]);
                        auxList6.Add(auxList4[i]);
                    }
                }
            }
            for (int i = 0; i < auxList6.Count; i++)
            {
                for (int y = 0; y < codP.Count; y++)
                {
                    if (auxList6[i] == codP[y])
                    {
                        tresMP[y] = (Convert.ToDecimal(tresMP[y]) + Convert.ToDecimal(auxList5[i])).ToString();
                    }
                }
            }

            auxList1.Clear();
            auxList2.Clear();
            auxList3.Clear();
            auxList4.Clear();
            auxList5.Clear();
            auxList6.Clear();
        }
        public void OrdemCompraC()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select oci_item, round(sum(oci_quantidade - oci_qtdfaturada), 2) as 'qtde' from (ordcitem inner join itens on ordcitem.oci_item = itens.itm_codigo) inner join ordcompra ON ordcitem.oci_numero = ordcompra.ocp_numero " +
                    "where itm_grupo != 0096 and itm_grupo != 0167 and(oci_sitentrega = 'P' or oci_sitentrega = 'Pendente') and ocp_dtrecebida is null and itm_situacao = 'A' and itm_grupo between  " + grupoInf + " and " + grupoSup + " and(itm_fornecedor between " + fornInf + " and " + fornSup + "" + fornNull + "  group by oci_item " +
                    "order by itm_codigo; ";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader oc = dao.Query.ExecuteReader();
            while (oc.Read())
            {
                auxList1.Add(oc["oci_item"].ToString());
                auxList2.Add(oc["qtde"].ToString());
            }
            for (int i = 0; i < codP.Count; i++)
            {
                if (auxList1.Count > 0)
                {
                    if (codP[i] == auxList1[w])
                    {
                        ocP.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        ocP.Add("0");
                }
                else
                    ocP.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            oc.Close();
            dao.Desconecta();
        }
        public void Grupos()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;
            Sql = "select cnc_item, cnc_qtde from compra_naocompra where cnc_grupo != 0096 and cnc_grupo != 0167 and cnc_grupo between " + grupoInf + " and " + grupoSup + " and (cnc_fornecedor between " + fornInf + " and " + fornSup + ") order by cnc_item";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while (aux.Read())
            {
                auxList1.Add(aux["cnc_item"].ToString());
                auxList2.Add(aux["cnc_qtde"].ToString());
            }
            for (int i = 0; i < codP.Count; i++)
            {
                if (auxList1.Count > 0)
                {
                    if (codP[i] == auxList1[w])
                    {
                        compraP.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        compraP.Add("");
                }
                else
                    compraP.Add("");
            }

            auxList1.Clear();
            auxList2.Clear();
            aux.Close();
            dao.Desconecta();

        }
        public void ContaTab()
        {

            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                if (dataGridView3.Rows[i].Cells[6].Value.ToString() != "")
                    contaTab1++;
            }
        }
        public CotacaoProd()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Comprando();
                if (dataGridView3[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                {
                    ccnc.Cnc_qtde = dataGridView3[e.ColumnIndex, e.RowIndex].Value.ToString();
                }

                for (int i = 0; i < y.Count; i++)
                {
                    if (y[i] == dataGridView3[0, e.RowIndex].Value.ToString())
                    {
                        aux = 1;
                        break;
                    }
                }

                if (aux == 0)
                {
                    ccnc.Cnc_fornecedor = dataGridView3[17, e.RowIndex].Value.ToString();
                    ccnc.Cnc_grupo = dataGridView3[16, e.RowIndex].Value.ToString();
                    ccnc.Cnc_item = dataGridView3[0, e.RowIndex].Value.ToString();
                    dao.CadastraCompra2(ccnc);
                }
                else
                {
                    dao.AlteraCompra2(ccnc, dataGridView3[0, e.RowIndex].Value.ToString());
                    aux = 0;
                }
                y.Clear();
                ccnc.Cnc_item = string.Empty;
                ccnc.Cnc_qtde = string.Empty;
                ccnc.Cnc_grupo = string.Empty;
                ccnc.Cnc_fornecedor = string.Empty;
                Total();
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.Equals("Crítico"))
            {
                e.CellStyle.BackColor = Color.Red;
            }
            if (e.Value.Equals("Normal"))
            {
                e.CellStyle.BackColor = Color.SandyBrown;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DadosBancoProd();
            ValoresSeteP();
            ValoresSetePAux();
            ValoresTresP();
            ComprarProd();
            Grupos();
            Composicao7();
            Composicao3();
            OrdemCompraC();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MontaTabelaProduto();
            PreecheTabelaProd();
            dataGridView3.Sort(dataGridView3.Columns["saldVend7Prod"], ListSortDirection.Ascending);
            Total();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void cotacaoProd_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void cotacaoProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaCompraProd = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comprando();
            int aux = 0;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                for (int w = 0; w < y.Count; w++)
                {
                    if (y[w] == codP[i])
                    {
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    ccnc.Cnc_fornecedor = dataGridView3.Rows[i].Cells[17].Value.ToString();
                    ccnc.Cnc_grupo = dataGridView3.Rows[i].Cells[16].Value.ToString();
                    ccnc.Cnc_item = dataGridView3.Rows[i].Cells[0].Value.ToString();
                    dao.CadastraCompra2(ccnc);
                }
                else
                    aux = 0;
            }

            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Cells[6].Value = "";
            }
            dao.AlteraCompra3();

            y.Clear();
            ccnc.Cnc_item = string.Empty;
            ccnc.Cnc_grupo = string.Empty;
            ccnc.Cnc_fornecedor = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                grupoInf = 0;
                grupoSup = 10000;
                fornInf = 0;
                fornSup = 10000;
                fornNull = " or itm_fornecedor is null)";
            }
            else if(textBox1.Text != string.Empty && textBox2.Text == string.Empty)
            {
                grupoInf = Convert.ToInt32(textBox1.Text);
                grupoSup = Convert.ToInt32(textBox1.Text);
                fornInf = 0;
                fornSup = 10000;
                fornNull = " or itm_fornecedor is null)";
            }
            else if (textBox1.Text == string.Empty && textBox2.Text != string.Empty)
            {
                fornInf = Convert.ToInt32(textBox2.Text);
                fornSup = Convert.ToInt32(textBox2.Text);
                fornNull = ")";
                grupoInf = 0;
                grupoSup = 10000;
            }
            else
            {
                grupoInf = Convert.ToInt32(textBox1.Text);
                grupoSup = Convert.ToInt32(textBox1.Text);
                fornInf = Convert.ToInt32(textBox2.Text);
                fornSup = Convert.ToInt32(textBox2.Text);
                fornNull = ")";
            }
            LimpaTabela();
            DadosBancoProd();
            ValoresSeteP();
            ValoresSetePAux();
            ValoresTresP();
            ComprarProd();
            Grupos();
            Composicao7();
            Composicao3();
            OrdemCompraC();
            MontaTabelaProduto();
            PreecheTabelaProd();
            dataGridView3.Sort(dataGridView3.Columns["saldVend7Prod"], ListSortDirection.Ascending);
            Total();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaTab();
            int w = 0;
            string[,] x = new string[contaTab1, 18];
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel|*.xlsx";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                Excel ex = new Excel();
                ex.CreateFile();
                ex.SavaAs(sfd.FileName);
                ex.Close();
                Excel ex2 = new Excel(sfd.FileName, "");
                ex2.WriteCell3(1, 0, 0, "Código");
                ex2.WriteCell3(1, 0, 1, "Produto");
                ex2.WriteCell3(1, 0, 2, "Un.");
                ex2.WriteCell3(1, 0, 3, "Min.");
                ex2.WriteCell3(1, 0, 4, "Max.");
                ex2.WriteCell3(1, 0, 5, "Saldo");
                ex2.WriteCell3(1, 0, 6, "Qtd");
                ex2.WriteCell3(1, 0, 7, "Obs.");
                ex2.WriteCell3(1, 0, 8, "+ meses");
                ex2.WriteCell3(1, 0, 9, "- meses");
                ex2.WriteCell3(1, 0, 10, "Saldo-Venda 7");
                ex2.WriteCell3(1, 0, 11, "Ult. Compra");
                ex2.WriteCell3(1, 0, 12, "Emb");
                ex2.WriteCell3(1, 0, 13, "Cód. Forn");
                ex2.WriteCell3(1, 0, 14, "Comprar?");
                ex2.WriteCell3(1, 0, 15, "Ult. Venda");
                ex2.WriteCell3(1, 0, 16, "Preço");
                ex2.WriteCell3(1, 0, 17, "Ord. C.");
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    if (dataGridView3.Rows[i].Cells[6].Value.ToString() != "")
                    {
                        x[w, 0] = dataGridView3.Rows[i].Cells[0].Value.ToString();
                        x[w, 1] = dataGridView3.Rows[i].Cells[1].Value.ToString();
                        x[w, 2] = dataGridView3.Rows[i].Cells[2].Value.ToString();
                        x[w, 3] = dataGridView3.Rows[i].Cells[3].Value.ToString();
                        x[w, 4] = dataGridView3.Rows[i].Cells[4].Value.ToString();
                        x[w, 5] = dataGridView3.Rows[i].Cells[5].Value.ToString();
                        x[w, 6] = dataGridView3.Rows[i].Cells[6].Value.ToString();
                        x[w, 8] = dataGridView3.Rows[i].Cells[7].Value.ToString();
                        x[w, 9] = dataGridView3.Rows[i].Cells[8].Value.ToString();
                        x[w, 10] = dataGridView3.Rows[i].Cells[9].Value.ToString();
                        x[w, 11] = dataGridView3.Rows[i].Cells[10].Value.ToString();
                        x[w, 12] = dataGridView3.Rows[i].Cells[11].Value.ToString();
                        x[w, 13] = dataGridView3.Rows[i].Cells[12].Value.ToString();
                        x[w, 14] = dataGridView3.Rows[i].Cells[13].Value.ToString();
                        x[w, 15] = dataGridView3.Rows[i].Cells[14].Value.ToString();
                        x[w, 16] = dataGridView3.Rows[i].Cells[15].Value.ToString();
                        x[w, 17] = dataGridView3.Rows[i].Cells[18].Value.ToString();
                        w++;
                        if (dataGridView3.Rows[i].Cells[13].Value.ToString() == "Crítico")
                            posiCrit.Add((w+1).ToString());
                        else if (dataGridView3.Rows[i].Cells[13].Value.ToString() == "Normal")
                            posiNorm.Add((w+1).ToString());
                    }
                }
                ex2.WriteRange(2, 1, contaTab1 + 1, 18, 1, x);
                ex2.AjustarColunas(1, "A", "R");
                ex2.Negrito(1, "A1:R1");
                int tama = contaTab1 + 1;
                ex2.PintarAmerelo(1, "F2:F" + tama + "");
                for (int i = 0; i < posiCrit.Count; i++)
                {
                    ex2.PintarVermelho(1, "O"+posiCrit[i]+":O"+posiCrit[i]+"");
                }
                for (int i = 0; i < posiNorm.Count; i++)
                {
                    ex2.PintarCastaAreno(1, "O" + posiNorm[i] + ":O" + posiNorm[i] + "");
                }
                    ex2.Save();
                ex2.Close();
                posiCrit.Clear();
                posiNorm.Clear();
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void cotacaoProd_Activated(object sender, EventArgs e)
        {
            if (var.CodForn != string.Empty)
            {
                textBox2.Text = var.CodForn;
                var.CodForn = string.Empty;
            }
            else if (var.CodGrupo != string.Empty)
            {
                textBox1.Text = var.CodGrupo;
                var.CodGrupo = string.Empty;
            }
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcuraForn pf = new ProcuraForn();
            pf.ShowDialog();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcuraGrupo pg = new ProcuraGrupo();
            pg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MesesCotacao mc = new MesesCotacao();
            mc.ShowDialog();
        }
    }
}