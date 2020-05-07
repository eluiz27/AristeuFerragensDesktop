namespace processosAdministrativos.Telas
{
    partial class ControleEst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleEst));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codigoBarrasRb = new System.Windows.Forms.RadioButton();
            this.descricaoRb = new System.Windows.Forms.RadioButton();
            this.codigoRb = new System.Windows.Forms.RadioButton();
            this.produtoTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codigoBarrasRb);
            this.groupBox1.Controls.Add(this.descricaoRb);
            this.groupBox1.Controls.Add(this.codigoRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // codigoBarrasRb
            // 
            this.codigoBarrasRb.AutoSize = true;
            this.codigoBarrasRb.Location = new System.Drawing.Point(177, 20);
            this.codigoBarrasRb.Name = "codigoBarrasRb";
            this.codigoBarrasRb.Size = new System.Drawing.Size(136, 21);
            this.codigoBarrasRb.TabIndex = 2;
            this.codigoBarrasRb.TabStop = true;
            this.codigoBarrasRb.Text = "Código de Barras";
            this.codigoBarrasRb.UseVisualStyleBackColor = true;
            // 
            // descricaoRb
            // 
            this.descricaoRb.AutoSize = true;
            this.descricaoRb.Location = new System.Drawing.Point(82, 20);
            this.descricaoRb.Name = "descricaoRb";
            this.descricaoRb.Size = new System.Drawing.Size(89, 21);
            this.descricaoRb.TabIndex = 1;
            this.descricaoRb.TabStop = true;
            this.descricaoRb.Text = "Descrição";
            this.descricaoRb.UseVisualStyleBackColor = true;
            // 
            // codigoRb
            // 
            this.codigoRb.AutoSize = true;
            this.codigoRb.Location = new System.Drawing.Point(6, 20);
            this.codigoRb.Name = "codigoRb";
            this.codigoRb.Size = new System.Drawing.Size(70, 21);
            this.codigoRb.TabIndex = 0;
            this.codigoRb.TabStop = true;
            this.codigoRb.Text = "Código";
            this.codigoRb.UseVisualStyleBackColor = true;
            // 
            // produtoTxt
            // 
            this.produtoTxt.Location = new System.Drawing.Point(13, 67);
            this.produtoTxt.Name = "produtoTxt";
            this.produtoTxt.Size = new System.Drawing.Size(422, 20);
            this.produtoTxt.TabIndex = 0;
            this.produtoTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.produtoTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(422, 249);
            this.dataGridView1.TabIndex = 2;
            // 
            // controleEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 355);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.produtoTxt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "controleEst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controleEst_FormClosing);
            this.Load += new System.EventHandler(this.controleEst_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton codigoRb;
        private System.Windows.Forms.RadioButton descricaoRb;
        private System.Windows.Forms.RadioButton codigoBarrasRb;
        private System.Windows.Forms.TextBox produtoTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}