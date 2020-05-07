namespace processosAdministrativos.Telas
{
    partial class ProcuraGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraGrupo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeRb = new System.Windows.Forms.RadioButton();
            this.codigoRb = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nomeRb);
            this.groupBox1.Controls.Add(this.codigoRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // nomeRb
            // 
            this.nomeRb.AutoSize = true;
            this.nomeRb.Location = new System.Drawing.Point(82, 21);
            this.nomeRb.Name = "nomeRb";
            this.nomeRb.Size = new System.Drawing.Size(63, 21);
            this.nomeRb.TabIndex = 2;
            this.nomeRb.TabStop = true;
            this.nomeRb.Text = "Nome";
            this.nomeRb.UseVisualStyleBackColor = true;
            // 
            // codigoRb
            // 
            this.codigoRb.AutoSize = true;
            this.codigoRb.Location = new System.Drawing.Point(6, 21);
            this.codigoRb.Name = "codigoRb";
            this.codigoRb.Size = new System.Drawing.Size(70, 21);
            this.codigoRb.TabIndex = 1;
            this.codigoRb.TabStop = true;
            this.codigoRb.Text = "Código";
            this.codigoRb.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome});
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(424, 320);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "grp_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "grp_descricao";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 300;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaTxt.Location = new System.Drawing.Point(13, 66);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(423, 20);
            this.pesquisaTxt.TabIndex = 4;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nomeTxt_KeyUp);
            // 
            // procuraGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "procuraGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procura Grupo";
            this.Load += new System.EventHandler(this.procuraGrupo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nomeRb;
        private System.Windows.Forms.RadioButton codigoRb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}