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
            reportViewer1.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "processosAdministrativos.impressao.etiquetaPrecoRl.rdlc";
            //Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[4];

            List<ReportParameter> p = new List<ReportParameter>();
            //ReportParameterCollection rpc = new ReportParameterCollection();

                p.Add(new ReportParameter("nome", "teste1"));
                p.Add(new ReportParameter("codItem", "456231"));
                p.Add(new ReportParameter("codForn", "564648"));
                p.Add(new ReportParameter("preco", "R$ 15,20"));
                p.Add(new ReportParameter("nome", "teste2"));
                p.Add(new ReportParameter("codItem", "456231"));
                p.Add(new ReportParameter("codForn", "564648"));
                p.Add(new ReportParameter("preco", "R$ 15,20"));


            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void imprimeEtiquetaPreco_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
