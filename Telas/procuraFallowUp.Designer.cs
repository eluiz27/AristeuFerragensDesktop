namespace processosAdministrativos.Telas
{
    partial class procuraFallowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procuraFallowUp));
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fornecedorRb = new System.Windows.Forms.RadioButton();
            this.ocRb = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerooc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procuraFalowUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.procuraFalowUpTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.procuraFalowUpTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procuraFalowUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 73);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(369, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaTxt_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fornecedorRb);
            this.groupBox1.Controls.Add(this.ocRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // fornecedorRb
            // 
            this.fornecedorRb.AutoSize = true;
            this.fornecedorRb.Location = new System.Drawing.Point(153, 22);
            this.fornecedorRb.Name = "fornecedorRb";
            this.fornecedorRb.Size = new System.Drawing.Size(99, 21);
            this.fornecedorRb.TabIndex = 1;
            this.fornecedorRb.TabStop = true;
            this.fornecedorRb.Text = "Fornecedor";
            this.fornecedorRb.UseVisualStyleBackColor = true;
            // 
            // ocRb
            // 
            this.ocRb.AutoSize = true;
            this.ocRb.Location = new System.Drawing.Point(7, 23);
            this.ocRb.Name = "ocRb";
            this.ocRb.Size = new System.Drawing.Size(140, 21);
            this.ocRb.TabIndex = 0;
            this.ocRb.TabStop = true;
            this.ocRb.Text = "Ordem de compra";
            this.ocRb.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.numerooc,
            this.fornecedor});
            this.dataGridView1.DataSource = this.procuraFalowUpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(369, 229);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "fup_codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // numerooc
            // 
            this.numerooc.DataPropertyName = "fup_ordCompra";
            this.numerooc.HeaderText = "Número OC";
            this.numerooc.Name = "numerooc";
            this.numerooc.ReadOnly = true;
            this.numerooc.Width = 90;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fnc_nome";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 220;
            // 
            // procuraFalowUpBindingSource
            // 
            this.procuraFalowUpBindingSource.DataMember = "procuraFalowUp";
            this.procuraFalowUpBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procuraFalowUpTableAdapter
            // 
            this.procuraFalowUpTableAdapter.ClearBeforeFill = true;
            // 
            // procuraFallowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "procuraFallowUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Fallow Up";
            this.Load += new System.EventHandler(this.procuraFallowUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procuraFalowUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fornecedorRb;
        private System.Windows.Forms.RadioButton ocRb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource procuraFalowUpBindingSource;
        private gs_aristeusDataSetTableAdapters.procuraFalowUpTableAdapter procuraFalowUpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerooc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}