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
    public partial class CadastraSituacao : Form
    {
        DAO dao = new DAO();
        private int _codigo = 0;
        public int aux = 0;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public void tabela()
        {
            QueryDataTable dt = new QueryDataTable();

            dataGridView1.DataSource = dt.procura("SELECT fups_codigo, fups_nome FROM fallowupsit ORDER BY fups_codigo DESC");
        }
        public CadastraSituacao()
        {
            InitializeComponent();
        }

        private void cadastraSituacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gs_aristeusDataSet.fallowupsit' table. You can move, or remove it, as needed.
            tabela();
        }

        private void cadastraSituacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlTelaAberta cta = new ControlTelaAberta();
            cta.TelaCadastroSituacao = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (situacaoTxt.Text != string.Empty)
            {
                ControlFallowUp cf = new ControlFallowUp();
                cf.Fup_situacao = situacaoTxt.Text;
                if (aux == 0)
                    dao.CadastraFallowUpSit(cf);
                else
                    dao.AlteraFallowUpSit(cf, Codigo);
                dataGridView1.DataSource = null;
                tabela();
                situacaoTxt.Text = string.Empty;
            }
            else
                MessageBox.Show("Campo Situação obrigatório!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Codigo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            situacaoTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            aux = 1;
        }
    }
}
