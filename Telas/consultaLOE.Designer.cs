namespace processosAdministrativos.Telas
{
    partial class consultaLOE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaLOE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opcaoRb = new System.Windows.Forms.RadioButton();
            this.vendedorRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loeconsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.comentarioTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vendasTxt = new System.Windows.Forms.TextBox();
            this.loe_consultaTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.loe_consultaTableAdapter();
            this.excelTb = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loeconsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opcaoRb);
            this.groupBox1.Controls.Add(this.vendedorRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // opcaoRb
            // 
            this.opcaoRb.AutoSize = true;
            this.opcaoRb.Location = new System.Drawing.Point(101, 23);
            this.opcaoRb.Name = "opcaoRb";
            this.opcaoRb.Size = new System.Drawing.Size(68, 21);
            this.opcaoRb.TabIndex = 1;
            this.opcaoRb.TabStop = true;
            this.opcaoRb.Text = "Opção";
            this.opcaoRb.UseVisualStyleBackColor = true;
            // 
            // vendedorRb
            // 
            this.vendedorRb.AutoSize = true;
            this.vendedorRb.Location = new System.Drawing.Point(7, 23);
            this.vendedorRb.Name = "vendedorRb";
            this.vendedorRb.Size = new System.Drawing.Size(88, 21);
            this.vendedorRb.TabIndex = 0;
            this.vendedorRb.TabStop = true;
            this.vendedorRb.Text = "Vendedor";
            this.vendedorRb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.superiorMtxt);
            this.groupBox2.Controls.Add(this.inferiorMtxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(522, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inferior";
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(74, 52);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(85, 23);
            this.superiorMtxt.TabIndex = 1;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(74, 22);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(85, 23);
            this.inferiorMtxt.TabIndex = 0;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(699, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(699, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(14, 76);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(502, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisaTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.vendedor,
            this.opcao,
            this.produto,
            this.qtde,
            this.preco,
            this.comentario,
            this.data,
            this.qtdeSistema});
            this.dataGridView1.DataSource = this.loeconsultaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(769, 338);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // loeconsultaBindingSource
            // 
            this.loeconsultaBindingSource.DataMember = "loe_consulta";
            this.loeconsultaBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comentário";
            // 
            // comentarioTxt
            // 
            this.comentarioTxt.Location = new System.Drawing.Point(99, 446);
            this.comentarioTxt.Name = "comentarioTxt";
            this.comentarioTxt.ReadOnly = true;
            this.comentarioTxt.Size = new System.Drawing.Size(551, 20);
            this.comentarioTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(656, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vendas";
            // 
            // vendasTxt
            // 
            this.vendasTxt.Location = new System.Drawing.Point(718, 446);
            this.vendasTxt.Name = "vendasTxt";
            this.vendasTxt.ReadOnly = true;
            this.vendasTxt.Size = new System.Drawing.Size(64, 20);
            this.vendasTxt.TabIndex = 7;
            // 
            // loe_consultaTableAdapter
            // 
            this.loe_consultaTableAdapter.ClearBeforeFill = true;
            // 
            // excelTb
            // 
            this.excelTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.excelTb.Location = new System.Drawing.Point(699, 72);
            this.excelTb.Name = "excelTb";
            this.excelTb.Size = new System.Drawing.Size(83, 24);
            this.excelTb.TabIndex = 10;
            this.excelTb.Text = "Excel";
            this.excelTb.UseVisualStyleBackColor = true;
            this.excelTb.Click += new System.EventHandler(this.excelTb_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "loe_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // vendedor
            // 
            this.vendedor.DataPropertyName = "vdd_nome";
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 60;
            // 
            // opcao
            // 
            this.opcao.DataPropertyName = "opcao_loe_descricao";
            this.opcao.HeaderText = "Opção";
            this.opcao.Name = "opcao";
            this.opcao.ReadOnly = true;
            this.opcao.Width = 170;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "produt";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 250;
            // 
            // qtde
            // 
            this.qtde.DataPropertyName = "loe_qtde";
            this.qtde.HeaderText = "Qtde";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            this.qtde.Width = 40;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "loe_preco";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 50;
            // 
            // comentario
            // 
            this.comentario.DataPropertyName = "comentario";
            this.comentario.HeaderText = "Comentário";
            this.comentario.Name = "comentario";
            this.comentario.ReadOnly = true;
            this.comentario.Width = 65;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 70;
            // 
            // qtdeSistema
            // 
            this.qtdeSistema.DataPropertyName = "qtdeSist";
            this.qtdeSistema.HeaderText = "Qtde";
            this.qtdeSistema.Name = "qtdeSistema";
            this.qtdeSistema.ReadOnly = true;
            this.qtdeSistema.Visible = false;
            // 
            // consultaLOE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 477);
            this.Controls.Add(this.excelTb);
            this.Controls.Add(this.vendasTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comentarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaLOE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta LOE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultaLOE_FormClosing);
            this.Load += new System.EventHandler(this.consultaLOE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loeconsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opcaoRb;
        private System.Windows.Forms.RadioButton vendedorRb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox comentarioTxt;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource loeconsultaBindingSource;
        private gs_aristeusDataSetTableAdapters.loe_consultaTableAdapter loe_consultaTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vendasTxt;
        private System.Windows.Forms.Button excelTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeSistema;
    }
}