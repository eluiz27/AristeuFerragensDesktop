using processosAdministrativos.Classes;
using processosAdministrativos.Controllers;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class Restricoes : Form
    {
        RestricaoController rc = new RestricaoController();
        int cod = 0;
        public void PreencheTabela()
        {
            dataGridView1.DataSource = rc.SelectRestricao();
        }
        public void LimpaCampo()
        {
            cargoCb.SelectedIndex = 0;
            compTxt.Text = string.Empty;
            usuarioTxt.Text = string.Empty;
            dashLojaCb.Checked = false;
            cod = 0;
        }
        public Restricoes()
        {
            InitializeComponent();
        }
        private void restricoes_Load(object sender, EventArgs e)
        {
            cargoCb.SelectedIndex = 0;
            PreencheTabela();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (compTxt.Text == string.Empty || usuarioTxt.Text == string.Empty)
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (cod)
                {
                    case 0:
                        rc.InsertRestricao(cargoCb.SelectedItem.ToString().ToLower(), compTxt.Text, usuarioTxt.Text, Convert.ToInt32(dashLojaCb.Checked));
                        MessageBox.Show("Salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        rc.UpdateRestricao(cod, cargoCb.SelectedItem.ToString().ToLower(), compTxt.Text, usuarioTxt.Text, Convert.ToInt32(dashLojaCb.Checked));
                        MessageBox.Show("Alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                PreencheTabela();
                LimpaCampo();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == cargoCb.Items[i].ToString().ToLower())
                {
                    cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    cargoCb.SelectedIndex = i;
                    compTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    usuarioTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    dashLojaCb.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value);
                }
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esta restrição?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rc.DeleteRestricao(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                PreencheTabela();
                LimpaCampo();
            }
        }
        private void restricoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaRestricoes = 0;
        }

        private void infoPcBt_Click(object sender, EventArgs e)
        {
            usuarioTxt.Text = Environment.UserName.ToLower();
            compTxt.Text = Environment.MachineName.ToLower();
        }
    }
}
