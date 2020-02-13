using processosAdministrativos.Classes;
using processosAdministrativos.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class Principal : Form
    {
        controlTelaAberta cta = new controlTelaAberta();
        ValoresGraficos vg = new ValoresGraficos();
        RestricaoConfig res = new RestricaoConfig();

        List<double> varsFatValor = new List<double>();
        List<double> varsPedValor = new List<double>();
        List<double> varsMeta = new List<double>();
        List<double> linhas = new List<double>();
        int validaDash = 0;

        string enviarMV = Path.GetFullPath("EnviarMV\\Usuario.txt");
        public static string[] linhasMV;

        public List<int> Setor { get; set; }

        int vdd1 = 0;
        int vdd2 = 0;

        int fecharTela = 1;

        int cont = 0;

        public void restricao()
        {
            List<int> aux = new List<int>();
            
            foreach(int lista in res.RestricMenu())
            {
                aux.Add(lista);
            }

            if (aux[0] == 0)
                comprasToolStripMenuItem.Enabled = false;
            if (aux[1] == 0)
                expediçãoToolStripMenuItem.Enabled = false;
            if (aux[2] == 0)
                estoqueToolStripMenuItem.Enabled = false;
            if (aux[3] == 0)
                financeiroToolStripMenuItem.Enabled = false;
            if (aux[4] == 0)
                vendasToolStripMenuItem.Enabled = false;
            if (aux[5] == 0)
                marketingToolStripMenuItem.Enabled = false;
            if (aux[6] == 0)
                atendimentoToolStripMenuItem.Enabled = false;
            if (aux[7] == 0)
                utilitáriosToolStripMenuItem.Enabled = false;

            if (res.Dash == "1")
                lojaBt.Enabled = true;
        }

        public void DadosGraficoFatValor()
        {
            double a = vg.graficoFatDia(vdd1, vdd2)[0];
            double b = vg.graficoFatMes(vdd1, vdd2)[0];
            double total = a + b;

            varsFatValor.Add(a);
            varsFatValor.Add(b);
            varsFatValor.Add(total);
        }

        public void PreencheGraficoFatValor()
        {
            totalFatLb.Text = "Total: ";

            graficoFat.Series["valor"].Points.Clear();

            graficoFat.Series["valor"].IsValueShownAsLabel = true;

            graficoFat.Series["valor"].Points.AddXY("Dia", varsFatValor[0].ToString("C2"));
            graficoFat.Series["valor"].Points.AddXY("Mês", varsFatValor[1]);

            graficoFat.Series["valor"].Points[0].Color = Color.IndianRed;
            graficoFat.Series["valor"].Points[0].LabelForeColor = Color.Black;
            graficoFat.Series["valor"].Points[1].Color = Color.DodgerBlue;
            graficoFat.Series["valor"].Points[1].LabelForeColor = Color.Black;

            graficoFat.Series["valor"].LabelFormat = "C2";

            totalFatLb.Text = (totalFatLb.Text + varsFatValor[2].ToString("C2")).ToString();

            varsFatValor.Clear();
        }

        public void GraficoFaturamentoQtde()
        {
            totalFatLb.Text = "Total: ";

            double a = vg.graficoFatDia(vdd1, vdd2)[1];
            int b = Convert.ToInt32(vg.graficoFatMes(vdd1, vdd2)[1]);
            double total = a + b;

            graficoFat.Series["valor"].Points.Clear();

            graficoFat.Series["valor"].IsValueShownAsLabel = true;

            graficoFat.Series["valor"].Points.AddXY("Dia", a);
            graficoFat.Series["valor"].Points.AddXY("Mês", b);

            graficoFat.Series["valor"].Points[0].Color = Color.IndianRed;
            graficoFat.Series["valor"].Points[0].LabelForeColor = Color.Black;
            graficoFat.Series["valor"].Points[1].Color = Color.DodgerBlue;
            graficoFat.Series["valor"].Points[1].LabelForeColor = Color.Black;

            totalFatLb.Text = totalFatLb.Text + total;
        }

        public void DadosGraficoPedValor()
        {
            double a = vg.graficoPedAprov(vdd1, vdd2)[0];
            double b = vg.graficoPedCanc(vdd1, vdd2)[0];
            double c = vg.graficoPedDev(vdd1, vdd2)[0];
            double total = b + c;

            varsPedValor.Add(a);
            varsPedValor.Add(b);
            varsPedValor.Add(c);
            varsPedValor.Add(total);
        }

        public void PreencheGraficoPedValor()
        {
            aprovLb.Text = "Aprovados: ";
            cancDevLb.Text = "Canc/Devolu: ";

            graficoPed.Series["valor"].Points.Clear();

            graficoPed.Series["valor"].IsValueShownAsLabel = true;

            graficoPed.Series["valor"].Points.AddXY("Canceladas", varsPedValor[1]);
            graficoPed.Series["valor"].Points.AddXY("Devolvidas", varsPedValor[2]);

            graficoPed.Series["valor"].Points[0].Color = Color.Red;
            graficoPed.Series["valor"].Points[0].LabelForeColor = Color.Black;
            graficoPed.Series["valor"].Points[1].Color = Color.Gold;
            graficoPed.Series["valor"].Points[1].LabelForeColor = Color.Black;

            graficoPed.Series["valor"].LabelFormat = "C2";

            aprovLb.Text = (aprovLb.Text + varsPedValor[0].ToString("C2")).ToString();
            cancDevLb.Text = (cancDevLb.Text + varsPedValor[3].ToString("C2")).ToString();

            varsPedValor.Clear();
        }

        public void GraficoPedidosQtde()
        {
            aprovLb.Text = "Aprovados: ";
            cancDevLb.Text = "Canc/Devolu: ";

            double a = vg.graficoPedAprov(vdd1, vdd2)[1];
            double b = vg.graficoPedCanc(vdd1, vdd2)[1];
            double c = vg.graficoPedDev(vdd1, vdd2)[1];
            double total = b + c;
            graficoPed.Series["valor"].Points.Clear();

            graficoPed.Series["valor"].IsValueShownAsLabel = true;

            graficoPed.Series["valor"].Points.AddXY("Canceladas", b);
            graficoPed.Series["valor"].Points.AddXY("Devolvidas", c);

            graficoPed.Series["valor"].Points[0].Color = Color.Red;
            graficoPed.Series["valor"].Points[0].LabelForeColor = Color.Black;
            graficoPed.Series["valor"].Points[1].Color = Color.Gold;
            graficoPed.Series["valor"].Points[1].LabelForeColor = Color.Black;

            aprovLb.Text = aprovLb.Text + a;
            cancDevLb.Text = cancDevLb.Text + total;
        }

        public void DadosGraficoMeta()
        {
            double a = vg.graficoMetaFeito(vdd1, vdd2);
            double b = vg.graficoMetaSaldo(vdd1, vdd2) - a;
            double total = a + b;

            varsMeta.Add(a);
            varsMeta.Add(b);
            varsMeta.Add(total);
        }

        public void PreencheGraficoMeta()
        {
            metaLb.Text = "Meta: ";

            graficoMeta.Series["valor"].Points.Clear();

            graficoMeta.Series["valor"].IsValueShownAsLabel = true;

            if (varsMeta[1] < 0)
            {
                graficoMeta.Series["valor"].Points.AddXY("Realizado", varsMeta[0]);
                graficoMeta.Series["valor"].Points[0].Color = Color.Green;
                graficoMeta.Series["valor"].Points[0].LabelForeColor = Color.Black;
            }
            else
            {
                graficoMeta.Series["valor"].Points.AddXY("Realizado", varsMeta[0]);
                graficoMeta.Series["valor"].Points.AddXY("Saldo", varsMeta[1]);

                graficoMeta.Series["valor"].Points[0].Color = Color.Green;
                graficoMeta.Series["valor"].Points[0].LabelForeColor = Color.Black;
                graficoMeta.Series["valor"].Points[1].Color = Color.Red;
                graficoMeta.Series["valor"].Points[1].LabelForeColor = Color.Black;
            }

            graficoMeta.Series["valor"].LabelFormat = "C2";

            metaLb.Text = (metaLb.Text + (varsMeta[2]).ToString("C2")).ToString();

            varsMeta.Clear();
        }

        public void DadosGraficoLine()
        {
            vg.graficoLinha(vdd1, vdd2);
            for(int i = 0; i < 6; i++)
            {
                linhas.Add(vg.Valores[i]);
            }
            vg.Valores.Clear();
        }

        public void PreencheGraficoLinha()
        {
            graficoIndic.Series["valor"].Points.Clear();

            if(Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
            {
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.ToString("30/MM"), linhas[0]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.AddMonths(1).ToString("05/MM"), linhas[1]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.AddMonths(1).ToString("10/MM"), linhas[2]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.AddMonths(1).ToString("15/MM"), linhas[3]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.AddMonths(1).ToString("20/MM"), linhas[4]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.AddMonths(1).ToString("25/MM"), linhas[5]);
            }
            else
            {
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.AddMonths(-1).ToString("30/MM"), linhas[0]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.ToString("05/MM"), linhas[1]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.ToString("10/MM"), linhas[2]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.ToString("15/MM"), linhas[3]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.ToString("20/MM"), linhas[4]);
                graficoIndic.Series[0].Points.AddXY(DateTime.Now.ToString("25/MM"), linhas[5]);
            }

            graficoIndic.Series["valor"].Color = Color.Purple;

            graficoIndic.Series["valor"].LabelFormat = "C2";

            var chart = graficoIndic.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;

            linhas.Clear();
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void processosAdm_Load(object sender, EventArgs e)
        {
            restricao();
            timer3.Start();
            if (vg.LeVendedor() != 0)
            {
                textBox1.Text = vg.LeVendedor().ToString();
                vdd1 = Convert.ToInt32(textBox1.Text);
                vdd2 = Convert.ToInt32(textBox1.Text);
                backgroundWorker1.RunWorkerAsync();
                timer1.Start();
            }
            else
                fecharTela = 0;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            fecharTela = 1;
            DadosGraficoFatValor();
        }
        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DadosGraficoPedValor();
        }
        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DadosGraficoMeta();
        }
        private void backgroundWorker4_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DadosGraficoLine();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PreencheGraficoFatValor();
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PreencheGraficoPedValor();
            backgroundWorker3.RunWorkerAsync();
        }
        private void backgroundWorker3_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PreencheGraficoMeta();
            backgroundWorker4.RunWorkerAsync();
        }
        private void backgroundWorker4_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            PreencheGraficoLinha();
            qtdeFatBt.Enabled = true;
            qtdePedBt.Enabled = true;
            textBox1.Enabled = true;
            if (res.Dash == "1")
                lojaBt.Enabled = true;
            fecharTela = 0;
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadAssistTec == 0)
            {
                cadastroAssistencia ca = new cadastroAssistencia();
                ca.Show();
                cta.TelaCadAssistTec = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["cadastraAssistencia"].BringToFront();
            }
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaAssistTec == 0)
            {
                assistenciaTecnica at = new assistenciaTecnica();
                at.Show();
                cta.TelaAssistTec = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["assistenciaTecnica"].BringToFront();
            }
        }

        private void assistênciasTécnicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaAssistTec == 0)
            {
                assistenciaTecnica at = new assistenciaTecnica();
                at.Show();
                cta.TelaAssistTec = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["assistenciaTecnica"].BringToFront();
            }
        }
        private void controleDeEntregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaContEntre == 0)
            {
                controleEntreg pe = new controleEntreg();
                pe.Show();
                cta.TelaContEntre = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["controleEntreg"].BringToFront();
            }
        }
        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaEntrega == 0)
            {
                cta.TelaEntrega = 1;
                procuraEntrega pe = new procuraEntrega();
                pe.Show();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["procuraEntrega"].BringToFront();
            }
        }
        private void cadastroEstoquistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadEstoquista == 0)
            {
                cadastroEstoquista ce = new cadastroEstoquista();
                ce.Show();
                cta.TelaCadEstoquista = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["CadastroEstoquista"].BringToFront();
            }
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaContEstoq == 0)
            {
                controleEst ce = new controleEst();
                ce.Show();
                cta.TelaContEstoq = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["controleEst"].BringToFront();
            }
        }
        private void cadastroDeBannersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadBanner == 0)
            {
                campanhas cb = new campanhas();
                cb.Show();
                cta.TelaCadBanner = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["campanhas"].BringToFront();
            }
        }

        private void cadastroDeValidadePorLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadLote == 0)
            {
                consultaLote cl = new consultaLote();
                cl.Show();
                cta.TelaConsultaLote = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaLote"].BringToFront();
            }
        }
        private void armazenagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadLote == 0)
            {
                cadastroLote cl = new cadastroLote();
                cl.Show();
                cta.TelaCadLote = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["cadastroLote"].BringToFront();
            }
        }
        private void lOEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaLOE == 0)
            {
                LOE loe = new LOE();
                loe.Show();
                cta.TelaLOE = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["LOE"].BringToFront();
            }
        }
        private void consultaLOEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaConsultaLOE == 0)
            {
                cta.TelaConsultaLOE = 1;
                consultaLOE cloe = new consultaLOE();
                cloe.Show();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaLOE"].BringToFront();
            }
        }
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaConsultLOEComple == 0)
            {
                consultaCompletaLOE cce = new consultaCompletaLOE();
                cce.Show();
                cta.TelaConsultLOEComple = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaCompletaLOE"].BringToFront();
            }
        }
        private void consultaLOEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cta.TelaConsultaLOE == 0)
            {
                consultaLOE cloe = new consultaLOE();
                cloe.Show();
                cta.TelaConsultaLOE = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaLOE"].BringToFront();
            }
        }

        private void cadastroSituaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadastroSituacao == 0)
            {
                cadastraSituacao cf = new cadastraSituacao();
                cf.Show();
                cta.TelaCadastroSituacao = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["cadastraSituacao"].BringToFront();
            }
        }
        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cta.TelaConsultaFallowUp == 0)
            {
                consultaFallowUp cf = new consultaFallowUp();
                cf.Show();
                cta.TelaConsultaFallowUp = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaFallowUp"].BringToFront();
            }
        }

        private void codificaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCodificacao == 0)
            {
                codificacao c = new codificacao();
                c.Show();
                cta.TelaCodificacao = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["codificacao"].BringToFront();
            }
        }
        private void nDeSérieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaNSerie == 0)
            {
                nSerie ns = new nSerie();
                ns.Show();
                cta.TelaNSerie = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["nSerie"].BringToFront();
            }
        }
        private void consultaNºSérieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaConsultaNSerie == 0)
            {
                consultaNSerie cns = new consultaNSerie();
                cns.Show();
                cta.TelaConsultaNSerie = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaNSerie"].BringToFront();
            }
        }
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cta.TelaCadastraLoe == 0)
            {
                LOE loe = new LOE();
                loe.Show();
                cta.TelaCadastraLoe = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["LOE"].BringToFront();
            }
        }
        private void etiquetaDePreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaEtiquetaPreco == 0)
            {
                etiquetaPreco ep = new etiquetaPreco();
                ep.Show();
                cta.TelaEtiquetaPreco = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["etiquetaPreco"].BringToFront();
            }
        }
        private void contagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaContagem == 0)
            {
                contagem c = new contagem();
                c.Show();
                cta.TelaContagem = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["contagem"].BringToFront();
            }
        }
        private void comprasFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaComprasFunc == 0)
            {
                comprasFunc cf = new comprasFunc();
                cf.Show();
                cta.TelaComprasFunc = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["comprasFunc"].BringToFront();
            }
        }
        private void codificaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cta.TelaConsCodif == 0)
            {
                consultaCodificacao cc = new consultaCodificacao();
                cc.Show();
                cta.TelaConsCodif = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["consultaCodificacao"].BringToFront();
            }
        }
        private void ordemDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaOdemCompra == 0)
            {
                ordemCompra oc = new ordemCompra();
                oc.Show();
                cta.TelaOdemCompra = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["ordemCompra"].BringToFront();
            }
        }
        private void médiaDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaMediaVenda == 0)
            {
                mediaVendas mv = new mediaVendas();
                mv.Show();
                cta.TelaMediaVenda = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["mediaVendas"].BringToFront();
            }
        }
        private void fixadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCompra == 0)
            {
                comprar c = new comprar();
                c.Show();
                cta.TelaCompra = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["comprar"].BringToFront();
            }
        }
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCompraProd == 0)
            {
                cotacaoProd cp = new cotacaoProd();
                cp.Show();
                cta.TelaCompraProd = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["cotacaoProd"].BringToFront();
            }

        }
        private void controladoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaControladoria == 0)
            {
                controladoria ct = new controladoria();
                ct.Show();
                cta.TelaControladoria = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["controladoria"].BringToFront();
            }
        }

        private void restriçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaRestricoes == 0)
            {
                Restricoes res = new Restricoes();
                res.Show();
                cta.TelaRestricoes = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["restricoes"].BringToFront();
            }
        }

        private void metaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaMeta == 0)
            {
                meta met = new meta();
                cta.TelaMeta = 1;
                met.Show();
                variaveis var = new variaveis();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["meta"].BringToFront();
            }
        }

        private void etiquetaDePreçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if(cta.TelaEtiquetaPreco == 0)
            {
                etiquetaPreco ep = new etiquetaPreco();
                cta.TelaEtiquetaPreco = 1;
                ep.Show();
                variaveis var = new variaveis();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["etiquetaPreco"].BringToFront();
            }
        }
        private void clientesForaEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaCliForaEstado == 0)
            {
                ClienteForaEstado cfe = new ClienteForaEstado();
                cta.TelaCliForaEstado = 1;
                cfe.Show();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["ClienteForaEstado"].BringToFront();
            }
        }

        private void ConfiguraçãoDeRedeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (cta.TelaConfRede == 0)
            {
                ConfiguracaoRede cr = new ConfiguracaoRede();
                cta.TelaConfRede = 1;
                cr.Show();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["ConfiguracaoRede"].BringToFront();
            }
        }
        private void chamadasDeTelefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaChamadas == 0)
            {
                Ligacoes li = new Ligacoes();
                cta.TelaChamadas = 1;
                li.Show();
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["Ligacoes"].BringToFront();
            }
        }

        private void processosAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(fecharTela == 0)
            {
                if (MessageBox.Show("Tem certeza que deseja fechar?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
            else
            {
                e.Cancel = true;
            }
        }


        private void Timer3_Tick(object sender, EventArgs e)
        {
            linhasMV = File.ReadAllLines(enviarMV);

            if (linhasMV[0] == Environment.UserName.ToLower() && linhasMV[1] == Environment.MachineName.ToLower())
            {
                if (DateTime.Now.ToString("HH:mm:ss") == "08:10:00")
                {
                    if (cta.TelaMapaVendas == 0)
                    {
                        mapaVendasCompleto mv = new mapaVendasCompleto();
                        mv.Show();
                        cta.TelaMapaVendas = 1;
                    }
                    else
                    {
                        MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.OpenForms["mapaVendasCompleto"].BringToFront();
                    }
                }
            }
        }
        private void mapaDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaMapaVendas == 0)
            {
                mapaVendasCompleto mv = new mapaVendasCompleto();
                mv.Show();
                cta.TelaMapaVendas = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["mapaVendasCompleto"].BringToFront();
            }
        }
        private void indicadoresDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaIndicVendas == 0)
            {
                indicadoresVendas iv = new indicadoresVendas();
                iv.Show();
                cta.TelaIndicVendas = 1;
            }
            else
            {
                MessageBox.Show("Tela ja aberta!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.OpenForms["indicadoresVendas"].BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            qtdeFatBt.Enabled = false;
            qtdePedBt.Enabled = false;
            valorFatBt.Enabled = false;
            valorPedBt.Enabled = false;
            textBox1.Enabled = false;
            lojaBt.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valorFatBt.Enabled = false;
            DadosGraficoFatValor();
            PreencheGraficoFatValor();
            graficoFat.Series["valor"].LabelFormat = "C2";
            qtdeFatBt.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qtdeFatBt.Enabled = false;
            GraficoFaturamentoQtde();
            graficoFat.Series["valor"].LabelFormat = "";
            valorFatBt.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valorPedBt.Enabled = false;
            DadosGraficoPedValor();
            PreencheGraficoPedValor();
            graficoPed.Series["valor"].LabelFormat = "C2";
            qtdePedBt.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qtdePedBt.Enabled = false;
            GraficoPedidosQtde();
            graficoPed.Series["valor"].LabelFormat = "";
            valorPedBt.Enabled = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (validaDash == 0)
            { 
                if (e.KeyCode == Keys.Enter)
                {
                    if (textBox1.Text != string.Empty)
                    {
                        if (vg.Vendedor(Convert.ToInt32(textBox1.Text)) == false)
                        {
                            MessageBox.Show("Código de vendedor incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            validaDash = 1;
                        }
                        else
                        {
                            qtdeFatBt.Enabled = false;
                            qtdePedBt.Enabled = false;
                            valorFatBt.Enabled = false;
                            valorPedBt.Enabled = false;
                            textBox1.Enabled = false;
                            lojaBt.Enabled = false;
                            vdd1 = Convert.ToInt32(textBox1.Text);
                            vdd2 = Convert.ToInt32(textBox1.Text);
                            backgroundWorker1.RunWorkerAsync();
                            timer1.Start();
                            vg.GravarPesquisa(Convert.ToInt32(textBox1.Text));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo de vendedor obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validaDash = 1;
                    }
                }
            }
            else
                validaDash = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            qtdeFatBt.Enabled = false;
            qtdePedBt.Enabled = false;
            valorFatBt.Enabled = false;
            valorPedBt.Enabled = false;
            textBox1.Enabled = false;
            lojaBt.Enabled = false;
            vdd1 = 1;
            vdd2 = 99;
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
        }
    }
}
