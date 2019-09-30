namespace processosAdministrativos.Telas
{
    partial class procuraCampanha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procuraCampanha));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.campanhaRb = new System.Windows.Forms.RadioButton();
            this.codProdRb = new System.Windows.Forms.RadioButton();
            this.produtoRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campanha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.campanha,
            this.cod,
            this.produto});
            this.dataGridView1.Location = new System.Drawing.Point(13, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(386, 246);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.produtoRb);
            this.groupBox1.Controls.Add(this.codProdRb);
            this.groupBox1.Controls.Add(this.campanhaRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // campanhaRb
            // 
            this.campanhaRb.AutoSize = true;
            this.campanhaRb.Location = new System.Drawing.Point(6, 21);
            this.campanhaRb.Name = "campanhaRb";
            this.campanhaRb.Size = new System.Drawing.Size(92, 20);
            this.campanhaRb.TabIndex = 0;
            this.campanhaRb.TabStop = true;
            this.campanhaRb.Text = "Campanha";
            this.campanhaRb.UseVisualStyleBackColor = true;
            // 
            // codProdRb
            // 
            this.codProdRb.AutoSize = true;
            this.codProdRb.Location = new System.Drawing.Point(104, 21);
            this.codProdRb.Name = "codProdRb";
            this.codProdRb.Size = new System.Drawing.Size(104, 20);
            this.codProdRb.TabIndex = 1;
            this.codProdRb.TabStop = true;
            this.codProdRb.Text = "Cód. Produto";
            this.codProdRb.UseVisualStyleBackColor = true;
            // 
            // produtoRb
            // 
            this.produtoRb.AutoSize = true;
            this.produtoRb.Location = new System.Drawing.Point(214, 21);
            this.produtoRb.Name = "produtoRb";
            this.produtoRb.Size = new System.Drawing.Size(73, 20);
            this.produtoRb.TabIndex = 2;
            this.produtoRb.TabStop = true;
            this.produtoRb.Text = "Produto";
            this.produtoRb.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 65);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(386, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaTxt_KeyUp);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cmak_codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // campanha
            // 
            this.campanha.DataPropertyName = "cmak_campanha";
            this.campanha.HeaderText = "Campanha";
            this.campanha.Name = "campanha";
            this.campanha.ReadOnly = true;
            this.campanha.Width = 80;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "cmak_item";
            this.cod.HeaderText = "Cód.";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 70;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "prod";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 170;
            // 
            // procuraCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 349);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "procuraCampanha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "procuraCampanha";
            this.Load += new System.EventHandler(this.procuraCampanha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton produtoRb;
        private System.Windows.Forms.RadioButton codProdRb;
        private System.Windows.Forms.RadioButton campanhaRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn campanha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
    }
}