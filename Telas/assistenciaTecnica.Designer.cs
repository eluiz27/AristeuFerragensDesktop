namespace processosAdministrativos.Telas
{
    partial class assistenciaTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assistenciaTecnica));
            this.label1 = new System.Windows.Forms.Label();
            this.produtoTxt = new System.Windows.Forms.TextBox();
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.assistencia1 = new System.Windows.Forms.TabPage();
            this.assistEnd1Txt = new System.Windows.Forms.TextBox();
            this.assistNome1Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assistencia2 = new System.Windows.Forms.TabPage();
            this.assistEnd2Txt = new System.Windows.Forms.TextBox();
            this.assistNome2Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.assisntecia3 = new System.Windows.Forms.TabPage();
            this.assistEnd3Txt = new System.Windows.Forms.TextBox();
            this.assistNome3Txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.assistForn1Txt = new System.Windows.Forms.TextBox();
            this.assistTel1Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.assistForn3Txt = new System.Windows.Forms.TextBox();
            this.assistTel3Txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.assistForn2Txt = new System.Windows.Forms.TextBox();
            this.assistTel2Txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.assistencia1.SuspendLayout();
            this.assistencia2.SuspendLayout();
            this.assisntecia3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Produto";
            // 
            // produtoTxt
            // 
            this.produtoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtoTxt.Location = new System.Drawing.Point(84, 13);
            this.produtoTxt.Name = "produtoTxt";
            this.produtoTxt.ReadOnly = true;
            this.produtoTxt.Size = new System.Drawing.Size(545, 20);
            this.produtoTxt.TabIndex = 0;
            this.produtoTxt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // mapa
            // 
            this.mapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(3, 3);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(611, 420);
            this.mapa.TabIndex = 21;
            this.mapa.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.mapa);
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 416);
            this.panel1.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.assistencia1);
            this.tabControl1.Controls.Add(this.assistencia2);
            this.tabControl1.Controls.Add(this.assisntecia3);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 110);
            this.tabControl1.TabIndex = 1;
            // 
            // assistencia1
            // 
            this.assistencia1.BackColor = System.Drawing.SystemColors.Control;
            this.assistencia1.Controls.Add(this.label11);
            this.assistencia1.Controls.Add(this.assistForn1Txt);
            this.assistencia1.Controls.Add(this.assistTel1Txt);
            this.assistencia1.Controls.Add(this.label3);
            this.assistencia1.Controls.Add(this.assistEnd1Txt);
            this.assistencia1.Controls.Add(this.assistNome1Txt);
            this.assistencia1.Controls.Add(this.label4);
            this.assistencia1.Controls.Add(this.label2);
            this.assistencia1.Location = new System.Drawing.Point(4, 22);
            this.assistencia1.Name = "assistencia1";
            this.assistencia1.Padding = new System.Windows.Forms.Padding(3);
            this.assistencia1.Size = new System.Drawing.Size(606, 84);
            this.assistencia1.TabIndex = 0;
            this.assistencia1.Text = "Assistencia 1";
            this.assistencia1.Enter += new System.EventHandler(this.assistencia1_Enter);
            // 
            // assistEnd1Txt
            // 
            this.assistEnd1Txt.Enabled = false;
            this.assistEnd1Txt.Location = new System.Drawing.Point(81, 59);
            this.assistEnd1Txt.Name = "assistEnd1Txt";
            this.assistEnd1Txt.Size = new System.Drawing.Size(513, 20);
            this.assistEnd1Txt.TabIndex = 5;
            // 
            // assistNome1Txt
            // 
            this.assistNome1Txt.Enabled = false;
            this.assistNome1Txt.Location = new System.Drawing.Point(81, 6);
            this.assistNome1Txt.Name = "assistNome1Txt";
            this.assistNome1Txt.Size = new System.Drawing.Size(513, 20);
            this.assistNome1Txt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // assistencia2
            // 
            this.assistencia2.BackColor = System.Drawing.SystemColors.Control;
            this.assistencia2.Controls.Add(this.label6);
            this.assistencia2.Controls.Add(this.assistForn2Txt);
            this.assistencia2.Controls.Add(this.assistTel2Txt);
            this.assistencia2.Controls.Add(this.label13);
            this.assistencia2.Controls.Add(this.assistEnd2Txt);
            this.assistencia2.Controls.Add(this.assistNome2Txt);
            this.assistencia2.Controls.Add(this.label5);
            this.assistencia2.Controls.Add(this.label7);
            this.assistencia2.Location = new System.Drawing.Point(4, 22);
            this.assistencia2.Name = "assistencia2";
            this.assistencia2.Padding = new System.Windows.Forms.Padding(3);
            this.assistencia2.Size = new System.Drawing.Size(606, 84);
            this.assistencia2.TabIndex = 1;
            this.assistencia2.Text = "Assistência 2";
            this.assistencia2.Enter += new System.EventHandler(this.assistencia2_Enter);
            // 
            // assistEnd2Txt
            // 
            this.assistEnd2Txt.Enabled = false;
            this.assistEnd2Txt.Location = new System.Drawing.Point(81, 59);
            this.assistEnd2Txt.Name = "assistEnd2Txt";
            this.assistEnd2Txt.Size = new System.Drawing.Size(513, 20);
            this.assistEnd2Txt.TabIndex = 9;
            // 
            // assistNome2Txt
            // 
            this.assistNome2Txt.Enabled = false;
            this.assistNome2Txt.Location = new System.Drawing.Point(81, 6);
            this.assistNome2Txt.Name = "assistNome2Txt";
            this.assistNome2Txt.Size = new System.Drawing.Size(513, 20);
            this.assistNome2Txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome";
            // 
            // assisntecia3
            // 
            this.assisntecia3.BackColor = System.Drawing.SystemColors.Control;
            this.assisntecia3.Controls.Add(this.label9);
            this.assisntecia3.Controls.Add(this.assistForn3Txt);
            this.assisntecia3.Controls.Add(this.assistTel3Txt);
            this.assisntecia3.Controls.Add(this.label12);
            this.assisntecia3.Controls.Add(this.assistEnd3Txt);
            this.assisntecia3.Controls.Add(this.assistNome3Txt);
            this.assisntecia3.Controls.Add(this.label8);
            this.assisntecia3.Controls.Add(this.label10);
            this.assisntecia3.Location = new System.Drawing.Point(4, 22);
            this.assisntecia3.Name = "assisntecia3";
            this.assisntecia3.Size = new System.Drawing.Size(606, 84);
            this.assisntecia3.TabIndex = 2;
            this.assisntecia3.Text = "Assistência 3";
            this.assisntecia3.Enter += new System.EventHandler(this.assisntecia3_Enter);
            // 
            // assistEnd3Txt
            // 
            this.assistEnd3Txt.Enabled = false;
            this.assistEnd3Txt.Location = new System.Drawing.Point(81, 59);
            this.assistEnd3Txt.Name = "assistEnd3Txt";
            this.assistEnd3Txt.Size = new System.Drawing.Size(513, 20);
            this.assistEnd3Txt.TabIndex = 13;
            // 
            // assistNome3Txt
            // 
            this.assistNome3Txt.Enabled = false;
            this.assistNome3Txt.Location = new System.Drawing.Point(81, 6);
            this.assistNome3Txt.Name = "assistNome3Txt";
            this.assistNome3Txt.Size = new System.Drawing.Size(513, 20);
            this.assistNome3Txt.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(6, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(234, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Fornecedor";
            // 
            // assistForn1Txt
            // 
            this.assistForn1Txt.Enabled = false;
            this.assistForn1Txt.Location = new System.Drawing.Point(321, 32);
            this.assistForn1Txt.Name = "assistForn1Txt";
            this.assistForn1Txt.Size = new System.Drawing.Size(273, 20);
            this.assistForn1Txt.TabIndex = 4;
            // 
            // assistTel1Txt
            // 
            this.assistTel1Txt.Enabled = false;
            this.assistTel1Txt.Location = new System.Drawing.Point(81, 32);
            this.assistTel1Txt.Name = "assistTel1Txt";
            this.assistTel1Txt.Size = new System.Drawing.Size(147, 20);
            this.assistTel1Txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(234, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fornecedor";
            // 
            // assistForn3Txt
            // 
            this.assistForn3Txt.Enabled = false;
            this.assistForn3Txt.Location = new System.Drawing.Point(321, 32);
            this.assistForn3Txt.Name = "assistForn3Txt";
            this.assistForn3Txt.Size = new System.Drawing.Size(273, 20);
            this.assistForn3Txt.TabIndex = 13;
            // 
            // assistTel3Txt
            // 
            this.assistTel3Txt.Enabled = false;
            this.assistTel3Txt.Location = new System.Drawing.Point(81, 32);
            this.assistTel3Txt.Name = "assistTel3Txt";
            this.assistTel3Txt.Size = new System.Drawing.Size(147, 20);
            this.assistTel3Txt.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(234, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fornecedor";
            // 
            // assistForn2Txt
            // 
            this.assistForn2Txt.Enabled = false;
            this.assistForn2Txt.Location = new System.Drawing.Point(321, 32);
            this.assistForn2Txt.Name = "assistForn2Txt";
            this.assistForn2Txt.Size = new System.Drawing.Size(273, 20);
            this.assistForn2Txt.TabIndex = 8;
            // 
            // assistTel2Txt
            // 
            this.assistTel2Txt.Enabled = false;
            this.assistTel2Txt.Location = new System.Drawing.Point(81, 32);
            this.assistTel2Txt.Name = "assistTel2Txt";
            this.assistTel2Txt.Size = new System.Drawing.Size(147, 20);
            this.assistTel2Txt.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(6, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telefone";
            // 
            // assistenciaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 583);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.produtoTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "assistenciaTecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistencias Técnicas";
            this.Activated += new System.EventHandler(this.assistenciaTecnica_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.assistenciaTecnica_FormClosing);
            this.Load += new System.EventHandler(this.assistenciaTecnica_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.assistencia1.ResumeLayout(false);
            this.assistencia1.PerformLayout();
            this.assistencia2.ResumeLayout(false);
            this.assistencia2.PerformLayout();
            this.assisntecia3.ResumeLayout(false);
            this.assisntecia3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox produtoTxt;
        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage assistencia2;
        private System.Windows.Forms.TabPage assisntecia3;
        private System.Windows.Forms.TabPage assistencia1;
        private System.Windows.Forms.TextBox assistEnd1Txt;
        private System.Windows.Forms.TextBox assistNome1Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assistEnd2Txt;
        private System.Windows.Forms.TextBox assistNome2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox assistEnd3Txt;
        private System.Windows.Forms.TextBox assistNome3Txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox assistForn1Txt;
        private System.Windows.Forms.TextBox assistTel1Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox assistForn3Txt;
        private System.Windows.Forms.TextBox assistTel3Txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox assistForn2Txt;
        private System.Windows.Forms.TextBox assistTel2Txt;
        private System.Windows.Forms.Label label13;
    }
}