using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraNota : Form
    {
        Variaveis vari = new Variaveis();

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

            if (notaRb.Checked)
                dataGridView1.DataSource = dt.procura("SELECT nt_documento, nt_agente, nt_nmagente FROM notas INNER JOIN Tipomovi ON Notas.nt_movimento = Tipomovi.tmv_codigo where tmv_grupo = 'c' AND nt_documento like '%" + pesquisar + "%'");
            else if (codFornRb.Checked)
                dataGridView1.DataSource = dt.procura("SELECT nt_documento, nt_agente, nt_nmagente FROM notas INNER JOIN Tipomovi ON Notas.nt_movimento = Tipomovi.tmv_codigo where tmv_grupo = 'c' AND nt_agente like '%" + pesquisar + "%'");
            else if (nomeFonrRb.Checked)
                dataGridView1.DataSource = dt.procura("SELECT nt_documento, nt_agente, nt_nmagente FROM notas INNER JOIN Tipomovi ON Notas.nt_movimento = Tipomovi.tmv_codigo where tmv_grupo = 'c' AND nt_nmagente like '%" + pesquisar + "%'");
        }
        public ProcuraNota()
        {
            InitializeComponent();
        }

        private void procuraNota_Load(object sender, EventArgs e)
        {
            notaRb.Checked = true;
            if(vari.DocCodific != string.Empty)
            {
                pesquisaTxt.Text = vari.DocCodific;
                vari.DocCodific = string.Empty;
            }
            PreencheTabela();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vari.NumNota = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vari.CodFornCodific = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            vari.AuxCodifica = 1;
            Close();
        }
    }
}
