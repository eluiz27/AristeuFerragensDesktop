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

        public void preencheTabela()
        {
            queryDataTable qdt = new queryDataTable();

            dataGridView1.DataSource = qdt.procura("select trp_codigo, trp_nome from transportadoras where trp_atuacao = 'entrega interna'");
        }

        public Entregadores()
        {
            InitializeComponent();
        }

        private void Entregadores_Load(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            controlEntreg ce = new controlEntreg();
            ce.Motoboy_contEntre = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            dao.alteraEntregador(ce, Cod);
            Cod = 1;
            this.Close();
        }
    }
}
