using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace processosAdministrativos.Telas
{
    public partial class mapaVendasCompleto : Form
    {
        DAO dao = new DAO();
        controlTelaAberta cta = new controlTelaAberta();
        DataTable tb = new DataTable();
        string caminhosMVTxt = Path.GetFullPath("Caminhos\\MapaVendas.txt");
        string caminhosIndTxt = Path.GetFullPath("Caminhos\\Indicadores.txt");
        StreamReader arquivo;

        string caminhoMV;
        string caminhoInd;
        private string Sql, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7, Sql8, Sql9 = String.Empty;
        List<string> vdds = new List<string>();
        List<string> vddsNome = new List<string>();
        List<string> vddsTipo = new List<string>();
        List<string> data = new List<string>();
        List<string> semana = new List<string>();
        List<string> atendim = new List<string>();
        List<string> atendimentos = new List<string>();
        List<string> acumulo1 = new List<string>();
        List<string> vendas = new List<string>();
        List<string> vendasAux = new List<string>();
        List<string> vendasData = new List<string>();
        List<string> acumulo2 = new List<string>();
        List<string> mccac = new List<string>();
        List<string> txc = new List<string>();
        List<string> acumulo3 = new List<string>();
        List<string> ppo = new List<string>();
        List<string> ppoAux = new List<string>();
        List<string> acumulo4 = new List<string>();
        List<string> medppo = new List<string>();
        List<string> loe = new List<string>();
        List<string> loeData = new List<string>();
        List<string> acumulo5 = new List<string>();
        List<string> medloe = new List<string>();
        List<string> norc = new List<string>();
        List<string> norcAux = new List<string>();
        List<string> norcData = new List<string>();
        List<string> orcValor = new List<string>();
        List<string> orcValorAux = new List<string>();
        List<string> vendaAux = new List<string>();
        List<string> devAux = new List<string>();
        List<string> dataDevAux = new List<string>();
        List<string> venda = new List<string>();
        List<string> vendaTotal = new List<string>();
        List<string> acumulo6 = new List<string>();
        List<string> meta = new List<string>();
        List<string> ValorMeta = new List<string>();
        List<string> objet = new List<string>();
        List<string> acumulo7 = new List<string>();
        List<string> saldo = new List<string>();
        List<string> previsao1 = new List<string>();
        List<string> p1 = new List<string>();
        List<string> a1 = new List<string>();
        List<string> objet2 = new List<string>();
        List<string> acumulo8 = new List<string>();
        List<string> saldo2 = new List<string>();
        List<string> p2 = new List<string>();
        List<string> a2 = new List<string>();
        List<string> tmac1 = new List<string>();
        List<string> vmac1 = new List<string>();
        List<string> mv = new List<string>();
        List<string> indVend = new List<string>();
        List<string> emailAux = new List<string>();
        List<string> grupoAux = new List<string>();
        string periodoMeta;
        string periodoPercent;
        int contador = 0;

        int apertaBt = 0;

        string vendedor1 = "0";
        string vendedor2 = "999";

        public void montaTabela()
        {
            tb.Columns.Add("qt", typeof(int));
            tb.Columns.Add("dt");
            tb.Columns.Add("dia");
            tb.Columns.Add("ca");
            tb.Columns.Add("ac1");
            tb.Columns.Add("cc");
            tb.Columns.Add("ac2");
            tb.Columns.Add("mvCcAc");
            tb.Columns.Add("txc");
            tb.Columns.Add("ac3");
            tb.Columns.Add("obj1");
            tb.Columns.Add("ppo");
            tb.Columns.Add("ac4");
            tb.Columns.Add("mPpo");
            tb.Columns.Add("loe");
            tb.Columns.Add("ac5");
            tb.Columns.Add("medLoe");
            tb.Columns.Add("qtOMv");
            tb.Columns.Add("vOrc");
            tb.Columns.Add("vBal");
            tb.Columns.Add("vtl");
            tb.Columns.Add("ac6");
            tb.Columns.Add("obj2");
            tb.Columns.Add("ac7");
            tb.Columns.Add("saldo1");
            tb.Columns.Add("previsao1");
            tb.Columns.Add("p1");
            tb.Columns.Add("a1");
            tb.Columns.Add("obj3");
            tb.Columns.Add("ac8");
            tb.Columns.Add("saldo2");
            tb.Columns.Add("previsao2");
            tb.Columns.Add("p2");
            tb.Columns.Add("a2");
            tb.Columns.Add("tmAc");
            tb.Columns.Add("vmAc");
            tb.Columns.Add("meta");
            tb.Columns.Add("sMeta");
        }
        public void preencheTabela()
        { 
            for (int i = 0; i < data.Count; i++)
            {
                if (i < venda.Count)
                {
                    tb.Rows.Add(i + 1, data[i].Substring(0, 2), semana[i], atendimentos[i], acumulo1[i],
                                vendas[i], acumulo2[i], mccac[i], txc[i], acumulo3[i], "85%", ppo[i],
                                acumulo4[i], medppo[i], loe[i], acumulo5[i], medloe[i], norc[i], orcValor[i],
                                venda[i], vendaTotal[i], acumulo6[i],  objet[i], acumulo7[i], saldo[i], previsao1[i],
                                p1[i], a1[i], objet2[i], acumulo8[i], saldo2[i], previsao1[i], p2[i], a2[i], tmac1[i], vmac1[i], 
                                string.Format("{0:0.00}", Convert.ToDouble(meta[i].Replace(".", ","))),
                                string.Format("{0:0.00}", Convert.ToDouble(meta[i].Replace(".",",")) * 1.10));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metaPercent mp = new metaPercent();
            mp.ShowDialog();
        }

        public void vendedores()
        {
            Sql = "select vdd_codigo, vdd_nome, vmet_tipo from vendedores inner join valor_meta on vendedores.vdd_codigo = valor_meta.vmet_vendedor where (vdd_cttfuncao = 'VENDEDOR' or vdd_cttfuncao = 'VENDEDORA') and vdd_situacao = 'A' and vmet_situacao = 1";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdd = dao.Query.ExecuteReader();
            while (vdd.Read())
            {
                vdds.Add(vdd["vdd_codigo"].ToString());
                vddsNome.Add(vdd["vdd_nome"].ToString());
                vddsTipo.Add(vdd["vmet_tipo"].ToString());
            }
            vdd.Close();
            dao.desconecta();
        }

        public void localizaDados()
        {
            string vdd1Aux = vendedor1.Replace("0","");
            string vdd2Aux = vendedor2.Replace("0", "");

            Sql8 = "select tmet_dia, tmet_meta, tmet_semana from tmp_meta where tmet_semana != 'DOM' and tmet_feriado = 0";
            dao.Query = new MySqlCommand(Sql8, dao.Conexao);
            dao.conecta();
            MySqlDataReader diaSema = dao.Query.ExecuteReader();
            while (diaSema.Read())
            {
                data.Add(diaSema["tmet_dia"].ToString());
                meta.Add(diaSema["tmet_meta"].ToString());
                semana.Add(diaSema["tmet_semana"].ToString());
            }
            diaSema.Close();
            dao.desconecta();

            String inferior;

            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1)
                inferior = DateTime.Now.ToString("yyyy-MM-"+data[0].Substring(0, 2)+" 00:00:00");
            else
                inferior = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-" + data[0].Substring(0, 2) + " 00:00:00");
            String superior = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 23:00:00");


            Sql = "SELECT COUNT(loe_codigo) as 'loe_codigo', DATE_FORMAT(loe_data, '%d') as 'data' FROM loe WHERE loe_id_vendedor BETWEEN '" + vdd1Aux + "' and '" + vdd2Aux + "' and loe_data BETWEEN '" + inferior + "' AND '" + superior + "' " +
                  "group by DATE_FORMAT(loe_data, '%Y-%m-%d') ORDER BY loe_data; ";

            Sql2 = "SELECT COUNT(nt_numero) as 'nt_numero', DATE_FORMAT(nt_data, '%d') as 'nt_data' FROM (Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                   "WHERE nt_vendedor BETWEEN '" + vendedor1 + "' and '" + vendedor2 + "' AND nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'V' and nt_empresa <> 91 " +
                   "group by nt_data ORDER BY DATE_FORMAT(nt_data, '%Y-%m-%d'); ";

            Sql3 = "SELECT count(mv_documento) as 'mv_documento' FROM (notas b INNER JOIN movimentos a ON a.mv_documento = b.nt_documento " +
                   "AND a.mv_empresa = b.nt_empresa AND a.mv_agente = b.nt_agente) INNER JOIN tipomovi c ON b.nt_movimento = c.tmv_codigo " +
                   "WHERE nt_vendedor BETWEEN '" + vendedor1 + "' and '" + vendedor2 + "' AND nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND nt_cancelada = 0 AND tmv_grupo = 'V' group by nt_data ORDER BY nt_data";

            Sql4 = "SELECT COUNT(ped_numero) as 'numero', DATE_FORMAT(ped_data, '%d') as 'data' FROM pedidos inner join vendedores on pedidos.ped_vendedor = vendedores.vdd_codigo " +
                   "where vdd_codigo BETWEEN '" + vendedor1 + "' and '" + vendedor2 + "' and ped_data BETWEEN '" + inferior + "' AND '" + superior + "' AND " +
                   "ped_orcamento <> '' AND ped_aprovado = 1 AND ped_cancelado = 0 group by ped_data ORDER BY DATE_FORMAT(ped_data, '%Y-%m-%d')";

            Sql5 = "SELECT round(SUM(ped_total), 2) as 'ped_total' FROM pedidos inner join vendedores on pedidos.ped_vendedor = vendedores.vdd_codigo " +
                   "where vdd_codigo BETWEEN '" + vendedor1 + "' and '" + vendedor2 + "' and ped_data BETWEEN '" + inferior + "' AND '" + superior + "' AND " +
                   "ped_orcamento <> '' AND ped_aprovado = 1 AND ped_cancelado = 0 group by ped_data ORDER BY DATE_FORMAT(ped_data, '%Y-%m-%d')";

            Sql6 = "SELECT round(SUM(nt_total), 2) as 'nt_total' FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo " +
                   "WHERE nt_vendedor BETWEEN '" + vendedor1 + "' and '" + vendedor2 + "' and nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND nt_cancelada = 0 AND tmv_grupo = 'V'  and tmv_codigo <> 77 " +
                   "group by nt_data ORDER BY nt_data";

            Sql7 = "SELECT round(SUM(nt_total), 2) as 'nt_total', DATE_FORMAT(nt_data, '%d') as 'nt_data' FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo " +
                   "WHERE nt_vendedor BETWEEN '" + vendedor1 + "' and '" + vendedor2 + "' and nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND '2018-10-15' AND nt_cancelada = 0 AND tmv_grupo = 'D' and tmv_tipo = 'E' " +
                   "group by nt_data ORDER BY DATE_FORMAT(nt_data, '%Y-%m-%d')";


            Sql9 = "select sum(vmet_meta) as 'vmet_meta' from valor_meta where vmet_vendedor between '" + vendedor1 + "' and '" + vendedor2 + "'";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader atend = dao.Query.ExecuteReader();
            while (atend.Read())
            {
                atendim.Add(atend["loe_codigo"].ToString());
                loeData.Add(atend["data"].ToString());
            }
            atend.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql9, dao.Conexao);
            dao.conecta();
            MySqlDataReader valMeta = dao.Query.ExecuteReader();
            while (valMeta.Read())
            {
                ValorMeta.Add(valMeta["vmet_meta"].ToString());
            }
            valMeta.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql2, dao.Conexao);
            dao.conecta();
            MySqlDataReader vend = dao.Query.ExecuteReader();
            while (vend.Read())
            {
                vendasAux.Add(vend["nt_numero"].ToString());
                vendasData.Add(vend["nt_data"].ToString());
            }
            vend.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql3, dao.Conexao);
            dao.conecta();
            MySqlDataReader pp = dao.Query.ExecuteReader();
            while (pp.Read())
            {
                ppoAux.Add(pp["mv_documento"].ToString());
            }
            pp.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql4, dao.Conexao);
            dao.conecta();
            MySqlDataReader numOrc = dao.Query.ExecuteReader();
            while (numOrc.Read())
            {
                norcAux.Add(numOrc["numero"].ToString());
                norcData.Add(numOrc["data"].ToString());
            }
            numOrc.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql5, dao.Conexao);
            dao.conecta();
            MySqlDataReader orc = dao.Query.ExecuteReader();
            while (orc.Read())
            {
                orcValorAux.Add(orc["ped_total"].ToString());
            }
            orc.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql6, dao.Conexao);
            dao.conecta();
            MySqlDataReader ven = dao.Query.ExecuteReader();
            while (ven.Read())
            {
                vendaAux.Add(ven["nt_total"].ToString());
            }
            ven.Close();
            dao.desconecta();

            dao.Query = new MySqlCommand(Sql7, dao.Conexao);
            dao.conecta();
            MySqlDataReader devol = dao.Query.ExecuteReader();
            while (devol.Read())
            {
                devAux.Add(devol["nt_total"].ToString());
                dataDevAux.Add(devol["nt_data"].ToString());
            }
            devol.Close();
            dao.desconecta();


            int x = 1;
            int y = 0;
            int z = 0;
            int w = 0;
            int x2 = 1;
            int qV = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (qV < vendasData.Count && vendasData[qV] == data[i].Substring(0, 2))
                {
                    if (w < loeData.Count())
                    {
                        if (loeData[w] == data[i].Substring(0, 2))
                        {
                            loe.Add(atendim[w]);
                            atendimentos.Add((Convert.ToDouble(atendim[w]) + Convert.ToDouble(vendasAux[qV])).ToString());
                            w++;
                        }
                        else
                        {
                            loe.Add("0");
                            atendimentos.Add(vendasAux[qV]);
                        }
                    }
                    else
                    {
                        loe.Add("0");
                        atendimentos.Add(vendasAux[qV]);
                    }
                    ppo.Add(ppoAux[qV]);
                    vendas.Add(vendasAux[qV]);
                }
                else
                {
                    atendimentos.Add("0");
                    loe.Add("0");
                    vendas.Add("0");
                    ppo.Add("0");
                }

                if (i == 0)
                {
                    acumulo1.Add(atendimentos[i]);
                    acumulo2.Add(vendas[i]);
                    acumulo4.Add(ppo[i]);
                    acumulo5.Add(loe[i]);
                }
                else
                {
                    acumulo1.Add((Convert.ToInt32(acumulo1[i - 1]) + Convert.ToInt32(atendimentos[i])).ToString());
                    acumulo2.Add((Convert.ToInt32(acumulo2[i - 1]) + Convert.ToInt32(vendas[i])).ToString());
                    acumulo4.Add((Convert.ToInt32(acumulo4[i - 1]) + Convert.ToInt32(ppo[i])).ToString());
                    acumulo5.Add((Convert.ToInt32(acumulo5[i - 1]) + Convert.ToInt32(loe[i])).ToString());
                }

                if (semana[i] != "SÁB")
                {
                    mccac.Add((Convert.ToInt32(acumulo2[i]) / x).ToString());
                    medloe.Add(string.Format("{0:0}", Convert.ToDouble(acumulo5[i]) / x));
                    x++;
                }
                else if (i != 0)
                {
                    mccac.Add(mccac[i - 1]);
                    medloe.Add(medloe[i - 1]);
                }
                else
                {
                    mccac.Add("0");
                    medloe.Add("0");
                }

                if (vendas[i] != "0")
                    txc.Add(Convert.ToInt32(((Convert.ToDouble(vendas[i]) / Convert.ToDouble(atendimentos[i])) * 100)).ToString());
                else
                    txc.Add("0");

                if (acumulo2[i] != "0" && acumulo1[i] != "0")
                    acumulo3.Add(Convert.ToInt32(((Convert.ToDouble(acumulo2[i]) / Convert.ToDouble(acumulo1[i])) * 100)).ToString());
                else
                    acumulo3.Add("0");
                medppo.Add(String.Format("{0:0.00}", (Convert.ToDouble(acumulo4[i]) / Convert.ToDouble(acumulo2[i]))));

                if (qV < vendasData.Count && vendasData[qV] == data[i].Substring(0, 2))
                {
                    if (z < dataDevAux.Count)
                    {
                        if (data[i].Substring(0, 2) == dataDevAux[z])
                        {
                            vendaTotal.Add(String.Format("{0:0,0.00}", (Convert.ToDouble(vendaAux[qV]) - Convert.ToDouble(devAux[z]))));
                            z++;
                        }
                        else
                        {
                            vendaTotal.Add(String.Format("{0:0,0.00}", Convert.ToDouble(vendaAux[qV])));
                        }
                    }
                    else
                    {
                        vendaTotal.Add(String.Format("{0:0,0.00}", Convert.ToDouble(vendaAux[qV])));
                    }

                    if (y < norcData.Count)
                    {
                        if (data[i].Substring(0, 2) == norcData[y])
                        {
                            norc.Add(norcAux[y]);
                            orcValor.Add(String.Format("{0:0,0.00}", Convert.ToDouble(orcValorAux[y])));
                            y++;
                        }
                        else
                        {
                            norc.Add("0");
                            orcValor.Add(String.Format("{0:0,0.00}", 0));
                        }
                    }
                    else
                    {
                        norc.Add("0");
                        orcValor.Add(String.Format("{0:0,0.00}", 0));
                    }

                    venda.Add(String.Format("{0:0,0.00}", Convert.ToDouble(vendaTotal[i]) - Convert.ToDouble(orcValor[i])));
                }
                else if(z < dataDevAux.Count)
                {
                    if (data[i].Substring(0, 2) == dataDevAux[z])
                    {
                        vendaTotal.Add(String.Format("{0:0,0.00}", "-" + devAux[z]));
                        norc.Add("0");
                        orcValor.Add(String.Format("{0:0,0.00}", 0));
                        venda.Add(String.Format("{0:0,0.00}", "-" + devAux[z]));
                        z++;
                    }
                    else
                    {
                        vendaTotal.Add(String.Format("{0:0,0.00}", 0));
                        norc.Add("0");
                        orcValor.Add(String.Format("{0:0,0.00}", 0));
                        venda.Add(String.Format("{0:0,0.00}", 0));
                    }
                }
                else if(y < norcData.Count)
                {
                    if (data[i].Substring(0, 2) == norcData[y])
                    {
                        vendaTotal.Add(String.Format("{0:0,0.00}", 0));
                        norc.Add("0");
                        orcValor.Add(String.Format("{0:0,0.00}", Convert.ToDouble(orcValorAux[y])));
                        venda.Add(String.Format("{0:0,0.00}", Convert.ToDouble(orcValorAux[y])));
                    }
                    else
                    {
                        vendaTotal.Add(String.Format("{0:0,0.00}", 0));
                        norc.Add("0");
                        orcValor.Add(String.Format("{0:0,0.00}", 0));
                        venda.Add(String.Format("{0:0,0.00}", 0));
                    }
                }
                else
                {
                    vendaTotal.Add(String.Format("{0:0,0.00}", 0));
                    norc.Add("0");
                    orcValor.Add(String.Format("{0:0,0.00}", 0));
                    venda.Add(String.Format("{0:0,0.00}", 0));
                }

                objet.Add(((Convert.ToDouble(ValorMeta[0]) * Convert.ToDouble(meta[i].Replace(".", ","))) / 100).ToString());
                objet2.Add(String.Format("{0:0}", (Convert.ToDouble(ValorMeta[0]) * (Convert.ToDouble(meta[i].Replace(".", ",")) * 1.10)) / 100));

                if (i == 0)
                {
                    acumulo6.Add(vendaTotal[i]);
                    acumulo7.Add(objet[i]);
                    acumulo8.Add(objet2[i]);
                }
                else
                {
                    acumulo6.Add((Convert.ToDouble(acumulo6[i - 1]) + Convert.ToDouble(vendaTotal[i])).ToString());
                    acumulo7.Add((Convert.ToDouble(acumulo7[i - 1]) + Convert.ToDouble(objet[i])).ToString());
                    acumulo8.Add((Convert.ToDouble(acumulo8[i - 1]) + Convert.ToDouble(objet2[i])).ToString());
                }
                saldo.Add(String.Format("{0:0.00}", Convert.ToDouble(acumulo6[i]) - Convert.ToDouble(acumulo7[i])));
                saldo2.Add(String.Format("{0:0.00}", Convert.ToDouble(acumulo6[i]) - Convert.ToDouble(acumulo8[i])));

                previsao1.Add(String.Format("{0:0}", Convert.ToDouble(ValorMeta[0]) - Convert.ToDouble(acumulo7[i]) + Convert.ToDouble(acumulo6[i])));

                p1.Add(String.Format("{0:0.0}", (Convert.ToDouble(previsao1[i]) / Convert.ToDouble(ValorMeta[0])) * 100));
                p2.Add(String.Format("{0:0.0}", (Convert.ToDouble(previsao1[i]) / (Convert.ToDouble(ValorMeta[0]) * 1.10)) * 100));

                a1.Add(String.Format("{0:0.0}", (Convert.ToDouble(acumulo6[i]) / Convert.ToDouble(ValorMeta[0])) * 100));
                a2.Add(String.Format("{0:0.0}", (Convert.ToDouble(acumulo6[i]) / (Convert.ToDouble(ValorMeta[0]) * 1.10)) * 100));

                tmac1.Add(String.Format("{0:0.00}", Convert.ToDouble(acumulo6[i]) / Convert.ToDouble(acumulo2[i])));

                if (qV < vendasData.Count && vendasData[qV] == data[i].Substring(0, 2))
                {

                    if (semana[i] != "SÁB")
                    {
                        vmac1.Add(String.Format("{0:0}", Convert.ToDouble(acumulo6[i]) / x2));
                        x2++;
                    }
                    else if(i != 0)
                        vmac1.Add(vmac1[i - 1]);
                    else
                        vmac1.Add("0");
                    qV++;
                }
                else if (i != 0)
                    vmac1.Add(vmac1[i - 1]);
                else
                    vmac1.Add("0");
            }
        }

        public void preencheMV()
        {
            arquivo = File.OpenText(caminhosMVTxt);
            caminhoMV = arquivo.ReadLine();
            arquivo.Close();
        }

        public void preencheInd()
        {
            arquivo = File.OpenText(caminhosIndTxt);
            caminhoInd = arquivo.ReadLine();
            arquivo.Close();
        }

        public void Envia()
        {
            int mes;
            int ano;

            if (DateTime.Now.ToString("MM") == "12" && Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1) ano = Convert.ToInt32(DateTime.Now.AddYears(1).ToString("yy"));
            else if (Convert.ToDateTime(DateTime.Now.ToString("dd/MM")) < Convert.ToDateTime("01/01")) ano = Convert.ToInt32(DateTime.Now.ToString("yy"));
            else ano = Convert.ToInt32(DateTime.Now.ToString("yy"));

            grupos();
            try
            {
                string emailsMv = string.Empty;
                for (int i = 0; i < mv.Count; i++)
                {
                    if (emailsMv == string.Empty)
                        emailsMv = mv[i];
                    else
                        emailsMv = emailsMv + ";" + mv[i];
                }
                if (emailsMv != string.Empty)
                {
                    DateTime inf = DateTime.Now;
                    DateTime sup = DateTime.Now;
                    if (inf.DayOfWeek.ToString() == "Monday")
                        inf = inf.AddDays(-2);
                    else
                        inf = inf.AddDays(-1);

                    if (Convert.ToInt32(inf.ToString("dd")) < 26)
                        mes = Convert.ToInt32(inf.ToString("MM"));
                    else
                        mes = Convert.ToInt32(inf.AddMonths(1).ToString("MM"));
                    string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();
                    Outlook._Application _app = new Outlook.Application();
                    Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                    mail.To = emailsMv;
                    mail.Subject = "MV-" + mesExtenso.Substring(0, 3).ToUpper() + "-" + ano;
                    mail.Display(mail);
                    mail.HTMLBody = "<font face='Arial'>Bom dia, segue em anexo MV-dia " + inf.ToString("dd") + "-" + inf.ToString("MM") + "</font>" + mail.HTMLBody;
                    mail.Importance = Outlook.OlImportance.olImportanceNormal;
                    mail.Attachments.Add(@"" + caminhoMV + "" + mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx", Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                    ((Outlook.MailItem)mail).Send();
                }
                else
                    MessageBox.Show("Nenhum e-mail de MV cadastrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mv.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string emailsIndVend = string.Empty;
                for (int i = 0; i < indVend.Count; i++)
                {
                    if (emailsIndVend == string.Empty)
                        emailsIndVend = indVend[i];
                    else
                        emailsIndVend = emailsIndVend + ";" + indVend[i];
                }
                if (emailsIndVend != string.Empty)
                {
                    DateTime inf = DateTime.Now;
                    DateTime sup = DateTime.Now;
                    if (inf.DayOfWeek.ToString() == "Monday")
                        inf = inf.AddDays(-2);
                    else
                        inf = inf.AddDays(-1);

                    if (Convert.ToInt32(inf.ToString("dd")) < 26)
                        mes = Convert.ToInt32(inf.ToString("MM"));
                    else
                        mes = Convert.ToInt32(inf.AddMonths(1).ToString("MM"));
                    string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();
                    Outlook._Application _app = new Outlook.Application();
                    Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                    mail.To = emailsIndVend;
                    mail.Subject = "Indicadores " + mesExtenso.Substring(0, 3).ToUpper() + "-" + ano;
                    mail.Display(mail);
                    mail.HTMLBody = "<font face='Arial'>Bom dia, segue em anexo indicadores de vendas " + inf.ToString("dd") + "-" + inf.ToString("MM") + "</font>" + mail.HTMLBody;
                    mail.Importance = Outlook.OlImportance.olImportanceNormal;
                    mail.Attachments.Add(@"" + caminhoInd + "" + mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx", Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                    ((Outlook.MailItem)mail).Send();
                }
                else
                    MessageBox.Show("Nenhum e-mail de indicadores cadastrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                indVend.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mv.Clear();
            indVend.Clear();
            cta.TelaMapaVendas = 0;
            this.Close();
        }

        public void limpa()
        {
            vdds.Clear();
            vddsNome.Clear();
            vddsTipo.Clear();
            data.Clear();
            semana.Clear();
            atendimentos.Clear();
            acumulo1.Clear();
            vendas.Clear();
            acumulo2.Clear();
            mccac.Clear();
            txc.Clear();
            acumulo3.Clear();
            ppo.Clear();
            acumulo4.Clear();
            medppo.Clear();
            loe.Clear();
            acumulo5.Clear();
            medloe.Clear();
            norc.Clear();
            norcAux.Clear();
            norcData.Clear();
            orcValor.Clear();
            orcValorAux.Clear();
            vendaAux.Clear();
            devAux.Clear();
            dataDevAux.Clear();
            venda.Clear();
            vendaTotal.Clear();
            acumulo6.Clear();
            meta.Clear();
            tb.Clear();
            atendim.Clear();
            loeData.Clear();
            ppoAux.Clear();
            vendasData.Clear();
            vendasAux.Clear();
            ValorMeta.Clear();
            objet.Clear();
            acumulo7.Clear();
            saldo.Clear();
            previsao1.Clear();
            p1.Clear();
            a1.Clear();
            objet2.Clear();
            acumulo8.Clear();
            saldo2.Clear();
            p2.Clear();
            a2.Clear();
            tmac1.Clear();
            vmac1.Clear();
            dataGridView1.Refresh();
        }

        public void preecheTabela()
        {
            int aux = 0;
            int ano;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                    aux++;
            }

            string[,] x1 = new string[aux, 1];
            int[] x2 = new int[6];

            int mes;

            if(Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1)
                mes = Convert.ToInt32(DateTime.Now.AddMonths(1).ToString("MM"));
            else
                mes = Convert.ToInt32(DateTime.Now.ToString("MM"));
            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();

            if (DateTime.Now.ToString("MM") == "12" && Convert.ToInt32(DateTime.Now.ToString("dd")) > 26) ano = Convert.ToInt32(DateTime.Now.AddYears(1).ToString("yy"));
            else if (Convert.ToDateTime(DateTime.Now.ToString("dd/MM")) < Convert.ToDateTime("01/01")) ano = Convert.ToInt32(DateTime.Now.ToString("yy"));
            else ano = Convert.ToInt32(DateTime.Now.ToString("yy"));

            excel ex = new excel(@""+ caminhoMV +""+ mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx", "123");

            x2[0] = 3;
            x2[1] = 5;
            x2[2] = 11;
            x2[3] = 17;
            x2[4] = 18;
            x2[5] = 19;

            for (int w = 0; w < vdds.Count +1; w++)
            {
                for (int y = 0; y < 6; y++)
                {
                    for (int i = 0; i < aux; i++)
                    {
                        if (y > 3)
                        {
                            if (Convert.ToUInt32(dataGridView1.Rows[i].Cells[x2[y]].Value.ToString().Substring(dataGridView1.Rows[i].Cells[x2[y]].Value.ToString().Length - 2, 2)) > 70)
                                x1[i, 0] = Math.Ceiling(Convert.ToDouble(dataGridView1.Rows[i].Cells[x2[y]].Value)).ToString();
                            else
                                x1[i, 0] = Math.Floor(Convert.ToDouble(dataGridView1.Rows[i].Cells[x2[y]].Value)).ToString();
                        }
                        else
                            x1[i, 0] = dataGridView1.Rows[i].Cells[x2[y]].Value.ToString();
                    }
                    ex.writeRange(6, x2[y] + 2, aux + 5, x2[y] + 2, w + 1, x1);
                }

                limpa();
                vendedores();

                if (w < vdds.Count)
                {
                    vendedor1 = vdds[w];
                    vendedor2 = vdds[w];
                    localizaDados();
                    preencheTabela();
                    dataGridView1.DataSource = tb;
                }

            }

            ex.Save();
            ex.Close();

            vendedor1 = "0";
            vendedor2 = "999";
            localizaDados();
            preencheTabela();
            dataGridView1.DataSource = tb;
        }

        public void preecheTabela2()
        {
            string[,] x1 = new string[dataGridView1.RowCount, 1];
            int[] x2 = new int[8];
            x2[0] = 8;
            x2[1] = 9;
            x2[2] = 15;
            x2[3] = 27;
            x2[4] = 29;
            x2[5] = 37;
            x2[6] = 38;
            x2[7] = 18;

            int mes;
            int ano;

            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1)
                mes = Convert.ToInt32(DateTime.Now.AddMonths(1).ToString("MM"));
            else
                mes = Convert.ToInt32(DateTime.Now.ToString("MM"));
            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();

            if (DateTime.Now.ToString("MM") == "12" && Convert.ToInt32(DateTime.Now.ToString("dd")) > 26) ano = Convert.ToInt32(DateTime.Now.AddYears(1).ToString("yy"));
            else if (Convert.ToDateTime(DateTime.Now.ToString("dd/MM")) < Convert.ToDateTime("01/01")) ano = Convert.ToInt32(DateTime.Now.ToString("yy"));
            else ano = Convert.ToInt32(DateTime.Now.ToString("yy"));

            excel ex = new excel(@""+ caminhoInd +""+ mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx", "");
            excel e = new excel(@""+ caminhoMV +""+ mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx", "123");

            int aux = 0;
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                    aux++;
            }

            int pasta = 1;
            int pasta2 = 1;
            int aux2 = 4;
            int z = 0;
            int y2 = 0;

            for (int w = 0; w < vdds.Count; w++)
            {
                if (vddsTipo[w] == "vendedor")
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (vddsTipo[w] == "vendedor")
                        {
                            ex.writeRange(4, aux2, aux + 3, aux2, pasta, e.readRange(6, x2[y], aux + 5, x2[y], pasta2 + 1));
                            aux2++;
                        }
                    }
                    aux2 = 4;
                    pasta++;
                }
                pasta2++;
            }

            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "0")
                    contador++;
            }

            string aux1 = dataGridView1.Rows[contador-1].Cells[1].Value.ToString();

            for (int i = 0; i < vdds.Count; i++)
            {
                for (int w = 0; w < 10; w++)
                {
                    if (vddsTipo[i] == "vendedor")
                    {
                        if (w != 5 && w != 7)
                        {
                            if(w != 4 && w != 6)
                            {
                                ex.writeCell3(ex.contaPastas(), z + 1, w + 1, ex.ReadCell3(z + 1, 3, y2 + 3, aux1));
                                y2++;
                            }
                            else
                            {
                                ex.writeCell4(ex.contaPastas(), z + 1, w + 1, Convert.ToDouble(ex.ReadCell3(z + 1, 3, y2 + 3, aux1)));
                                y2++;
                            }
                        }
                    }
                }
                y2 = 0;
                if (vddsTipo[i] == "vendedor")
                    z++;
            }

            e.Save();
            e.Close();
            ex.Save();
            ex.Close();
            String strCaminhoNomeArquivo = @""+ caminhoMV +""+ mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx";
            String strCaminhoNomeArquivo2 = @""+ caminhoInd +""+ mesExtenso.Substring(0, 3).ToUpper() + "_" + ano + ".xlsx";
            //System.Diagnostics.Process.Start(strCaminhoNomeArquivo2);
            //System.Diagnostics.Process.Start(strCaminhoNomeArquivo);
            CopiaVendas cv = new CopiaVendas();
            cv.Copia();
            Envia();
        }

        public void grupos()
        {
            Sql = "SELECT grpe_email, grpe_grupo FROM grupo_emails";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader grup = dao.Query.ExecuteReader();
            while (grup.Read())
            {
                grupoAux.Add(grup["grpe_grupo"].ToString());
                emailAux.Add(grup["grpe_email"].ToString());
            }

            for (int i = 0; i < emailAux.Count; i++)
            {
                if (grupoAux[i] == "MV")
                {
                    mv.Add(emailAux[i]);
                }
                else if (grupoAux[i] == "INDICADORES")
                {
                    indVend.Add(emailAux[i]);
                }
            }
            grup.Close();
            dao.desconecta();
            emailAux.Clear();
            grupoAux.Clear();
        }

        public void novoPeriodo()
        {
            Sql = "select tmet_dia from tmp_meta order by tmet_codigo desc limit 1";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader periodo = dao.Query.ExecuteReader();
            while (periodo.Read())
            {
                periodoPercent = periodo["tmet_dia"].ToString();
            }
            periodo.Close();
            dao.desconecta();
        }

        public mapaVendasCompleto()
        {
            InitializeComponent();
        }

        private void metaBt_Click(object sender, EventArgs e)
        {
            meta me = new meta();
            me.ShowDialog();
        }

        private void emailTxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grupoEmails ge = new grupoEmails();
            ge.ShowDialog();
        }

        private void DefCamBt_Click(object sender, EventArgs e)
        {
            CaminhosMV cmv = new CaminhosMV();
            cmv.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now.ToString("HH:mm:ss") == "08:10:20")
            {
                preecheTabela();
                preecheTabela2();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void mapaVendasCompleto_Load(object sender, EventArgs e)
        {
            vendedores();
            dataGridView2.Rows.Add();
            dataGridView2.Rows[0].Cells[0].Value = "LOJA   ";
            for (int i = 0; i < vdds.Count; i++)
            {
                dataGridView2.Rows[0].Cells[i + 1].Value = vddsNome[i].Replace(" (EXPERIENCIA)", "") + "   ";
                dataGridView2.Columns[i + 1].Visible = true;
            }
            novoPeriodo();
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1)
            {
                try
                {
                    if (periodoPercent.Substring(periodoPercent.Length - 2, 2) == DateTime.Now.ToString("MM"))
                    {
                        MessageBox.Show("Inicie um novo periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        excelBt.Enabled = false;
                        enviarBt.Enabled = false;
                    }
                    else
                    {
                        excelBt.Enabled = true;
                        enviarBt.Enabled = true;
                        montaTabela();
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                catch(Exception error)
                {

                }

            }
            else
            {
                if (periodoPercent.Substring(periodoPercent.Length - 2, 2) == DateTime.Now.ToString("MM"))
                {
                    excelBt.Enabled = true;
                    enviarBt.Enabled = true;
                    montaTabela();
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Inicie um novo periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    excelBt.Enabled = false;
                    enviarBt.Enabled = false;
                }
            }
            preencheMV();
            preencheInd();
            timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            localizaDados();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            preencheTabela();
            dataGridView1.DataSource = tb;
            apertaBt = 0;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            novoPeriodo();
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1)
            {
                if (periodoPercent.Substring(periodoPercent.Length - 2, 2) == DateTime.Now.ToString("MM"))
                {
                    MessageBox.Show("Inicie um novo periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    excelBt.Enabled = false;
                    enviarBt.Enabled = false;
                }
                else
                {
                    excelBt.Enabled = true;
                    enviarBt.Enabled = true;
                    if (apertaBt == 0)
                    {
                        limpa();
                        vendedores();
                        if (e.ColumnIndex > 0)
                        {
                            vendedor1 = vdds[e.ColumnIndex - 1];
                            vendedor2 = vdds[e.ColumnIndex - 1];
                        }
                        else
                        {
                            vendedor1 = "0";
                            vendedor2 = "999";
                        }
                        backgroundWorker1.RunWorkerAsync();
                        apertaBt = 1;
                    }
                }
            }
            else
            {
                if (periodoPercent.Substring(periodoPercent.Length - 2, 2) == DateTime.Now.ToString("MM"))
                {
                    excelBt.Enabled = true;
                    enviarBt.Enabled = true;
                    if (apertaBt == 0)
                    {
                        limpa();
                        vendedores();
                        if (e.ColumnIndex > 0)
                        {
                            vendedor1 = vdds[e.ColumnIndex - 1];
                            vendedor2 = vdds[e.ColumnIndex - 1];
                        }
                        else
                        {
                            vendedor1 = "0";
                            vendedor2 = "999";
                        }
                        backgroundWorker1.RunWorkerAsync();
                        apertaBt = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Inicie um novo periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    excelBt.Enabled = false;
                    enviarBt.Enabled = false;
                }
            }
        }

        private void excelBt_Click(object sender, EventArgs e)
        {
            preecheTabela();
            preecheTabela2();
        }

        private void enviarBt_Click(object sender, EventArgs e)
        {
            Envia();
        }

        private void mapaVendasCompleto_Activated(object sender, EventArgs e)
        {
            variaveis var = new variaveis();
            if (var.AuxMapaVendas == 1)
            {
                if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 26 && Convert.ToInt32(DateTime.Now.DayOfWeek) != 1)
                {
                    if (periodoPercent.Substring(periodoPercent.Length - 2, 2) == DateTime.Now.ToString("MM"))
                    {
                        MessageBox.Show("Inicie um novo periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var.AuxMapaVendas = 0;
                        excelBt.Enabled = false;
                        enviarBt.Enabled = false;
                    }
                    else
                    {
                        excelBt.Enabled = true;
                        enviarBt.Enabled = true;
                        limpa();
                        vendedor1 = "0";
                        vendedor2 = "999";
                        localizaDados();
                        preencheTabela();
                        dataGridView1.DataSource = tb;
                        var.AuxMapaVendas = 0;
                        dataGridView2.Rows.Clear();
                        dataGridView2.Refresh();
                        vdds.Clear();
                        vddsNome.Clear();
                        vendedores();
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[0].Cells[0].Value = "LOJA   ";
                        for (int i = 0; i < vdds.Count; i++)
                        {
                            dataGridView2.Rows[0].Cells[i + 1].Value = vddsNome[i].Replace(" (EXPERIENCIA)", "") + "   ";
                            dataGridView2.Columns[i + 1].Visible = true;
                        }
                    }
                }
                else
                {
                    if (periodoPercent.Substring(periodoPercent.Length - 2, 2) == DateTime.Now.ToString("MM"))
                    {
                        excelBt.Enabled = true;
                        enviarBt.Enabled = true;
                        limpa();
                        vendedor1 = "0";
                        vendedor2 = "999";
                        localizaDados();
                        preencheTabela();
                        dataGridView1.DataSource = tb;
                        var.AuxMapaVendas = 0;
                        dataGridView2.Rows.Clear();
                        dataGridView2.Refresh();
                        vdds.Clear();
                        vddsNome.Clear();
                        vendedores();
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[0].Cells[0].Value = "LOJA   ";
                        for (int i = 0; i < vdds.Count; i++)
                        {
                            dataGridView2.Columns[i+2].Visible = false;
                            dataGridView2.Rows[0].Cells[i + 1].Value = vddsNome[i].Replace(" (EXPERIENCIA)", "") + "   ";
                            dataGridView2.Columns[i + 1].Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inicie um novo periodo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var.AuxMapaVendas = 0;
                        excelBt.Enabled = false;
                        enviarBt.Enabled = false;
                    }
                }
            }
            preencheMV();
            preencheInd();
        }

        private void mapaVendasCompleto_FormClosing(object sender, FormClosingEventArgs e)
        {
            cta.TelaMapaVendas = 0;
        }
    }
}
