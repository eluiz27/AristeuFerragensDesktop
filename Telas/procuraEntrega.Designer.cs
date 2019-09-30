namespace processosAdministrativos.Telas
{
    partial class procuraEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(procuraEntrega));
            this.filtroGb = new System.Windows.Forms.GroupBox();
            this.motoboyRb = new System.Windows.Forms.RadioButton();
            this.vendedorRb = new System.Windows.Forms.RadioButton();
            this.clienteRb = new System.Windows.Forms.RadioButton();
            this.pedidoRb = new System.Windows.Forms.RadioButton();
            this.dataGb = new System.Windows.Forms.GroupBox();
            this.superiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.inferiorMtxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sairBt = new System.Windows.Forms.Button();
            this.pesquisarBt = new System.Windows.Forms.Button();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nPedidoTxt = new System.Windows.Forms.TextBox();
            this.nPedidoLb = new System.Windows.Forms.Label();
            this.motoboyTxt = new System.Windows.Forms.TextBox();
            this.motoboyLb = new System.Windows.Forms.Label();
            this.clienteLb = new System.Windows.Forms.Label();
            this.vendedorLb = new System.Windows.Forms.Label();
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.vendedorTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gravaBt = new System.Windows.Forms.Button();
            this.limparBt = new System.Windows.Forms.Button();
            this.pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoboy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtroGb.SuspendLayout();
            this.dataGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtroGb
            // 
            this.filtroGb.Controls.Add(this.motoboyRb);
            this.filtroGb.Controls.Add(this.vendedorRb);
            this.filtroGb.Controls.Add(this.clienteRb);
            this.filtroGb.Controls.Add(this.pedidoRb);
            this.filtroGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filtroGb.Location = new System.Drawing.Point(12, 101);
            this.filtroGb.Name = "filtroGb";
            this.filtroGb.Size = new System.Drawing.Size(371, 59);
            this.filtroGb.TabIndex = 1;
            this.filtroGb.TabStop = false;
            this.filtroGb.Text = "Filtro";
            // 
            // motoboyRb
            // 
            this.motoboyRb.AutoSize = true;
            this.motoboyRb.Location = new System.Drawing.Point(270, 23);
            this.motoboyRb.Name = "motoboyRb";
            this.motoboyRb.Size = new System.Drawing.Size(80, 21);
            this.motoboyRb.TabIndex = 3;
            this.motoboyRb.TabStop = true;
            this.motoboyRb.Text = "Motoboy";
            this.motoboyRb.UseVisualStyleBackColor = true;
            // 
            // vendedorRb
            // 
            this.vendedorRb.AutoSize = true;
            this.vendedorRb.Location = new System.Drawing.Point(158, 23);
            this.vendedorRb.Name = "vendedorRb";
            this.vendedorRb.Size = new System.Drawing.Size(106, 21);
            this.vendedorRb.TabIndex = 2;
            this.vendedorRb.TabStop = true;
            this.vendedorRb.Text = "Vendedor(a)";
            this.vendedorRb.UseVisualStyleBackColor = true;
            // 
            // clienteRb
            // 
            this.clienteRb.AutoSize = true;
            this.clienteRb.Location = new System.Drawing.Point(83, 23);
            this.clienteRb.Name = "clienteRb";
            this.clienteRb.Size = new System.Drawing.Size(69, 21);
            this.clienteRb.TabIndex = 1;
            this.clienteRb.TabStop = true;
            this.clienteRb.Text = "Cliente";
            this.clienteRb.UseVisualStyleBackColor = true;
            // 
            // pedidoRb
            // 
            this.pedidoRb.AutoSize = true;
            this.pedidoRb.Location = new System.Drawing.Point(7, 23);
            this.pedidoRb.Name = "pedidoRb";
            this.pedidoRb.Size = new System.Drawing.Size(70, 21);
            this.pedidoRb.TabIndex = 0;
            this.pedidoRb.TabStop = true;
            this.pedidoRb.Text = "Pedido";
            this.pedidoRb.UseVisualStyleBackColor = true;
            // 
            // dataGb
            // 
            this.dataGb.Controls.Add(this.superiorMtxt);
            this.dataGb.Controls.Add(this.inferiorMtxt);
            this.dataGb.Controls.Add(this.label2);
            this.dataGb.Controls.Add(this.label1);
            this.dataGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataGb.Location = new System.Drawing.Point(390, 101);
            this.dataGb.Name = "dataGb";
            this.dataGb.Size = new System.Drawing.Size(196, 85);
            this.dataGb.TabIndex = 2;
            this.dataGb.TabStop = false;
            this.dataGb.Text = "Data";
            // 
            // superiorMtxt
            // 
            this.superiorMtxt.Location = new System.Drawing.Point(76, 53);
            this.superiorMtxt.Mask = "00/00/0000";
            this.superiorMtxt.Name = "superiorMtxt";
            this.superiorMtxt.Size = new System.Drawing.Size(114, 23);
            this.superiorMtxt.TabIndex = 3;
            this.superiorMtxt.ValidatingType = typeof(System.DateTime);
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(76, 23);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(114, 23);
            this.inferiorMtxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inferior";
            // 
            // sairBt
            // 
            this.sairBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sairBt.Location = new System.Drawing.Point(593, 110);
            this.sairBt.Name = "sairBt";
            this.sairBt.Size = new System.Drawing.Size(97, 34);
            this.sairBt.TabIndex = 3;
            this.sairBt.Text = "Sair";
            this.sairBt.UseVisualStyleBackColor = true;
            this.sairBt.Click += new System.EventHandler(this.sairBt_Click);
            // 
            // pesquisarBt
            // 
            this.pesquisarBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pesquisarBt.Location = new System.Drawing.Point(593, 152);
            this.pesquisarBt.Name = "pesquisarBt";
            this.pesquisarBt.Size = new System.Drawing.Size(97, 34);
            this.pesquisarBt.TabIndex = 4;
            this.pesquisarBt.Text = "Pesquisar";
            this.pesquisarBt.UseVisualStyleBackColor = true;
            this.pesquisarBt.Click += new System.EventHandler(this.pesquisarBt_Click);
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(12, 166);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(371, 20);
            this.pesquisaTxt.TabIndex = 5;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesqusiarTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pedido,
            this.vendedor,
            this.cliente,
            this.motoboy,
            this.aCaminho,
            this.entregue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 372);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gravaBt);
            this.groupBox1.Controls.Add(this.limparBt);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.motoboyTxt);
            this.groupBox1.Controls.Add(this.motoboyLb);
            this.groupBox1.Controls.Add(this.clienteLb);
            this.groupBox1.Controls.Add(this.vendedorLb);
            this.groupBox1.Controls.Add(this.clienteTxt);
            this.groupBox1.Controls.Add(this.vendedorTxt);
            this.groupBox1.Controls.Add(this.nPedidoTxt);
            this.groupBox1.Controls.Add(this.nPedidoLb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // nPedidoTxt
            // 
            this.nPedidoTxt.Location = new System.Drawing.Point(90, 16);
            this.nPedidoTxt.Name = "nPedidoTxt";
            this.nPedidoTxt.Size = new System.Drawing.Size(90, 22);
            this.nPedidoTxt.TabIndex = 0;
            this.nPedidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nPedidoTxt_KeyPress);
            this.nPedidoTxt.Leave += new System.EventHandler(this.nPedidoTxt_Leave);
            // 
            // nPedidoLb
            // 
            this.nPedidoLb.AutoSize = true;
            this.nPedidoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nPedidoLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nPedidoLb.Location = new System.Drawing.Point(6, 18);
            this.nPedidoLb.Name = "nPedidoLb";
            this.nPedidoLb.Size = new System.Drawing.Size(78, 20);
            this.nPedidoLb.TabIndex = 7;
            this.nPedidoLb.Text = "N° Pedido";
            // 
            // motoboyTxt
            // 
            this.motoboyTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.motoboyTxt.Location = new System.Drawing.Point(90, 44);
            this.motoboyTxt.Name = "motoboyTxt";
            this.motoboyTxt.Size = new System.Drawing.Size(239, 22);
            this.motoboyTxt.TabIndex = 1;
            // 
            // motoboyLb
            // 
            this.motoboyLb.AutoSize = true;
            this.motoboyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.motoboyLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.motoboyLb.Location = new System.Drawing.Point(14, 46);
            this.motoboyLb.Name = "motoboyLb";
            this.motoboyLb.Size = new System.Drawing.Size(70, 20);
            this.motoboyLb.TabIndex = 10;
            this.motoboyLb.Text = "Motoboy";
            // 
            // clienteLb
            // 
            this.clienteLb.AutoSize = true;
            this.clienteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clienteLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clienteLb.Location = new System.Drawing.Point(393, 16);
            this.clienteLb.Name = "clienteLb";
            this.clienteLb.Size = new System.Drawing.Size(58, 20);
            this.clienteLb.TabIndex = 9;
            this.clienteLb.Text = "Cliente";
            // 
            // vendedorLb
            // 
            this.vendedorLb.AutoSize = true;
            this.vendedorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vendedorLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vendedorLb.Location = new System.Drawing.Point(186, 18);
            this.vendedorLb.Name = "vendedorLb";
            this.vendedorLb.Size = new System.Drawing.Size(98, 20);
            this.vendedorLb.TabIndex = 8;
            this.vendedorLb.Text = "Vendedor(a)";
            // 
            // clienteTxt
            // 
            this.clienteTxt.Enabled = false;
            this.clienteTxt.Location = new System.Drawing.Point(457, 16);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.Size = new System.Drawing.Size(215, 22);
            this.clienteTxt.TabIndex = 6;
            // 
            // vendedorTxt
            // 
            this.vendedorTxt.Enabled = false;
            this.vendedorTxt.Location = new System.Drawing.Point(290, 16);
            this.vendedorTxt.Name = "vendedorTxt";
            this.vendedorTxt.Size = new System.Drawing.Size(97, 22);
            this.vendedorTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(335, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Situação";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A Caminho",
            "Entregue"});
            this.comboBox1.Location = new System.Drawing.Point(413, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // gravaBt
            // 
            this.gravaBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gravaBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gravaBt.Location = new System.Drawing.Point(597, 43);
            this.gravaBt.Name = "gravaBt";
            this.gravaBt.Size = new System.Drawing.Size(75, 27);
            this.gravaBt.TabIndex = 3;
            this.gravaBt.Text = "Gravar";
            this.gravaBt.UseVisualStyleBackColor = true;
            this.gravaBt.Click += new System.EventHandler(this.gravaBt_Click);
            // 
            // limparBt
            // 
            this.limparBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.limparBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.limparBt.Location = new System.Drawing.Point(516, 43);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(75, 27);
            this.limparBt.TabIndex = 4;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.limparBt_Click);
            // 
            // pedido
            // 
            this.pedido.DataPropertyName = "pedido_contEntre";
            this.pedido.HeaderText = "Pedido";
            this.pedido.Name = "pedido";
            this.pedido.ReadOnly = true;
            this.pedido.Width = 60;
            // 
            // vendedor
            // 
            this.vendedor.DataPropertyName = "vendedor_contEntre";
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 80;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente_contEntre";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 190;
            // 
            // motoboy
            // 
            this.motoboy.DataPropertyName = "trp_nome";
            this.motoboy.HeaderText = "Motoboy";
            this.motoboy.Name = "motoboy";
            this.motoboy.ReadOnly = true;
            // 
            // aCaminho
            // 
            this.aCaminho.DataPropertyName = "dt_aCaminho";
            this.aCaminho.HeaderText = "A caminho";
            this.aCaminho.Name = "aCaminho";
            this.aCaminho.ReadOnly = true;
            this.aCaminho.Width = 90;
            // 
            // entregue
            // 
            this.entregue.DataPropertyName = "dt_entregue";
            this.entregue.HeaderText = "Entregue";
            this.entregue.Name = "entregue";
            this.entregue.ReadOnly = true;
            this.entregue.Width = 90;
            // 
            // procuraEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.pesquisarBt);
            this.Controls.Add(this.sairBt);
            this.Controls.Add(this.dataGb);
            this.Controls.Add(this.filtroGb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "procuraEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Entrega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.procuraEntrega_FormClosing);
            this.Load += new System.EventHandler(this.procuraEntrega_Load);
            this.filtroGb.ResumeLayout(false);
            this.filtroGb.PerformLayout();
            this.dataGb.ResumeLayout(false);
            this.dataGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox filtroGb;
        private System.Windows.Forms.RadioButton vendedorRb;
        private System.Windows.Forms.RadioButton clienteRb;
        private System.Windows.Forms.RadioButton pedidoRb;
        private System.Windows.Forms.RadioButton motoboyRb;
        private System.Windows.Forms.GroupBox dataGb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox superiorMtxt;
        private System.Windows.Forms.MaskedTextBox inferiorMtxt;
        private System.Windows.Forms.Button sairBt;
        private System.Windows.Forms.Button pesquisarBt;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nPedidoTxt;
        private System.Windows.Forms.Label nPedidoLb;
        private System.Windows.Forms.TextBox motoboyTxt;
        private System.Windows.Forms.Label motoboyLb;
        private System.Windows.Forms.Label clienteLb;
        private System.Windows.Forms.Label vendedorLb;
        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.TextBox vendedorTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gravaBt;
        private System.Windows.Forms.Button limparBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoboy;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCaminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregue;
    }
}