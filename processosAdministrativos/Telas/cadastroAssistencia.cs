using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using processosAdministrativos.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace processosAdministrativos.Telas
{
    public partial class CadastroAssistencia : Form
    {
        DAO dao = new DAO();
        private string Sql = String.Empty;
        ControlTelaAberta cta = new ControlTelaAberta();
        Variaveis vat = new Variaveis();

        public CadastroAssistencia()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(enderecoTxt);
            sList.Add("Rua, número - bairro, cidade - estado, CEP");
            SetCueBanner(ref tList, sList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText){
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }
        public bool CampoVazio()
        {
            bool ok = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (string.IsNullOrEmpty(ctrl.Text))
                    {
                        ok = true;
                        break;
                    }
                }
            }
            return ok;
        }
        public void limpaCampo()
        {
            nomeTxt.Text = string.Empty;
            telefoneTxt.Text = string.Empty;
            enderecoTxt.Text = string.Empty;
            latitudeTxt.Text = string.Empty;
            longitudeTxt.Text = string.Empty;
            fornecedorTxt.Text = string.Empty;
            vat.CodFornAssistTec = 0;
            vat.CodAssistTec = 0;
            vat.NomeFornAssistTec = string.Empty;
            vat.Aux2AssistTec = 0;
            vat.Aux3AssistTec = 0;
        }
        private void fornecedorTxt_Enter(object sender, EventArgs e)
        {
            ProcuraForn f = new ProcuraForn();
            f.ShowDialog();
            cta.TelaProcForn = 1;
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            ControlAssistTec cat = new ControlAssistTec();
            if (CampoVazio() == false)
            {
                cat.Nome_assistTec = nomeTxt.Text;
                cat.Telefone_assistTec = telefoneTxt.Text;
                cat.Endereco_assistTec = enderecoTxt.Text;
                cat.Lat_assistTec = latitudeTxt.Text;
                cat.Long_assistTec = longitudeTxt.Text;
                cat.Fornecedor_assistTec = vat.CodFornAssistTec;
                if (vat.Aux2AssistTec == 0)
                {
                    dao.CadastraAssistTec(cat);
                    MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (vat.Aux2AssistTec == 1)
                    {
                        dao.AlteraAssistTec(cat, vat.CodAssistTec);
                        MessageBox.Show("Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                limpaCampo();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cadastraAssistencia_Activated(object sender, EventArgs e)
        {
            if (vat.NomeFornAssistTec.Length > 0)
            {
                fornecedorTxt.Text = vat.NomeFornAssistTec;
            }

            if (vat.Aux3AssistTec == 1)
            {
                Sql = "SELECT nome_assistTec, nome_assistTec, telefone_assistTec, endereco_assistTec, lat_assistTec, long_assistTec, fnc_nome, fornecedor_assistTec FROM assistencias_tecnicas INNER JOIN fornecedores ON assistencias_tecnicas.fornecedor_assistTec = fornecedores.fnc_codigo WHERE codigo_assistTec = " + vat.CodAssistTec + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.Conecta();
                MySqlDataReader assistTec = dao.Query.ExecuteReader();
                assistTec.Read();
                nomeTxt.Text = assistTec["nome_assistTec"].ToString();
                telefoneTxt.Text = assistTec["telefone_assistTec"].ToString();
                enderecoTxt.Text = assistTec["endereco_assistTec"].ToString();
                latitudeTxt.Text = assistTec["lat_assistTec"].ToString();
                longitudeTxt.Text = assistTec["long_assistTec"].ToString();
                fornecedorTxt.Text = assistTec["fnc_nome"].ToString();
                vat.CodFornAssistTec = Convert.ToInt32(assistTec["fornecedor_assistTec"]);
                vat.Aux3AssistTec = 0;
                assistTec.Close();
                dao.Desconecta();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void cadastraAssistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaCadAssistTec = 0;
            limpaCampo();
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            limpaCampo();
            ProcuraAssistTec pa = new ProcuraAssistTec();
            pa.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.travelaholics.com.br/ferramentas/qual-%C3%A9-a-minha-latitude-e-longitude/");
        }

        private void fornecedorTxt_DoubleClick(object sender, EventArgs e)
        {
            ProcuraForn f = new ProcuraForn();
            f.ShowDialog();
        }
    }
}
