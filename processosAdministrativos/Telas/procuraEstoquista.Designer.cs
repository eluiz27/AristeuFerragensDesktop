namespace processosAdministrativos.Telas
{
    partial class ProcuraEstoquista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraEstoquista));
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.estoquistaTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.estoquistaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(70, 12);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(163, 20);
            this.pesquisaTxt.TabIndex = 1;
            this.pesquisaTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nomeTxt_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome});
            this.dataGridView1.DataSource = this.estoquistaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(222, 211);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "est_codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "est_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // estoquistaBindingSource
            // 
            this.estoquistaBindingSource.DataMember = "estoquista";
            this.estoquistaBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoquistaTableAdapter
            // 
            this.estoquistaTableAdapter.ClearBeforeFill = true;
            // 
            // procuraEstoquista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pesquisaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "procuraEstoquista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoquista";
            this.Load += new System.EventHandler(this.alterarEstoquista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoquistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource estoquistaBindingSource;
        private gs_aristeusDataSetTableAdapters.estoquistaTableAdapter estoquistaTableAdapter;
    }
}