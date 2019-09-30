namespace processosAdministrativos.Telas
{
    partial class cadastroLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroLote));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numLoteTxt = new System.Windows.Forms.TextBox();
            this.codBarrasTxt = new System.Windows.Forms.TextBox();
            this.produtoTxt = new System.Windows.Forms.TextBox();
            this.salvarBt = new System.Windows.Forms.Button();
            this.lmpatBt = new System.Windows.Forms.Button();
            this.alterarBt = new System.Windows.Forms.Button();
            this.qtdeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.validadeMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Núm. Lote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cód. Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Produto";
            // 
            // numLoteTxt
            // 
            this.numLoteTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.numLoteTxt.Location = new System.Drawing.Point(101, 12);
            this.numLoteTxt.Name = "numLoteTxt";
            this.numLoteTxt.Size = new System.Drawing.Size(254, 20);
            this.numLoteTxt.TabIndex = 0;
            // 
            // codBarrasTxt
            // 
            this.codBarrasTxt.Location = new System.Drawing.Point(101, 38);
            this.codBarrasTxt.Name = "codBarrasTxt";
            this.codBarrasTxt.Size = new System.Drawing.Size(254, 20);
            this.codBarrasTxt.TabIndex = 1;
            // 
            // produtoTxt
            // 
            this.produtoTxt.Location = new System.Drawing.Point(101, 64);
            this.produtoTxt.Name = "produtoTxt";
            this.produtoTxt.ReadOnly = true;
            this.produtoTxt.Size = new System.Drawing.Size(254, 20);
            this.produtoTxt.TabIndex = 2;
            this.produtoTxt.Enter += new System.EventHandler(this.produtoTxt_Enter);
            // 
            // salvarBt
            // 
            this.salvarBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.salvarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salvarBt.Location = new System.Drawing.Point(279, 122);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(75, 26);
            this.salvarBt.TabIndex = 5;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.salvarBt_Click);
            // 
            // lmpatBt
            // 
            this.lmpatBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lmpatBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lmpatBt.Location = new System.Drawing.Point(117, 121);
            this.lmpatBt.Name = "lmpatBt";
            this.lmpatBt.Size = new System.Drawing.Size(75, 26);
            this.lmpatBt.TabIndex = 7;
            this.lmpatBt.Text = "Limpar";
            this.lmpatBt.UseVisualStyleBackColor = true;
            this.lmpatBt.Click += new System.EventHandler(this.lmpatBt_Click);
            // 
            // alterarBt
            // 
            this.alterarBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.alterarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alterarBt.Location = new System.Drawing.Point(198, 121);
            this.alterarBt.Name = "alterarBt";
            this.alterarBt.Size = new System.Drawing.Size(75, 26);
            this.alterarBt.TabIndex = 6;
            this.alterarBt.Text = "Alterar";
            this.alterarBt.UseVisualStyleBackColor = true;
            this.alterarBt.Click += new System.EventHandler(this.alterarBt_Click);
            // 
            // qtdeTxt
            // 
            this.qtdeTxt.Location = new System.Drawing.Point(101, 90);
            this.qtdeTxt.Name = "qtdeTxt";
            this.qtdeTxt.Size = new System.Drawing.Size(91, 20);
            this.qtdeTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade";
            // 
            // validadeMtxt
            // 
            this.validadeMtxt.Location = new System.Drawing.Point(264, 90);
            this.validadeMtxt.Mask = "00/00/0000";
            this.validadeMtxt.Name = "validadeMtxt";
            this.validadeMtxt.Size = new System.Drawing.Size(91, 20);
            this.validadeMtxt.TabIndex = 4;
            this.validadeMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(195, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Validade";
            // 
            // cadastroLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 158);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.validadeMtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtdeTxt);
            this.Controls.Add(this.alterarBt);
            this.Controls.Add(this.lmpatBt);
            this.Controls.Add(this.salvarBt);
            this.Controls.Add(this.produtoTxt);
            this.Controls.Add(this.codBarrasTxt);
            this.Controls.Add(this.numLoteTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastroLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Lote com Validade";
            this.Activated += new System.EventHandler(this.cadastroLote_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cadastroLote_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numLoteTxt;
        private System.Windows.Forms.TextBox codBarrasTxt;
        private System.Windows.Forms.TextBox produtoTxt;
        private System.Windows.Forms.Button salvarBt;
        private System.Windows.Forms.Button lmpatBt;
        private System.Windows.Forms.Button alterarBt;
        private System.Windows.Forms.TextBox qtdeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox validadeMtxt;
        private System.Windows.Forms.Label label6;
    }
}