using processosAdministrativos.Classes;
using System;
using System.Windows.Forms;

namespace processosAdministrativos.Telas
{
    public partial class ProcuraEntrega : Form
    {
        DAO dao = new DAO();
        ControlEntreg ce = new ControlEntreg();
        ControlTelaAberta cta = new ControlTelaAberta();
        Entregadores entre = new Entregadores();

        int clique = 0;
        int excluir = 0;

        public void PreencheTabela()
        {
            QueryDataTable qdt = new QueryDataTable();

            string pesquisar = pesquisaTxt.Text.Replace('*', '%');

            DateTime aux1 = DateTime.Parse(inferiorMtxt.Text);
            DateTime aux2 = DateTime.Parse(superiorMtxt.Text);
            string inferior = aux1.ToString("yyyy-MM-dd 00:00:00");
            string superior = aux2.ToString("yyyy-MM-dd 23:00:00");

            if (pedidoRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT cod_contEntre, pedido_contEntre, cliente_contEntre, vdd_nome, trp_nome, situacao_contEntre, dt_aCaminho, dt_entregue, obs_contEntre FROM (controle_entrega a  inner join transportadoras b on a.motoboy_contEntre = b.trp_codigo) left outer join vendedores c on a.vendedor_contEntre = c.vdd_codigo WHERE pedido_contEntre LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY dt_aCaminho desc");
            else if (vendedorRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT cod_contEntre, pedido_contEntre, cliente_contEntre, vdd_nome, trp_nome, situacao_contEntre, dt_aCaminho, dt_entregue, obs_contEntre FROM (controle_entrega a  inner join transportadoras b on a.motoboy_contEntre = b.trp_codigo) left outer join vendedores c on a.vendedor_contEntre = c.vdd_codigo WHERE vdd_nome LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY dt_aCaminho desc");
            else if (clienteRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT cod_contEntre, pedido_contEntre, cliente_contEntre, vdd_nome, trp_nome, situacao_contEntre, dt_aCaminho, dt_entregue, obs_contEntre FROM (controle_entrega a  inner join transportadoras b on a.motoboy_contEntre = b.trp_codigo) left outer join vendedores c on a.vendedor_contEntre = c.vdd_codigo WHERE cliente_contEntre LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY dt_aCaminho desc");
            else if (motoboyRb.Checked)
                dataGridView1.DataSource = qdt.procura("SELECT cod_contEntre, pedido_contEntre, cliente_contEntre, vdd_nome, trp_nome, situacao_contEntre, dt_aCaminho, dt_entregue, obs_contEntre FROM (controle_entrega a  inner join transportadoras b on a.motoboy_contEntre = b.trp_codigo) left outer join vendedores c on a.vendedor_contEntre = c.vdd_codigo WHERE trp_nome LIKE '" + pesquisar + "%' AND dt_aCaminho between '" + inferior + "' AND '" + superior + "' ORDER BY dt_aCaminho desc");
        }
        public ProcuraEntrega()
        {
            InitializeComponent();
        }

        private void procuraEntrega_Load(object sender, EventArgs e)
        {
            pedidoRb.Checked = true;
            inferiorMtxt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            superiorMtxt.Text = DateTime.Now.ToString("dd-MM-yyyy");
            PreencheTabela();

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            if(cta.TelaEntrega == 1)
                dataGridView1.Columns[8].ReadOnly = true;

        }

        private void pesqusiarTxt_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheTabela();
        }

        private void sairBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pesquisarBt_Click(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                ce.Obs_contEntre = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();

                dao.AlteraObsEntrega(ce, Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
            }
        }

        private void InferiorMtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if(clique == 0)
            {
                inferiorMtxt.SelectionStart = 0;
                inferiorMtxt.SelectionLength = inferiorMtxt.TextLength;
                clique = 1;
            }
        }

        private void SuperiorMtxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (clique == 0)
            {
                superiorMtxt.SelectionStart = 0;
                superiorMtxt.SelectionLength = inferiorMtxt.TextLength;
                clique = 1;
            }
        }

        private void InferiorMtxt_Leave(object sender, EventArgs e)
        {
            clique = 0;
        }

        private void SuperiorMtxt_Leave(object sender, EventArgs e)
        {
            clique = 1;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cta.TelaEntrega == 0)
            {
                if (e.ColumnIndex == 5 && dataGridView1[5, e.RowIndex].Value.ToString() == "A caminho")
                {
                    ce.Situacao_contEntre = "Entregue";
                    ce.Dt_entregue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    dao.AlteraSituEntrega(ce, Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
                    PreencheTabela();
                }

                if (e.ColumnIndex == 4)
                {
                    entre.Cod = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                    entre.ShowDialog();
                }
            }
        }

        private void ProcuraEntrega_FormClosing(object sender, FormClosingEventArgs e)
        {
            Variaveis var = new Variaveis();
            var.FechaTela = 1;
            cta.TelaEntrega = 0;
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cta.TelaEntrega == 0)
            {
                dao.DeletaEntrega(excluir);
                PreencheTabela();
            }

        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cta.TelaEntrega == 0)
            {
                try
                {
                    excluir = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

                }
                catch
                {

                }
            }

        }

        private void ProcuraEntrega_Activated(object sender, EventArgs e)
        {
            if(entre.Cod == 1)
            {
                PreencheTabela();
                entre.Cod = 0;
            }
        }
    }
}
