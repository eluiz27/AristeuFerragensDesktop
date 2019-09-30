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
            this.components = new System.ComponentModel.Container();
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
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoboy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroGb.SuspendLayout();
            this.dataGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtroGb
            // 
            this.filtroGb.Controls.Add(this.motoboyRb);
            this.filtroGb.Controls.Add(this.vendedorRb);
            this.filtroGb.Controls.Add(this.clienteRb);
            this.filtroGb.Controls.Add(this.pedidoRb);
            this.filtroGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filtroGb.Location = new System.Drawing.Point(12, 12);
            this.filtroGb.Name = "filtroGb";
            this.filtroGb.Size = new System.Drawing.Size(441, 59);
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
            this.dataGb.Location = new System.Drawing.Point(472, 13);
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
            this.superiorMtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SuperiorMtxt_MouseClick);
            this.superiorMtxt.Leave += new System.EventHandler(this.SuperiorMtxt_Leave);
            // 
            // inferiorMtxt
            // 
            this.inferiorMtxt.Location = new System.Drawing.Point(76, 23);
            this.inferiorMtxt.Mask = "00/00/0000";
            this.inferiorMtxt.Name = "inferiorMtxt";
            this.inferiorMtxt.Size = new System.Drawing.Size(114, 23);
            this.inferiorMtxt.TabIndex = 2;
            this.inferiorMtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InferiorMtxt_MouseClick);
            this.inferiorMtxt.Leave += new System.EventHandler(this.InferiorMtxt_Leave);
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
            this.sairBt.Location = new System.Drawing.Point(675, 22);
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
            this.pesquisarBt.Location = new System.Drawing.Point(675, 64);
            this.pesquisarBt.Name = "pesquisarBt";
            this.pesquisarBt.Size = new System.Drawing.Size(97, 34);
            this.pesquisarBt.TabIndex = 4;
            this.pesquisarBt.Text = "Pesquisar";
            this.pesquisarBt.UseVisualStyleBackColor = true;
            this.pesquisarBt.Click += new System.EventHandler(this.pesquisarBt_Click);
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(12, 77);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(441, 20);
            this.pesquisaTxt.TabIndex = 5;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesqusiarTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.pedido,
            this.cliente,
            this.vendedor,
            this.motoboy,
            this.situacao,
            this.aCaminho,
            this.entregue,
            this.obs});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 372);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDown);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod_contEntre";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // pedido
            // 
            this.pedido.DataPropertyName = "pedido_contEntre";
            this.pedido.HeaderText = "Pedido";
            this.pedido.Name = "pedido";
            this.pedido.Width = 60;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente_contEntre";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.Width = 120;
            // 
            // vendedor
            // 
            this.vendedor.DataPropertyName = "vdd_nome";
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.Width = 80;
            // 
            // motoboy
            // 
            this.motoboy.DataPropertyName = "trp_nome";
            this.motoboy.HeaderText = "Motoboy";
            this.motoboy.Name = "motoboy";
            this.motoboy.Width = 80;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao_contEntre";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.Width = 80;
            // 
            // aCaminho
            // 
            this.aCaminho.DataPropertyName = "dt_aCaminho";
            this.aCaminho.HeaderText = "A caminho";
            this.aCaminho.Name = "aCaminho";
            this.aCaminho.Width = 85;
            // 
            // entregue
            // 
            this.entregue.DataPropertyName = "dt_entregue";
            this.entregue.HeaderText = "Entregue";
            this.entregue.Name = "entregue";
            this.entregue.Width = 85;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs_contEntre";
            this.obs.HeaderText = "Obs.";
            this.obs.Name = "obs";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.ExcluirToolStripMenuItem_Click);
            // 
            // procuraEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 489);
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
            this.Activated += new System.EventHandler(this.ProcuraEntrega_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcuraEntrega_FormClosing);
            this.Load += new System.EventHandler(this.procuraEntrega_Load);
            this.filtroGb.ResumeLayout(false);
            this.filtroGb.PerformLayout();
            this.dataGb.ResumeLayout(false);
            this.dataGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoboy;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCaminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregue;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}