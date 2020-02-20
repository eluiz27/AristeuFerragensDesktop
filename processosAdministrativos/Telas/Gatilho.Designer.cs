namespace processosAdministrativos.Telas
{
    partial class Gatilho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gatilho));
            this.label1 = new System.Windows.Forms.Label();
            this.compLb = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.compTxt = new System.Windows.Forms.TextBox();
            this.preencherBt = new System.Windows.Forms.Button();
            this.gravarBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // compLb
            // 
            this.compLb.AutoSize = true;
            this.compLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compLb.Location = new System.Drawing.Point(13, 41);
            this.compLb.Name = "compLb";
            this.compLb.Size = new System.Drawing.Size(85, 16);
            this.compLb.TabIndex = 1;
            this.compLb.Text = "Computador:";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(104, 13);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(92, 20);
            this.usuarioTxt.TabIndex = 2;
            // 
            // compTxt
            // 
            this.compTxt.Location = new System.Drawing.Point(104, 39);
            this.compTxt.Name = "compTxt";
            this.compTxt.Size = new System.Drawing.Size(92, 20);
            this.compTxt.TabIndex = 3;
            // 
            // preencherBt
            // 
            this.preencherBt.Location = new System.Drawing.Point(16, 75);
            this.preencherBt.Name = "preencherBt";
            this.preencherBt.Size = new System.Drawing.Size(75, 23);
            this.preencherBt.TabIndex = 4;
            this.preencherBt.Text = "Preencher";
            this.preencherBt.UseVisualStyleBackColor = true;
            this.preencherBt.Click += new System.EventHandler(this.preencherBt_Click);
            // 
            // gravarBt
            // 
            this.gravarBt.Location = new System.Drawing.Point(121, 75);
            this.gravarBt.Name = "gravarBt";
            this.gravarBt.Size = new System.Drawing.Size(75, 23);
            this.gravarBt.TabIndex = 5;
            this.gravarBt.Text = "Gravar";
            this.gravarBt.UseVisualStyleBackColor = true;
            this.gravarBt.Click += new System.EventHandler(this.gravarBt_Click);
            // 
            // Gatilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 110);
            this.Controls.Add(this.gravarBt);
            this.Controls.Add(this.preencherBt);
            this.Controls.Add(this.compTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.compLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Gatilho";
            this.Text = "Gatilho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label compLb;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox compTxt;
        private System.Windows.Forms.Button preencherBt;
        private System.Windows.Forms.Button gravarBt;
    }
}