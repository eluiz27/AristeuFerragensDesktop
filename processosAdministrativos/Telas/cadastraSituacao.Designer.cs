namespace processosAdministrativos.Telas
{
    partial class CadastraSituacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraSituacao));
            this.label1 = new System.Windows.Forms.Label();
            this.situacaoTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.fallowupsitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fallowupsitTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.fallowupsitTableAdapter();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallowupsitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Situação";
            // 
            // situacaoTxt
            // 
            this.situacaoTxt.Location = new System.Drawing.Point(82, 10);
            this.situacaoTxt.Name = "situacaoTxt";
            this.situacaoTxt.Size = new System.Drawing.Size(219, 20);
            this.situacaoTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(226, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.situacao});
            this.dataGridView1.DataSource = this.fallowupsitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(285, 100);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fallowupsitBindingSource
            // 
            this.fallowupsitBindingSource.DataMember = "fallowupsit";
            this.fallowupsitBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // fallowupsitTableAdapter
            // 
            this.fallowupsitTableAdapter.ClearBeforeFill = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "fups_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "fups_nome";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 145;
            // 
            // cadastraSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 181);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.situacaoTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadastraSituacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Situação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cadastraSituacao_FormClosing);
            this.Load += new System.EventHandler(this.cadastraSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallowupsitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox situacaoTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource fallowupsitBindingSource;
        private gs_aristeusDataSetTableAdapters.fallowupsitTableAdapter fallowupsitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}