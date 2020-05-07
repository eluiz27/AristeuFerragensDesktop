namespace processosAdministrativos.Telas
{
    partial class MediaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaVendas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisarBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(811, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(441, 12);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(70, 20);
            this.inferiorMtxt.TabIndex = 1;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inferior";
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(579, 12);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(70, 20);
            this.superiorMtxt.TabIndex = 4;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Superior";
            // 
            // pesquisarBt
            // 
            this.pesquisarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarBt.Location = new System.Drawing.Point(655, 9);
            this.pesquisarBt.Name = "pesquisarBt";
            this.pesquisarBt.Size = new System.Drawing.Size(87, 25);
            this.pesquisarBt.TabIndex = 6;
            this.pesquisarBt.Text = "Pesquisar";
            this.pesquisarBt.UseVisualStyleBackColor = true;
            this.pesquisarBt.Click += new System.EventHandler(this.pesquisarBt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // mediaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesquisarBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.superiorMtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inferiorMtxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mediaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média de Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mediaVendas_FormClosing);
            this.Load += new System.EventHandler(this.mediaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pesquisarBt;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}