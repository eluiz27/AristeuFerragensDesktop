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
    public partial class cadastraBanner : Form
    {
        DAO dao = new DAO();
        variaveis vat = new variaveis();
        private string Sql = String.Empty;

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
        public void limparCampo()
        {
            campanhaTxt.Text = string.Empty;
            imgTxt.Text = string.Empty;
            validadeMtxt.Text = string.Empty;
            vat.CodBanner = 0;
        }

        public cadastraBanner()
        {
            InitializeComponent();
        }

        private void cadastraBanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            limparCampo();
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (CampoVazio() == false)
            {
                controlBanner cb = new controlBanner();
                cb.Banrot_campanha = campanhaTxt.Text;
                cb.Banrot_img = imgTxt.Text;
                DateTime data = DateTime.Parse(validadeMtxt.Text);
                cb.Banrot_validade = data.ToString("yyyy-MM-dd 23:59:59");
                if (vat.CodBanner == 0)
                {
                    dao.cadastraBanner(cb);
                    MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dao.alteraBanner(cb, vat.CodBanner);
                    MessageBox.Show("Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vat.CodBanner = 0;
                }
                limparCampo();
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                campanhaTxt.Focus();
            }
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            limparCampo();
            procuraBanner pb = new procuraBanner();
            pb.ShowDialog();
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            limparCampo();
        }

        private void cadastraBanner_Activated(object sender, EventArgs e)
        {
            if (vat.CodBanner != 0)
            {
                Sql = "SELECT banrot_campanha, banrot_img, banrot_validade FROM banner_rotativo WHERE banrot_codigo = " + vat.CodBanner + "";
                dao.Query = new MySqlCommand(Sql, dao.Conexao);
                dao.conecta();
                MySqlDataReader banners = dao.Query.ExecuteReader();
                banners.Read();
                campanhaTxt.Text = banners["banrot_campanha"].ToString();
                imgTxt.Text = banners["banrot_img"].ToString();
                DateTime aux = Convert.ToDateTime(banners["banrot_validade"]);
                validadeMtxt.Text = aux.ToString("dd-MM-yyyy");
                banners.Close();
                dao.desconecta();
            }
        }
    }
}
