namespace processosAdministrativos.Telas
{
    partial class ProcuraUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraUsuarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usuarioRb = new System.Windows.Forms.RadioButton();
            this.codigoRb = new System.Windows.Forms.RadioButton();
            this.pesquisarTxt = new System.Windows.Forms.TextBox();
            this.acesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acesso,
            this.usuario,
            this.senha});
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(354, 257);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usuarioRb);
            this.groupBox1.Controls.Add(this.codigoRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // usuarioRb
            // 
            this.usuarioRb.AutoSize = true;
            this.usuarioRb.Location = new System.Drawing.Point(83, 21);
            this.usuarioRb.Name = "usuarioRb";
            this.usuarioRb.Size = new System.Drawing.Size(73, 20);
            this.usuarioRb.TabIndex = 1;
            this.usuarioRb.TabStop = true;
            this.usuarioRb.Text = "Usuário";
            this.usuarioRb.UseVisualStyleBackColor = true;
            // 
            // codigoRb
            // 
            this.codigoRb.AutoSize = true;
            this.codigoRb.Location = new System.Drawing.Point(6, 21);
            this.codigoRb.Name = "codigoRb";
            this.codigoRb.Size = new System.Drawing.Size(70, 20);
            this.codigoRb.TabIndex = 0;
            this.codigoRb.TabStop = true;
            this.codigoRb.Text = "Código";
            this.codigoRb.UseVisualStyleBackColor = true;
            // 
            // pesquisarTxt
            // 
            this.pesquisarTxt.Location = new System.Drawing.Point(12, 67);
            this.pesquisarTxt.Name = "pesquisarTxt";
            this.pesquisarTxt.Size = new System.Drawing.Size(354, 20);
            this.pesquisarTxt.TabIndex = 0;
            this.pesquisarTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pesquisarTxt_KeyUp);
            // 
            // acesso
            // 
            this.acesso.DataPropertyName = "sen_acesso";
            this.acesso.HeaderText = "Acesso";
            this.acesso.Name = "acesso";
            this.acesso.ReadOnly = true;
            this.acesso.Width = 80;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "sen_usuario";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 200;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "res_senha";
            this.senha.HeaderText = "senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // procuraUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 362);
            this.Controls.Add(this.pesquisarTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "procuraUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "procuraUsuarios";
            this.Load += new System.EventHandler(this.procuraUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton usuarioRb;
        private System.Windows.Forms.RadioButton codigoRb;
        private System.Windows.Forms.TextBox pesquisarTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn acesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
    }
}