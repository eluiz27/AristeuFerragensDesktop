using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos
{
    public partial class imprimeEtiquetaPreco : Form
    {
        public imprimeEtiquetaPreco(List<string> nome, List<string> codItem, List<string> codForn, List<string> preco)
        {
            InitializeComponent();

            for (int i = 0; i < nome.Count; i++)
            {
                relatorio.etiqueta.AddetiquetaRow(nome[i], codItem[i], codForn[i], preco[i]);
            }

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }

        private void imprimeEtiquetaPreco_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
