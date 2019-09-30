namespace processosAdministrativos.Telas
{
    partial class etiquetaPreco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(etiquetaPreco));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.etiquetaTp = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QtdeTxt = new System.Windows.Forms.TextBox();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.precoAltTp = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imprimirBt = new System.Windows.Forms.Button();
            this.pesquisarBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.etiquetaTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.precoAltTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.etiquetaTp);
            this.tabControl1.Controls.Add(this.precoAltTp);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 332);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // etiquetaTp
            // 
            this.etiquetaTp.BackColor = System.Drawing.SystemColors.Control;
            this.etiquetaTp.Controls.Add(this.dataGridView2);
            this.etiquetaTp.Controls.Add(this.button1);
            this.etiquetaTp.Controls.Add(this.label4);
            this.etiquetaTp.Controls.Add(this.label3);
            this.etiquetaTp.Controls.Add(this.QtdeTxt);
            this.etiquetaTp.Controls.Add(this.codigoTxt);
            this.etiquetaTp.Location = new System.Drawing.Point(4, 22);
            this.etiquetaTp.Name = "etiquetaTp";
            this.etiquetaTp.Padding = new System.Windows.Forms.Padding(3);
            this.etiquetaTp.Size = new System.Drawing.Size(484, 306);
            this.etiquetaTp.TabIndex = 0;
            this.etiquetaTp.Text = "Etiqueta";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(465, 252);
            this.dataGridView2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(296, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qtde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código";
            // 
            // QtdeTxt
            // 
            this.QtdeTxt.Location = new System.Drawing.Point(341, 10);
            this.QtdeTxt.Name = "QtdeTxt";
            this.QtdeTxt.Size = new System.Drawing.Size(100, 20);
            this.QtdeTxt.TabIndex = 2;
            // 
            // codigoTxt
            // 
            this.codigoTxt.Location = new System.Drawing.Point(64, 10);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(226, 20);
            this.codigoTxt.TabIndex = 1;
            // 
            // precoAltTp
            // 
            this.precoAltTp.BackColor = System.Drawing.SystemColors.Control;
            this.precoAltTp.Controls.Add(this.dataGridView1);
            this.precoAltTp.Controls.Add(this.pesquisarBt);
            this.precoAltTp.Controls.Add(this.label1);
            this.precoAltTp.Controls.Add(this.superiorMtxt);
            this.precoAltTp.Controls.Add(this.label2);
            this.precoAltTp.Controls.Add(this.inferiorMtxt);
            this.precoAltTp.Location = new System.Drawing.Point(4, 22);
            this.precoAltTp.Name = "precoAltTp";
            this.precoAltTp.Padding = new System.Windows.Forms.Padding(3);
            this.precoAltTp.Size = new System.Drawing.Size(484, 306);
            this.precoAltTp.TabIndex = 1;
            this.precoAltTp.Text = "Preço alterado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.produto,
            this.preco,
            this.codForn,
            this.selec});
            this.dataGridView1.Location = new System.Drawing.Point(10, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 252);
            this.dataGridView1.TabIndex = 11;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "itm_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "itm_descricao";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 200;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "itm_preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 70;
            // 
            // codForn
            // 
            this.codForn.DataPropertyName = "itm_fornecedor";
            this.codForn.HeaderText = "CodForn";
            this.codForn.Name = "codForn";
            this.codForn.ReadOnly = true;
            this.codForn.Visible = false;
            // 
            // selec
            // 
            this.selec.DataPropertyName = "selec";
            this.selec.HeaderText = "Slec.";
            this.selec.Name = "selec";
            this.selec.Width = 70;
            // 
            // imprimirBt
            // 
            this.imprimirBt.Location = new System.Drawing.Point(429, 350);
            this.imprimirBt.Name = "imprimirBt";
            this.imprimirBt.Size = new System.Drawing.Size(75, 23);
            this.imprimirBt.TabIndex = 10;
            this.imprimirBt.Text = "Imprimir";
            this.imprimirBt.UseVisualStyleBackColor = true;
            this.imprimirBt.Click += new System.EventHandler(this.imprimirBt_Click);
            // 
            // pesquisarBt
            // 
            this.pesquisarBt.Location = new System.Drawing.Point(399, 11);
            this.pesquisarBt.Name = "pesquisarBt";
            this.pesquisarBt.Size = new System.Drawing.Size(75, 23);
            this.pesquisarBt.TabIndex = 9;
            this.pesquisarBt.Text = "Pesquisar";
            this.pesquisarBt.UseVisualStyleBackColor = true;
            this.pesquisarBt.Click += new System.EventHandler(this.pesquisarBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inferior";
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(214, 14);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(73, 20);
            this.superiorMtxt.TabIndex = 8;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(146, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Superior";
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(69, 14);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(71, 20);
            this.inferiorMtxt.TabIndex = 7;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // etiquetaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 381);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.imprimirBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "etiquetaPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas de Preço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.etiquetaPreco_FormClosing);
            this.Load += new System.EventHandler(this.etiquetaPreco_Load);
            this.tabControl1.ResumeLayout(false);
            this.etiquetaTp.ResumeLayout(false);
            this.etiquetaTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.precoAltTp.ResumeLayout(false);
            this.precoAltTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage etiquetaTp;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QtdeTxt;
        private System.Windows.Forms.TextBox codigoTxt;
        private System.Windows.Forms.TabPage precoAltTp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn codForn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selec;
        private System.Windows.Forms.Button imprimirBt;
        private System.Windows.Forms.Button pesquisarBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;



    }
}