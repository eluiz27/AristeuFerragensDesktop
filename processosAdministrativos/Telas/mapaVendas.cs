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
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Collections;
using Outlook = Microsoft.Office.Interop.Outlook;
using processosAdministrativos.Telas;

namespace processosAdministrativos
{
    public partial class mapaVendas : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        List<string> vdds = new List<string>();
        List<string> numAtend = new List<string>();
        List<string> numVend = new List<string>();
        List<string> prodPed = new List<string>();
        List<string> numOrc = new List<string>();
        List<string> orc = new List<string>();
        List<string> vend = new List<string>();
        List<string> mv = new List<string>();
        List<string> indVend = new List<string>();
        List<string> emailAux = new List<string>();
        List<string> grupoAux = new List<string>();
        int i = -1;
        int auxiliar = 0;

        public void vendedores()
        {
            Sql = "select vdd_codigo, vdd_nome from vendedores where vdd_codigo > 8 and vdd_codigo != 13 and vdd_situacao = 'A'";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.conecta();
            MySqlDataReader vdd = dao.Query.ExecuteReader();
            while (vdd.Read())
            {
                vdds.Add(vdd["vdd_codigo"].ToString());
            }
            dao.desconecta();
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
            dao.desconecta();
            emailAux.Clear();
            grupoAux.Clear();
        }

        public void proxVdd(int aux)
        {
            if (aux == 1 && i < vdds.Count-1)
            {
                i++;
            }
            else
            {
                if (aux == 0 && i > -1)
                {
                    i--;
                }
            }
            if (i >= 0 && i <= vdds.Count-1)
            {
                vendedorTxt.Text = vdds[i].ToString();
            }
            else
            {
                
            }           
        }
        public void loja()
        {
            double total;
            double venda;
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            querys qr = new querys();
            qr.selcTotal(inferior, superior);
            int atend = Convert.ToInt32(qr.NAtendL) + Convert.ToInt32(qr.NVendasL);

            total = qr.OrcamL + double.Parse(qr.VendasL);
            venda = Convert.ToDouble(qr.VendasL);

            nAtendTxt.Text = atend.ToString();
            nVendaTxt.Text = qr.NVendasL;
            nOrcTxt.Text = qr.NOrcamL;
            orcTxt.Text = string.Format("{0:0,0.00}", qr.OrcamL);
            vendaTxt.Text = string.Format("{0:0,0.00}", venda);
            totalTxt.Text = string.Format("{0:0,0.00}", total);
        }
        public void vendedorDados()
        {
            double total;
            double venda;
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            querys qr = new querys();
            qr.selecao(inferior, superior, int.Parse(vendedorTxt.Text));
            int atend = Convert.ToInt32(qr.NAtend) + Convert.ToInt32(qr.NVendas);

            total = qr.Orcam + double.Parse(qr.Vendas);
            venda = Convert.ToDouble(qr.Vendas);

            nAtendTxt.Text = atend.ToString();
            nVendaTxt.Text = qr.NVendas;
            nOrcTxt.Text = qr.NOrcam;
            orcTxt.Text = string.Format("{0:0,0.00}", qr.Orcam);
            vendaTxt.Text = string.Format("{0:0,0.00}", venda);
            totalTxt.Text = string.Format("{0:0,0.00}", total);
        }
        public void limpaVar()
        {
            numAtend.Clear();
            numVend.Clear();
            prodPed.Clear();
            numOrc.Clear();
            vend.Clear();
        }
        public void preenchePlanilha()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");
            int mes;

            if (Convert.ToInt32(aux1.ToString("dd")) <= 25)
                mes = Convert.ToInt32(aux1.ToString("MM"));
            else
                mes = Convert.ToInt32(aux1.AddMonths(1).ToString("MM"));

            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();

            excel ex = new excel(@"\\POSEIDON\documentos\Informatica\Luiz\MV\MV\MV_" + mesExtenso.Substring(0, 3).ToUpper() + "_"+aux1.ToString("yy")+".xlsx", "123");

            querys qr = new querys();

            for (int i = 0; i < vdds.Count; i++)
            {
                qr.selecao(inferior, superior, Convert.ToInt32(vdds[i]));
                int atend = Convert.ToInt32(qr.NAtend) + Convert.ToInt32(qr.NVendas);
                
                numAtend.Add(atend.ToString());
                numVend.Add(qr.NVendas);
                prodPed.Add(qr.ItensPed);
                numOrc.Add(qr.NOrcam);
                orc.Add(Math.Floor(qr.Orcam).ToString());
                vend.Add(Math.Floor(double.Parse(qr.Vendas)).ToString());

                ex.writeCell(i + 2, 5, 4, numAtend[i], aux1.ToString("dd"));
                ex.writeCell(i + 2, 5, 6, numVend[i], aux1.ToString("dd"));
                ex.writeCell(i + 2, 5, 12, prodPed[i], aux1.ToString("dd"));
                ex.writeCell(i + 2, 5, 18, numOrc[i], aux1.ToString("dd"));
                ex.writeCell(i + 2, 5, 19, orc[i], aux1.ToString("dd"));
                ex.writeCell(i + 2, 5, 20, vend[i], aux1.ToString("dd"));
            }
            qr.selcTotal(inferior, superior);
            int atendTot = Convert.ToInt32(qr.NAtendL) + Convert.ToInt32(qr.NVendasL);

            ex.writeCell(1, 5, 4, atendTot.ToString(), aux1.ToString("dd"));
            ex.writeCell(1, 5, 6, qr.NVendasL, aux1.ToString("dd"));
            ex.writeCell(1, 5, 12, qr.ItensPedL, aux1.ToString("dd"));
            ex.writeCell(1, 5, 18, qr.NOrcamL, aux1.ToString("dd"));
            ex.writeCell(1, 5, 19, Math.Floor(qr.OrcamL).ToString(), aux1.ToString("dd"));
            ex.writeCell(1, 5, 20, Math.Floor(double.Parse(qr.VendasL)).ToString(), aux1.ToString("dd"));

            ex.Save();
            ex.Close();
            preenchePlanilha2();
            limpaVar();
            String strCaminhoNomeArquivo = @"\\POSEIDON\documentos\Informatica\Luiz\MV\MV\MV_" + mesExtenso.Substring(0, 3).ToUpper() + "_" + aux1.ToString("yy") + ".xlsx";
            System.Diagnostics.Process.Start(strCaminhoNomeArquivo);

        }
        public void preenchePlanilha2()
        {
            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            String inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            String superior = aux2.ToString("yyyy-MM-dd 23:00:00");
            int y = 0;
            int z = 0;
            int mes;

            if (Convert.ToInt32(aux1.ToString("dd")) <= 25)
                mes = Convert.ToInt32(aux1.ToString("MM"));
            else
                mes = Convert.ToInt32(aux1.AddMonths(1).ToString("MM"));

            string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();
            excel ex = new excel(@"\\POSEIDON\documentos\Informatica\Luiz\MV\Vendedores\VDD_" + mesExtenso.Substring(0, 3).ToUpper() + "_"+aux1.ToString("yy")+".xlsx", "");
            excel e = new excel(@"\\POSEIDON\documentos\Informatica\Luiz\MV\MV\MV_" + mesExtenso.Substring(0, 3).ToUpper() + "_" + aux1.ToString("yy") + ".xlsx", "123");
            for (int i = 0; i < vdds.Count; i++)
            {
                if (vdds[i] != "027" && vdds[i] != "037")
                {
                    ex.writeCellIndic(y + 1, 3, 3, e.ReadCell2(i + 2, 5, 7, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 4, e.ReadCell2(i + 2, 5, 8, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 5, e.ReadCell2(i + 2, 5, 14, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 6, e.ReadCell2(i + 2, 5, 25, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 7, e.ReadCell2(i + 2, 5, 27, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 8, e.ReadCell2(i + 2, 5, 35, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 9, e.ReadCell2(i + 2, 5, 36, aux1.ToString("dd")), aux1.ToString("dd"));
                    ex.writeCellIndic(y + 1, 3, 10, e.ReadCell2(i + 2, 5, 17, aux1.ToString("dd")), aux1.ToString("dd"));
                    y++;
                }
            }
            for (int i = 0; i < vdds.Count; i++)
            {
                for (int w = 0; w < 8; w++)
                {
                    if (vdds[i] != "027" && vdds[i] != "037")
                    {
                        ex.writeCell3(ex.contaPastas(), z + 1, w + 1, ex.ReadCell3(z + 1, 3, w + 3, aux1.ToString("dd")));
                    }
                }
                if (vdds[i] != "027" && vdds[i] != "037")
                    z++;
            }

            e.Close();
            ex.Save();
            ex.Close();
        }
        public mapaVendas()
        {
            InitializeComponent();
        }

        private void mapa_vendas_Load(object sender, EventArgs e)
        {
            DateTime inf = DateTime.Now;
            DateTime sup = DateTime.Now;
            if (inf.DayOfWeek.ToString() == "Monday")
            {
                inferiorMtxt.Text = inf.AddDays(-2).ToString("dd-MM-yyyy");
                superiorMtxt.Text = sup.AddDays(-2).ToString("dd-MM-yyyy");
            }
            else
            {
                inferiorMtxt.Text = inf.AddDays(-1).ToString("dd-MM-yyyy");
                superiorMtxt.Text = sup.AddDays(-1).ToString("dd-MM-yyyy");
            }
            loja();
            vendedores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vendedorTxt.Text == "")
            {
                loja();
            }
            else
            {
                vendedorDados();
            }
        }

        private void proxBt_Click(object sender, EventArgs e)
        {
            proxVdd(auxiliar = 1);
            vendedorDados();
        }

        private void antBt_Click(object sender, EventArgs e)
        {
            proxVdd(auxiliar = 0);
            if (i < 0)
            {
                loja();
                vendedorTxt.Text = "";
            }
            else
            {
                vendedorDados();
            }
        }

        private void mapaVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaMapaVendas = 0;
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (inferiorMtxt.Text == superiorMtxt.Text)
            {
                preenchePlanilha();
            }
        }

        private void dataGb_Enter(object sender, EventArgs e)
        {

        }

        private void enviarBt_Click(object sender, EventArgs e)
        {
            int mes;
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
                    DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
                    if (Convert.ToInt32(aux1.ToString("dd")) <= 25)
                        mes = Convert.ToInt32(aux1.ToString("MM"));
                    else
                        mes = Convert.ToInt32(aux1.AddMonths(1).ToString("MM"));
                    string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();
                    Outlook._Application _app = new Outlook.Application();
                    Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                    mail.To = emailsMv;
                    mail.Subject = "MV-" + mesExtenso.Substring(0, 3).ToUpper() + "-" + aux1.ToString("yy");
                    mail.Display(mail);
                    mail.HTMLBody = "<font face='Arial'>Bom dia, segue em anexo MV-dia " + aux1.ToString("dd") + "-" + aux1.ToString("MM") + "</font>" + mail.HTMLBody;
                    mail.Importance = Outlook.OlImportance.olImportanceNormal;
                    mail.Attachments.Add(@"\\POSEIDON\documentos\Informatica\Luiz\MV\MV\MV_" + mesExtenso.Substring(0, 3).ToUpper() + "_" + aux1.ToString("yy") + ".xlsx", Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                    //((Outlook.MailItem)mail).Send();
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
                    DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
                    if (Convert.ToInt32(aux1.ToString("dd")) <= 25)
                        mes = Convert.ToInt32(aux1.ToString("MM"));
                    else
                        mes = Convert.ToInt32(aux1.AddMonths(1).ToString("MM"));
                    string mesExtenso = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(mes).ToString();
                    Outlook._Application _app = new Outlook.Application();
                    Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                    mail.To = emailsIndVend;
                    mail.Subject = "Indicadores " + mesExtenso.Substring(0, 3).ToUpper() + "-" + aux1.ToString("yy");
                    mail.Display(mail);
                    mail.HTMLBody = "<font face='Arial'>Bom dia, segue em anexo indicadores de vendas " + aux1.ToString("dd") + "-" + aux1.ToString("MM") + "</font>" + mail.HTMLBody;
                    mail.Importance = Outlook.OlImportance.olImportanceNormal;
                    mail.Attachments.Add(@"\\POSEIDON\documentos\Informatica\Luiz\MV\Vendedores\VDD_" + mesExtenso.Substring(0, 3).ToUpper() + "_" + aux1.ToString("yy") + ".xlsx", Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
                    //((Outlook.MailItem)mail).Send();
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            grupoEmails ge = new grupoEmails();
            ge.ShowDialog();
        }
    }
}
