namespace processosAdministrativos
{
    partial class imprimeEtiquetaPreco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imprimeEtiquetaPreco));
            this.etiquetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorio = new processosAdministrativos.relatorio();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // etiquetaBindingSource
            // 
            this.etiquetaBindingSource.DataMember = "etiqueta";
            this.etiquetaBindingSource.DataSource = this.relatorio;
            // 
            // relatorio
            // 
            this.relatorio.DataSetName = "relatorio";
            this.relatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 5;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.etiquetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "processosAdministrativos.impressao.etiqueta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(547, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // imprimeEtiquetaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 493);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "imprimeEtiquetaPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas de Preço";
            this.Load += new System.EventHandler(this.imprimeEtiquetaPreco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etiquetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource etiquetaBindingSource;
        private relatorio relatorio;
    }
}