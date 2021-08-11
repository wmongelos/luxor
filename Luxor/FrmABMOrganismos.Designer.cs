
namespace Luxor
{
    partial class FrmABMOrganismos
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextDescripcion = new Luxor.Controls.TextBoxAdv();
            this.ChkRequiereAcceso = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(326, 175);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 38);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Cancelar";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(170, 175);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(150, 38);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Guardar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripción";
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.TextDescripcion.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextDescripcion.Location = new System.Drawing.Point(13, 76);
            this.TextDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Numeric = false;
            this.TextDescripcion.Padding = new System.Windows.Forms.Padding(1);
            this.TextDescripcion.Password = false;
            this.TextDescripcion.Size = new System.Drawing.Size(451, 30);
            this.TextDescripcion.TabIndex = 0;
            // 
            // ChkRequiereAcceso
            // 
            this.ChkRequiereAcceso.AutoSize = true;
            this.ChkRequiereAcceso.Location = new System.Drawing.Point(12, 114);
            this.ChkRequiereAcceso.Name = "ChkRequiereAcceso";
            this.ChkRequiereAcceso.Size = new System.Drawing.Size(206, 25);
            this.ChkRequiereAcceso.TabIndex = 24;
            this.ChkRequiereAcceso.Text = "Requiere Datos de Acceso";
            this.ChkRequiereAcceso.UseVisualStyleBackColor = true;
            // 
            // FrmABMOrganismos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 225);
            this.Controls.Add(this.ChkRequiereAcceso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextDescripcion);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "FrmABMOrganismos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmABMOrganismos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxAdv TextDescripcion;
        private System.Windows.Forms.CheckBox ChkRequiereAcceso;
    }
}