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
    public partial class cadastroFallowUp : Form
    {
        variaveis vat = new variaveis();
        MySqlConnection sqlConn = null;
        private string strConn = "server=10.0.0.210;userid=Luiz;password=GEN@#0996;database=gs_aristeus";
        private string Sql, Sql2, Sql3 = String.Empty;
        MySqlCommand cmd, cmd2, cmd3;
        List<string> fup = new List<string>();
        List<string> ordem = new List<string>();

        public void preecheCombo()
        {
            sqlConn = new MySqlConnection(strConn);
            Sql = "SELECT fups_codigo, fups_nome FROM fallowupsit";
            cmd = new MySqlCommand(Sql, sqlConn);
            sqlConn.Open();
            MySqlDataReader sit = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sit);
            DataRow row = table.NewRow();
            row["fups_nome"] = "";
            table.Rows.InsertAt(row, 0);

            situacaoCb.DataSource = table;
            situacaoCb.DisplayMember = "fups_nome";
            situacaoCb.ValueMember = "fups_codigo";

            sqlConn.Close();
        }

        public void limpar()
        {
            ocTxt.Text = string.Empty;
            situacaoCb.SelectedIndex = 0;
            fup.Clear();
            ordem.Clear();
            vat.CodFalowUp = 0;
            vat.CodOrdemComp = string.Empty;
            vat.AuxFallowUp = 0;
        }
        public cadastroFallowUp()
        {
            InitializeComponent();
        }

        private void ocTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            procuraOC po = new procuraOC();
            po.ShowDialog();
        }

        private void cadastroFallowUp_Activated(object sender, EventArgs e)
        {
            if (vat.AuxFallowUp == 1)
            {
                ocTxt.Text = vat.CodOrdemComp;
                vat.AuxFallowUp = 0;
            }
            else if (vat.CodFalowUp > 0)
            {
                sqlConn = new MySqlConnection(strConn);
                Sql2 = "SELECT fup_ordCompra, fup_situacao FROM fallowup WHERE fup_codigo = " + vat.CodFalowUp + "";
                cmd2 = new MySqlCommand(Sql2, sqlConn);
                sqlConn.Open();
                MySqlDataReader falow = cmd2.ExecuteReader();
                falow.Read();
                fup.Add(falow["fup_ordCompra"].ToString());
                fup.Add(falow["fup_situacao"].ToString());

                ocTxt.Text = fup[0];
                situacaoCb.SelectedValue = fup[1];
                fup.Clear();

                sqlConn.Close();
            }
                
        }

        private void cadastroFallowUp_Load(object sender, EventArgs e)
        {
            preecheCombo();
        }

        private void salvarBt_Click(object sender, EventArgs e)
        {
            if (ocTxt.Text != string.Empty && situacaoCb.SelectedIndex > 0)
            {
                sqlConn = new MySqlConnection(strConn);
                Sql2 = "SELECT ocp_data, ocp_fornecedor, ocp_comprador, ocp_prevent FROM ordcompra WHERE ocp_numero = " + vat.CodOrdemComp + "";
                cmd2 = new MySqlCommand(Sql2, sqlConn);
                sqlConn.Open();
                MySqlDataReader ord = cmd2.ExecuteReader();
                ord.Read();
                ordem.Add(ord["ocp_data"].ToString());
                ordem.Add(ord["ocp_fornecedor"].ToString());
                ordem.Add(ord["ocp_comprador"].ToString());
                ordem.Add(ord["ocp_prevent"].ToString());
                sqlConn.Close();
                DAO dao = new DAO();
                controlFallowUp cf = new controlFallowUp();
                cf.Fup_ordCompra = vat.CodOrdemComp;
                cf.Fup_dataPed = Convert.ToDateTime(ordem[0]);
                cf.Fup_fornecedor = ordem[1];
                cf.Fup_comprador = ordem[2];
                cf.Fup_dataEntrega = Convert.ToDateTime(ordem[3]);
                cf.Fup_situacao = situacaoCb.SelectedValue.ToString();
                cf.Fup_dataAlteracao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (vat.CodFalowUp == 0)
                {
                    dao.cadastraFallowUp(cf);
                    MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //dao.AlteraFallowUp(cf, vat.CodFalowUp);
                    MessageBox.Show("Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpar();
            }else
                MessageBox.Show("Campos Obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            procuraFallowUp pf = new procuraFallowUp();
            pf.ShowDialog();
        }

        private void LimparBt_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
