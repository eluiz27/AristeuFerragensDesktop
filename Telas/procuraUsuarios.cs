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
    public partial class procuraUsuarios : Form
    {
        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisarTxt.Text.Replace('*', '%');

            if(codigoRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT sen_acesso, sen_usuario, res_senha FROM senhas a left outer join restricoes b on a.sen_acesso = b.res_usuario WHERE sen_acesso like '%" + pesquisar+"%' order by sen_acesso desc");
            else
                dataGridView1.DataSource = qdt.procura("SELECT sen_acesso, sen_usuario, res_senha FROM senhas a left outer join restricoes b on a.sen_acesso = b.res_usuario WHERE sen_usuario like '%" + pesquisar+"%' order by sen_acesso desc");
        }
        public procuraUsuarios()
        {
            InitializeComponent();
        }

        private void procuraUsuarios_Load(object sender, EventArgs e)
        {
            codigoRb.Checked = true;
            preencheTabela();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            variaveis var = new variaveis();
            var.CodUsuario = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var.AuxSenha = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var.AuxUsuario = 1;
            this.Close();
        }

        private void pesquisarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }
    }
}
