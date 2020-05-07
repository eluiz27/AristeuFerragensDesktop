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
    public partial class Comprar : Form
    {
        private string Sql = String.Empty;
        DAO dao = new DAO();
        ControlCompNComp ccnc = new ControlCompNComp();
        List<string> y = new List<string>();
        List<string> comprouC = new List<string>();
        List<string> comprouB = new List<string>();
        List<string> codC = new List<string>();
        List<string> prodC = new List<string>();
        List<string> codFornC = new List<string>();
        List<string> unC = new List<string>();
        List<string> saldoC = new List<string>();
        List<string> embaC = new List<string>();
        List<string> minC = new List<string>();
        List<string> maxC = new List<string>();
        List<string> seteC = new List<string>();
        List<string> tresC = new List<string>();
        List<string> qtdeC = new List<string>();
        List<string> saldVendC = new List<string>();
        List<string> saldVend2C = new List<string>();
        List<string> ocC = new List<string>();
        List<string> codB = new List<string>();
        List<string> prodB = new List<string>();
        List<string> codFornB = new List<string>();
        List<string> unB = new List<string>();
        List<string> saldoB = new List<string>();
        List<string> embaB = new List<string>();
        List<string> minB = new List<string>();
        List<string> maxB = new List<string>();
        List<string> seteB = new List<string>();
        List<string> tresB = new List<string>();
        List<string> qtdeB = new List<string>();
        List<string> saldVendB = new List<string>();
        List<string> saldVend2B = new List<string>();
        List<string> ocB = new List<string>();
        List<string> codP = new List<string>();
        List<string> prodP = new List<string>();
        List<string> unP = new List<string>();
        List<string> minP = new List<string>();
        List<string> maxP = new List<string>();
        List<string> saldoP = new List<string>();
        List<string> compraP = new List<string>();
        List<string> seteMP = new List<string>();
        List<string> tresMP = new List<string>();
        List<string> saldVendP = new List<string>();
        List<string> ultCP = new List<string>();
        List<string> embP = new List<string>();
        List<string> codFornP = new List<string>();
        List<string> comprarP = new List<string>();
        List<string> ultVP = new List<string>();
        List<string> precoProd = new List<string>();
        int aux = 0;
        int coluna = 10;
        int contaTab2 = 0;
        int contaTab3 = 0;

        public void contaTab()
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (bool.Parse(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString()) == true)
                    contaTab2++;
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (bool.Parse(dataGridView2.Rows[i].Cells[0].FormattedValue.ToString()) == true)
                    contaTab3++;
            }
        }
        public void montaTabelaCiser()
        {
            DataGridViewCheckBoxColumn um = new DataGridViewCheckBoxColumn();
            um.HeaderText = "Comprar?";
            um.Name = "compra";
            um.DataPropertyName = "compra";
            um.Width = 70;
            dataGridView1.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn();
            dois.HeaderText = "Código";
            dois.Name = "codProdCiser";
            dois.ReadOnly = true;
            dois.DataPropertyName = "itm_codigo";
            dois.Width = 70;
            dataGridView1.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "Produto";
            tres.Name = "prodCiser";
            tres.ReadOnly = true;
            tres.DataPropertyName = "itm_descricao";
            tres.Width = 285;
            dataGridView1.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "Cód. Forn.";
            quatro.Name = "codFornCiser";
            quatro.ReadOnly = true;
            quatro.DataPropertyName = "itm_identificacao";
            quatro.Width = 90;
            dataGridView1.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "Un.";
            cinco.Name = "unCiser";
            cinco.ReadOnly = true;
            cinco.DataPropertyName = "itm_unidade";
            cinco.Width = 40;
            dataGridView1.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn();
            seis.HeaderText = "Saldo";
            seis.Name = "saldoCiser";
            seis.ReadOnly = true;
            seis.DataPropertyName = "saldo";
            seis.Width = 50;
            seis.DefaultCellStyle.BackColor = Color.Tan;
            dataGridView1.Columns.Add(seis);

            DataGridViewTextBoxColumn sete = new DataGridViewTextBoxColumn();
            sete.HeaderText = "Embalagem";
            sete.Name = "embaCiser";
            sete.ReadOnly = true;
            sete.DataPropertyName = "ITM_Embalagem";
            sete.Width = 85;
            dataGridView1.Columns.Add(sete);

            DataGridViewTextBoxColumn oito = new DataGridViewTextBoxColumn();
            oito.HeaderText = "Mín.";
            oito.Name = "minCiser";
            oito.ReadOnly = true;
            oito.DataPropertyName = "itm_minimo";
            oito.Width = 50;
            oito.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView1.Columns.Add(oito);

            DataGridViewTextBoxColumn nove = new DataGridViewTextBoxColumn();
            nove.HeaderText = "Máx.";
            nove.Name = "maxCiser";
            nove.ReadOnly = true;
            nove.DataPropertyName = "itm_maximo";
            nove.Width = 50;
            nove.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView1.Columns.Add(nove);

            DataGridViewTextBoxColumn dez = new DataGridViewTextBoxColumn();
            dez.HeaderText = "7 Meses";
            dez.Name = "seteMCiser";
            dez.ReadOnly = true;
            dez.DataPropertyName = "seteMes";
            dez.Width = 60;
            dataGridView1.Columns.Add(dez);

            DataGridViewTextBoxColumn onze = new DataGridViewTextBoxColumn();
            onze.HeaderText = "3 Meses";
            onze.Name = "tresMCiser";
            onze.ReadOnly = true;
            onze.DataPropertyName = "tresMes";
            onze.Width = 60;
            dataGridView1.Columns.Add(onze);

            DataGridViewTextBoxColumn dose = new DataGridViewTextBoxColumn();
            dose.HeaderText = "Qtde";
            dose.Name = "qtdeCiser";
            dose.ReadOnly = true;
            dose.DataPropertyName = "qtde";
            dose.Width = 50;
            dataGridView1.Columns.Add(dose);

            DataGridViewTextBoxColumn trese = new DataGridViewTextBoxColumn();
            trese.HeaderText = "Vend 7-Sald";
            trese.Name = "vendSald7Ciser";
            trese.ReadOnly = true;
            trese.DataPropertyName = "vendSald7";
            trese.Width = 80;
            trese.DefaultCellStyle.BackColor = Color.LightCoral;
            dataGridView1.Columns.Add(trese);

            DataGridViewTextBoxColumn quatorze = new DataGridViewTextBoxColumn();
            quatorze.HeaderText = "Vend 3-Sald";
            quatorze.Name = "vendSald3Ciser";
            quatorze.ReadOnly = true;
            quatorze.DataPropertyName = "vendSald3";
            quatorze.Width = 80;
            quatorze.DefaultCellStyle.BackColor = Color.LightCoral;
            dataGridView1.Columns.Add(quatorze);

            DataGridViewTextBoxColumn quinze = new DataGridViewTextBoxColumn();
            quinze.HeaderText = "Pendencia";
            quinze.Name = "pendCiser";
            quinze.ReadOnly = true;
            quinze.DataPropertyName = "pendencia";
            quinze.Width = 80;
            dataGridView1.Columns.Add(quinze);
        }

        public void montaTabelaBelenus()
        {
            DataGridViewCheckBoxColumn um = new DataGridViewCheckBoxColumn();
            um.HeaderText = "Comprar?";
            um.Name = "compra";
            um.DataPropertyName = "compra";
            um.Width = 70;
            dataGridView2.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn();
            dois.HeaderText = "Código";
            dois.Name = "codProdBelenus";
            dois.ReadOnly = true;
            dois.DataPropertyName = "itm_codigo";
            dois.Width = 70;
            dataGridView2.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "Produto";
            tres.Name = "prodBelenus";
            tres.ReadOnly = true;
            tres.DataPropertyName = "itm_descricao";
            tres.Width = 285;
            dataGridView2.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "Cód. Forn.";
            quatro.Name = "codFornBelenus";
            quatro.ReadOnly = true;
            quatro.DataPropertyName = "itm_identificacao";
            quatro.Width = 90;
            dataGridView2.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "Un.";
            cinco.Name = "unBelenus";
            cinco.ReadOnly = true;
            cinco.DataPropertyName = "itm_unidade";
            cinco.Width = 40;
            dataGridView2.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn();
            seis.HeaderText = "Saldo";
            seis.Name = "saldoBelenus";
            seis.ReadOnly = true;
            seis.DataPropertyName = "saldo";
            seis.Width = 50;
            seis.DefaultCellStyle.BackColor = Color.Tan;
            dataGridView2.Columns.Add(seis);

            DataGridViewTextBoxColumn sete = new DataGridViewTextBoxColumn();
            sete.HeaderText = "Embalagem";
            sete.Name = "embaBelenus";
            sete.ReadOnly = true;
            sete.DataPropertyName = "ITM_Embalagem";
            sete.Width = 85;
            dataGridView2.Columns.Add(sete);

            DataGridViewTextBoxColumn oito = new DataGridViewTextBoxColumn();
            oito.HeaderText = "Mín.";
            oito.Name = "minBelenus";
            oito.ReadOnly = true;
            oito.DataPropertyName = "itm_minimo";
            oito.Width = 50;
            oito.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView2.Columns.Add(oito);

            DataGridViewTextBoxColumn nove = new DataGridViewTextBoxColumn();
            nove.HeaderText = "Máx.";
            nove.Name = "maxBelenus";
            nove.ReadOnly = true;
            nove.DataPropertyName = "itm_maximo";
            nove.Width = 50;
            nove.DefaultCellStyle.BackColor = Color.Silver;
            dataGridView2.Columns.Add(nove);

            DataGridViewTextBoxColumn dez = new DataGridViewTextBoxColumn();
            dez.HeaderText = "7 Meses";
            dez.Name = "seteMBelenus";
            dez.ReadOnly = true;
            dez.DataPropertyName = "seteMes";
            dez.Width = 60;
            dataGridView2.Columns.Add(dez);

            DataGridViewTextBoxColumn onze = new DataGridViewTextBoxColumn();
            onze.HeaderText = "3 Meses";
            onze.Name = "tresMBelenus";
            onze.ReadOnly = true;
            onze.DataPropertyName = "tresMes";
            onze.Width = 60;
            dataGridView2.Columns.Add(onze);

            DataGridViewTextBoxColumn dose = new DataGridViewTextBoxColumn();
            dose.HeaderText = "Qtde";
            dose.Name = "qtdeBelenus";
            dose.ReadOnly = true;
            dose.DataPropertyName = "qtde";
            dose.Width = 50;
            dataGridView2.Columns.Add(dose);

            DataGridViewTextBoxColumn trese = new DataGridViewTextBoxColumn();
            trese.HeaderText = "Vend 7-Sald";
            trese.Name = "vendSald7Ciser";
            trese.ReadOnly = true;
            trese.DataPropertyName = "vendSald7";
            trese.Width = 80;
            trese.DefaultCellStyle.BackColor = Color.LightCoral;
            dataGridView2.Columns.Add(trese);

            DataGridViewTextBoxColumn quatorze = new DataGridViewTextBoxColumn();
            quatorze.HeaderText = "Vend 3-Sald";
            quatorze.Name = "vendSald3Ciser";
            quatorze.ReadOnly = true;
            quatorze.DataPropertyName = "vendSald3";
            quatorze.Width = 80;
            quatorze.DefaultCellStyle.BackColor = Color.LightCoral;
            dataGridView2.Columns.Add(quatorze);

            DataGridViewTextBoxColumn quinze = new DataGridViewTextBoxColumn();
            quinze.HeaderText = "Pendencia";
            quinze.Name = "pendBelenus";
            quinze.ReadOnly = true;
            quinze.DataPropertyName = "pendencia";
            quinze.Width = 80;
            dataGridView2.Columns.Add(quinze);
        }
        
        public void preecheTabelaCiser()
        {
            var tb = new DataTable();
            tb.Columns.Add("compra");
            tb.Columns.Add("itm_codigo");
            tb.Columns.Add("itm_descricao");
            tb.Columns.Add("itm_identificacao");
            tb.Columns.Add("itm_unidade");
            tb.Columns.Add("saldo");
            tb.Columns.Add("ITM_Embalagem");
            tb.Columns.Add("itm_minimo");
            tb.Columns.Add("itm_maximo");
            tb.Columns.Add("seteMes");
            tb.Columns.Add("tresMes");
            tb.Columns.Add("qtde");
            tb.Columns.Add("vendSald7");
            tb.Columns.Add("vendSald3");
            tb.Columns.Add("pendencia");

            for (int i = 0; i < codC.Count; i++)
            {
                if(comprouC[i] == "1")
                    tb.Rows.Add(true, codC[i], prodC[i], codFornC[i], unC[i], saldoC[i], embaC[i], minC[i], maxC[i], seteC[i], tresC[i], qtdeC[i], saldVend2C[i], saldVendC[i], ocC[i]);           
                else if(comprouC[i] == "")
                    tb.Rows.Add(true, codC[i], prodC[i], codFornC[i], unC[i], saldoC[i], embaC[i], minC[i], maxC[i], seteC[i], tresC[i], qtdeC[i], saldVend2C[i], saldVendC[i], ocC[i]);           

            }
            for (int i = 0; i < codC.Count; i++)
            {
                if (comprouC[i] == "0")
                    tb.Rows.Add(false, codC[i], prodC[i], codFornC[i], unC[i], saldoC[i], embaC[i], minC[i], maxC[i], seteC[i], tresC[i], qtdeC[i], saldVend2C[i], saldVendC[i], ocC[i]);           
            }
            dataGridView1.DataSource = tb;
        }
        public void dadosBancoCiser()
        {
            Sql = "SELECT itm_codigo, itm_descricao, itm_identificacao, itm_unidade,  ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) as 'saldo', " +
                    "ITM_Embalagem, round(itm_minimo, 2) as 'itm_minimo', round(itm_maximo, 2) as 'itm_maximo', round(itm_maximo - ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), 2) as 'qtde', cnc_comprar " +
                    "FROM itens left outer join compra_naocompra a on itens.itm_codigo = a.cnc_item where itm_grupo = 0096 and itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo order by saldo, itm_descricao";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader ciser = dao.Query.ExecuteReader();
            while (ciser.Read())
            {
                codC.Add(ciser["itm_codigo"].ToString());
                prodC.Add(ciser["itm_descricao"].ToString());
                codFornC.Add(ciser["itm_identificacao"].ToString());
                unC.Add(ciser["itm_unidade"].ToString());
                saldoC.Add(ciser["saldo"].ToString());
                embaC.Add(ciser["ITM_Embalagem"].ToString());
                minC.Add(ciser["itm_minimo"].ToString());
                maxC.Add(ciser["itm_maximo"].ToString());
                qtdeC.Add(ciser["qtde"].ToString());
                comprouC.Add(ciser["cnc_comprar"].ToString());
            }
            ciser.Close();
            dao.Desconecta();
        }

        public void ordemComrpaC()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select oci_item, round(sum(oci_quantidade), 2) as 'qtde' from (ordcitem inner join itens on ordcitem.oci_item = itens.itm_codigo) inner join ordcompra ON ordcitem.oci_numero = ordcompra.ocp_numero " +
                    "where itm_grupo = 0096 and (oci_sitentrega = 'P' or oci_sitentrega = 'Pendente') and ocp_dtrecebida is null and itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo group by oci_item " +
                    "order by ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), itm_descricao;";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader oc = dao.Query.ExecuteReader();
            while (oc.Read())
            {
                auxList1.Add(oc["oci_item"].ToString());
                auxList2.Add(oc["qtde"].ToString());
            }
            for (int i = 0; i < codC.Count; i++)
            {
                if (auxList1.Count > 0)
                {
                    if (codC[i] == auxList1[w])
                    {
                        ocC.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        ocC.Add("0");
                }
                else
                    ocC.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            oc.Close();
            dao.Desconecta();
        }
        public void valoresTresC()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                                "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                                "INNER JOIN itens on a.mv_item = itens.itm_codigo " +
                                "where nt_data between '" + DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and Tipomovi.tmv_grupo = 'V' and itm_grupo = 0096 and " +
                                "itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo group by mv_item " +
                                "order by ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), itm_descricao";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader treM = dao.Query.ExecuteReader();
            while (treM.Read())
            {
                auxList1.Add(treM["mv_item"].ToString());
                auxList2.Add(treM["qtde"].ToString());
            }
            for (int i = 0; i < codC.Count; i++)
            {
                if (codC[i] == auxList1[w])
                {
                    tresC.Add(auxList2[w]);
                    if (w < auxList1.Count - 1)
                    {
                        w++;
                    }
                }
                else
                    tresC.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            treM.Close();
            dao.Desconecta();

            for (int i = 0; i < tresC.Count; i++)
            {
                saldVendC.Add(string.Format("{0:0,0.00}", (Convert.ToDouble(tresC[i]) - Convert.ToDouble(saldoC[i]))));
            }
        }
        public void valoresSeteC()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                    "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                    "INNER JOIN itens on a.mv_item = itens.itm_codigo " +
                    "where nt_data between '" + DateTime.Now.AddMonths(-7).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and Tipomovi.tmv_grupo = 'V' and itm_grupo = 0096 and " +
                    "itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo group by mv_item " +
                    "order by ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), itm_descricao";
            
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader seteM = dao.Query.ExecuteReader();
            while (seteM.Read())
            {
                auxList1.Add(seteM["mv_item"].ToString());
                auxList2.Add(seteM["qtde"].ToString());
            }
            for (int i = 0; i < codC.Count; i++)
            {
                if (codC[i] == auxList1[w])
                {
                    seteC.Add(auxList2[w]);
                    if (w < auxList1.Count - 1)
                    {
                        w++;
                    }
                }
                else
                    seteC.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            seteM.Close();
            dao.Desconecta();

            for (int i = 0; i < seteC.Count; i++)
            {
                saldVend2C.Add(string.Format("{0:0,0.00}", (Convert.ToDouble(seteC[i]) - Convert.ToDouble(saldoC[i]))));
            }
        }
        public void preecheTabelaBelenus()
        {
            var tb = new DataTable();
            tb.Columns.Add("compra");
            tb.Columns.Add("itm_codigo");
            tb.Columns.Add("itm_descricao");
            tb.Columns.Add("itm_identificacao");
            tb.Columns.Add("itm_unidade");
            tb.Columns.Add("saldo");
            tb.Columns.Add("ITM_Embalagem");
            tb.Columns.Add("itm_minimo");
            tb.Columns.Add("itm_maximo");
            tb.Columns.Add("seteMes");
            tb.Columns.Add("tresMes");
            tb.Columns.Add("qtde");
            tb.Columns.Add("vendSald7");
            tb.Columns.Add("vendSald3");
            tb.Columns.Add("pendencia");

            for (int i = 0; i < codB.Count; i++)
            {
                if(comprouB[i] == "1")
                    tb.Rows.Add(true, codB[i], prodB[i], codFornB[i], unB[i], saldoB[i], embaB[i], minB[i], maxB[i], seteB[i], tresB[i], qtdeB[i], saldVend2B[i], saldVendB[i], ocB[i]);
                else if(comprouB[i] == "")
                    tb.Rows.Add(true, codB[i], prodB[i], codFornB[i], unB[i], saldoB[i], embaB[i], minB[i], maxB[i], seteB[i], tresB[i], qtdeB[i], saldVend2B[i], saldVendB[i], ocB[i]);
            }
            for (int i = 0; i < codB.Count; i++)
            {
                if(comprouB[i] == "0")
                    tb.Rows.Add(false, codB[i], prodB[i], codFornB[i], unB[i], saldoB[i], embaB[i], minB[i], maxB[i], seteB[i], tresB[i], qtdeB[i], saldVend2B[i], saldVendB[i], ocB[i]);
            }
            dataGridView2.DataSource = tb;
        }
        public void dadosBancoBelenus()
        {
            Sql = "SELECT itm_codigo, itm_descricao, itm_identificacao, itm_unidade,  ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) as 'saldo', " +
                    "ITM_Embalagem, round(itm_minimo, 2) as 'itm_minimo', round(itm_maximo, 2) as 'itm_maximo', round(itm_maximo - ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), 2) as 'qtde', cnc_comprar " +
                    "FROM itens left outer join compra_naocompra a on itens.itm_codigo = a.cnc_item where itm_grupo = 0167 and itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo order by saldo, itm_descricao";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader belenus = dao.Query.ExecuteReader();
            while (belenus.Read())
            {
                codB.Add(belenus["itm_codigo"].ToString());
                prodB.Add(belenus["itm_descricao"].ToString());
                codFornB.Add(belenus["itm_identificacao"].ToString());
                unB.Add(belenus["itm_unidade"].ToString());
                saldoB.Add(belenus["saldo"].ToString());
                embaB.Add(belenus["ITM_Embalagem"].ToString());
                minB.Add(belenus["itm_minimo"].ToString());
                maxB.Add(belenus["itm_maximo"].ToString());
                qtdeB.Add(belenus["qtde"].ToString());
                comprouB.Add(belenus["cnc_comprar"].ToString());
            }
            belenus.Close();
            dao.Desconecta();
        }

        public void ordemComrpaB()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select oci_item, round(sum(oci_quantidade), 2) as 'qtde' from (ordcitem inner join itens on ordcitem.oci_item = itens.itm_codigo) inner join ordcompra ON ordcitem.oci_numero = ordcompra.ocp_numero " +
                    "where itm_grupo = 0167 and (oci_sitentrega = 'P' or oci_sitentrega = 'Pendente') and ocp_dtrecebida is null and itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo group by oci_item " +
                    "order by ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), itm_descricao;";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader oc = dao.Query.ExecuteReader();
            while (oc.Read())
            {
                auxList1.Add(oc["oci_item"].ToString());
                auxList2.Add(oc["qtde"].ToString());
            }
            for (int i = 0; i < codB.Count; i++)
            {
                if (auxList1.Count > 0)
                {
                    if (codB[i] == auxList1[w])
                    {
                        ocB.Add(auxList2[w]);
                        if (w < auxList1.Count - 1)
                        {
                            w++;
                        }
                    }
                    else
                        ocB.Add("0");
                }
                else
                    ocB.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            oc.Close();
            dao.Desconecta();
        }

        public void valoresTresB()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                               "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                               "INNER JOIN itens on a.mv_item = itens.itm_codigo " +
                               "where nt_data between '" + DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and Tipomovi.tmv_grupo = 'V' and itm_grupo = 0167 and " +
                               "itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo group by mv_item " +
                               "order by ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), itm_descricao";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader treM = dao.Query.ExecuteReader();
            while (treM.Read())
            {
                auxList1.Add(treM["mv_item"].ToString());
                auxList2.Add(treM["qtde"].ToString());
            }
            for (int i = 0; i < codB.Count; i++)
            {
                if (codB[i] == auxList1[w])
                {
                    tresB.Add(auxList2[w]);
                    if (w < auxList1.Count - 1)
                    {
                        w++;
                    }
                }
                else
                    tresB.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            treM.Close();
            dao.Desconecta();

            for (int i = 0; i < tresB.Count; i++)
            {
                saldVendB.Add(string.Format("{0:0,0.00}", (Convert.ToDouble(tresB[i]) - Convert.ToDouble(saldoB[i]))));
            }
        }
        public void valoresSeteB()
        {
            List<string> auxList1 = new List<string>();
            List<string> auxList2 = new List<string>();
            int w = 0;

            Sql = "select mv_item, round(sum(mv_quantidade), 2) as 'qtde' from (notas b INNER JOIN Tipomovi ON b.nt_movimento = Tipomovi.tmv_codigo) " +
                               "INNER JOIN movimentos a ON  a.mv_empresa = b.nt_empresa and a.mv_documento = b.nt_documento and a.mv_agente = b.nt_agente " +
                               "INNER JOIN itens on a.mv_item = itens.itm_codigo " +
                               "where nt_data between '" + DateTime.Now.AddMonths(-7).ToString("yyyy-MM-dd 00:00:00") + "' and '" + DateTime.Now.ToString("yyyy-MM-dd 23:00:00") + "' and Tipomovi.tmv_grupo = 'V' and itm_grupo = 0167 and " +
                               "itm_situacao = 'A' and ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2) < itm_maximo group by mv_item " +
                               "order by ROUND((ITM_Anterior+ITM_Entradas+ITM_Compras-ITM_Saidas-ITM_Vendas),2), itm_descricao";

            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader seteM = dao.Query.ExecuteReader();
            while (seteM.Read())
            {
                auxList1.Add(seteM["mv_item"].ToString());
                auxList2.Add(seteM["qtde"].ToString());
            }
            for (int i = 0; i < codB.Count; i++)
            {
                if (codB[i] == auxList1[w])
                {
                    seteB.Add(auxList2[w]);
                    if (w < auxList1.Count - 1)
                    {
                        w++;
                    }
                }
                else
                    seteB.Add("0");
            }
            auxList1.Clear();
            auxList2.Clear();
            seteM.Close();
            dao.Desconecta();

            for (int i = 0; i < seteB.Count; i++)
            {
                saldVend2B.Add(string.Format("{0:0,0.00}", (Convert.ToDouble(seteB[i]) - Convert.ToDouble(saldoB[i]))));
            }
        }
        
        public void comprando()
        {
            Sql = "SELECT cnc_item FROM compra_naocompra";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader aux = dao.Query.ExecuteReader();
            while(aux.Read())
            {
                y.Add(aux["cnc_item"].ToString());
            }
            aux.Close();
            dao.Desconecta();
        }
        public Comprar()
        {
            InitializeComponent();
        }

        private void comprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaCompra = 0;
        }

        private void comprar_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comprando();
            int x = 0;
            int aux = 0;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "compra")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!bool.Parse(row.Cells["compra"].EditedFormattedValue.ToString()))
                    {
                        x = 1;
                    }
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (x == 1)
                    {
                        dataGridView1.Rows[i].Cells["compra"].Value = true;
                        for (int b = 0; b < y.Count; b++)
                        {
                            if (y[b] == dataGridView1.Rows[i].Cells[1].Value.ToString())
                            {
                                aux = 1;
                                break;
                            }
                        }
                        if (aux == 0)
                        {
                            ccnc.Cnc_item = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 1;
                            dao.CadastraCompra(ccnc);
                        }
                        else
                        {
                            ccnc.Cnc_item = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 1;
                            dao.AlteraCompra(ccnc, dataGridView1.Rows[i].Cells[1].Value.ToString());
                        }
                        aux = 0;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells["compra"].Value = false;
                        for (int c = 0; c < y.Count; c++)
                        {
                            if (y[c] == dataGridView1.Rows[i].Cells[1].Value.ToString())
                            {
                                aux = 1;
                                break;
                            }
                        }
                        if (aux == 0)
                        {
                            ccnc.Cnc_item = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 0;
                            dao.CadastraCompra(ccnc);
                        }
                        else
                        {
                            ccnc.Cnc_item = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 0;
                            dao.AlteraCompra(ccnc, dataGridView1.Rows[i].Cells[1].Value.ToString());
                        }
                        aux = 0;
                    }
                }
                y.Clear();
                ccnc.Cnc_comprar = 0;
                ccnc.Cnc_item = string.Empty;
            }
        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comprando();
            int x = 0;
            int aux = 0;
            if (dataGridView2.Columns[e.ColumnIndex].Name == "compra")
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!bool.Parse(row.Cells["compra"].EditedFormattedValue.ToString()))
                    {
                        x = 1;
                    }
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (x == 1)
                    {
                        dataGridView2.Rows[i].Cells["compra"].Value = true;
                        for (int b = 0; b < y.Count; b++)
                        {
                            if (y[b] == dataGridView2.Rows[i].Cells[1].Value.ToString())
                            {
                                aux = 1;
                                break;
                            }
                        }
                        if (aux == 0)
                        {
                            ccnc.Cnc_item = dataGridView2.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 1;
                            dao.CadastraCompra(ccnc);
                        }
                        else
                        {
                            ccnc.Cnc_item = dataGridView2.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 1;
                            dao.AlteraCompra(ccnc, dataGridView2.Rows[i].Cells[1].Value.ToString());
                        }
                        aux = 0;
                    }
                    else
                    {
                        dataGridView2.Rows[i].Cells["compra"].Value = false;
                        for (int c = 0; c < y.Count; c++)
                        {
                            if (y[c] == dataGridView2.Rows[i].Cells[1].Value.ToString())
                            {
                                aux = 1;
                                break;
                            }
                        }
                        if (aux == 0)
                        {
                            ccnc.Cnc_item = dataGridView2.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 0;
                            dao.CadastraCompra(ccnc);
                        }
                        else
                        {
                            ccnc.Cnc_item = dataGridView2.Rows[i].Cells[1].Value.ToString();
                            ccnc.Cnc_comprar = 0;
                            dao.AlteraCompra(ccnc, dataGridView2.Rows[i].Cells[1].Value.ToString());
                        }
                        aux = 0;
                    }
                }
                y.Clear();
                ccnc.Cnc_comprar = 0;
                ccnc.Cnc_item = string.Empty;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (coluna == 0)
            {
                comprando();
                if (bool.Parse(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString()) == true)
                    ccnc.Cnc_comprar = 0;
                else
                    ccnc.Cnc_comprar = 1;
                for (int i = 0; i < y.Count; i++)
                {
                    if (y[i] == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                    {
                        aux = 1;
                        break;
                    }
                }
                if (aux == 0)
                {
                    ccnc.Cnc_item = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    dao.CadastraCompra(ccnc);
                }
                else
                {
                    dao.AlteraCompra(ccnc, dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    aux = 0;
                }
                y.Clear();
                coluna = 10;
                ccnc.Cnc_comprar = 0;
                ccnc.Cnc_item = string.Empty;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            coluna = e.ColumnIndex;
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (coluna == 0)
            {
                comprando();
                if (bool.Parse(dataGridView2.CurrentRow.Cells[0].FormattedValue.ToString()) == true)
                    ccnc.Cnc_comprar = 0;
                else
                    ccnc.Cnc_comprar = 1;
                for (int i = 0; i < y.Count; i++)
                {
                    if (y[i] == dataGridView2.CurrentRow.Cells[1].Value.ToString())
                    {
                        aux = 1;
                        break;
                    }
                }
                if (aux == 0)
                {
                    ccnc.Cnc_item = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    dao.CadastraCompra(ccnc);
                }
                else
                {
                    dao.AlteraCompra(ccnc, dataGridView2.CurrentRow.Cells[1].Value.ToString());
                    aux = 0;
                }
                y.Clear();
                coluna = 10;
                ccnc.Cnc_comprar = 0;
                ccnc.Cnc_item = string.Empty;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            coluna = e.ColumnIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contaTab();
            if (tabControl1.SelectedTab == ciserTp)
            {
                int z = 0;
                string[,] x = new string[contaTab2, 14];
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
                    ex2.WriteCell3(1, 0, 2, "Cód. Forn.");
                    ex2.WriteCell3(1, 0, 3, "Un.");
                    ex2.WriteCell3(1, 0, 4, "Saldo");
                    ex2.WriteCell3(1, 0, 5, "Embalagem");
                    ex2.WriteCell3(1, 0, 6, "Mín.");
                    ex2.WriteCell3(1, 0, 7, "Máx.");
                    ex2.WriteCell3(1, 0, 8, "7 Meses");
                    ex2.WriteCell3(1, 0, 9, "3 Meses");
                    ex2.WriteCell3(1, 0, 10, "Qtde");
                    ex2.WriteCell3(1, 0, 11, "Saldo - Venda 7");
                    ex2.WriteCell3(1, 0, 12, "Saldo - Venda 3");
                    ex2.WriteCell3(1, 0, 13, "Pendencia OC");
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (bool.Parse(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString()) == true)
                        {
                            x[z, 0] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            x[z, 1] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            x[z, 2] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            x[z, 3] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            x[z, 4] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            x[z, 5] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                            x[z, 6] = dataGridView1.Rows[i].Cells[7].Value.ToString();
                            x[z, 7] = dataGridView1.Rows[i].Cells[8].Value.ToString();
                            x[z, 8] = dataGridView1.Rows[i].Cells[9].Value.ToString();
                            x[z, 9] = dataGridView1.Rows[i].Cells[10].Value.ToString();
                            x[z, 10] = dataGridView1.Rows[i].Cells[11].Value.ToString();
                            x[z, 11] = dataGridView1.Rows[i].Cells[12].Value.ToString();
                            x[z, 12] = dataGridView1.Rows[i].Cells[13].Value.ToString();
                            x[z, 13] = dataGridView1.Rows[i].Cells[14].Value.ToString();
                            z++;
                        }
                    }
                    ex2.WriteRange(2, 1, contaTab2 + 1, 14, 1, x);
                    ex2.AjustarColunas(1, "A", "N");
                    ex2.Negrito(1,"A1:N1");
                    ex2.Save();
                    ex2.Close();
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            else if (tabControl1.SelectedTab == belenoTp)
            {
                int w = 0;
                string[,] x = new string[contaTab3, 14];
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
                    ex2.WriteCell3(1, 0, 2, "Cód. Forn.");
                    ex2.WriteCell3(1, 0, 3, "Un.");
                    ex2.WriteCell3(1, 0, 4, "Saldo");
                    ex2.WriteCell3(1, 0, 5, "Embalagem");
                    ex2.WriteCell3(1, 0, 6, "Mín.");
                    ex2.WriteCell3(1, 0, 7, "Máx.");
                    ex2.WriteCell3(1, 0, 8, "7 Meses");
                    ex2.WriteCell3(1, 0, 9, "3 Meses");
                    ex2.WriteCell3(1, 0, 10, "Qtde");
                    ex2.WriteCell3(1, 0, 11, "Saldo - Venda 7");
                    ex2.WriteCell3(1, 0, 12, "Saldo - Venda 3");
                    ex2.WriteCell3(1, 0, 13, "Pendencia OC");
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (bool.Parse(dataGridView2.Rows[i].Cells[0].FormattedValue.ToString()) == true)
                        {
                            x[w, 0] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                            x[w, 1] = dataGridView2.Rows[i].Cells[2].Value.ToString();
                            x[w, 2] = dataGridView2.Rows[i].Cells[3].Value.ToString();
                            x[w, 3] = dataGridView2.Rows[i].Cells[4].Value.ToString();
                            x[w, 4] = dataGridView2.Rows[i].Cells[5].Value.ToString();
                            x[w, 5] = dataGridView2.Rows[i].Cells[6].Value.ToString();
                            x[w, 6] = dataGridView2.Rows[i].Cells[7].Value.ToString();
                            x[w, 7] = dataGridView2.Rows[i].Cells[8].Value.ToString();
                            x[w, 8] = dataGridView2.Rows[i].Cells[9].Value.ToString();
                            x[w, 9] = dataGridView2.Rows[i].Cells[10].Value.ToString();
                            x[w, 10] = dataGridView2.Rows[i].Cells[11].Value.ToString();
                            x[w, 11] = dataGridView2.Rows[i].Cells[12].Value.ToString();
                            x[w, 12] = dataGridView2.Rows[i].Cells[13].Value.ToString();
                            x[w, 13] = dataGridView2.Rows[i].Cells[14].Value.ToString();
                            w++;
                        }
                    }
                    ex2.WriteRange(2, 1, contaTab3 + 1, 14, 1, x);
                    ex2.AjustarColunas(1, "A", "N");
                    ex2.Negrito(1, "A1:N1");
                    ex2.Save();
                    ex2.Close();
                    System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
            contaTab2 = 0;
            contaTab3 = 0;
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
            dadosBancoBelenus();
            ordemComrpaB();
            valoresSeteB();
            valoresTresB();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            dadosBancoCiser();
            ordemComrpaC();
            valoresSeteC();
            valoresTresC();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            montaTabelaBelenus();
            preecheTabelaBelenus();
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            montaTabelaCiser();
            preecheTabelaCiser();
            textBox1.Text = dataGridView1.RowCount.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == ciserTp)
                textBox1.Text = dataGridView1.RowCount.ToString();
            else
                textBox1.Text = dataGridView2.RowCount.ToString();
        }
    }
}
