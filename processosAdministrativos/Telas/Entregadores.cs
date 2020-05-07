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
    public partial class Entregadores : Form
    {
        DAO dao = new DAO();

        private int cod = 0;

        public int Cod { get => cod; set => cod = value; }

        public void PreencheTabela()
        {
            QueryDataTable qdt = new QueryDataTable();

            dataGridView1.DataSource = qdt.procura("select trp_codigo, trp_nome from transportadoras where trp_atuacao = 'entrega interna'");
        }

        public Entregadores()
        {
            InitializeComponent();
        }

        private void Entregadores_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ControlEntreg ce = new ControlEntreg();
            ce.Motoboy_contEntre = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            dao.AlteraEntregador(ce, Cod);
            Cod = 1;
            this.Close();
        }
    }
}
