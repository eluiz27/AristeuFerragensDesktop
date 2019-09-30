namespace processosAdministrativos.Telas
{
    partial class procuraNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procuraNota));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeFonrRb = new System.Windows.Forms.RadioButton();
            this.codFornRb = new System.Windows.Forms.RadioButton();
            this.notaRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nomeFonrRb);
            this.groupBox1.Controls.Add(this.codFornRb);
            this.groupBox1.Controls.Add(this.notaRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // nomeFonrRb
            // 
            this.nomeFonrRb.AutoSize = true;
            this.nomeFonrRb.Location = new System.Drawing.Point(226, 22);
            this.nomeFonrRb.Name = "nomeFonrRb";
            this.nomeFonrRb.Size = new System.Drawing.Size(140, 21);
            this.nomeFonrRb.TabIndex = 2;
            this.nomeFonrRb.TabStop = true;
            this.nomeFonrRb.Text = "Nome Fornecedor";
            this.nomeFonrRb.UseVisualStyleBackColor = true;
            // 
            // codFornRb
            // 
            this.codFornRb.AutoSize = true;
            this.codFornRb.Location = new System.Drawing.Point(88, 22);
            this.codFornRb.Name = "codFornRb";
            this.codFornRb.Size = new System.Drawing.Size(132, 21);
            this.codFornRb.TabIndex = 1;
            this.codFornRb.TabStop = true;
            this.codFornRb.Text = "Cód. Fornecedor";
            this.codFornRb.UseVisualStyleBackColor = true;
            // 
            // notaRb
            // 
            this.notaRb.AutoSize = true;
            this.notaRb.Location = new System.Drawing.Point(7, 23);
            this.notaRb.Name = "notaRb";
            this.notaRb.Size = new System.Drawing.Size(75, 21);
            this.notaRb.TabIndex = 0;
            this.notaRb.TabStop = true;
            this.notaRb.Text = "Nº Nota";
            this.notaRb.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 73);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(396, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nNota,
            this.codForn,
            this.nomeForn});
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(396, 226);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // nNota
            // 
            this.nNota.DataPropertyName = "nt_documento";
            this.nNota.HeaderText = "Nº Nota";
            this.nNota.Name = "nNota";
            this.nNota.ReadOnly = true;
            this.nNota.Width = 70;
            // 
            // codForn
            // 
            this.codForn.DataPropertyName = "nt_agente";
            this.codForn.HeaderText = "Código";
            this.codForn.Name = "codForn";
            this.codForn.ReadOnly = true;
            this.codForn.Width = 70;
            // 
            // nomeForn
            // 
            this.nomeForn.DataPropertyName = "nt_nmagente";
            this.nomeForn.HeaderText = "Nome Fornecedor";
            this.nomeForn.Name = "nomeForn";
            this.nomeForn.ReadOnly = true;
            this.nomeForn.Width = 190;
            // 
            // procuraNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "procuraNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesqusia Nota";
            this.Load += new System.EventHandler(this.procuraNota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nomeFonrRb;
        private System.Windows.Forms.RadioButton codFornRb;
        private System.Windows.Forms.RadioButton notaRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn codForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeForn;
    }
}