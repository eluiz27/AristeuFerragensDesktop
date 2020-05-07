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
    public partial class Controladoria : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> emp = new List<string>();
        List<DateTime> data = new List<DateTime>();
        List<string> doc = new List<string>();
        List<string> codCli = new List<string>();
        List<string> cli = new List<string>();
        List<string> classe = new List<string>();
        List<string> grupo = new List<string>();
        List<string> prod = new List<string>();
        List<string> codProd = new List<string>();
        List<string> qtde = new List<string>();
        List<string> uni = new List<string>();
        List<string> preco = new List<string>();
        List<string> total = new List<string>();
        List<string> valorN = new List<string>();
        List<string> valorIcms = new List<string>();
        List<string> valorIpi = new List<string>();
        List<string> pis = new List<string>();
        List<string> cofins = new List<string>();
        List<string> irpj = new List<string>();
        List<string> csll = new List<string>();
        List<string> simples = new List<string>();
        List<string> cmv = new List<string>();
        List<string> cmvAj = new List<string>();
        List<string> cmvAjCorr = new List<string>();
        List<string> vendaLiq = new List<string>();
        List<string> margemBruta = new List<string>();
        List<string> mb = new List<string>();
        List<string> vend = new List<string>();
        List<string> empNeg = new List<string>();
        List<DateTime> dataNeg = new List<DateTime>();
        List<string> docNeg = new List<string>();
        List<string> codCliNeg = new List<string>();
        List<string> cliNeg = new List<string>();
        List<string> classeNeg = new List<string>();
        List<string> grupoNeg = new List<string>();
        List<string> prodNeg = new List<string>();
        List<string> codProdNeg = new List<string>();
        List<string> qtdeNeg = new List<string>();
        List<string> uniNeg = new List<string>();
        List<string> precoNeg = new List<string>();
        List<string> totalNeg = new List<string>();
        List<string> valorNNeg = new List<string>();
        List<string> valorIcmsNeg = new List<string>();
        List<string> valorIpiNeg = new List<string>();
        List<string> pisNeg = new List<string>();
        List<string> cofinsNeg = new List<string>();
        List<string> irpjNeg = new List<string>();
        List<string> csllNeg = new List<string>();
        List<string> simplesNeg = new List<string>();
        List<string> cmvNeg = new List<string>();
        List<string> cmvAjNeg = new List<string>();
        List<string> cmvAjCorrNeg = new List<string>();
        List<string> vendaLiqNeg = new List<string>();
        List<string> margemBrutaNeg = new List<string>();
        List<string> mbNeg = new List<string>();
        List<string> vendNeg = new List<string>();
        List<string> vendTot = new List<string>();
        List<string> nomeTot = new List<string>();
        List<string> valorNTot = new List<string>();
        List<string> mbTot = new List<string>();
        List<string> percentMbTot = new List<string>();
        List<string> vendTotNeg = new List<string>();
        List<string> nomeTotNeg = new List<string>();
        List<string> valorNTotNeg = new List<string>();
        List<string> mbTotNeg = new List<string>();
        List<string> percentMbTotNeg = new List<string>();

        public void montaTabela()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn();
            um.HeaderText = "EMPRESA";
            um.Name = "empresa";
            um.DataPropertyName = "emp_razao";
            um.Width = 80;
            dataGridView1.Columns.Add(um);

            DataGridViewTextBoxColumn dois = new DataGridViewTextBoxColumn();
            dois.HeaderText = "DATA";
            dois.Name = "data";
            dois.DataPropertyName = "nt_data";
            dois.Width = 70;
            dataGridView1.Columns.Add(dois);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "DOCUMENTO";
            tres.Name = "documento";
            tres.DataPropertyName = "mv_documento";
            tres.Width = 70;
            dataGridView1.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "CÓDIGO DO CLIENTE";
            quatro.Name = "codCli";
            quatro.DataPropertyName = "mv_agente";
            quatro.Width = 70;
            dataGridView1.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "NOME DO CLIENTE";
            cinco.Name = "codCli";
            cinco.DataPropertyName = "cli_nome";
            cinco.Width = 150;
            dataGridView1.Columns.Add(cinco);

            DataGridViewTextBoxColumn seis = new DataGridViewTextBoxColumn();
            seis.HeaderText = "CLASSE";
            seis.Name = "classe";
            seis.DataPropertyName = "clg_descricao";
            seis.Width = 100;
            dataGridView1.Columns.Add(seis);

            DataGridViewTextBoxColumn sete = new DataGridViewTextBoxColumn();
            sete.HeaderText = "GRUPO";
            sete.Name = "grupo";
            sete.DataPropertyName = "grp_descricao";
            sete.Width = 100;
            dataGridView1.Columns.Add(sete);

            DataGridViewTextBoxColumn oito = new DataGridViewTextBoxColumn();
            oito.HeaderText = "DESCRIÇÃO DO ÍTEM";
            oito.Name = "produto";
            oito.DataPropertyName = "MV_Descricao";
            oito.Width = 250;
            dataGridView1.Columns.Add(oito);

            DataGridViewTextBoxColumn nove = new DataGridViewTextBoxColumn();
            nove.HeaderText = "CÓDIGO DO ITEM";
            nove.Name = "codItem";
            nove.DataPropertyName = "mv_item";
            nove.Width = 80;
            dataGridView1.Columns.Add(nove);

            DataGridViewTextBoxColumn dez = new DataGridViewTextBoxColumn();
            dez.HeaderText = "QTD DA NOTA";
            dez.Name = "qtde";
            dez.DataPropertyName = "mv_quantidade";
            dez.Width = 60;
            dataGridView1.Columns.Add(dez);

            DataGridViewTextBoxColumn onze = new DataGridViewTextBoxColumn();
            onze.HeaderText = "UND NOTA";
            onze.Name = "un";
            onze.DataPropertyName = "mv_unidade";
            onze.Width = 80;
            dataGridView1.Columns.Add(onze);

            DataGridViewTextBoxColumn doze = new DataGridViewTextBoxColumn();
            doze.HeaderText = "PREÇO UNIT. NOTA";
            doze.Name = "precoUnNota";
            doze.DataPropertyName = "mv_preco";
            doze.Width = 80;
            dataGridView1.Columns.Add(doze);

            DataGridViewTextBoxColumn treze = new DataGridViewTextBoxColumn();
            treze.HeaderText = "VALOR TOT. ITEM";
            treze.Name = "valorTotItem";
            treze.DataPropertyName = "mv_total";
            treze.Width = 80;
            dataGridView1.Columns.Add(treze);

            DataGridViewTextBoxColumn quatorze = new DataGridViewTextBoxColumn();
            quatorze.HeaderText = "VALOR TT NOTA";
            quatorze.Name = "valorTtNota";
            quatorze.DataPropertyName = "valorNota";
            quatorze.Width = 80;
            dataGridView1.Columns.Add(quatorze);

            DataGridViewTextBoxColumn quinze = new DataGridViewTextBoxColumn();
            quinze.HeaderText = "VALOR ICMS";
            quinze.Name = "valorIcms";
            quinze.DataPropertyName = "mv_valoricms";
            quinze.Width = 80;
            dataGridView1.Columns.Add(quinze);

            DataGridViewTextBoxColumn dezesseis = new DataGridViewTextBoxColumn();
            dezesseis.HeaderText = "VALOR IPI";
            dezesseis.Name = "valorIpi";
            dezesseis.DataPropertyName = "mv_valoripi";
            dezesseis.Width = 80;
            dataGridView1.Columns.Add(dezesseis);

            DataGridViewTextBoxColumn dezessete = new DataGridViewTextBoxColumn();
            dezessete.HeaderText = "PIS";
            dezessete.Name = "valorPis";
            dezessete.DataPropertyName = "pis";
            dezessete.Width = 80;
            dataGridView1.Columns.Add(dezessete);

            DataGridViewTextBoxColumn dezoito = new DataGridViewTextBoxColumn();
            dezoito.HeaderText = "COFINS";
            dezoito.Name = "valorCofins";
            dezoito.DataPropertyName = "cofins";
            dezoito.Width = 80;
            dataGridView1.Columns.Add(dezoito);

            DataGridViewTextBoxColumn dezenove = new DataGridViewTextBoxColumn();
            dezenove.HeaderText = "IRPJ";
            dezenove.Name = "valorIrpj";
            dezenove.DataPropertyName = "irpj";
            dezenove.Width = 80;
            dataGridView1.Columns.Add(dezenove);

            DataGridViewTextBoxColumn vinte = new DataGridViewTextBoxColumn();
            vinte.HeaderText = "CSLL";
            vinte.Name = "valorCsll";
            vinte.DataPropertyName = "csll";
            vinte.Width = 80;
            dataGridView1.Columns.Add(vinte);

            DataGridViewTextBoxColumn vinteUm = new DataGridViewTextBoxColumn();
            vinteUm.HeaderText = "SIMPLES";
            vinteUm.Name = "valorSimples";
            vinteUm.DataPropertyName = "simples";
            vinteUm.Width = 80;
            dataGridView1.Columns.Add(vinteUm);

            DataGridViewTextBoxColumn vintedois = new DataGridViewTextBoxColumn();
            vintedois.HeaderText = "CMV";
            vintedois.Name = "valorCmv";
            vintedois.DataPropertyName = "mv_custo";
            vintedois.Width = 80;
            dataGridView1.Columns.Add(vintedois);

            DataGridViewTextBoxColumn vintetres = new DataGridViewTextBoxColumn();
            vintetres.HeaderText = "CMV AJ";
            vintetres.Name = "valorCmvAj";
            vintetres.DataPropertyName = "cmvAj";
            vintetres.Width = 80;
            dataGridView1.Columns.Add(vintetres);

            DataGridViewTextBoxColumn vinteQuatro = new DataGridViewTextBoxColumn();
            vinteQuatro.HeaderText = "CMV AJ CORR";
            vinteQuatro.Name = "valorCmvAjCorr";
            vinteQuatro.DataPropertyName = "cmvAjCorr";
            vinteQuatro.Width = 80;
            dataGridView1.Columns.Add(vinteQuatro);

            DataGridViewTextBoxColumn vinteCinco = new DataGridViewTextBoxColumn();
            vinteCinco.HeaderText = "VENDA LIQ";
            vinteCinco.Name = "vendaLiquida";
            vinteCinco.DataPropertyName = "vendaLiq";
            vinteCinco.Width = 80;
            dataGridView1.Columns.Add(vinteCinco);

            DataGridViewTextBoxColumn vinteSeis = new DataGridViewTextBoxColumn();
            vinteSeis.HeaderText = "MARGEM BRUTA";
            vinteSeis.Name = "margemBruta";
            vinteSeis.DataPropertyName = "margemB";
            vinteSeis.Width = 80;
            dataGridView1.Columns.Add(vinteSeis);

            DataGridViewTextBoxColumn vinteSete = new DataGridViewTextBoxColumn();
            vinteSete.HeaderText = "MB%";
            vinteSete.Name = "mbPercent";
            vinteSete.DataPropertyName = "mb";
            vinteSete.Width = 80;
            dataGridView1.Columns.Add(vinteSete);

            DataGridViewTextBoxColumn vinteOito = new DataGridViewTextBoxColumn();
            vinteOito.HeaderText = "VENDEDOR";
            vinteOito.Name = "vendedor";
            vinteOito.DataPropertyName = "vdd";
            vinteOito.Width = 80;
            dataGridView1.Columns.Add(vinteOito);
        }

        public void montaTabela2()
        {
            DataGridViewTextBoxColumn um = new DataGridViewTextBoxColumn();
            um.HeaderText = "VENDEDOR";
            um.Name = "vendedor";
            um.DataPropertyName = "vdd";
            um.Width = 150;
            dataGridView2.Columns.Add(um);

            DataGridViewTextBoxColumn tres = new DataGridViewTextBoxColumn();
            tres.HeaderText = "SOMA VALOR TT DA NOTA";
            tres.Name = "somaValorTt";
            tres.DataPropertyName = "somaTt";
            tres.Width = 120;
            dataGridView2.Columns.Add(tres);

            DataGridViewTextBoxColumn quatro = new DataGridViewTextBoxColumn();
            quatro.HeaderText = "SOMA MARGEM BRUTA";
            quatro.Name = "somaMargemBruta";
            quatro.DataPropertyName = "somaMargem";
            quatro.Width = 120;
            dataGridView2.Columns.Add(quatro);

            DataGridViewTextBoxColumn cinco = new DataGridViewTextBoxColumn();
            cinco.HeaderText = "% MARGEM BRUTA";
            cinco.Name = "percentMargemBruta";
            cinco.DataPropertyName = "percentMargem";
            cinco.Width = 120;
            dataGridView2.Columns.Add(cinco);
        }

        public void preecheTabela()
        {
            var tb = new DataTable();
            tb.Columns.Add("emp_razao");
            tb.Columns.Add("nt_data", typeof(DateTime));
            tb.Columns.Add("mv_documento");
            tb.Columns.Add("mv_agente");
            tb.Columns.Add("cli_nome");
            tb.Columns.Add("clg_descricao");
            tb.Columns.Add("grp_descricao");
            tb.Columns.Add("MV_Descricao");
            tb.Columns.Add("mv_item");
            tb.Columns.Add("mv_quantidade");
            tb.Columns.Add("mv_unidade");
            tb.Columns.Add("mv_preco", typeof(decimal));
            tb.Columns.Add("mv_total", typeof(decimal));
            tb.Columns.Add("valorNota", typeof(decimal));
            tb.Columns.Add("mv_valoricms", typeof(decimal));
            tb.Columns.Add("mv_valoripi", typeof(decimal));
            tb.Columns.Add("pis", typeof(decimal));
            tb.Columns.Add("cofins", typeof(decimal));
            tb.Columns.Add("irpj", typeof(decimal));
            tb.Columns.Add("csll", typeof(decimal));
            tb.Columns.Add("simples", typeof(decimal));
            tb.Columns.Add("mv_custo", typeof(decimal));
            tb.Columns.Add("cmvAj", typeof(decimal));
            tb.Columns.Add("cmvAjCorr", typeof(decimal));
            tb.Columns.Add("vendaLiq", typeof(decimal));
            tb.Columns.Add("margemB", typeof(decimal));
            tb.Columns.Add("mb", typeof(decimal));
            tb.Columns.Add("vdd");

            for (int i = 0; i < doc.Count; i++)
            {
                tb.Rows.Add(emp[i], data[i], doc[i], codCli[i], cli[i], classe[i], grupo[i], prod[i], codProd[i], qtde[i], uni[i], preco[i], total[i], valorN[i], valorIcms[i], valorIpi[i], pis[i], cofins[i], irpj[i], csll[i], simples[i], cmv[i], cmvAj[i], cmvAjCorr[i], vendaLiq[i], margemBruta[i], mb[i], vend[i]);
            }
            for (int i = 0; i < docNeg.Count; i++)
            {
                tb.Rows.Add(empNeg[i], dataNeg[i], docNeg[i], codCliNeg[i], cliNeg[i], classeNeg[i], grupoNeg[i], prodNeg[i], codProdNeg[i], qtdeNeg[i], uniNeg[i], precoNeg[i], totalNeg[i], valorNNeg[i], valorIcmsNeg[i], valorIpiNeg[i], pisNeg[i], cofinsNeg[i], irpjNeg[i], csllNeg[i], simplesNeg[i], cmvNeg[i], cmvAjNeg[i], cmvAjCorrNeg[i], vendaLiqNeg[i], margemBrutaNeg[i], mbNeg[i], vendNeg[i]);
            }
            dataGridView1.DataSource = tb;
        }

        public void preencheTabela2()
        {
            var tb = new DataTable();
            tb.Columns.Add("vdd");
            tb.Columns.Add("somaTt", typeof(decimal));
            tb.Columns.Add("somaMargem", typeof(decimal));
            tb.Columns.Add("percentMargem", typeof(decimal));

            for (int i = 0; i < vendTot.Count; i++)
            {
                tb.Rows.Add(vendTot[i], valorNTot[i], mbTot[i], percentMbTot[i]);
            }
            dataGridView2.DataSource = tb;
        }

        public void localizaDadosPosi()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "SELECT emp_razao, nt_data, mv_documento, mv_agente, cli_nome, clg_descricao, grp_descricao, MID(MV_Descricao,1,100) as 'MV_Descricao', mv_item, round(mv_quantidade, 2) as 'mv_quantidade', " +
                    "mv_unidade, round(mv_preco, 2) as 'mv_preco', round(mv_total, 2) as 'mv_total', round(mv_valoricms, 2) as 'mv_valoricms', round(mv_valoripi, 2) as 'mv_valoripi', round(mv_custo, 2) as 'mv_custo', nt_vendedor " +
                    "FROM((((((movimentos INNER JOIN notas ON movimentos.mv_empresa = notas.nt_empresa AND movimentos.mv_agente = notas.nt_agente AND movimentos.mv_documento = notas.nt_documento) " +
                    "INNER JOIN itens ON movimentos.mv_item = itens.itm_codigo) INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) INNER JOIN grupos ON itens.itm_grupo = grupos.grp_codigo) " +
                    "INNER JOIN classes ON itens.itm_classe = classes.clg_codigo) INNER JOIN clientes ON movimentos.mv_agente = clientes.cli_codigo) " +
                    "INNER JOIN empresas ON empresas.emp_codigo = mv_empresa WHERE notas.nt_data between '"+inferior+"' and '"+superior+"'AND " +
                    "notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'V' Order by -notas.nt_data, movimentos.mv_agente, movimentos.mv_item";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader contro = dao.Query.ExecuteReader();
            while (contro.Read())
            {
                emp.Add(contro["emp_razao"].ToString());
                data.Add(Convert.ToDateTime(contro["nt_data"]));
                doc.Add(contro["mv_documento"].ToString());
                codCli.Add(contro["mv_agente"].ToString());
                cli.Add(contro["cli_nome"].ToString());
                classe.Add(contro["clg_descricao"].ToString());
                grupo.Add(contro["grp_descricao"].ToString());
                prod.Add(contro["MV_Descricao"].ToString());
                codProd.Add(contro["mv_item"].ToString());
                qtde.Add(contro["mv_quantidade"].ToString());
                uni.Add(contro["mv_unidade"].ToString());
                preco.Add(contro["mv_preco"].ToString());
                total.Add(contro["mv_total"].ToString());
                valorIcms.Add(contro["mv_valoricms"].ToString());
                valorIpi.Add(contro["mv_valoripi"].ToString());
                cmv.Add(contro["mv_custo"].ToString());
                vend.Add(contro["nt_vendedor"].ToString());
            }
            contro.Close();
            dao.Desconecta();

            for(int i = 0; i < doc.Count; i++)
            {
                valorN.Add(String.Format("{0:0.00}", (Convert.ToDecimal(total[i]) + Convert.ToDecimal(valorIpi[i]))));
                if(emp[i] == "Empresa Teste")
                {
                    pis.Add("0");
                    cofins.Add("0");
                    irpj.Add("0");
                    csll.Add("0");
                }
                else
                {
                    pis.Add(Convert.ToDecimal(((Convert.ToDouble(valorN[i]) - Convert.ToDouble(valorIpi[i])) * 0.0065)).ToString());
                    cofins.Add(((Convert.ToDouble(valorN[i]) - Convert.ToDouble(valorIpi[i])) * 0.03).ToString());
                    irpj.Add((((Convert.ToDouble(valorN[i]) - Convert.ToDouble(valorIpi[i])) * 0.08) * 0.15).ToString());
                    csll.Add((((Convert.ToDouble(valorN[i]) - Convert.ToDouble(valorIpi[i])) * 0.12) * 0.09).ToString());
                }
                cmvAj.Add((Convert.ToDouble(cmv[i]) * Convert.ToDouble(qtde[i])).ToString());
                cmvAjCorr.Add((Convert.ToDouble(cmvAj[i]) - Convert.ToDouble(valorIcms[i])).ToString());
                if (emp[i] == "A. C. Machado E Cia. Ltda.")
                {
                    simples.Add("0");
                    vendaLiq.Add(String.Format("{0:0.00}", (Convert.ToDouble(valorN[i]) - Convert.ToDouble(valorIcms[i]) - Convert.ToDouble(valorIpi[i]) - Convert.ToDouble(pis[i]) - Convert.ToDouble(cofins[i]) - Convert.ToDouble(irpj[i]) - Convert.ToDouble(csll[i]))));
                }
                else if (emp[i] == "B.C.MACHADO LTDA.")
                {
                    simples.Add((Convert.ToDouble(valorN[i]) * 0.0812).ToString());
                    vendaLiq.Add(String.Format("{0:0.00}", (Convert.ToDouble(valorN[i]) - Convert.ToDouble(simples[i]))));
                }
                else
                {
                    simples.Add("0");
                    vendaLiq.Add(valorN[i]);
                }
                margemBruta.Add((Convert.ToDouble(vendaLiq[i]) - Convert.ToDouble(cmvAjCorr[i])).ToString());
                if (valorN[i] != "0,00")
                    mb.Add(String.Format("{0:0.00}", (Convert.ToDouble(margemBruta[i]) / Convert.ToDouble(valorN[i]) * 100)));
                else
                    mb.Add("0");
            }
        }

        public void localizaDadosNeg()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "SELECT emp_razao, nt_data, mv_documento, mv_agente, cli_nome, clg_descricao, grp_descricao, MID(MV_Descricao,1,100) as 'MV_Descricao', mv_item, round(mv_quantidade, 2) as 'mv_quantidade', " +
                    "mv_unidade, round((mv_preco * -1), 2) as 'mv_preco', round((mv_total * -1), 2) as 'mv_total', round((mv_valoricms * -1), 2) as 'mv_valoricms' , round((mv_valoripi * -1), 2) as 'mv_valoripi', round((if(mv_custo = '0', itm_custo, mv_custo) * -1), 2) as 'mv_custo', nt_vendedor " +
                    "FROM((((((movimentos INNER JOIN notas ON movimentos.mv_empresa = notas.nt_empresa AND movimentos.mv_agente = notas.nt_agente AND movimentos.mv_documento = notas.nt_documento) "+
                    "INNER JOIN itens ON movimentos.mv_item = itens.itm_codigo) INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) INNER JOIN grupos ON itens.itm_grupo = grupos.grp_codigo) "+
                    "INNER JOIN classes ON itens.itm_classe = classes.clg_codigo) INNER JOIN clientes ON movimentos.mv_agente = clientes.cli_codigo) "+
                    "INNER JOIN empresas ON empresas.emp_codigo = mv_empresa WHERE notas.nt_data between '" + inferior + "' and '" + superior + "' AND notas.nt_cancelada = 0 AND " +
                    "tipomovi.tmv_grupo = 'D' AND tipomovi.tmv_tipo = 'E' Order by notas.nt_data, movimentos.mv_agente, movimentos.mv_item";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader contro = dao.Query.ExecuteReader();
            while (contro.Read())
            {
                empNeg.Add(contro["emp_razao"].ToString());
                dataNeg.Add(Convert.ToDateTime(contro["nt_data"]));
                docNeg.Add(contro["mv_documento"].ToString());
                codCliNeg.Add(contro["mv_agente"].ToString());
                cliNeg.Add(contro["cli_nome"].ToString());
                classeNeg.Add(contro["clg_descricao"].ToString());
                grupoNeg.Add(contro["grp_descricao"].ToString());
                prodNeg.Add(contro["MV_Descricao"].ToString());
                codProdNeg.Add(contro["mv_item"].ToString());
                qtdeNeg.Add(contro["mv_quantidade"].ToString());
                uniNeg.Add(contro["mv_unidade"].ToString());
                precoNeg.Add(contro["mv_preco"].ToString());
                totalNeg.Add(contro["mv_total"].ToString());
                valorIcmsNeg.Add(contro["mv_valoricms"].ToString());
                valorIpiNeg.Add(contro["mv_valoripi"].ToString());
                cmvNeg.Add(contro["mv_custo"].ToString());
                vendNeg.Add(contro["nt_vendedor"].ToString());
            }
            contro.Close();
            dao.Desconecta();

            for (int i = 0; i < docNeg.Count; i++)
            {
                valorNNeg.Add(String.Format("{0:0.00}", (Convert.ToDecimal(totalNeg[i]) + Convert.ToDecimal(valorIpiNeg[i]))));
                if (empNeg[i] == "Empresa Teste")
                {
                    pisNeg.Add("0");
                    cofinsNeg.Add("0");
                    irpjNeg.Add("0");
                    csllNeg.Add("0");
                }
                else
                {
                    pisNeg.Add(Convert.ToDecimal(((Convert.ToDouble(valorNNeg[i]) - Convert.ToDouble(valorIpiNeg[i])) * 0.0065)).ToString());
                    cofinsNeg.Add(((Convert.ToDouble(valorNNeg[i]) - Convert.ToDouble(valorIpiNeg[i])) * 0.03).ToString());
                    irpjNeg.Add((((Convert.ToDouble(valorNNeg[i]) - Convert.ToDouble(valorIpiNeg[i])) * 0.08) * 0.15).ToString());
                    csllNeg.Add((((Convert.ToDouble(valorNNeg[i]) - Convert.ToDouble(valorIpiNeg[i])) * 0.12) * 0.09).ToString());
                }
                cmvAjNeg.Add((Convert.ToDouble(cmvNeg[i]) * Convert.ToDouble(qtdeNeg[i])).ToString());
                cmvAjCorrNeg.Add((Convert.ToDouble(cmvAjNeg[i]) - Convert.ToDouble(valorIcmsNeg[i])).ToString());
                if (empNeg[i] == "A. C. Machado E Cia. Ltda.")
                {
                    simplesNeg.Add("0");
                    vendaLiqNeg.Add(String.Format("{0:0.00}", (Convert.ToDouble(valorNNeg[i]) - Convert.ToDouble(valorIcmsNeg[i]) - Convert.ToDouble(valorIpiNeg[i]) - Convert.ToDouble(pisNeg[i]) - Convert.ToDouble(cofinsNeg[i]) - Convert.ToDouble(irpjNeg[i]) - Convert.ToDouble(csllNeg[i]))));
                }
                else if (empNeg[i] == "B.C.MACHADO LTDA.")
                {
                    simplesNeg.Add((Convert.ToDouble(valorNNeg[i]) * 0.0812).ToString());
                    vendaLiqNeg.Add(String.Format("{0:0.00}", (Convert.ToDouble(valorNNeg[i]) - Convert.ToDouble(simplesNeg[i]))));
                }
                else
                {
                    simplesNeg.Add("0");
                    vendaLiqNeg.Add(valorN[i]);
                }
                margemBrutaNeg.Add((Convert.ToDouble(vendaLiqNeg[i]) - Convert.ToDouble(cmvAjCorrNeg[i])).ToString());
                mbNeg.Add(String.Format("{0:0.00}", ((Convert.ToDouble(margemBrutaNeg[i]) / Convert.ToDouble(valorNNeg[i]) * 100))));
            }
        }

        public void localizaDadosPosi2()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");
             
            Sql = "select nt_vendedor, vdd_nome " +
                    "FROM(((((((movimentos INNER JOIN notas ON movimentos.mv_empresa = notas.nt_empresa AND movimentos.mv_agente = notas.nt_agente AND movimentos.mv_documento = notas.nt_documento) " +
                    "INNER JOIN itens ON movimentos.mv_item = itens.itm_codigo) INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) INNER JOIN grupos ON itens.itm_grupo = grupos.grp_codigo) " +
                    "INNER JOIN classes ON itens.itm_classe = classes.clg_codigo) INNER JOIN clientes ON movimentos.mv_agente = clientes.cli_codigo) " +
                    "INNER JOIN empresas ON empresas.emp_codigo = mv_empresa) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo WHERE notas.nt_data between '" + inferior + "' and '" + superior + "'AND " +
                    "notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'V' group by nt_vendedor Order by nt_vendedor;";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader contro = dao.Query.ExecuteReader();
            while (contro.Read())
            {
                nomeTot.Add(contro["nt_vendedor"].ToString());
                vendTot.Add(contro["vdd_nome"].ToString());
            }
            contro.Close();
            dao.Desconecta();

            decimal total = 0;
            decimal margemB = 0;
            decimal totalTot = 0;
            decimal margemBTot = 0;

            for (int i = 0; i < nomeTot.Count; i++)
            {
                for(int y = 0; y < doc.Count; y++)
                {
                    if (vend[y] == nomeTot[i])
                    {
                        total = total + Convert.ToDecimal(valorN[y]);
                        margemB = margemB + Convert.ToDecimal(margemBruta[y]);
                        totalTot = totalTot + Convert.ToDecimal(valorN[y]);
                        margemBTot = margemBTot + Convert.ToDecimal(margemBruta[y]);
                    }
                }
                valorNTot.Add(String.Format("{0:0.00}", total));
                mbTot.Add(String.Format("{0:0.00}", margemB));
                total = 0;
                margemB = 0;
            }
        }
        public void localizaDadosNeg2()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            Sql = "select nt_vendedor, vdd_nome " +
                    "FROM(((((((movimentos INNER JOIN notas ON movimentos.mv_empresa = notas.nt_empresa AND movimentos.mv_agente = notas.nt_agente AND movimentos.mv_documento = notas.nt_documento) " +
                    "INNER JOIN itens ON movimentos.mv_item = itens.itm_codigo) INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) INNER JOIN grupos ON itens.itm_grupo = grupos.grp_codigo) " +
                    "INNER JOIN classes ON itens.itm_classe = classes.clg_codigo) INNER JOIN clientes ON movimentos.mv_agente = clientes.cli_codigo) " +
                    "INNER JOIN empresas ON empresas.emp_codigo = mv_empresa) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo WHERE notas.nt_data between '" + inferior + "' and '" + superior + "'AND " +
                    "notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'V' group by nt_vendedor Order by nt_vendedor;";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader contro = dao.Query.ExecuteReader();
            while (contro.Read())
            {
                nomeTotNeg.Add(contro["nt_vendedor"].ToString());
                vendTotNeg.Add(contro["vdd_nome"].ToString());
            }
            contro.Close();
            dao.Desconecta();

            decimal totalTot = 0;
            decimal margemBTot = 0;

            for (int i = 0; i < nomeTotNeg.Count; i++)
            {
                for (int y = 0; y < docNeg.Count; y++)
                {
                    if (vendNeg[y] == nomeTotNeg[i])
                    {
                        valorNTot[i] = String.Format("{0:0.00}", Convert.ToDecimal(valorNTot[i]) + Convert.ToDecimal(valorNNeg[y]));
                        mbTot[i] = String.Format("{0:0.00}", Convert.ToDecimal(mbTot[i]) + Convert.ToDecimal(margemBrutaNeg[y]));
                    }
                }
            }

            for (int i = 0; i < vendTot.Count; i++)
            {
                totalTot = Convert.ToDecimal(totalTot) + Convert.ToDecimal(valorNTot[i]);
                margemBTot = Convert.ToDecimal(margemBTot) + Convert.ToDecimal(mbTot[i]);
                percentMbTot.Add(String.Format("{0:0.00}", (Convert.ToDecimal(mbTot[i]) / Convert.ToDecimal(valorNTot[i]) * 100)));
            }
            vendTot.Add("TOTAL");
            valorNTot.Add(String.Format("{0:0.00}", totalTot));
            mbTot.Add(String.Format("{0:0.00}", margemBTot));
            percentMbTot.Add(String.Format("{0:0.00}", (margemBTot / totalTot * 100)));
        }

        public void limpaTabela()
        {
            nomeTot.Clear();
            nomeTotNeg.Clear();
            emp.Clear();
            data.Clear();
            doc.Clear();
            codCli.Clear();
            cli.Clear();
            classe.Clear();
            grupo.Clear();
            prod.Clear();
            codProd.Clear();
            qtde.Clear();
            uni.Clear();
            preco.Clear();
            total.Clear();
            valorN.Clear();
            valorIcms.Clear();
            valorIpi.Clear();
            pis.Clear();
            cofins.Clear();
            irpj.Clear();
            csll.Clear();
            simples.Clear();
            cmv.Clear();
            cmvAj.Clear();
            cmvAjCorr.Clear();
            vendaLiq.Clear();
            margemBruta.Clear();
            mb.Clear();
            vend.Clear();
            empNeg.Clear();
            dataNeg.Clear();
            docNeg.Clear();
            codCliNeg.Clear();
            cliNeg.Clear();
            classeNeg.Clear();
            grupoNeg.Clear();
            prodNeg.Clear();
            codProdNeg.Clear();
            qtdeNeg.Clear();
            uniNeg.Clear();
            precoNeg.Clear();
            totalNeg.Clear();
            valorNNeg.Clear();
            valorIcmsNeg.Clear();
            valorIpiNeg.Clear();
            pisNeg.Clear();
            cofinsNeg.Clear();
            irpjNeg.Clear();
            csllNeg.Clear();
            simplesNeg.Clear();
            cmvNeg.Clear();
            cmvAjNeg.Clear();
            cmvAjCorrNeg.Clear();
            vendaLiqNeg.Clear();
            margemBrutaNeg.Clear();
            mbNeg.Clear();
            vendNeg.Clear();
            valorNTot.Clear();
            valorNTotNeg.Clear();
            vendTot.Clear();
            vendTotNeg.Clear();
            mbTot.Clear();
            mbTotNeg.Clear();
            percentMbTot.Clear();
            percentMbTotNeg.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }

        public Controladoria()
        {
            InitializeComponent();
        }

        private void controladoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaControladoria = 0;
        }

        private void controladoria_Load(object sender, EventArgs e)
        {
            DateTime aux1 = DateTime.Parse("01"+DateTime.Now.ToString("/MM/yyyy"));
            DateTime aux2 = aux1.AddMonths(1);
            DateTime aux3 = aux2.AddDays(-1);
            inferiorMtxt.Text = aux1.ToString("01/MM/yyyy");
            superiorMtxt.Text = aux3.ToString("dd/MM/yyyy");
            backgroundWorker1.RunWorkerAsync();
        }

        private void excelBt_Click(object sender, EventArgs e)
        {
            int z = 0;
            double[,] x = new double[dataGridView1.RowCount, 17];
            string[,] x1 = new string[dataGridView1.RowCount, 11];
            double[,] x2 = new double[dataGridView2.RowCount, 3];
            string[,] x3 = new string[dataGridView2.RowCount, 1];

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel|*.xlsx";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                Excel ex = new Excel();
                ex.CreateFile();
                ex.CreateSheet();
                ex.SavaAs(sfd.FileName);
                ex.Close();
                Excel ex2 = new Excel(sfd.FileName, "");
                ex2.WriteCell3(1, 0, 0, "EMPRESA");
                ex2.WriteCell3(1, 0, 1, "DATA");
                ex2.WriteCell3(1, 0, 2, "DOCUMENTO");
                ex2.WriteCell3(1, 0, 3, "CÓDIGO DO CLIENTE");
                ex2.WriteCell3(1, 0, 4, "NOME DO CLIENTE");
                ex2.WriteCell3(1, 0, 5, "CLASSE");
                ex2.WriteCell3(1, 0, 6, "GRUPO");
                ex2.WriteCell3(1, 0, 7, "DESCRIÇÃO DO ÍTEM");
                ex2.WriteCell3(1, 0, 8, "CÓDIGO DO ITEM");
                ex2.WriteCell3(1, 0, 9, "QTD DA NOTA");
                ex2.WriteCell3(1, 0, 10, "UND NOTA");
                ex2.WriteCell3(1, 0, 11, "PREÇO UNIT. NOTA");
                ex2.WriteCell3(1, 0, 12, "VALOR TOT. ITEM");
                ex2.WriteCell3(1, 0, 13, "VALOR TT NOTA");
                ex2.WriteCell3(1, 0, 14, "VALOR ICMS");
                ex2.WriteCell3(1, 0, 15, "VALOR IPI");
                ex2.WriteCell3(1, 0, 16, "PIS");
                ex2.WriteCell3(1, 0, 17, "COFINS");
                ex2.WriteCell3(1, 0, 18, "IRPJ");
                ex2.WriteCell3(1, 0, 19, "CSLL");
                ex2.WriteCell3(1, 0, 20, "SIMPLES");
                ex2.WriteCell3(1, 0, 21, "CMV");
                ex2.WriteCell3(1, 0, 22, "CMV AJ");
                ex2.WriteCell3(1, 0, 23, "CMV AJ CORR");
                ex2.WriteCell3(1, 0, 24, "VENDA LIQ");
                ex2.WriteCell3(1, 0, 25, "MARGEM BRUTA");
                ex2.WriteCell3(1, 0, 26, "MB%");
                ex2.WriteCell3(1, 0, 27, "VENDEDOR");
                ex2.WriteCell3(2, 0, 0, "VENDEDOR");
                ex2.WriteCell3(2, 0, 1, "SOMA VALOR TT DA NOTA");
                ex2.WriteCell3(2, 0, 2, "SOMA MARGEM BRUTA");
                ex2.WriteCell3(2, 0, 3, "% MARGEM BRUTA");


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    DateTime aux = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);
                    x1[z, 0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    x1[z, 1] = aux.ToString("dd/MM/yyyy");
                    x1[z, 2] = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    x1[z, 3] = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    x1[z, 4] = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    x1[z, 5] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    x1[z, 6] = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    x1[z, 7] = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    x1[z, 8] = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    x1[z, 9] = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    x1[z, 10] = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    x[z, 0] = Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value);
                    x[z, 1] = Convert.ToDouble(dataGridView1.Rows[i].Cells[12].Value);
                    x[z, 2] = Convert.ToDouble(dataGridView1.Rows[i].Cells[13].Value);
                    x[z, 3] = Convert.ToDouble(dataGridView1.Rows[i].Cells[14].Value);
                    x[z, 4] = Convert.ToDouble(dataGridView1.Rows[i].Cells[15].Value);
                    x[z, 5] = Convert.ToDouble(dataGridView1.Rows[i].Cells[16].Value);
                    x[z, 6] = Convert.ToDouble(dataGridView1.Rows[i].Cells[17].Value);
                    x[z, 7] = Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value);
                    x[z, 8] = Convert.ToDouble(dataGridView1.Rows[i].Cells[19].Value);
                    x[z, 9] = Convert.ToDouble(dataGridView1.Rows[i].Cells[20].Value);
                    x[z, 10] = Convert.ToDouble(dataGridView1.Rows[i].Cells[21].Value);
                    x[z, 11] = Convert.ToDouble(dataGridView1.Rows[i].Cells[22].Value);
                    x[z, 12] = Convert.ToDouble(dataGridView1.Rows[i].Cells[23].Value);
                    x[z, 13] = Convert.ToDouble(dataGridView1.Rows[i].Cells[24].Value);
                    x[z, 14] = Convert.ToDouble(dataGridView1.Rows[i].Cells[25].Value);
                    x[z, 15] = Convert.ToDouble(dataGridView1.Rows[i].Cells[26].Value);
                    x[z, 16] = Convert.ToDouble(dataGridView1.Rows[i].Cells[27].Value);

                    z++;
                }
                z = 0;
                for(int i = 0; i < dataGridView2.RowCount; i++)
                {
                    x3[z, 0] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    x2[z, 0] = Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value);
                    x2[z, 1] = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value);
                    x2[z, 2] = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);

                    z++;
                }
                ex2.WriteRange(2, 1, dataGridView1.RowCount + 1, 11, 1, x1);
                ex2.WriteRange2(2, 12, dataGridView1.RowCount + 1, 28, 1, x);
                ex2.WriteRange(2, 1, dataGridView2.RowCount + 1, 1, 2, x3);
                ex2.WriteRange2(2, 2, dataGridView2.RowCount + 1, 4, 2, x2);
                ex2.AjustarColunas(1, "A", "AB");
                ex2.AjustarColunas(2, "A", "D");
                ex2.Negrito(1, "A1:AB1");
                ex2.Negrito(2, "A1:D1");
                ex2.Negrito(2, "A" + (dataGridView2.RowCount + 1).ToString()+":D"+ (dataGridView2.RowCount + 1).ToString());
                ex2.Save();
                ex2.Close();
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            limpaTabela();
            localizaDadosPosi();
            localizaDadosNeg();
            montaTabela();
            preecheTabela();
            localizaDadosPosi2();
            localizaDadosNeg2();
            montaTabela2();
            preencheTabela2();
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == dataGridView2.RowCount -1)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            localizaDadosPosi();
            localizaDadosNeg();
            localizaDadosPosi2();
            localizaDadosNeg2();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            montaTabela();
            preecheTabela();
            montaTabela2();
            preencheTabela2();
        }
    }
}
