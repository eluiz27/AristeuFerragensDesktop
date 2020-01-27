namespace processosAdministrativos.Telas
{
    partial class Restricoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restricoes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cargoCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.infoPcBt = new System.Windows.Forms.Button();
            this.dashLojaCb = new System.Windows.Forms.CheckBox();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restrições";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cargo,
            this.computador,
            this.usuario,
            this.dash});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(603, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargo:";
            // 
            // cargoCb
            // 
            this.cargoCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoCb.FormattingEnabled = true;
            this.cargoCb.Items.AddRange(new object[] {
            "Compras",
            "Expedição",
            "Estoque",
            "Financeiro",
            "Vendas",
            "Marketing",
            "Recepção",
            "Adm_system"});
            this.cargoCb.Location = new System.Drawing.Point(66, 8);
            this.cargoCb.Name = "cargoCb";
            this.cargoCb.Size = new System.Drawing.Size(121, 21);
            this.cargoCb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computador:";
            // 
            // compTxt
            // 
            this.compTxt.Location = new System.Drawing.Point(294, 8);
            this.compTxt.Name = "compTxt";
            this.compTxt.Size = new System.Drawing.Size(123, 20);
            this.compTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "usuario:";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(495, 8);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(132, 20);
            this.usuarioTxt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(562, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(495, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // infoPcBt
            // 
            this.infoPcBt.Location = new System.Drawing.Point(441, 34);
            this.infoPcBt.Name = "infoPcBt";
            this.infoPcBt.Size = new System.Drawing.Size(48, 28);
            this.infoPcBt.TabIndex = 9;
            this.infoPcBt.Text = "Info.";
            this.infoPcBt.UseVisualStyleBackColor = true;
            this.infoPcBt.Click += new System.EventHandler(this.infoPcBt_Click);
            // 
            // dashLojaCb
            // 
            this.dashLojaCb.AutoSize = true;
            this.dashLojaCb.Location = new System.Drawing.Point(14, 44);
            this.dashLojaCb.Name = "dashLojaCb";
            this.dashLojaCb.Size = new System.Drawing.Size(107, 17);
            this.dashLojaCb.TabIndex = 10;
            this.dashLojaCb.Text = "Dashboard - Loja";
            this.dashLojaCb.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "restC_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "restC_cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 150;
            // 
            // computador
            // 
            this.computador.DataPropertyName = "restC_computador";
            this.computador.HeaderText = "Computador";
            this.computador.Name = "computador";
            this.computador.ReadOnly = true;
            this.computador.Width = 200;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "restC_usuario";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 130;
            // 
            // dash
            // 
            this.dash.DataPropertyName = "restC_dash";
            this.dash.HeaderText = "Dash";
            this.dash.Name = "dash";
            this.dash.ReadOnly = true;
            this.dash.Width = 50;
            // 
            // Restricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 397);
            this.Controls.Add(this.dashLojaCb);
            this.Controls.Add(this.infoPcBt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cargoCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Restricoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restrições";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.restricoes_FormClosing);
            this.Load += new System.EventHandler(this.restricoes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cargoCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox compTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button infoPcBt;
        private System.Windows.Forms.CheckBox dashLojaCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn computador;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dash;
    }
}