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
    public partial class progresso : Form
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public progresso()
        {
            InitializeComponent();
        }

        private void progresso_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (x == 1)
                    this.Hide();
        }
    }
}
