
namespace Luxor
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LblUserLogin = new System.Windows.Forms.Label();
            this.PnMenu = new System.Windows.Forms.Panel();
            this.PbMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnMinimize = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.Label();
            this.PnClose = new System.Windows.Forms.Panel();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.PnNavBar = new System.Windows.Forms.Panel();
            this.BtnTareas = new Luxor.Controls.NavBarButton();
            this.BtnConfig = new Luxor.Controls.NavBarButton();
            this.BtnClientes = new Luxor.Controls.NavBarButton();
            this.PnLineApp = new System.Windows.Forms.Panel();
            this.navBarButton1 = new Luxor.Controls.NavBarButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnSubHeader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PnContent = new System.Windows.Forms.Panel();
            this.PnHeader.SuspendLayout();
            this.PnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnMinimize.SuspendLayout();
            this.PnClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.PnNavBar.SuspendLayout();
            this.PnSubHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.PnHeader.Controls.Add(this.LblUserLogin);
            this.PnHeader.Controls.Add(this.PnMenu);
            this.PnHeader.Controls.Add(this.pictureBox1);
            this.PnHeader.Controls.Add(this.PnMinimize);
            this.PnHeader.Controls.Add(this.PnClose);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(800, 45);
            this.PnHeader.TabIndex = 0;
            // 
            // LblUserLogin
            // 
            this.LblUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserLogin.ForeColor = System.Drawing.Color.White;
            this.LblUserLogin.Location = new System.Drawing.Point(477, 10);
            this.LblUserLogin.Name = "LblUserLogin";
            this.LblUserLogin.Size = new System.Drawing.Size(184, 23);
            this.LblUserLogin.TabIndex = 8;
            this.LblUserLogin.Text = "[ Nombre de Usuario ]";
            this.LblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnMenu
            // 
            this.PnMenu.Controls.Add(this.PbMenu);
            this.PnMenu.Location = new System.Drawing.Point(0, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(47, 44);
            this.PnMenu.TabIndex = 7;
            this.PnMenu.Click += new System.EventHandler(this.PnMenu_Click);
            this.PnMenu.MouseEnter += new System.EventHandler(this.PnMenu_MouseEnter);
            this.PnMenu.MouseLeave += new System.EventHandler(this.PnMenu_MouseLeave);
            // 
            // PbMenu
            // 
            this.PbMenu.Image = global::Luxor.Properties.Resources.icons8_squared_menu_32__1_;
            this.PbMenu.Location = new System.Drawing.Point(7, 6);
            this.PbMenu.Name = "PbMenu";
            this.PbMenu.Size = new System.Drawing.Size(32, 32);
            this.PbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbMenu.TabIndex = 7;
            this.PbMenu.TabStop = false;
            this.PbMenu.Click += new System.EventHandler(this.PnMenu_Click);
            this.PbMenu.MouseEnter += new System.EventHandler(this.PnMenu_MouseEnter);
            this.PbMenu.MouseLeave += new System.EventHandler(this.PnMenu_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Luxor.Properties.Resources.icons8_male_user_32;
            this.pictureBox1.Location = new System.Drawing.Point(667, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PnMinimize
            // 
            this.PnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.PnMinimize.Controls.Add(this.PbMinimize);
            this.PnMinimize.Location = new System.Drawing.Point(710, 0);
            this.PnMinimize.Name = "PnMinimize";
            this.PnMinimize.Size = new System.Drawing.Size(45, 29);
            this.PnMinimize.TabIndex = 4;
            this.PnMinimize.Click += new System.EventHandler(this.PnMinimize_Click);
            this.PnMinimize.MouseEnter += new System.EventHandler(this.PnMinimize_MouseEnter);
            this.PnMinimize.MouseLeave += new System.EventHandler(this.PnMinimize_MouseLeave);
            // 
            // PbMinimize
            // 
            this.PbMinimize.AutoSize = true;
            this.PbMinimize.ForeColor = System.Drawing.Color.White;
            this.PbMinimize.Location = new System.Drawing.Point(14, 9);
            this.PbMinimize.Name = "PbMinimize";
            this.PbMinimize.Size = new System.Drawing.Size(19, 13);
            this.PbMinimize.TabIndex = 0;
            this.PbMinimize.Text = "__";
            this.PbMinimize.Click += new System.EventHandler(this.PnMinimize_Click);
            this.PbMinimize.MouseEnter += new System.EventHandler(this.PnMinimize_MouseEnter);
            this.PbMinimize.MouseLeave += new System.EventHandler(this.PnMinimize_MouseLeave);
            // 
            // PnClose
            // 
            this.PnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnClose.Controls.Add(this.PbClose);
            this.PnClose.Location = new System.Drawing.Point(755, 0);
            this.PnClose.Name = "PnClose";
            this.PnClose.Size = new System.Drawing.Size(45, 29);
            this.PnClose.TabIndex = 3;
            this.PnClose.Click += new System.EventHandler(this.PnClose_Click);
            this.PnClose.MouseEnter += new System.EventHandler(this.PnClose_MouseEnter);
            this.PnClose.MouseLeave += new System.EventHandler(this.PnClose_MouseLeave);
            // 
            // PbClose
            // 
            this.PbClose.Image = global::Luxor.Properties.Resources.icons8_multiply_32;
            this.PbClose.Location = new System.Drawing.Point(10, 3);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(24, 24);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbClose.TabIndex = 0;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PnClose_Click);
            this.PbClose.MouseEnter += new System.EventHandler(this.PnClose_MouseEnter);
            this.PbClose.MouseLeave += new System.EventHandler(this.PnClose_MouseLeave);
            // 
            // PnNavBar
            // 
            this.PnNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PnNavBar.Controls.Add(this.BtnTareas);
            this.PnNavBar.Controls.Add(this.BtnConfig);
            this.PnNavBar.Controls.Add(this.BtnClientes);
            this.PnNavBar.Controls.Add(this.PnLineApp);
            this.PnNavBar.Controls.Add(this.navBarButton1);
            this.PnNavBar.Controls.Add(this.panel3);
            this.PnNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnNavBar.Location = new System.Drawing.Point(0, 45);
            this.PnNavBar.Name = "PnNavBar";
            this.PnNavBar.Size = new System.Drawing.Size(47, 405);
            this.PnNavBar.TabIndex = 1;
            // 
            // BtnTareas
            // 
            this.BtnTareas.Active = false;
            this.BtnTareas.Caption = "Gestión de Tareas";
            this.BtnTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTareas.Icon = global::Luxor.Properties.Resources.icons8_todo_list_32;
            this.BtnTareas.Location = new System.Drawing.Point(0, 95);
            this.BtnTareas.Name = "BtnTareas";
            this.BtnTareas.Size = new System.Drawing.Size(46, 45);
            this.BtnTareas.TabIndex = 6;
            this.BtnTareas.Click += new System.EventHandler(this.BtnTareas_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.Active = false;
            this.BtnConfig.Caption = "Configuración";
            this.BtnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfig.Icon = ((System.Drawing.Image)(resources.GetObject("BtnConfig.Icon")));
            this.BtnConfig.Location = new System.Drawing.Point(0, 360);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(46, 45);
            this.BtnConfig.TabIndex = 5;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Active = false;
            this.BtnClientes.Caption = "Clientes";
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.Icon = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Icon")));
            this.BtnClientes.Location = new System.Drawing.Point(0, 50);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(46, 45);
            this.BtnClientes.TabIndex = 4;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // PnLineApp
            // 
            this.PnLineApp.BackColor = System.Drawing.Color.Transparent;
            this.PnLineApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLineApp.Location = new System.Drawing.Point(0, 45);
            this.PnLineApp.Name = "PnLineApp";
            this.PnLineApp.Size = new System.Drawing.Size(46, 5);
            this.PnLineApp.TabIndex = 3;
            // 
            // navBarButton1
            // 
            this.navBarButton1.Active = false;
            this.navBarButton1.Caption = "Luxor Contable";
            this.navBarButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarButton1.Icon = global::Luxor.Properties.Resources.icons8_xbox_l_32;
            this.navBarButton1.Location = new System.Drawing.Point(0, 0);
            this.navBarButton1.Name = "navBarButton1";
            this.navBarButton1.Size = new System.Drawing.Size(46, 45);
            this.navBarButton1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(46, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 405);
            this.panel3.TabIndex = 0;
            // 
            // PnSubHeader
            // 
            this.PnSubHeader.Controls.Add(this.panel4);
            this.PnSubHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnSubHeader.Location = new System.Drawing.Point(47, 45);
            this.PnSubHeader.Name = "PnSubHeader";
            this.PnSubHeader.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PnSubHeader.Size = new System.Drawing.Size(753, 50);
            this.PnSubHeader.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(733, 1);
            this.panel4.TabIndex = 0;
            // 
            // PnContent
            // 
            this.PnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContent.Location = new System.Drawing.Point(47, 95);
            this.PnContent.Name = "PnContent";
            this.PnContent.Size = new System.Drawing.Size(753, 355);
            this.PnContent.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnContent);
            this.Controls.Add(this.PnSubHeader);
            this.Controls.Add(this.PnNavBar);
            this.Controls.Add(this.PnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnMenu.ResumeLayout(false);
            this.PnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnMinimize.ResumeLayout(false);
            this.PnMinimize.PerformLayout();
            this.PnClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.PnNavBar.ResumeLayout(false);
            this.PnSubHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Panel PnNavBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnClose;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Panel PnMinimize;
        private System.Windows.Forms.Label PbMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.PictureBox PbMenu;
        private Controls.NavBarButton navBarButton1;
        private System.Windows.Forms.Panel PnSubHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PnContent;
        private System.Windows.Forms.Panel PnLineApp;
        private Controls.NavBarButton BtnClientes;
        private System.Windows.Forms.Label LblUserLogin;
        private Controls.NavBarButton BtnConfig;
        private Controls.NavBarButton BtnTareas;
    }
}

