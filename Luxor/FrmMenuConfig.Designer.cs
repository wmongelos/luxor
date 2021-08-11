
namespace Luxor
{
    partial class FrmMenuConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuConfig));
            this.FLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnConfig = new Luxor.Controls.MenuButton();
            this.BtnRoles = new Luxor.Controls.MenuButton();
            this.BtnUsuarios = new Luxor.Controls.MenuButton();
            this.BtnEntidades = new Luxor.Controls.MenuButton();
            this.BtnMediosPagos = new Luxor.Controls.MenuButton();
            this.BtnMediosComu = new Luxor.Controls.MenuButton();
            this.BtnOrganismos = new Luxor.Controls.MenuButton();
            this.BtnTareas_Tipos = new Luxor.Controls.MenuButton();
            this.menuButton9 = new Luxor.Controls.MenuButton();
            this.FLPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLPanel
            // 
            this.FLPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLPanel.Controls.Add(this.BtnConfig);
            this.FLPanel.Controls.Add(this.BtnRoles);
            this.FLPanel.Controls.Add(this.BtnUsuarios);
            this.FLPanel.Controls.Add(this.BtnEntidades);
            this.FLPanel.Controls.Add(this.BtnMediosPagos);
            this.FLPanel.Controls.Add(this.BtnMediosComu);
            this.FLPanel.Controls.Add(this.BtnOrganismos);
            this.FLPanel.Controls.Add(this.BtnTareas_Tipos);
            this.FLPanel.Controls.Add(this.menuButton9);
            this.FLPanel.Location = new System.Drawing.Point(12, 12);
            this.FLPanel.Name = "FLPanel";
            this.FLPanel.Size = new System.Drawing.Size(776, 426);
            this.FLPanel.TabIndex = 0;
            // 
            // BtnConfig
            // 
            this.BtnConfig.Caption = "Sistema";
            this.BtnConfig.Icon = global::Luxor.Properties.Resources.icons8_settings_32;
            this.BtnConfig.Location = new System.Drawing.Point(3, 3);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(230, 100);
            this.BtnConfig.SubCaption = "Configuración General del Sistema";
            this.BtnConfig.TabIndex = 0;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnRoles
            // 
            this.BtnRoles.Caption = "Seguridad";
            this.BtnRoles.Icon = global::Luxor.Properties.Resources.icons8_access_32;
            this.BtnRoles.Location = new System.Drawing.Point(239, 3);
            this.BtnRoles.Name = "BtnRoles";
            this.BtnRoles.Size = new System.Drawing.Size(230, 100);
            this.BtnRoles.SubCaption = "Roles y Permisos de Usuarios del Sistema";
            this.BtnRoles.TabIndex = 1;
            this.BtnRoles.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Caption = "Usuarios del Sistema";
            this.BtnUsuarios.Icon = global::Luxor.Properties.Resources.icons8_user_secured_32;
            this.BtnUsuarios.Location = new System.Drawing.Point(475, 3);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(230, 100);
            this.BtnUsuarios.SubCaption = "Gestión de Usuarios del Sistema";
            this.BtnUsuarios.TabIndex = 2;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnEntidades
            // 
            this.BtnEntidades.Caption = "Entidades Bancarias";
            this.BtnEntidades.Icon = global::Luxor.Properties.Resources.icons8_bank_building_32;
            this.BtnEntidades.Location = new System.Drawing.Point(3, 109);
            this.BtnEntidades.Name = "BtnEntidades";
            this.BtnEntidades.Size = new System.Drawing.Size(230, 100);
            this.BtnEntidades.SubCaption = "Gestión de Entidades Bancarias";
            this.BtnEntidades.TabIndex = 3;
            this.BtnEntidades.Click += new System.EventHandler(this.BtnEntidades_Click);
            // 
            // BtnMediosPagos
            // 
            this.BtnMediosPagos.Caption = "Medios de Pagos";
            this.BtnMediosPagos.Icon = ((System.Drawing.Image)(resources.GetObject("BtnMediosPagos.Icon")));
            this.BtnMediosPagos.Location = new System.Drawing.Point(239, 109);
            this.BtnMediosPagos.Name = "BtnMediosPagos";
            this.BtnMediosPagos.Size = new System.Drawing.Size(230, 100);
            this.BtnMediosPagos.SubCaption = "Gestión de Medios de Pagos";
            this.BtnMediosPagos.TabIndex = 4;
            this.BtnMediosPagos.Click += new System.EventHandler(this.BtnMediosPagos_Click);
            // 
            // BtnMediosComu
            // 
            this.BtnMediosComu.Caption = "Comunicación";
            this.BtnMediosComu.Icon = ((System.Drawing.Image)(resources.GetObject("BtnMediosComu.Icon")));
            this.BtnMediosComu.Location = new System.Drawing.Point(475, 109);
            this.BtnMediosComu.Name = "BtnMediosComu";
            this.BtnMediosComu.Size = new System.Drawing.Size(230, 100);
            this.BtnMediosComu.SubCaption = "Gestión de Formas de Comunicación";
            this.BtnMediosComu.TabIndex = 5;
            this.BtnMediosComu.Click += new System.EventHandler(this.BtnMediosComu_Click);
            // 
            // BtnOrganismos
            // 
            this.BtnOrganismos.Caption = "Organismos";
            this.BtnOrganismos.Icon = global::Luxor.Properties.Resources.icons8_organization_32;
            this.BtnOrganismos.Location = new System.Drawing.Point(3, 215);
            this.BtnOrganismos.Name = "BtnOrganismos";
            this.BtnOrganismos.Size = new System.Drawing.Size(230, 100);
            this.BtnOrganismos.SubCaption = "Gestion de Org. Públicos";
            this.BtnOrganismos.TabIndex = 6;
            this.BtnOrganismos.Click += new System.EventHandler(this.BtnOrganismos_Click);
            // 
            // BtnTareas_Tipos
            // 
            this.BtnTareas_Tipos.Caption = "Tareas";
            this.BtnTareas_Tipos.Icon = global::Luxor.Properties.Resources.icons8_todo_list_32;
            this.BtnTareas_Tipos.Location = new System.Drawing.Point(239, 215);
            this.BtnTareas_Tipos.Name = "BtnTareas_Tipos";
            this.BtnTareas_Tipos.Size = new System.Drawing.Size(230, 100);
            this.BtnTareas_Tipos.SubCaption = "Tipos de Tareas";
            this.BtnTareas_Tipos.TabIndex = 7;
            this.BtnTareas_Tipos.Click += new System.EventHandler(this.BtnTareas_Tipos_Click);
            // 
            // menuButton9
            // 
            this.menuButton9.Caption = "[ Caption ]";
            this.menuButton9.Icon = ((System.Drawing.Image)(resources.GetObject("menuButton9.Icon")));
            this.menuButton9.Location = new System.Drawing.Point(475, 215);
            this.menuButton9.Name = "menuButton9";
            this.menuButton9.Size = new System.Drawing.Size(230, 100);
            this.menuButton9.SubCaption = "[ SubCaption ]";
            this.menuButton9.TabIndex = 8;
            this.menuButton9.Visible = false;
            // 
            // FrmMenuConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FLPanel);
            this.Name = "FrmMenuConfig";
            this.Text = "FrmMenuConfig";
            this.FLPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPanel;
        private Controls.MenuButton BtnConfig;
        private Controls.MenuButton BtnRoles;
        private Controls.MenuButton BtnUsuarios;
        private Controls.MenuButton BtnEntidades;
        private Controls.MenuButton BtnMediosPagos;
        private Controls.MenuButton BtnMediosComu;
        private Controls.MenuButton BtnOrganismos;
        private Controls.MenuButton BtnTareas_Tipos;
        private Controls.MenuButton menuButton9;
    }
}