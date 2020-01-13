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
    public partial class ClienteForaEstado : Form
    {
        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            dataGridView1.DataSource = qdt.procura("select cli_codigo, cli_nome, if(cli_pessoa = 'F', 'Física', 'Jurídica') as 'pessoa', cli_cgc, cli_estado, cli_situacao from clientes where cli_estado != 'PR'");
        }
        public ClienteForaEstado()
        {
            InitializeComponent();
            preencheTabela();
        }

        private void ClienteForaEstado_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlTelaAberta cta = new controlTelaAberta();
            cta.TelaCliForaEstado = 0;
        }
    }
}
