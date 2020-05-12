namespace Sistema_Projeto.Apresentacao {
    partial class FrmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesqCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesqProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbCadCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCadProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbPesqProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.tsmSobre,
            this.tsmSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadCliente,
            this.tsmPesqCliente,
            this.tsmEditCliente});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tsmCadCliente
            // 
            this.tsmCadCliente.Name = "tsmCadCliente";
            this.tsmCadCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmCadCliente.Text = "Cadastrar";
            this.tsmCadCliente.Click += new System.EventHandler(this.tsmCadCliente_Click);
            // 
            // tsmPesqCliente
            // 
            this.tsmPesqCliente.Name = "tsmPesqCliente";
            this.tsmPesqCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmPesqCliente.Text = "Consultar";
            this.tsmPesqCliente.Click += new System.EventHandler(this.tsmPesqCliente_Click);
            // 
            // tsmEditCliente
            // 
            this.tsmEditCliente.Name = "tsmEditCliente";
            this.tsmEditCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmEditCliente.Text = "Editar";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadProduto,
            this.tsmPesqProd,
            this.tsmEditProduto});
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.funcionarioToolStripMenuItem.Text = "Produto";
            // 
            // tsmCadProduto
            // 
            this.tsmCadProduto.Name = "tsmCadProduto";
            this.tsmCadProduto.Size = new System.Drawing.Size(125, 22);
            this.tsmCadProduto.Text = "Cadastrar";
            this.tsmCadProduto.Click += new System.EventHandler(this.tsmCadProduto_Click);
            // 
            // tsmPesqProd
            // 
            this.tsmPesqProd.Name = "tsmPesqProd";
            this.tsmPesqProd.Size = new System.Drawing.Size(125, 22);
            this.tsmPesqProd.Text = "Consultar";
            // 
            // tsmEditProduto
            // 
            this.tsmEditProduto.Name = "tsmEditProduto";
            this.tsmEditProduto.Size = new System.Drawing.Size(125, 22);
            this.tsmEditProduto.Text = "Editar";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // tsmSobre
            // 
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(49, 20);
            this.tsmSobre.Text = "Sobre";
            this.tsmSobre.Click += new System.EventHandler(this.tsmSobre_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(38, 20);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo!";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadCliente,
            this.tsbEditarCliente,
            this.tsbPesquisarCliente,
            this.toolStripSeparator1,
            this.tsbCadProduto,
            this.tsbEditarProduto,
            this.tsbPesqProduto,
            this.toolStripSeparator2,
            this.tsbSair});
            this.tsMenu.Location = new System.Drawing.Point(0, 24);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(812, 57);
            this.tsMenu.TabIndex = 3;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbCadCliente
            // 
            this.tsbCadCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadCliente.Image")));
            this.tsbCadCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadCliente.Name = "tsbCadCliente";
            this.tsbCadCliente.Size = new System.Drawing.Size(54, 54);
            this.tsbCadCliente.Text = "Cadastrar Cliente";
            this.tsbCadCliente.Click += new System.EventHandler(this.tsbCadCliente_Click);
            // 
            // tsbEditarCliente
            // 
            this.tsbEditarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarCliente.Image")));
            this.tsbEditarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarCliente.Name = "tsbEditarCliente";
            this.tsbEditarCliente.Size = new System.Drawing.Size(54, 54);
            this.tsbEditarCliente.Text = "Editar Cliente";
            this.tsbEditarCliente.ToolTipText = "Editar Cliente";
            // 
            // tsbPesquisarCliente
            // 
            this.tsbPesquisarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisarCliente.Image")));
            this.tsbPesquisarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisarCliente.Name = "tsbPesquisarCliente";
            this.tsbPesquisarCliente.Size = new System.Drawing.Size(54, 54);
            this.tsbPesquisarCliente.Text = "toolStripButton3";
            this.tsbPesquisarCliente.ToolTipText = "Pesquisar Clientes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // tsbCadProduto
            // 
            this.tsbCadProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadProduto.Image")));
            this.tsbCadProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadProduto.Name = "tsbCadProduto";
            this.tsbCadProduto.Size = new System.Drawing.Size(54, 54);
            this.tsbCadProduto.Text = "toolStripButton4";
            this.tsbCadProduto.ToolTipText = "Cadastrar Produtos";
            // 
            // tsbEditarProduto
            // 
            this.tsbEditarProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarProduto.Image")));
            this.tsbEditarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarProduto.Name = "tsbEditarProduto";
            this.tsbEditarProduto.Size = new System.Drawing.Size(54, 54);
            this.tsbEditarProduto.Text = "toolStripButton5";
            this.tsbEditarProduto.ToolTipText = "Pesquisar Produtos";
            // 
            // tsbPesqProduto
            // 
            this.tsbPesqProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesqProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesqProduto.Image")));
            this.tsbPesqProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesqProduto.Name = "tsbPesqProduto";
            this.tsbPesqProduto.Size = new System.Drawing.Size(54, 54);
            this.tsbPesqProduto.Text = "toolStripButton6";
            this.tsbPesqProduto.ToolTipText = "Pesquisar Produtos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(54, 54);
            this.tsbSair.Text = "toolStripButton7";
            this.tsbSair.ToolTipText = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 429);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Loja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmPesqCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmEditCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmCadProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmPesqProd;
        private System.Windows.Forms.ToolStripMenuItem tsmEditProduto;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbCadCliente;
        private System.Windows.Forms.ToolStripButton tsbEditarCliente;
        private System.Windows.Forms.ToolStripButton tsbPesquisarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCadProduto;
        private System.Windows.Forms.ToolStripButton tsbEditarProduto;
        private System.Windows.Forms.ToolStripButton tsbPesqProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
    }
}