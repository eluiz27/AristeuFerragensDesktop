namespace processosAdministrativos.Telas
{
    partial class consultaLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaLote));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaloteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.validadeMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numLoteTxt = new System.Windows.Forms.TextBox();
            this.consulta_loteTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.consulta_loteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaloteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.numLote,
            this.codBarras,
            this.produto,
            this.qtde,
            this.validade});
            this.dataGridView1.DataSource = this.consultaloteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 379);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "ltv_codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // numLote
            // 
            this.numLote.DataPropertyName = "ltv_numLote";
            this.numLote.HeaderText = "Número Lote";
            this.numLote.Name = "numLote";
            this.numLote.ReadOnly = true;
            // 
            // codBarras
            // 
            this.codBarras.DataPropertyName = "ltv_codBarras";
            this.codBarras.HeaderText = "Código de Barras";
            this.codBarras.Name = "codBarras";
            this.codBarras.ReadOnly = true;
            this.codBarras.Width = 150;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 300;
            // 
            // qtde
            // 
            this.qtde.DataPropertyName = "ltv_qtde";
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 50;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "ltv_validade";
            dataGridViewCellStyle1.NullValue = null;
            this.validade.DefaultCellStyle = dataGridViewCellStyle1;
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            this.validade.Width = 70;
            // 
            // consultaloteBindingSource
            // 
            this.consultaloteBindingSource.DataMember = "consulta_lote";
            this.consultaloteBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.validadeMtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numLoteTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // validadeMtxt
            // 
            this.validadeMtxt.Location = new System.Drawing.Point(551, 22);
            this.validadeMtxt.Mask = "00/00/0000";
            this.validadeMtxt.Name = "validadeMtxt";
            this.validadeMtxt.Size = new System.Drawing.Size(100, 23);
            this.validadeMtxt.TabIndex = 1;
            this.validadeMtxt.ValidatingType = typeof(System.DateTime);
            this.validadeMtxt.Enter += new System.EventHandler(this.validadeMtxt_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(482, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Validade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número do Lote";
            // 
            // numLoteTxt
            // 
            this.numLoteTxt.Location = new System.Drawing.Point(123, 22);
            this.numLoteTxt.Name = "numLoteTxt";
            this.numLoteTxt.Size = new System.Drawing.Size(353, 23);
            this.numLoteTxt.TabIndex = 0;
            this.numLoteTxt.Enter += new System.EventHandler(this.numLoteTxt_Enter);
            this.numLoteTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // consulta_loteTableAdapter
            // 
            this.consulta_loteTableAdapter.ClearBeforeFill = true;
            // 
            // consultaLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Lote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultaLote_FormClosing);
            this.Load += new System.EventHandler(this.consultaLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaloteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource consultaloteBindingSource;
        private gs_aristeusDataSetTableAdapters.consulta_loteTableAdapter consulta_loteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox validadeMtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numLoteTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
    }
}