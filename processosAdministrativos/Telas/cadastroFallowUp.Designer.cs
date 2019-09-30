namespace processosAdministrativos.Telas
{
    partial class cadastroFallowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroFallowUp));
            this.label1 = new System.Windows.Forms.Label();
            this.ocTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.situacaoCb = new System.Windows.Forms.ComboBox();
            this.salvarBt = new System.Windows.Forms.Button();
            this.LimparBt = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordem de Compra";
            // 
            // ocTxt
            // 
            this.ocTxt.Location = new System.Drawing.Point(143, 12);
            this.ocTxt.Name = "ocTxt";
            this.ocTxt.ReadOnly = true;
            this.ocTxt.Size = new System.Drawing.Size(242, 20);
            this.ocTxt.TabIndex = 1;
            this.ocTxt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ocTxt_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Situação";
            // 
            // situacaoCb
            // 
            this.situacaoCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.situacaoCb.FormattingEnabled = true;
            this.situacaoCb.Location = new System.Drawing.Point(143, 40);
            this.situacaoCb.Name = "situacaoCb";
            this.situacaoCb.Size = new System.Drawing.Size(242, 21);
            this.situacaoCb.TabIndex = 4;
            // 
            // salvarBt
            // 
            this.salvarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salvarBt.Location = new System.Drawing.Point(307, 67);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(78, 27);
            this.salvarBt.TabIndex = 5;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.salvarBt_Click);
            // 
            // LimparBt
            // 
            this.LimparBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LimparBt.Location = new System.Drawing.Point(142, 66);
            this.LimparBt.Name = "LimparBt";
            this.LimparBt.Size = new System.Drawing.Size(75, 27);
            this.LimparBt.TabIndex = 6;
            this.LimparBt.Text = "Limpar";
            this.LimparBt.UseVisualStyleBackColor = true;
            this.LimparBt.Click += new System.EventHandler(this.LimparBt_Click);
            // 
            // alterar
            // 
            this.alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alterar.Location = new System.Drawing.Point(223, 66);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(78, 27);
            this.alterar.TabIndex = 7;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // cadastroFallowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 105);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.LimparBt);
            this.Controls.Add(this.salvarBt);
            this.Controls.Add(this.situacaoCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ocTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastroFallowUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Follow Up";
            this.Activated += new System.EventHandler(this.cadastroFallowUp_Activated);
            this.Load += new System.EventHandler(this.cadastroFallowUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ocTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox situacaoCb;
        private System.Windows.Forms.Button salvarBt;
        private System.Windows.Forms.Button LimparBt;
        private System.Windows.Forms.Button alterar;
    }
}