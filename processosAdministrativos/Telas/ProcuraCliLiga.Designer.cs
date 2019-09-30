namespace processosAdministrativos.Telas
{
    partial class ProcuraCliLiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraCliLiga));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.filtro = new System.Windows.Forms.GroupBox();
            this.clienteRb = new System.Windows.Forms.RadioButton();
            this.RazaoSocRb = new System.Windows.Forms.RadioButton();
            this.vendedorRb = new System.Windows.Forms.RadioButton();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.nomeFantasia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(12, 67);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(423, 20);
            this.pesquisaTxt.TabIndex = 0;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PesquisaTxt_KeyUp);
            // 
            // filtro
            // 
            this.filtro.Controls.Add(this.clienteRb);
            this.filtro.Controls.Add(this.RazaoSocRb);
            this.filtro.Controls.Add(this.vendedorRb);
            this.filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro.Location = new System.Drawing.Point(13, 13);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(423, 48);
            this.filtro.TabIndex = 1;
            this.filtro.TabStop = false;
            this.filtro.Text = "Filtro";
            // 
            // clienteRb
            // 
            this.clienteRb.AutoSize = true;
            this.clienteRb.Location = new System.Drawing.Point(79, 20);
            this.clienteRb.Name = "clienteRb";
            this.clienteRb.Size = new System.Drawing.Size(131, 20);
            this.clienteRb.TabIndex = 2;
            this.clienteRb.TabStop = true;
            this.clienteRb.Text = "Vendedor/Cliente";
            this.clienteRb.UseVisualStyleBackColor = true;
            // 
            // RazaoSocRb
            // 
            this.RazaoSocRb.AutoSize = true;
            this.RazaoSocRb.Location = new System.Drawing.Point(6, 20);
            this.RazaoSocRb.Name = "RazaoSocRb";
            this.RazaoSocRb.Size = new System.Drawing.Size(67, 20);
            this.RazaoSocRb.TabIndex = 1;
            this.RazaoSocRb.TabStop = true;
            this.RazaoSocRb.Text = "Cliente";
            this.RazaoSocRb.UseVisualStyleBackColor = true;
            // 
            // vendedorRb
            // 
            this.vendedorRb.AutoSize = true;
            this.vendedorRb.Location = new System.Drawing.Point(216, 20);
            this.vendedorRb.Name = "vendedorRb";
            this.vendedorRb.Size = new System.Drawing.Size(86, 20);
            this.vendedorRb.TabIndex = 0;
            this.vendedorRb.TabStop = true;
            this.vendedorRb.Text = "Vendedor";
            this.vendedorRb.UseVisualStyleBackColor = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 195;
            // 
            // nomeFantasia
            // 
            this.nomeFantasia.DataPropertyName = "Vazio";
            this.nomeFantasia.HeaderText = "Nome Fantasia";
            this.nomeFantasia.Name = "nomeFantasia";
            this.nomeFantasia.ReadOnly = true;
            this.nomeFantasia.Width = 165;
            // 
            // ProcuraCliLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcuraCliLiga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ProcuraCliLiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.filtro.ResumeLayout(false);
            this.filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.GroupBox filtro;
        private System.Windows.Forms.RadioButton RazaoSocRb;
        private System.Windows.Forms.RadioButton vendedorRb;
        private System.Windows.Forms.RadioButton clienteRb;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasia;
    }
}