namespace processosAdministrativos.Telas
{
    partial class ConsultaCodificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCodificacao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquista1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquista2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultCodificacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estoquistaRb = new System.Windows.Forms.RadioButton();
            this.fornecedorRb = new System.Windows.Forms.RadioButton();
            this.notaRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.consultCodificacaoTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.consultCodificacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultCodificacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nota,
            this.forn,
            this.estoquista1,
            this.estoquista2,
            this.data});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(696, 339);
            this.dataGridView1.TabIndex = 4;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "codf_nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Width = 60;
            // 
            // forn
            // 
            this.forn.DataPropertyName = "fnc_nome";
            this.forn.HeaderText = "Fornecedor";
            this.forn.Name = "forn";
            this.forn.ReadOnly = true;
            this.forn.Width = 200;
            // 
            // estoquista1
            // 
            this.estoquista1.DataPropertyName = "estoq1";
            this.estoquista1.HeaderText = "Estoquista 1";
            this.estoquista1.Name = "estoquista1";
            this.estoquista1.ReadOnly = true;
            this.estoquista1.Width = 150;
            // 
            // estoquista2
            // 
            this.estoquista2.DataPropertyName = "estoq2";
            this.estoquista2.HeaderText = "Estoquista 2";
            this.estoquista2.Name = "estoquista2";
            this.estoquista2.ReadOnly = true;
            this.estoquista2.Width = 150;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 70;
            // 
            // consultCodificacaoBindingSource
            // 
            this.consultCodificacaoBindingSource.DataMember = "consultCodificacao";
            this.consultCodificacaoBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estoquistaRb);
            this.groupBox1.Controls.Add(this.fornecedorRb);
            this.groupBox1.Controls.Add(this.notaRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // estoquistaRb
            // 
            this.estoquistaRb.AutoSize = true;
            this.estoquistaRb.Location = new System.Drawing.Point(174, 22);
            this.estoquistaRb.Name = "estoquistaRb";
            this.estoquistaRb.Size = new System.Drawing.Size(92, 21);
            this.estoquistaRb.TabIndex = 2;
            this.estoquistaRb.TabStop = true;
            this.estoquistaRb.Text = "Estoquista";
            this.estoquistaRb.UseVisualStyleBackColor = true;
            // 
            // fornecedorRb
            // 
            this.fornecedorRb.AutoSize = true;
            this.fornecedorRb.Location = new System.Drawing.Point(69, 22);
            this.fornecedorRb.Name = "fornecedorRb";
            this.fornecedorRb.Size = new System.Drawing.Size(99, 21);
            this.fornecedorRb.TabIndex = 1;
            this.fornecedorRb.TabStop = true;
            this.fornecedorRb.Text = "Fornecedor";
            this.fornecedorRb.UseVisualStyleBackColor = true;
            // 
            // notaRb
            // 
            this.notaRb.AutoSize = true;
            this.notaRb.Location = new System.Drawing.Point(7, 23);
            this.notaRb.Name = "notaRb";
            this.notaRb.Size = new System.Drawing.Size(56, 21);
            this.notaRb.TabIndex = 0;
            this.notaRb.TabStop = true;
            this.notaRb.Text = "Nota";
            this.notaRb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.superiorMtxt);
            this.groupBox2.Controls.Add(this.inferiorMtxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(290, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inferior";
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(210, 22);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(75, 23);
            this.superiorMtxt.TabIndex = 1;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(64, 21);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(75, 23);
            this.inferiorMtxt.TabIndex = 0;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(592, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 74);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(573, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // consultCodificacaoTableAdapter
            // 
            this.consultCodificacaoTableAdapter.ClearBeforeFill = true;
            // 
            // consultaCodificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 451);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaCodificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Codificação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultaCodificacao_FormClosing);
            this.Load += new System.EventHandler(this.consultaCodificacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultCodificacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton estoquistaRb;
        private System.Windows.Forms.RadioButton fornecedorRb;
        private System.Windows.Forms.RadioButton notaRb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource consultCodificacaoBindingSource;
        private gs_aristeusDataSetTableAdapters.consultCodificacaoTableAdapter consultCodificacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoquista1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoquista2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}