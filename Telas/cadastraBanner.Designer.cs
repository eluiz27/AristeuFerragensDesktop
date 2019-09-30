namespace processosAdministrativos.Telas
{
    partial class cadastraBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastraBanner));
            this.label1 = new System.Windows.Forms.Label();
            this.campanhaTxt = new System.Windows.Forms.TextBox();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validadeMtxt = new System.Windows.Forms.MaskedTextBox();
            this.salvarBt = new System.Windows.Forms.Button();
            this.alterarBt = new System.Windows.Forms.Button();
            this.limparBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Campanha";
            // 
            // campanhaTxt
            // 
            this.campanhaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.campanhaTxt.Location = new System.Drawing.Point(96, 13);
            this.campanhaTxt.Name = "campanhaTxt";
            this.campanhaTxt.Size = new System.Drawing.Size(93, 20);
            this.campanhaTxt.TabIndex = 0;
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(96, 40);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(240, 20);
            this.imgTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Imagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(195, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Validade";
            // 
            // validadeMtxt
            // 
            this.validadeMtxt.Location = new System.Drawing.Point(264, 13);
            this.validadeMtxt.Mask = "00/00/0000";
            this.validadeMtxt.Name = "validadeMtxt";
            this.validadeMtxt.Size = new System.Drawing.Size(72, 20);
            this.validadeMtxt.TabIndex = 1;
            this.validadeMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // salvarBt
            // 
            this.salvarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salvarBt.Location = new System.Drawing.Point(261, 66);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(75, 29);
            this.salvarBt.TabIndex = 3;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.salvarBt_Click);
            // 
            // alterarBt
            // 
            this.alterarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alterarBt.Location = new System.Drawing.Point(180, 66);
            this.alterarBt.Name = "alterarBt";
            this.alterarBt.Size = new System.Drawing.Size(75, 29);
            this.alterarBt.TabIndex = 4;
            this.alterarBt.Text = "Alterar";
            this.alterarBt.UseVisualStyleBackColor = true;
            this.alterarBt.Click += new System.EventHandler(this.alterarBt_Click);
            // 
            // limparBt
            // 
            this.limparBt.Location = new System.Drawing.Point(99, 66);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(75, 29);
            this.limparBt.TabIndex = 8;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.limparBt_Click);
            // 
            // cadastraBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 107);
            this.Controls.Add(this.limparBt);
            this.Controls.Add(this.alterarBt);
            this.Controls.Add(this.salvarBt);
            this.Controls.Add(this.validadeMtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgTxt);
            this.Controls.Add(this.campanhaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastraBanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Banner";
            this.Activated += new System.EventHandler(this.cadastraBanner_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cadastraBanner_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campanhaTxt;
        private System.Windows.Forms.TextBox imgTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox validadeMtxt;
        private System.Windows.Forms.Button salvarBt;
        private System.Windows.Forms.Button alterarBt;
        private System.Windows.Forms.Button limparBt;
    }
}