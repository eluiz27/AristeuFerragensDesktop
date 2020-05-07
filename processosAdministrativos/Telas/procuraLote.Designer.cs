namespace processosAdministrativos.Telas
{
    partial class ProcuraLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraLote));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLote,
            this.produto});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(338, 243);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // numLote
            // 
            this.numLote.DataPropertyName = "ltv_numLote";
            this.numLote.HeaderText = "Número do lote";
            this.numLote.Name = "numLote";
            this.numLote.ReadOnly = true;
            this.numLote.Width = 105;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "itm_descricao";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 175;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(12, 13);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(338, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // procuraLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 294);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "procuraLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Lote";
            this.Load += new System.EventHandler(this.procuraLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
    }
}