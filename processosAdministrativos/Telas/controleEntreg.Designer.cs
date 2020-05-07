namespace processosAdministrativos.Telas
{
    partial class ControleEntreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleEntreg));
            this.label1 = new System.Windows.Forms.Label();
            this.nPedidoLb = new System.Windows.Forms.Label();
            this.nPedidoTxt = new System.Windows.Forms.TextBox();
            this.gravaBt = new System.Windows.Forms.Button();
            this.motoboyLb = new System.Windows.Forms.Label();
            this.motoBoyCb = new System.Windows.Forms.ComboBox();
            this.pedidosGv = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.relatorioBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosGv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nPedidoLb
            // 
            resources.ApplyResources(this.nPedidoLb, "nPedidoLb");
            this.nPedidoLb.Name = "nPedidoLb";
            // 
            // nPedidoTxt
            // 
            resources.ApplyResources(this.nPedidoTxt, "nPedidoTxt");
            this.nPedidoTxt.Name = "nPedidoTxt";
            this.nPedidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NPedidoTxt_KeyPress);
            // 
            // gravaBt
            // 
            resources.ApplyResources(this.gravaBt, "gravaBt");
            this.gravaBt.Name = "gravaBt";
            this.gravaBt.UseVisualStyleBackColor = true;
            this.gravaBt.Click += new System.EventHandler(this.GravaBt_Click);
            // 
            // motoboyLb
            // 
            resources.ApplyResources(this.motoboyLb, "motoboyLb");
            this.motoboyLb.Name = "motoboyLb";
            // 
            // motoBoyCb
            // 
            this.motoBoyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motoBoyCb.FormattingEnabled = true;
            resources.ApplyResources(this.motoBoyCb, "motoBoyCb");
            this.motoBoyCb.Name = "motoBoyCb";
            this.motoBoyCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MotoBoyCb_KeyPress);
            // 
            // pedidosGv
            // 
            this.pedidosGv.AllowUserToAddRows = false;
            this.pedidosGv.AllowUserToDeleteRows = false;
            this.pedidosGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.pedidosGv, "pedidosGv");
            this.pedidosGv.Name = "pedidosGv";
            this.pedidosGv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PedidosGv_CellEndEdit);
            this.pedidosGv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.PedidosGv_EditingControlShowing);
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // relatorioBt
            // 
            resources.ApplyResources(this.relatorioBt, "relatorioBt");
            this.relatorioBt.Name = "relatorioBt";
            this.relatorioBt.UseVisualStyleBackColor = true;
            this.relatorioBt.Click += new System.EventHandler(this.RelatorioBt_Click);
            // 
            // controleEntreg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.relatorioBt);
            this.Controls.Add(this.pedidosGv);
            this.Controls.Add(this.motoBoyCb);
            this.Controls.Add(this.motoboyLb);
            this.Controls.Add(this.gravaBt);
            this.Controls.Add(this.nPedidoTxt);
            this.Controls.Add(this.nPedidoLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "controleEntreg";
            this.Activated += new System.EventHandler(this.ControleEntreg_Activated_1);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControleEntreg_FormClosing);
            this.Load += new System.EventHandler(this.ControleEntreg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nPedidoLb;
        private System.Windows.Forms.TextBox nPedidoTxt;
        private System.Windows.Forms.Button gravaBt;
        private System.Windows.Forms.Label motoboyLb;
        private System.Windows.Forms.ComboBox motoBoyCb;
        private System.Windows.Forms.DataGridView pedidosGv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button relatorioBt;
    }
}

