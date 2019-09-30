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
    public partial class cadastroCampanha : Form
    {
        variaveis var = new variaveis();

        public void limpar()
        {
            campanhaCb.SelectedIndex = 0;
            produtoTxt.Text = string.Empty;
            codigoTxt.Text = string.Empty;
            var.CodCampanha = string.Empty;
            var.ProdCampanha = string.Empty;
        }

        public cadastroCampanha()
        {
            InitializeComponent();
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            procuraProd pp = new procuraProd();
            var.AuxCampanha = 1;
            pp.ShowDialog();
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (campanhaCb.SelectedIndex > 0 && produtoTxt.Text != string.Empty)
            {
                controlCampanha cc = new controlCampanha();
                DAO dao = new DAO();
                cc.Cmak_campanha = campanhaCb.SelectedItem.ToString();
                cc.Cmak_codigo = codigoTxt.Text;
                cc.Cmak_produto = "";
                cc.Cmak_alcance = "0";
                cc.Cmak_curtidas = "0";
                cc.Cmak_compart = "0";
                cc.Cmak_data = DateTime.Now.ToString("yyyy-MM-dd");

                dao.cadastraCampanha(cc);
                MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            else
                MessageBox.Show("Campos obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cadastroCampanha_Activated(object sender, EventArgs e)
        {
            if(var.CodCampanha != string.Empty)
            {
                codigoTxt.Text = var.CodCampanha;
                produtoTxt.Text = var.ProdCampanha;
                var.AuxCampanha = 0;
            }
        }

        private void limparBt_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void cadastroCampanha_FormClosing(object sender, FormClosingEventArgs e)
        {
            var.AuxCampanha = 1;
        }

        private void cadastroCampanha_Load(object sender, EventArgs e)
        {
            DateTime aux = DateTime.Now;
            if(aux.ToString("ddd", new CultureInfo("pt-BR")) == "seg")
                campanhaCb.SelectedIndex = 1;
            else if(aux.ToString("ddd", new CultureInfo("pt-BR")) == "ter")
                campanhaCb.SelectedIndex = 2;
            else if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "qua")
                campanhaCb.SelectedIndex = 3;
            else if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "qui")
                campanhaCb.SelectedIndex = 4;
            else if (aux.ToString("ddd", new CultureInfo("pt-BR")) == "sex")
                campanhaCb.SelectedIndex = 3;
            else
                campanhaCb.SelectedIndex = 0;
        }
    }
}
