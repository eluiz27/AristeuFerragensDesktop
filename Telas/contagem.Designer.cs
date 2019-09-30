namespace processosAdministrativos.Telas
{
    partial class contagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contagem));
            this.label1 = new System.Windows.Forms.Label();
            this.prefixProdTxt = new System.Windows.Forms.TextBox();
            this.pararBt = new System.Windows.Forms.Button();
            this.iniciarBt = new System.Windows.Forms.Button();
            this.limparBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeCont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefixo Produto";
            // 
            // prefixProdTxt
            // 
            this.prefixProdTxt.Location = new System.Drawing.Point(118, 12);
            this.prefixProdTxt.Name = "prefixProdTxt";
            this.prefixProdTxt.Size = new System.Drawing.Size(342, 20);
            this.prefixProdTxt.TabIndex = 1;
            this.prefixProdTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prefixProdTxt_KeyUp);
            // 
            // pararBt
            // 
            this.pararBt.Enabled = false;
            this.pararBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pararBt.Location = new System.Drawing.Point(385, 330);
            this.pararBt.Name = "pararBt";
            this.pararBt.Size = new System.Drawing.Size(75, 27);
            this.pararBt.TabIndex = 6;
            this.pararBt.Text = "Parar";
            this.pararBt.UseVisualStyleBackColor = true;
            this.pararBt.Click += new System.EventHandler(this.pararBt_Click);
            // 
            // iniciarBt
            // 
            this.iniciarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iniciarBt.Location = new System.Drawing.Point(304, 330);
            this.iniciarBt.Name = "iniciarBt";
            this.iniciarBt.Size = new System.Drawing.Size(75, 27);
            this.iniciarBt.TabIndex = 7;
            this.iniciarBt.Text = "Iniciar";
            this.iniciarBt.UseVisualStyleBackColor = true;
            this.iniciarBt.Click += new System.EventHandler(this.iniciarBt_Click);
            // 
            // limparBt
            // 
            this.limparBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.limparBt.Location = new System.Drawing.Point(223, 330);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(75, 27);
            this.limparBt.TabIndex = 8;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.limparBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.produto,
            this.qtdeCont,
            this.qtdeReal});
            this.dataGridView1.Location = new System.Drawing.Point(16, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 285);
            this.dataGridView1.TabIndex = 9;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "itm_codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "itm_descricao";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 220;
            // 
            // qtdeCont
            // 
            this.qtdeCont.HeaderText = "Qtde Cont";
            this.qtdeCont.Name = "qtdeCont";
            this.qtdeCont.Width = 80;
            // 
            // qtdeReal
            // 
            this.qtdeReal.HeaderText = "Qtde Real";
            this.qtdeReal.Name = "qtdeReal";
            this.qtdeReal.ReadOnly = true;
            this.qtdeReal.Width = 80;
            // 
            // contagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.limparBt);
            this.Controls.Add(this.iniciarBt);
            this.Controls.Add(this.pararBt);
            this.Controls.Add(this.prefixProdTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "contagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.contagem_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prefixProdTxt;
        private System.Windows.Forms.Button pararBt;
        private System.Windows.Forms.Button iniciarBt;
        private System.Windows.Forms.Button limparBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeReal;
    }
}