namespace processosAdministrativos.Telas
{
    partial class consultaNSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaNSerie));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gs_aristeusDataSet = new processosAdministrativos.gs_aristeusDataSet();
            this.nSerieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nSerieTableAdapter = new processosAdministrativos.gs_aristeusDataSetTableAdapters.nSerieTableAdapter();
            this.codProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSerieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(680, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProd,
            this.produto,
            this.nSerie,
            this.pedido,
            this.data});
            this.dataGridView1.DataSource = this.nSerieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(726, 397);
            this.dataGridView1.TabIndex = 2;
            // 
            // gs_aristeusDataSet
            // 
            this.gs_aristeusDataSet.DataSetName = "gs_aristeusDataSet";
            this.gs_aristeusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nSerieBindingSource
            // 
            this.nSerieBindingSource.DataMember = "nSerie";
            this.nSerieBindingSource.DataSource = this.gs_aristeusDataSet;
            // 
            // nSerieTableAdapter
            // 
            this.nSerieTableAdapter.ClearBeforeFill = true;
            // 
            // codProd
            // 
            this.codProd.DataPropertyName = "ns_produto";
            this.codProd.HeaderText = "Cód. Prod.";
            this.codProd.Name = "codProd";
            this.codProd.ReadOnly = true;
            this.codProd.Width = 90;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "itm_descricao";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 250;
            // 
            // nSerie
            // 
            this.nSerie.DataPropertyName = "ns_nSerie";
            this.nSerie.HeaderText = "Nº Série";
            this.nSerie.Name = "nSerie";
            this.nSerie.ReadOnly = true;
            this.nSerie.Width = 190;
            // 
            // pedido
            // 
            this.pedido.DataPropertyName = "ns_pedido";
            this.pedido.HeaderText = "Pedido";
            this.pedido.Name = "pedido";
            this.pedido.ReadOnly = true;
            this.pedido.Width = 70;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 70;
            // 
            // consultaNSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "consultaNSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Nº de Série";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.consultaNSerie_FormClosing);
            this.Load += new System.EventHandler(this.consultaNSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gs_aristeusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSerieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gs_aristeusDataSet gs_aristeusDataSet;
        private System.Windows.Forms.BindingSource nSerieBindingSource;
        private gs_aristeusDataSetTableAdapters.nSerieTableAdapter nSerieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}