namespace processosAdministrativos.Telas
{
    partial class cadastroCampanha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCampanha));
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.produtoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salvarBt = new System.Windows.Forms.Button();
            this.limparBt = new System.Windows.Forms.Button();
            this.campanhaCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // codigoTxt
            // 
            this.codigoTxt.Location = new System.Drawing.Point(92, 38);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.ReadOnly = true;
            this.codigoTxt.Size = new System.Drawing.Size(182, 20);
            this.codigoTxt.TabIndex = 1;
            this.codigoTxt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDoubleClick);
            // 
            // produtoTxt
            // 
            this.produtoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.produtoTxt.Location = new System.Drawing.Point(92, 65);
            this.produtoTxt.Name = "produtoTxt";
            this.produtoTxt.Size = new System.Drawing.Size(182, 20);
            this.produtoTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Campanha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto";
            // 
            // salvarBt
            // 
            this.salvarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBt.Location = new System.Drawing.Point(199, 94);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(75, 25);
            this.salvarBt.TabIndex = 6;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.salvarBt_Click);
            // 
            // limparBt
            // 
            this.limparBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBt.Location = new System.Drawing.Point(118, 94);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(75, 25);
            this.limparBt.TabIndex = 8;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.limparBt_Click);
            // 
            // campanhaCb
            // 
            this.campanhaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campanhaCb.FormattingEnabled = true;
            this.campanhaCb.Items.AddRange(new object[] {
            "",
            "NOVIDADE",
            "PROMOÇÃO",
            "OFERTA",
            "LIQUIDAÇÃO"});
            this.campanhaCb.Location = new System.Drawing.Point(93, 7);
            this.campanhaCb.Name = "campanhaCb";
            this.campanhaCb.Size = new System.Drawing.Size(181, 21);
            this.campanhaCb.TabIndex = 0;
            // 
            // cadastroCampanha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 128);
            this.Controls.Add(this.campanhaCb);
            this.Controls.Add(this.limparBt);
            this.Controls.Add(this.salvarBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produtoTxt);
            this.Controls.Add(this.codigoTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastroCampanha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastroCampanha";
            this.Activated += new System.EventHandler(this.cadastroCampanha_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cadastroCampanha_FormClosing);
            this.Load += new System.EventHandler(this.cadastroCampanha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.TextBox produtoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salvarBt;
        private System.Windows.Forms.Button limparBt;
        private System.Windows.Forms.ComboBox campanhaCb;
    }
}