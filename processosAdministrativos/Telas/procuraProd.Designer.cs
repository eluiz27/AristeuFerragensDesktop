namespace processosAdministrativos.Telas
{
    partial class ProcuraProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraProd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codigoBarrasRb = new System.Windows.Forms.RadioButton();
            this.nomeRb = new System.Windows.Forms.RadioButton();
            this.codigoRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.itensTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.itensTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codigoBarrasRb);
            this.groupBox1.Controls.Add(this.nomeRb);
            this.groupBox1.Controls.Add(this.codigoRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // codigoBarrasRb
            // 
            this.codigoBarrasRb.AutoSize = true;
            this.codigoBarrasRb.Location = new System.Drawing.Point(152, 21);
            this.codigoBarrasRb.Name = "codigoBarrasRb";
            this.codigoBarrasRb.Size = new System.Drawing.Size(136, 21);
            this.codigoBarrasRb.TabIndex = 5;
            this.codigoBarrasRb.TabStop = true;
            this.codigoBarrasRb.Text = "Código de Barras";
            this.codigoBarrasRb.UseVisualStyleBackColor = true;
            // 
            // nomeRb
            // 
            this.nomeRb.AutoSize = true;
            this.nomeRb.Location = new System.Drawing.Point(83, 21);
            this.nomeRb.Name = "nomeRb";
            this.nomeRb.Size = new System.Drawing.Size(63, 21);
            this.nomeRb.TabIndex = 4;
            this.nomeRb.TabStop = true;
            this.nomeRb.Text = "Nome";
            this.nomeRb.UseVisualStyleBackColor = true;
            // 
            // codigoRb
            // 
            this.codigoRb.AutoSize = true;
            this.codigoRb.Location = new System.Drawing.Point(7, 21);
            this.codigoRb.Name = "codigoRb";
            this.codigoRb.Size = new System.Drawing.Size(70, 21);
            this.codigoRb.TabIndex = 3;
            this.codigoRb.TabStop = true;
            this.codigoRb.Text = "Código";
            this.codigoRb.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 68);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(423, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome});
            this.dataGridView1.DataSource = this.itensBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(423, 318);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "itm_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "itm_descricao";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 320;
            // 
            // itensBindingSource
            // 
            this.itensBindingSource.DataMember = "itens";
            this.itensBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itensTableAdapter
            // 
            this.itensTableAdapter.ClearBeforeFill = true;
            // 
            // procuraProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "procuraProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.procuraProd_FormClosing);
            this.Load += new System.EventHandler(this.procuraProd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nomeRb;
        private System.Windows.Forms.RadioButton codigoRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource itensBindingSource;
        private gs_aristeusDataSetTableAdapters.itensTableAdapter itensTableAdapter;
        private System.Windows.Forms.RadioButton codigoBarrasRb;
    }
}