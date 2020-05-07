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
        QueryDataTable qdt = new QueryDataTable();

        public static string CorrecoesTexto(string text)
        {
            text = text.Replace("'", string.Empty);
            text = text.Replace('*', '%');

            return text;
        }

        public void PreencheTabela()
        {

            string pesquisar = CorrecoesTexto(pesquisaTxt.Text);

            if (RazaoSocRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select cli_nome as 'Nome', cli_fantasia as 'Vazio' from clientes where cli_situacaocad = 'A' and (cli_nome like '%"+ pesquisar + "%' or cli_fantasia like '%" + pesquisar + "%')");
            else if (clienteRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select concat(vdd_nome , ' - ', count(*)) as 'Nome' , 'Vazio' from notas inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo where nt_nmagente like '" + pesquisar +"' and vdd_situacao = 'A' group by nt_vendedor order by count(*) desc");
            else if (vendedorRb.Checked == true)
                dataGridView1.DataSource = qdt.procura("select nt_nmagente as 'Nome', 'Vazio' from notas inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo where vdd_nome like '%" + pesquisar +"%' and vdd_situacao = 'A' and nt_agente != 3666 and nt_agente not like '%c%machado%ltda%' group by nt_agente order by nt_nmagente");
        }

        public ProcuraCliLiga()
        {
            InitializeComponent();
        }

        private void ProcuraCliLiga_Load(object sender, EventArgs e)
        {
            RazaoSocRb.Checked = true;
            pesquisaTxt.Focus();
            dataGridView1.DataSource = qdt.procura("select cli_nome as 'Nome', cli_fantasia as 'Vazio' from clientes where cli_situacaocad = 'A'");
        }

        private void PesquisaTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }
    }
}
