﻿namespace processosAdministrativos.Telas
{
    partial class codificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codificacao));
            this.label1 = new System.Windows.Forms.Label();
            this.notaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.codificaCb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.estoq1Cb = new System.Windows.Forms.ComboBox();
            this.estoq2Cb = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota";
            // 
            // notaTxt
            // 
            this.notaTxt.Location = new System.Drawing.Point(57, 12);
            this.notaTxt.Name = "notaTxt";
            this.notaTxt.Size = new System.Drawing.Size(584, 20);
            this.notaTxt.TabIndex = 1;
            this.notaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notaTxt_KeyPress);
            this.notaTxt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notaTxt_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(709, 451);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estoquista";
            // 
            // codificaCb
            // 
            this.codificaCb.AutoSize = true;
            this.codificaCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.codificaCb.Location = new System.Drawing.Point(541, 505);
            this.codificaCb.Name = "codificaCb";
            this.codificaCb.Size = new System.Drawing.Size(100, 21);
            this.codificaCb.TabIndex = 5;
            this.codificaCb.Text = "Codificados";
            this.codificaCb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(647, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // estoq1Cb
            // 
            this.estoq1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estoq1Cb.FormattingEnabled = true;
            this.estoq1Cb.Location = new System.Drawing.Point(93, 504);
            this.estoq1Cb.Name = "estoq1Cb";
            this.estoq1Cb.Size = new System.Drawing.Size(218, 21);
            this.estoq1Cb.TabIndex = 7;
            this.estoq1Cb.SelectedIndexChanged += new System.EventHandler(this.estoq1Cb_SelectedIndexChanged);
            // 
            // estoq2Cb
            // 
            this.estoq2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estoq2Cb.Enabled = false;
            this.estoq2Cb.FormattingEnabled = true;
            this.estoq2Cb.Location = new System.Drawing.Point(317, 504);
            this.estoq2Cb.Name = "estoq2Cb";
            this.estoq2Cb.Size = new System.Drawing.Size(218, 21);
            this.estoq2Cb.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // codificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.estoq2Cb);
            this.Controls.Add(this.estoq1Cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codificaCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.notaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "codificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codificação";
            this.Activated += new System.EventHandler(this.codificacao_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.codificacao_FormClosing);
            this.Load += new System.EventHandler(this.codificacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox codificaCb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox estoq1Cb;
        private System.Windows.Forms.ComboBox estoq2Cb;
        private System.Windows.Forms.Button button2;
    }
}