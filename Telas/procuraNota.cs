using processosAdministrativos.Classes;
using processosAdministrativos.Dao;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class procuraNota : Form
    {
        variaveis vari = new variaveis();

        public void preencheTabela()
        {
            queryDataTable dt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            if (notaRb.Checked)
                dataGridView1.DataSource = dt.procura("SELECT nt_documento, nt_agente, nt_nmagente FROM notas INNER JOIN Tipomovi ON Notas.nt_movimento = Tipomovi.tmv_codigo where tmv_grupo = 'c' AND nt_documento like '%" + pesquisar + "%'");
            else if (codFornRb.Checked)
                dataGridView1.DataSource = dt.procura("SELECT nt_documento, nt_agente, nt_nmagente FROM notas INNER JOIN Tipomovi ON Notas.nt_movimento = Tipomovi.tmv_codigo where tmv_grupo = 'c' AND nt_agente like '%" + pesquisar + "%'");
            else if (nomeFonrRb.Checked)
                dataGridView1.DataSource = dt.procura("SELECT nt_documento, nt_agente, nt_nmagente FROM notas INNER JOIN Tipomovi ON Notas.nt_movimento = Tipomovi.tmv_codigo where tmv_grupo = 'c' AND nt_nmagente like '%" + pesquisar + "%'");
        }
        public procuraNota()
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
            preencheTabela();
        }

        private void pesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vari.NumNota = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vari.CodFornCodific = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            vari.AuxCodifica = 1;
            this.Close();
        }
    }
}
