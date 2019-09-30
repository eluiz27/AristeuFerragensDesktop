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
    public partial class ProcuraCliLiga : Form
    {
        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            if(RazaoSocRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select cli_nome as 'Nome' from clientes where cli_situacaocad = 'A' and cli_nome like '%"+ pesquisar +"%'");
            else if(nomeFantRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select cli_fantasia as 'Nome' from clientes where cli_situacaocad = 'A' and cli_fantasia like '%" + pesquisar + "%'");
            else if (clienteRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select vdd_nome as 'Nome' from notas inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo where nt_nmagente = '"+ pesquisar +"' and vdd_situacao = 'A' group by nt_vendedor order by count(*) desc limit 1");
            else if (vendedorRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select nt_nmagente as 'Nome' from notas inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo where vdd_nome like '%"+ pesquisar +"%' and vdd_situacao = 'A' and nt_agente != 3666 and nt_agente not like '%c%machado%ltda%' group by nt_agente order by nt_nmagente desc;");
        }

        public ProcuraCliLiga()
        {
            InitializeComponent();
        }

        private void ProcuraCliLiga_Load(object sender, EventArgs e)
        {
            RazaoSocRb.Checked = true;
            pesquisaTxt.Focus();
        }

        private void PesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            preencheTabela();
        }
    }
}
