namespace processosAdministrativos.Telas
{
    partial class ProcuraAssistTec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraAssistTec));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assistenciaRb = new System.Windows.Forms.RadioButton();
            this.nomeFornRb = new System.Windows.Forms.RadioButton();
            this.codFornRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.assistenciaRb);
            this.groupBox1.Controls.Add(this.nomeFornRb);
            this.groupBox1.Controls.Add(this.codFornRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // assistenciaRb
            // 
            this.assistenciaRb.AutoSize = true;
            this.assistenciaRb.Location = new System.Drawing.Point(299, 21);
            this.assistenciaRb.Name = "assistenciaRb";
            this.assistenciaRb.Size = new System.Drawing.Size(97, 21);
            this.assistenciaRb.TabIndex = 2;
            this.assistenciaRb.TabStop = true;
            this.assistenciaRb.Text = "Assistencia";
            this.assistenciaRb.UseVisualStyleBackColor = true;
            // 
            // nomeFornRb
            // 
            this.nomeFornRb.AutoSize = true;
            this.nomeFornRb.Location = new System.Drawing.Point(153, 21);
            this.nomeFornRb.Name = "nomeFornRb";
            this.nomeFornRb.Size = new System.Drawing.Size(140, 21);
            this.nomeFornRb.TabIndex = 1;
            this.nomeFornRb.TabStop = true;
            this.nomeFornRb.Text = "Nome Fornecedor";
            this.nomeFornRb.UseVisualStyleBackColor = true;
            // 
            // codFornRb
            // 
            this.codFornRb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.codFornRb.AutoSize = true;
            this.codFornRb.Location = new System.Drawing.Point(6, 21);
            this.codFornRb.Name = "codFornRb";
            this.codFornRb.Size = new System.Drawing.Size(141, 21);
            this.codFornRb.TabIndex = 0;
            this.codFornRb.TabStop = true;
            this.codFornRb.Text = "código fornecedor";
            this.codFornRb.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 68);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(461, 20);
            this.pesquisaTxt.TabIndex = 1;
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
            this.codigo,
            this.nome,
            this.fornecedor});
            this.dataGridView1.Location = new System.Drawing.Point(13, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(461, 352);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo_assistTec";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome_assistTec";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 180;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fnc_nome";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 180;
            // 
            // procuraAssistTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "procuraAssistTec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Assistência Técnica";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.procuraAssistTec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton codFornRb;
        private System.Windows.Forms.RadioButton assistenciaRb;
        private System.Windows.Forms.RadioButton nomeFornRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}