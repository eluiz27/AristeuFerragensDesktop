using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class Ligacoes : Form
    {
        string caminho = Path.GetFullPath("Txts\\vendedores.txt");
        public static string[] linhas;
        DAO dao = new DAO();
        int cod = 0;
        public Ligacoes()
        {
            InitializeComponent();
        }

        public void PreencheCombo()
        {
            linhas = File.ReadAllLines(caminho);
            foreach (string x in linhas)
            {
                paraCb.Items.Add(x);
            }
        }

        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }

        public void PreencheTabela()
        {
            QueryDataTable dt = new QueryDataTable();
            string pesquisar = CorrecoesTexto(pesquisaTxt.Text);
            if (clienteRb.Checked == true)
                dataGridView1.DataSource = dt.procura("SELECT DATE_FORMAT(liga_data, '%d/%m/%Y') AS 'dataFormatada', liga_hora, liga_cliente, liga_para, liga_situacao, liga_obs, liga_id FROM ligacoes WHERE liga_cliente like '%" + pesquisar + "%' AND liga_data BETWEEN '"+ DateTime.Parse(inferiorMtxt.Text).ToString("yyyy-MM-dd 00:00:00") + "' AND '"+ DateTime.Parse(superiorMtxt.Text).ToString("yyyy-MM-dd 23:00:00") + "' ORDER BY liga_data, liga_hora");
            else if(paraRb.Checked == true)
                dataGridView1.DataSource = dt.procura("SELECT DATE_FORMAT(liga_data, '%d/%m/%Y') AS 'dataFormatada', liga_hora, liga_cliente, liga_para, liga_situacao, liga_obs, liga_id FROM ligacoes WHERE liga_para like '%" + pesquisar + "%' AND liga_data BETWEEN '" + DateTime.Parse(inferiorMtxt.Text).ToString("yyyy-MM-dd 00:00:00") + "' AND '" + DateTime.Parse(superiorMtxt.Text).ToString("yyyy-MM-dd 23:00:00") + "' ORDER BY liga_data, liga_hora");
            else if(situacaoRb.Checked == true)
                dataGridView1.DataSource = dt.procura("SELECT DATE_FORMAT(liga_data, '%d/%m/%Y') AS 'dataFormatada', liga_hora, liga_cliente, liga_para, liga_situacao, liga_obs, liga_id FROM ligacoes WHERE liga_situacao like '%" + pesquisar + "%' AND liga_data BETWEEN '" + DateTime.Parse(inferiorMtxt.Text).ToString("yyyy-MM-dd 00:00:00") + "' AND '" + DateTime.Parse(superiorMtxt.Text).ToString("yyyy-MM-dd 23:00:00") + "' ORDER BY liga_data, liga_hora");
        }

        public void SalvaLigacao()
        {
            ControlLigacoes cl = new ControlLigacoes();
            if(clienteTxt.Text != string.Empty && paraCb.SelectedIndex >= 0)
            {
                cl.Liga_data = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                if (horaMtxt.Text.Trim().Replace(":", string.Empty) == string.Empty)
                    cl.Liga_hora = DateTime.Now.ToString("HH:mm");
                else
                    cl.Liga_hora = horaMtxt.Text;
                cl.Liga_cliente = clienteTxt.Text;
                cl.Liga_para = paraCb.SelectedItem.ToString();
                cl.Liga_situacao = situacaoCb.SelectedItem.ToString();
                if (obsTxt.Text != string.Empty)
                    cl.Liga_obs = obsTxt.Text;
                else
                    cl.Liga_obs = "";

                if(cod == 0)
                {
                    dao.CadastraLigacoes(cl);
                    MessageBox.Show("Salvo com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dao.AlteraLigacoes(cl, cod);
                    MessageBox.Show("Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Limpar()
        {
            clienteTxt.Text = string.Empty;
            paraCb.SelectedIndex = 0;
            obsTxt.Text = string.Empty;
            horaMtxt.Text = string.Empty;
            situacaoCb.SelectedIndex = 0;
            cod = 0;
        }

        public void LimparPesquisa()
        {
            clienteRb.Checked = true;
            pesquisaTxt.Text = string.Empty;
            inferiorMtxt.Text = DateTime.Now.ToString("dd/MM/yy");
            superiorMtxt.Text = DateTime.Now.ToString("dd/MM/yy");
            PreencheTabela();
        }

        private void Ligacoes_Load(object sender, EventArgs e)
        {
            situacaoCb.SelectedIndex = 0;
            clienteRb.Checked = true;
            inferiorMtxt.Text = DateTime.Now.ToString("dd/MM/yy");
            superiorMtxt.Text = DateTime.Now.ToString("dd/MM/yy");
            PreencheTabela();
            PreencheCombo();
            paraCb.SelectedIndex = 0;
        }

        private void Ligacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaChamadas = 0;
        }

        private void LimparBt_Click(object sender, EventArgs e)
        {
            Limpar();
            clienteTxt.Focus();
        }

        private void ComfirmaBt_Click(object sender, EventArgs e)
        {
            SalvaLigacao();
            PreencheTabela();
            Limpar();
            clienteTxt.Focus();
        }

        private void SituacaoCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SalvaLigacao();
                PreencheTabela();
                Limpar();
                clienteTxt.Focus();
            }
        }

        private void HoraMtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SalvaLigacao();
                PreencheTabela();
                Limpar();
                clienteTxt.Focus();
            }
        }

        private void ObsTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SalvaLigacao();
                PreencheTabela();
                Limpar();
                clienteTxt.Focus();
            }
        }

        private void PesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void InferiorMtxt_GotFocus(object sender, EventArgs e)
        {
            inferiorMtxt.SelectAll();
        }

        private void SuperiorMtxt_GotFocus(object sender, EventArgs e)
        {
            superiorMtxt.SelectAll();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            clienteTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            paraCb.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Transferido")
                situacaoCb.SelectedIndex = 0;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Recado")
                situacaoCb.SelectedIndex = 1;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Desligou")
                situacaoCb.SelectedIndex = 2;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Pessoal")
                situacaoCb.SelectedIndex = 3;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Outros")
                situacaoCb.SelectedIndex = 4;
            horaMtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            obsTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ProcuraCliLiga pcl = new ProcuraCliLiga();
            pcl.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cv = new CadastroFuncionario();
            cv.ShowDialog();
        }
    }
}
