namespace processosAdministrativos.Telas
{
    partial class Ligacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ligacoes));
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paraTxt = new System.Windows.Forms.TextBox();
            this.comfirmaBt = new System.Windows.Forms.Button();
            this.limparBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.horaMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.situacaoCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.obslabel = new System.Windows.Forms.Label();
            this.obsTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.situacaoRb = new System.Windows.Forms.RadioButton();
            this.paraRb = new System.Windows.Forms.RadioButton();
            this.clienteRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteTxt
            // 
            this.clienteTxt.Location = new System.Drawing.Point(67, 14);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.Size = new System.Drawing.Size(143, 20);
            this.clienteTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Para";
            // 
            // paraTxt
            // 
            this.paraTxt.Location = new System.Drawing.Point(259, 14);
            this.paraTxt.Name = "paraTxt";
            this.paraTxt.Size = new System.Drawing.Size(134, 20);
            this.paraTxt.TabIndex = 1;
            // 
            // comfirmaBt
            // 
            this.comfirmaBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmaBt.Location = new System.Drawing.Point(696, 12);
            this.comfirmaBt.Name = "comfirmaBt";
            this.comfirmaBt.Size = new System.Drawing.Size(73, 27);
            this.comfirmaBt.TabIndex = 6;
            this.comfirmaBt.Text = "Confirmar";
            this.comfirmaBt.UseVisualStyleBackColor = true;
            this.comfirmaBt.Click += new System.EventHandler(this.ComfirmaBt_Click);
            // 
            // limparBt
            // 
            this.limparBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBt.Location = new System.Drawing.Point(696, 45);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(73, 27);
            this.limparBt.TabIndex = 5;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.LimparBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.hora,
            this.cliente,
            this.para,
            this.situacao,
            this.obs,
            this.codigo});
            this.dataGridView1.Location = new System.Drawing.Point(15, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 348);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            // 
            // horaMtxt
            // 
            this.horaMtxt.Location = new System.Drawing.Point(623, 14);
            this.horaMtxt.Mask = "00:00";
            this.horaMtxt.Name = "horaMtxt";
            this.horaMtxt.Size = new System.Drawing.Size(41, 20);
            this.horaMtxt.TabIndex = 3;
            this.horaMtxt.ValidatingType = typeof(System.DateTime);
            this.horaMtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoraMtxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora";
            // 
            // situacaoCb
            // 
            this.situacaoCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.situacaoCb.FormattingEnabled = true;
            this.situacaoCb.Items.AddRange(new object[] {
            "Transferido",
            "Recado",
            "Desligou",
            "Pessoal",
            "Outros"});
            this.situacaoCb.Location = new System.Drawing.Point(464, 14);
            this.situacaoCb.Name = "situacaoCb";
            this.situacaoCb.Size = new System.Drawing.Size(110, 21);
            this.situacaoCb.TabIndex = 2;
            this.situacaoCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SituacaoCb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(399, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Situação";
            // 
            // obslabel
            // 
            this.obslabel.AutoSize = true;
            this.obslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obslabel.Location = new System.Drawing.Point(24, 41);
            this.obslabel.Name = "obslabel";
            this.obslabel.Size = new System.Drawing.Size(36, 16);
            this.obslabel.TabIndex = 11;
            this.obslabel.Text = "Obs.";
            // 
            // obsTxt
            // 
            this.obsTxt.Location = new System.Drawing.Point(67, 40);
            this.obsTxt.Name = "obsTxt";
            this.obsTxt.Size = new System.Drawing.Size(326, 20);
            this.obsTxt.TabIndex = 4;
            this.obsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObsTxt_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.situacaoRb);
            this.groupBox1.Controls.Add(this.paraRb);
            this.groupBox1.Controls.Add(this.clienteRb);
            this.groupBox1.Controls.Add(this.pesquisaTxt);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 74);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.superiorMtxt);
            this.groupBox2.Controls.Add(this.inferiorMtxt);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Superior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Inferior";
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(168, 19);
            this.superiorMtxt.Mask = "00/00/00";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(57, 20);
            this.superiorMtxt.TabIndex = 1;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            this.superiorMtxt.GotFocus += new System.EventHandler(this.SuperiorMtxt_GotFocus);
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(51, 19);
            this.inferiorMtxt.Mask = "00/00/00";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(59, 20);
            this.inferiorMtxt.TabIndex = 0;
            this.inferiorMtxt.ValidatingType = typeof(System.DateTime);
            this.inferiorMtxt.GotFocus += new System.EventHandler(this.InferiorMtxt_GotFocus);
            // 
            // situacaoRb
            // 
            this.situacaoRb.AutoSize = true;
            this.situacaoRb.Location = new System.Drawing.Point(122, 20);
            this.situacaoRb.Name = "situacaoRb";
            this.situacaoRb.Size = new System.Drawing.Size(67, 17);
            this.situacaoRb.TabIndex = 3;
            this.situacaoRb.TabStop = true;
            this.situacaoRb.Text = "Situação";
            this.situacaoRb.UseVisualStyleBackColor = true;
            // 
            // paraRb
            // 
            this.paraRb.AutoSize = true;
            this.paraRb.Location = new System.Drawing.Point(69, 20);
            this.paraRb.Name = "paraRb";
            this.paraRb.Size = new System.Drawing.Size(47, 17);
            this.paraRb.TabIndex = 2;
            this.paraRb.TabStop = true;
            this.paraRb.Text = "Para";
            this.paraRb.UseVisualStyleBackColor = true;
            // 
            // clienteRb
            // 
            this.clienteRb.AutoSize = true;
            this.clienteRb.Location = new System.Drawing.Point(6, 19);
            this.clienteRb.Name = "clienteRb";
            this.clienteRb.Size = new System.Drawing.Size(57, 17);
            this.clienteRb.TabIndex = 1;
            this.clienteRb.TabStop = true;
            this.clienteRb.Text = "Cliente";
            this.clienteRb.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(7, 45);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(418, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PesquisaTxt_KeyUp);
            // 
            // data
            // 
            this.data.DataPropertyName = "dataFormatada";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 80;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "liga_hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 70;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "liga_cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 180;
            // 
            // para
            // 
            this.para.DataPropertyName = "liga_para";
            this.para.HeaderText = "Para";
            this.para.Name = "para";
            this.para.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "liga_situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "liga_obs";
            this.obs.HeaderText = "Obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 150;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "liga_id";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(565, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Consultar cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Ligacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 514);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.obslabel);
            this.Controls.Add(this.obsTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.situacaoCb);
            this.Controls.Add(this.horaMtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.limparBt);
            this.Controls.Add(this.comfirmaBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paraTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ligacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ligações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ligacoes_FormClosing);
            this.Load += new System.EventHandler(this.Ligacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paraTxt;
        private System.Windows.Forms.Button comfirmaBt;
        private System.Windows.Forms.Button limparBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox horaMtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox situacaoCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label obslabel;
        private System.Windows.Forms.TextBox obsTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.RadioButton situacaoRb;
        private System.Windows.Forms.RadioButton paraRb;
        private System.Windows.Forms.RadioButton clienteRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn para;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.Button button3;
    }
}