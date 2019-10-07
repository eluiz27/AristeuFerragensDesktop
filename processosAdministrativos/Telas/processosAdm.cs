using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class processosAdm : Form
    {
        DAO dao = new DAO();
        controlTelaAberta cta = new controlTelaAberta();
        int aux, aux2 = 0;
        private string Sql = String.Empty;
        List<string> banner = new List<string>();

        private static string codUsuario = string.Empty;

        public string CodUsuario { get => codUsuario; set => codUsuario = value; }

        public void consultaBanco()
        {
            Sql = "SELECT banrot_img FROM banner_rotativo WHERE banrot_validade > '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            try
            {
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                MySqlDataReader vdd = dao.Query.ExecuteReader();
                banner.Clear();
                while (vdd.Read())
                {
                    banner.Add(vdd["banrot_img"].ToString());
                }
                dao.desconecta();
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro, contate o suporte!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public processosAdm()
        {
            InitializeComponent();
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
        private void indicadoresDePerformânceToolStripMenuItem_Click(object sender, EventArgs e)
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
                restricoes res = new restricoes();
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

        private void ChamadasTelefoneToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void ConfiguraçãoDeRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(banner.Count > 0)
            {
                if (aux2 < (banner.Count - 1))
                {
                    aux2++;
                    novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
                }
                else
                {
                    aux2 = 0;
                    novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(aux == 0)
            {
                timer1.Stop();
                timer2.Stop();
                aux = 1;
            }
            else
            {
                timer1.Start();
                timer2.Start();
                aux = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (banner.Count > 0)
            {
                if (aux2 < banner.Count - 1)
                {
                    aux2++;
                    novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
                }
                else
                {
                    aux2 = 0;
                    novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (banner.Count > 0)
            { 
                if (aux2 > 0)
                {
                    aux2--;
                    novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
                }
                else
                {
                    aux2 = banner.Count - 1;
                    novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
                }
            }
        }

        private void processosAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void salvarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
            saveFileDialog1.Title = "Salvar um arquivo de imagem";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            this.novidadePb.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            this.novidadePb.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }
                    fs.Close();
                    saveFileDialog1.FileName = "";
                }
                MessageBox.Show("Imagem salva com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            timer1.Start();
        }

        private void processosAdm_Load(object sender, EventArgs e)
        {
            consultaBanco();
            timer2.Start();
            if(banner.Count > 0)
                novidadePb.Image = new Bitmap(@"\\poseidon\sistemas\Processos Administrativos\Banners\" + banner[aux2]);
            timer1.Start();
            timer3.Start();
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

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now.ToString("HH:mm:ss") == "08:10:00")
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

        private void Timer4_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now.ToString("HH:mm:ss") == "20:00:00")
            {
                CopiaVendas cv = new CopiaVendas();
                cv.Copia();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            consultaBanco();
            novidadePb.Refresh();
        }
    }
}
