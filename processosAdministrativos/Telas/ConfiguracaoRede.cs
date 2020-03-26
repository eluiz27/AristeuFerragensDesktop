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
    public partial class ConfiguracaoRede : Form
    {
        DAO dao = new DAO();

        string caminhosRede = Path.GetFullPath("Conexão\\ConexaoRede.txt");
        string userSenha = Path.GetFullPath("Conexão\\UserSenha.txt");
        StreamWriter x;
        StreamWriter y;

        public void SalvarConexao()
        {
            x = File.CreateText(caminhosRede);
            y = File.CreateText(userSenha);
            x.WriteLine(servidorTxt.Text);
            x.WriteLine(portaTxt.Text);
            x.WriteLine(baseDadosTxt.Text);
            y.WriteLine(usuarioTxt.Text);
            y.WriteLine(senhaTxt.Text);
            x.Close();
            y.Close();
        }

        public void PreencheRede()
        {
            servidorTxt.Text = ConexaoRede.RecuperaConexao()[0];
            portaTxt.Text = ConexaoRede.RecuperaConexao()[1];
            baseDadosTxt.Text = ConexaoRede.RecuperaConexao()[2];
            usuarioTxt.Text = ConexaoRede.RecuperaConexao()[3];
            senhaTxt.Text = ConexaoRede.RecuperaConexao()[4];
        }
        public ConfiguracaoRede()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dao.TesteConexao(servidorTxt.Text, portaTxt.Text, baseDadosTxt.Text, usuarioTxt.Text, senhaTxt.Text) == 1)
            {
                if (servidorTxt.Text.Length != 0 && portaTxt.Text.Length != 0 && baseDadosTxt.Text.Length != 0 && usuarioTxt.Text.Length != 0 && senhaTxt.Text.Length != 0)
                {
                    SalvarConexao();
                    MessageBox.Show("Conexão salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Todos os campos são obrigatórios!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Conexão incorreta, não será salva!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConfiguracaoRede_Load(object sender, EventArgs e)
        {
            PreencheRede();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dao.TesteConexao(servidorTxt.Text, portaTxt.Text, baseDadosTxt.Text, usuarioTxt.Text, senhaTxt.Text) == 1)
            {
                MessageBox.Show("Conexão realizada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dao.desconecta();
            }
            else
                MessageBox.Show("Falha na conexão!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void ConfiguracaoRede_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cr = new controlTelaAberta();
            cr.TelaConfRede = 0;
        }
    }
}
