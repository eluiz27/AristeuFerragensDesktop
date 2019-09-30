namespace processosAdministrativos.Telas
{
    partial class grupoEmails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grupoEmails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grupoRb = new System.Windows.Forms.RadioButton();
            this.donoRb = new System.Windows.Forms.RadioButton();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoemailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.donoTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.grupoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salvarBt = new System.Windows.Forms.Button();
            this.grupo_emailsTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.grupo_emailsTableAdapter();
            this.limparBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoemailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grupoRb);
            this.groupBox1.Controls.Add(this.donoRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // grupoRb
            // 
            this.grupoRb.AutoSize = true;
            this.grupoRb.Location = new System.Drawing.Point(73, 22);
            this.grupoRb.Name = "grupoRb";
            this.grupoRb.Size = new System.Drawing.Size(63, 20);
            this.grupoRb.TabIndex = 1;
            this.grupoRb.TabStop = true;
            this.grupoRb.Text = "Grupo";
            this.grupoRb.UseVisualStyleBackColor = true;
            // 
            // donoRb
            // 
            this.donoRb.AutoSize = true;
            this.donoRb.Location = new System.Drawing.Point(7, 22);
            this.donoRb.Name = "donoRb";
            this.donoRb.Size = new System.Drawing.Size(59, 20);
            this.donoRb.TabIndex = 0;
            this.donoRb.TabStop = true;
            this.donoRb.Text = "Dono";
            this.donoRb.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(156, 172);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(251, 20);
            this.pesquisaTxt.TabIndex = 8;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.dono,
            this.grupo,
            this.email});
            this.dataGridView1.DataSource = this.grupoemailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(396, 161);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "grpe_codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // dono
            // 
            this.dono.DataPropertyName = "grpe_dono";
            this.dono.HeaderText = "Dono";
            this.dono.Name = "dono";
            this.dono.ReadOnly = true;
            this.dono.Width = 70;
            // 
            // grupo
            // 
            this.grupo.DataPropertyName = "grpe_grupo";
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            this.grupo.Width = 70;
            // 
            // email
            // 
            this.email.DataPropertyName = "grpe_email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 190;
            // 
            // grupoemailsBindingSource
            // 
            this.grupoemailsBindingSource.DataMember = "grupo_emails";
            this.grupoemailsBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donoTxt
            // 
            this.donoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.donoTxt.Location = new System.Drawing.Point(59, 10);
            this.donoTxt.Name = "donoTxt";
            this.donoTxt.Size = new System.Drawing.Size(326, 20);
            this.donoTxt.TabIndex = 0;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(59, 63);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(326, 20);
            this.emailTxt.TabIndex = 2;
            // 
            // grupoTxt
            // 
            this.grupoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.grupoTxt.Location = new System.Drawing.Point(59, 37);
            this.grupoTxt.Name = "grupoTxt";
            this.grupoTxt.Size = new System.Drawing.Size(326, 20);
            this.grupoTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grupo";
            // 
            // salvarBt
            // 
            this.salvarBt.Location = new System.Drawing.Point(310, 89);
            this.salvarBt.Name = "salvarBt";
            this.salvarBt.Size = new System.Drawing.Size(75, 23);
            this.salvarBt.TabIndex = 5;
            this.salvarBt.Text = "Salvar";
            this.salvarBt.UseVisualStyleBackColor = true;
            this.salvarBt.Click += new System.EventHandler(this.salvarBt_Click);
            // 
            // grupo_emailsTableAdapter
            // 
            this.grupo_emailsTableAdapter.ClearBeforeFill = true;
            // 
            // limparBt
            // 
            this.limparBt.Location = new System.Drawing.Point(229, 89);
            this.limparBt.Name = "limparBt";
            this.limparBt.Size = new System.Drawing.Size(75, 23);
            this.limparBt.TabIndex = 3;
            this.limparBt.Text = "Limpar";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.limparBt_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.donoTxt);
            this.panel1.Controls.Add(this.limparBt);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.salvarBt);
            this.panel1.Controls.Add(this.grupoTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 123);
            this.panel1.TabIndex = 11;
            // 
            // grupoEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "grupoEmails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "grupoEmails";
            this.Load += new System.EventHandler(this.grupoEmails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoemailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton grupoRb;
        private System.Windows.Forms.RadioButton donoRb;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox donoTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox grupoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salvarBt;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource grupoemailsBindingSource;
        private gs_aristeusDataSetTableAdapters.grupo_emailsTableAdapter grupo_emailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dono;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button limparBt;
        private System.Windows.Forms.Panel panel1;
    }
}