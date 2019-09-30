namespace processosAdministrativos.Telas
{
    partial class controleEntreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controleEntreg));
            this.label1 = new System.Windows.Forms.Label();
            this.nPedidoLb = new System.Windows.Forms.Label();
            this.nPedidoTxt = new System.Windows.Forms.TextBox();
            this.vendedorTxt = new System.Windows.Forms.TextBox();
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.vendedorLb = new System.Windows.Forms.Label();
            this.clienteLb = new System.Windows.Forms.Label();
            this.aCaminhoRd = new System.Windows.Forms.RadioButton();
            this.entregueRd = new System.Windows.Forms.RadioButton();
            this.expedicaoRd = new System.Windows.Forms.RadioButton();
            this.situacaoGb = new System.Windows.Forms.GroupBox();
            this.limparBt = new System.Windows.Forms.Button();
            this.relatorioBt = new System.Windows.Forms.Button();
            this.gravaBt = new System.Windows.Forms.Button();
            this.motoboyLb = new System.Windows.Forms.Label();
            this.motoboyTxt = new System.Windows.Forms.TextBox();
            this.situacaoGb.SuspendLayout();
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
            this.nPedidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nPedidoTxt_KeyPress);
            // 
            // vendedorTxt
            // 
            resources.ApplyResources(this.vendedorTxt, "vendedorTxt");
            this.vendedorTxt.Name = "vendedorTxt";
            // 
            // clienteTxt
            // 
            resources.ApplyResources(this.clienteTxt, "clienteTxt");
            this.clienteTxt.Name = "clienteTxt";
            // 
            // vendedorLb
            // 
            resources.ApplyResources(this.vendedorLb, "vendedorLb");
            this.vendedorLb.Name = "vendedorLb";
            // 
            // clienteLb
            // 
            resources.ApplyResources(this.clienteLb, "clienteLb");
            this.clienteLb.Name = "clienteLb";
            // 
            // aCaminhoRd
            // 
            resources.ApplyResources(this.aCaminhoRd, "aCaminhoRd");
            this.aCaminhoRd.Name = "aCaminhoRd";
            this.aCaminhoRd.TabStop = true;
            this.aCaminhoRd.UseVisualStyleBackColor = true;
            // 
            // entregueRd
            // 
            resources.ApplyResources(this.entregueRd, "entregueRd");
            this.entregueRd.Name = "entregueRd";
            this.entregueRd.TabStop = true;
            this.entregueRd.UseVisualStyleBackColor = true;
            // 
            // expedicaoRd
            // 
            resources.ApplyResources(this.expedicaoRd, "expedicaoRd");
            this.expedicaoRd.Name = "expedicaoRd";
            this.expedicaoRd.TabStop = true;
            this.expedicaoRd.UseVisualStyleBackColor = true;
            // 
            // situacaoGb
            // 
            this.situacaoGb.Controls.Add(this.expedicaoRd);
            this.situacaoGb.Controls.Add(this.entregueRd);
            this.situacaoGb.Controls.Add(this.aCaminhoRd);
            resources.ApplyResources(this.situacaoGb, "situacaoGb");
            this.situacaoGb.Name = "situacaoGb";
            this.situacaoGb.TabStop = false;
            // 
            // limparBt
            // 
            resources.ApplyResources(this.limparBt, "limparBt");
            this.limparBt.Name = "limparBt";
            this.limparBt.UseVisualStyleBackColor = true;
            this.limparBt.Click += new System.EventHandler(this.limparBt_Click);
            // 
            // relatorioBt
            // 
            resources.ApplyResources(this.relatorioBt, "relatorioBt");
            this.relatorioBt.Name = "relatorioBt";
            this.relatorioBt.UseVisualStyleBackColor = true;
            this.relatorioBt.Click += new System.EventHandler(this.relatorioBt_Click);
            // 
            // gravaBt
            // 
            resources.ApplyResources(this.gravaBt, "gravaBt");
            this.gravaBt.Name = "gravaBt";
            this.gravaBt.UseVisualStyleBackColor = true;
            this.gravaBt.Click += new System.EventHandler(this.gravaBt_Click_1);
            // 
            // motoboyLb
            // 
            resources.ApplyResources(this.motoboyLb, "motoboyLb");
            this.motoboyLb.Name = "motoboyLb";
            // 
            // motoboyTxt
            // 
            this.motoboyTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.motoboyTxt, "motoboyTxt");
            this.motoboyTxt.Name = "motoboyTxt";
            // 
            // ControleEntreg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.motoboyTxt);
            this.Controls.Add(this.motoboyLb);
            this.Controls.Add(this.gravaBt);
            this.Controls.Add(this.relatorioBt);
            this.Controls.Add(this.limparBt);
            this.Controls.Add(this.situacaoGb);
            this.Controls.Add(this.clienteLb);
            this.Controls.Add(this.vendedorLb);
            this.Controls.Add(this.clienteTxt);
            this.Controls.Add(this.vendedorTxt);
            this.Controls.Add(this.nPedidoTxt);
            this.Controls.Add(this.nPedidoLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControleEntreg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControleEntreg_FormClosing);
            this.situacaoGb.ResumeLayout(false);
            this.situacaoGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nPedidoLb;
        private System.Windows.Forms.TextBox nPedidoTxt;
        private System.Windows.Forms.TextBox vendedorTxt;
        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.Label vendedorLb;
        private System.Windows.Forms.Label clienteLb;
        private System.Windows.Forms.RadioButton aCaminhoRd;
        private System.Windows.Forms.RadioButton entregueRd;
        private System.Windows.Forms.RadioButton expedicaoRd;
        private System.Windows.Forms.GroupBox situacaoGb;
        private System.Windows.Forms.Button limparBt;
        private System.Windows.Forms.Button relatorioBt;
        private System.Windows.Forms.Button gravaBt;
        private System.Windows.Forms.Label motoboyLb;
        private System.Windows.Forms.TextBox motoboyTxt;
    }
}

