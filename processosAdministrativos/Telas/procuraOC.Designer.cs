namespace processosAdministrativos.Telas
{
    partial class procuraOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procuraOC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fornecedorRb = new System.Windows.Forms.RadioButton();
            this.ocRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordemCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fornecedorRb);
            this.groupBox1.Controls.Add(this.ocRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
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
            // pesquisaTxt
            // 
            this.pesquisaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 74);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(369, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordemCompra,
            this.fornecedor});
            this.dataGridView1.Location = new System.Drawing.Point(13, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(369, 228);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // ordemCompra
            // 
            this.ordemCompra.DataPropertyName = "ocp_numero";
            this.ordemCompra.HeaderText = "Número OC";
            this.ordemCompra.Name = "ordemCompra";
            this.ordemCompra.ReadOnly = true;
            this.ordemCompra.Width = 90;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "ocp_nmfornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 220;
            // 
            // procuraOC
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
            this.Name = "procuraOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Ordem de Compra";
            this.Load += new System.EventHandler(this.procuraOC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fornecedorRb;
        private System.Windows.Forms.RadioButton ocRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}