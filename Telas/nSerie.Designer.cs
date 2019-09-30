namespace processosAdministrativos
{
    partial class nSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nSerie));
            this.label1 = new System.Windows.Forms.Label();
            this.pedidoTxt = new System.Windows.Forms.TextBox();
            this.produtoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nSerieTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salvarBt = new System.Windows.Forms.Button();
            this.limparBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // pedidoTxt
            // 
            this.pedidoTxt.Location = new System.Drawing.Point(16, 34);
            this.pedidoTxt.Name = "pedidoTxt";
            this.pedidoTxt.Size = new System.Drawing.Size(49, 20);
            this.pedidoTxt.TabIndex = 1;
            // 
            // produtoTxt
            // 
            this.produtoTxt.Location = new System.Drawing.Point(72, 33);
            this.produtoTxt.Name = "produtoTxt";
            this.produtoTxt.Size = new System.Drawing.Size(57, 20);
            this.produtoTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(71, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto";
            // 
            // nSerieTxt
            // 
            this.nSerieTxt.Location = new System.Drawing.Point(136, 33);
            this.nSerieTxt.Name = "nSerieTxt";
            this.nSerieTxt.Size = new System.Drawing.Size(225, 20);
            this.nSerieTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(135, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº de série";
            // 
            // salvarBt
            // 
            this.salvarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salvarBt.Location = new System.Drawing.Point(286, 59);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(75, 30);
            this.salvarBt.TabIndex = 6;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // limparBt
            // 
            this.limparBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.limparBt.Location = new System.Drawing.Point(205, 59);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(75, 30);
            this.limparBt.TabIndex = 7;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            // 
            // nSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 99);
            this.Controls.Add(this.limparBt);
            this.Controls.Add(this.salvarBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nSerieTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.produtoTxt);
            this.Controls.Add(this.pedidoTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "nSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nº Série";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nSerie_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pedidoTxt;
        private System.Windows.Forms.TextBox produtoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nSerieTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salvarBt;
        private System.Windows.Forms.Button limparBt;
    }
}