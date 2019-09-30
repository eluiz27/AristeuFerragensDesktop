namespace processosAdministrativos.Telas
{
    partial class indicadoresVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indicadoresVendas));
            this.dataGb = new System.Windows.Forms.GroupBox();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeAten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdePedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGb
            // 
            this.dataGb.Controls.Add(this.inferiorMtxt);
            this.dataGb.Controls.Add(this.superiorMtxt);
            this.dataGb.Controls.Add(this.label7);
            this.dataGb.Controls.Add(this.label2);
            this.dataGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataGb.Location = new System.Drawing.Point(626, 12);
            this.dataGb.Name = "dataGb";
            this.dataGb.Size = new System.Drawing.Size(301, 51);
            this.dataGb.TabIndex = 3;
            this.dataGb.TabStop = false;
            this.dataGb.Text = "Data";
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(65, 20);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(75, 23);
            this.inferiorMtxt.TabIndex = 0;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(214, 20);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(75, 23);
            this.superiorMtxt.TabIndex = 1;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Superior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inferior";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Preencher Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.nDev,
            this.nCan,
            this.qtdeAten,
            this.qtdePedi,
            this.qtdeItem,
            this.devolu,
            this.desco,
            this.totalLiq});
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(915, 407);
            this.dataGridView1.TabIndex = 8;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "no";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // nDev
            // 
            this.nDev.DataPropertyName = "nD";
            this.nDev.HeaderText = "N° Devoluções";
            this.nDev.Name = "nDev";
            this.nDev.ReadOnly = true;
            this.nDev.Width = 110;
            // 
            // nCan
            // 
            this.nCan.DataPropertyName = "nC";
            this.nCan.HeaderText = "N° Cancelados";
            this.nCan.Name = "nCan";
            this.nCan.ReadOnly = true;
            this.nCan.Width = 110;
            // 
            // qtdeAten
            // 
            this.qtdeAten.DataPropertyName = "qA";
            this.qtdeAten.HeaderText = "Qtde. Atend.";
            this.qtdeAten.Name = "qtdeAten";
            this.qtdeAten.ReadOnly = true;
            // 
            // qtdePedi
            // 
            this.qtdePedi.DataPropertyName = "qP";
            this.qtdePedi.HeaderText = "Qtde. Pedido";
            this.qtdePedi.Name = "qtdePedi";
            this.qtdePedi.ReadOnly = true;
            // 
            // qtdeItem
            // 
            this.qtdeItem.DataPropertyName = "qI";
            this.qtdeItem.HeaderText = "Qtde. Itens";
            this.qtdeItem.Name = "qtdeItem";
            this.qtdeItem.ReadOnly = true;
            this.qtdeItem.Width = 90;
            // 
            // devolu
            // 
            this.devolu.DataPropertyName = "de";
            this.devolu.HeaderText = "Devoluções";
            this.devolu.Name = "devolu";
            this.devolu.ReadOnly = true;
            this.devolu.Width = 90;
            // 
            // desco
            // 
            this.desco.DataPropertyName = "des";
            this.desco.HeaderText = "Descontos";
            this.desco.Name = "desco";
            this.desco.ReadOnly = true;
            this.desco.Width = 80;
            // 
            // totalLiq
            // 
            this.totalLiq.DataPropertyName = "tQ";
            this.totalLiq.HeaderText = "Total Liq.";
            this.totalLiq.Name = "totalLiq";
            this.totalLiq.ReadOnly = true;
            this.totalLiq.Width = 80;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Atualuzar Planilha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // indicadoresVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "indicadoresVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indicadores de Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.indicadoresVendas_FormClosing);
            this.Load += new System.EventHandler(this.indicadoresVendas_Load);
            this.dataGb.ResumeLayout(false);
            this.dataGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox dataGb;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeAten;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdePedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn desco;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLiq;
        private System.Windows.Forms.Button button2;
    }
}