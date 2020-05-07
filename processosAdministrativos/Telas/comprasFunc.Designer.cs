namespace processosAdministrativos.Telas
{
    partial class ComprasFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasFunc));
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionarioCb = new System.Windows.Forms.CheckBox();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.pesquisarBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emAbertoCb = new System.Windows.Forms.CheckBox();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.excelBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(13, 13);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(383, 20);
            this.nomeTxt.TabIndex = 0;
            this.nomeTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nomeTxt_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(402, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inferior";
            // 
            // funcionarioCb
            // 
            this.funcionarioCb.AutoSize = true;
            this.funcionarioCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.funcionarioCb.Location = new System.Drawing.Point(12, 39);
            this.funcionarioCb.Name = "funcionarioCb";
            this.funcionarioCb.Size = new System.Drawing.Size(108, 21);
            this.funcionarioCb.TabIndex = 2;
            this.funcionarioCb.Text = "Funcionários";
            this.funcionarioCb.UseVisualStyleBackColor = true;
            this.funcionarioCb.CheckedChanged += new System.EventHandler(this.funcionarioCb_CheckedChanged);
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(460, 13);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(72, 20);
            this.inferiorMtxt.TabIndex = 3;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // pesquisarBt
            // 
            this.pesquisarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pesquisarBt.Location = new System.Drawing.Point(536, 8);
            this.pesquisarBt.Name = "pesquisarBt";
            this.pesquisarBt.Size = new System.Drawing.Size(75, 25);
            this.pesquisarBt.TabIndex = 4;
            this.pesquisarBt.Text = "Pesquisar";
            this.pesquisarBt.UseVisualStyleBackColor = true;
            this.pesquisarBt.Click += new System.EventHandler(this.pesquisarBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documento,
            this.nome,
            this.parcela,
            this.valor});
            this.dataGridView1.Location = new System.Drawing.Point(13, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(598, 409);
            this.dataGridView1.TabIndex = 5;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "rec_documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 80;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "cli_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 290;
            // 
            // parcela
            // 
            this.parcela.DataPropertyName = "rec_parcela";
            this.parcela.HeaderText = "Parcela";
            this.parcela.Name = "parcela";
            this.parcela.ReadOnly = true;
            this.parcela.Width = 80;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "rec_valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 80;
            // 
            // emAbertoCb
            // 
            this.emAbertoCb.AutoSize = true;
            this.emAbertoCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emAbertoCb.Location = new System.Drawing.Point(126, 39);
            this.emAbertoCb.Name = "emAbertoCb";
            this.emAbertoCb.Size = new System.Drawing.Size(92, 21);
            this.emAbertoCb.TabIndex = 6;
            this.emAbertoCb.Text = "Em aberto";
            this.emAbertoCb.UseVisualStyleBackColor = true;
            this.emAbertoCb.CheckedChanged += new System.EventHandler(this.emAbertoCb_CheckedChanged);
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(460, 39);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(72, 20);
            this.superiorMtxt.TabIndex = 8;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(394, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "superior";
            // 
            // excelBt
            // 
            this.excelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.excelBt.Location = new System.Drawing.Point(536, 39);
            this.excelBt.Name = "excelBt";
            this.excelBt.Size = new System.Drawing.Size(75, 25);
            this.excelBt.TabIndex = 9;
            this.excelBt.Text = "Excel";
            this.excelBt.UseVisualStyleBackColor = true;
            this.excelBt.Click += new System.EventHandler(this.excelBt_Click);
            // 
            // comprasFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 491);
            this.Controls.Add(this.excelBt);
            this.Controls.Add(this.superiorMtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emAbertoCb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisarBt);
            this.Controls.Add(this.inferiorMtxt);
            this.Controls.Add(this.funcionarioCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "comprasFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras dos Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.comprasFunc_FormClosing);
            this.Load += new System.EventHandler(this.comprasFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox funcionarioCb;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.Button pesquisarBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.CheckBox emAbertoCb;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button excelBt;
    }
}