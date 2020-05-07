namespace processosAdministrativos.Telas
{
    partial class ConsultaFallowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFallowUp));
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedorTxt = new System.Windows.Forms.TextBox();
            this.dataMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fallowUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.fallowUpTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.fallowUpTableAdapter();
            this.salvarBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallowUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor";
            // 
            // fornecedorTxt
            // 
            this.fornecedorTxt.Location = new System.Drawing.Point(100, 13);
            this.fornecedorTxt.Name = "fornecedorTxt";
            this.fornecedorTxt.Size = new System.Drawing.Size(409, 20);
            this.fornecedorTxt.TabIndex = 1;
            this.fornecedorTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataMtxt
            // 
            this.dataMtxt.Location = new System.Drawing.Point(613, 11);
            this.dataMtxt.Mask = "00/00/0000";
            this.dataMtxt.Name = "dataMtxt";
            this.dataMtxt.Size = new System.Drawing.Size(76, 20);
            this.dataMtxt.TabIndex = 2;
            this.dataMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(515, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Entrega";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // fallowUpBindingSource
            // 
            this.fallowUpBindingSource.DataMember = "fallowUp";
            this.fallowUpBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(695, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fallowUpTableAdapter
            // 
            this.fallowUpTableAdapter.ClearBeforeFill = true;
            // 
            // salvarBt
            // 
            this.salvarBt.Location = new System.Drawing.Point(783, 8);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(75, 25);
            this.salvarBt.TabIndex = 6;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.salvarBt_Click_1);
            // 
            // consultaFallowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 452);
            this.Controls.Add(this.salvarBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataMtxt);
            this.Controls.Add(this.fornecedorTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaFallowUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Follow Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultaFallowUp_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallowUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fornecedorTxt;
        private System.Windows.Forms.MaskedTextBox dataMtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource fallowUpBindingSource;
        private gs_aristeusDataSetTableAdapters.fallowUpTableAdapter fallowUpTableAdapter;
        private System.Windows.Forms.Button salvarBt;
    }
}