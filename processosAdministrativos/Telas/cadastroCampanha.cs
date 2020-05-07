using MySql.Data.MySqlClient;
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
    public partial class CadastroCampanha : Form
    {
        Variaveis var = new Variaveis();
        DAO dao = new DAO();
        private string Sql = String.Empty;
        DateTime data;


        public void EscolheCampanha()
        {
            Sql = "select cmak_campanha, cmak_data from campanha_marketing order by cmak_codigo desc limit 1";
            dao.Query = new MySqlCommand(Sql, dao.Conexao);
            dao.Conecta();
            MySqlDataReader campa = dao.Query.ExecuteReader();
            while (campa.Read())
            {
                data = Convert.ToDateTime(campa["cmak_data"]);
            }
            campa.Close();
            dao.Desconecta();

            if (data.ToString("ddd", new CultureInfo("pt-BR")) == "sex")
                campanhaCb.SelectedIndex = 1;
            else if (data.ToString("ddd", new CultureInfo("pt-BR")) == "seg")
                campanhaCb.SelectedIndex = 2;
            else if (data.ToString("ddd", new CultureInfo("pt-BR")) == "ter")
                campanhaCb.SelectedIndex = 3;
            else if (data.ToString("ddd", new CultureInfo("pt-BR")) == "qua")
                campanhaCb.SelectedIndex = 4;
            else if (data.ToString("ddd", new CultureInfo("pt-BR")) == "qui")
                campanhaCb.SelectedIndex = 3;
            else
                campanhaCb.SelectedIndex = 0;
        }

        public void limpar()
        {
            campanhaCb.SelectedIndex = 0;
            produtoTxt.Text = string.Empty;
            codigoTxt.Text = string.Empty;
            var.CodCampanha = string.Empty;
            var.ProdCampanha = string.Empty;
        }

        public CadastroCampanha()
        {
            InitializeComponent();
        }

        private void cadastroCampanha_Load(object sender, EventArgs e)
        {
            EscolheCampanha();
        }
        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcuraProd pp = new ProcuraProd();
            var.AuxCampanha = 1;
            pp.ShowDialog();
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (campanhaCb.SelectedIndex > 0 && produtoTxt.Text != string.Empty)
            {
                ControlCampanha cc = new ControlCampanha();
                DAO dao = new DAO();
                cc.Cmak_campanha = campanhaCb.SelectedItem.ToString();
                cc.Cmak_codigo = codigoTxt.Text;
                cc.Cmak_produto = "";
                cc.Cmak_alcance = "0";
                cc.Cmak_curtidas = "0";
                cc.Cmak_compart = "0";
                if (data.ToString("ddd", new CultureInfo("pt-BR")) == "sex")
                    cc.Cmak_data = data.AddDays(3).ToString("yyyy-MM-dd");
                else
                    cc.Cmak_data = data.AddDays(1).ToString("yyyy-MM-dd");


                dao.CadastraCampanha(cc);
                MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                EscolheCampanha();
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
    }
}
