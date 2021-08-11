
namespace Luxor.Controls
{
    partial class NavBarButton
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnLineActive = new System.Windows.Forms.Panel();
            this.PnIcon = new System.Windows.Forms.Panel();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.LblCaption = new System.Windows.Forms.Label();
            this.PnIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnLineActive
            // 
            this.PnLineActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.PnLineActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnLineActive.Location = new System.Drawing.Point(0, 0);
            this.PnLineActive.Name = "PnLineActive";
            this.PnLineActive.Size = new System.Drawing.Size(5, 45);
            this.PnLineActive.TabIndex = 0;
            this.PnLineActive.Visible = false;
            // 
            // PnIcon
            // 
            this.PnIcon.Controls.Add(this.PbIcon);
            this.PnIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnIcon.Location = new System.Drawing.Point(5, 0);
            this.PnIcon.MaximumSize = new System.Drawing.Size(47, 0);
            this.PnIcon.Name = "PnIcon";
            this.PnIcon.Size = new System.Drawing.Size(46, 45);
            this.PnIcon.TabIndex = 1;
            this.PnIcon.MouseEnter += new System.EventHandler(this.NavBarButton_MouseEnter);
            this.PnIcon.MouseLeave += new System.EventHandler(this.NavBarButton_MouseLeave);
            // 
            // PbIcon
            // 
            this.PbIcon.Image = global::Luxor.Properties.Resources.icons8_contact_details_32;
            this.PbIcon.Location = new System.Drawing.Point(6, 6);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(32, 32);
            this.PbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbIcon.TabIndex = 0;
            this.PbIcon.TabStop = false;
            this.PbIcon.MouseEnter += new System.EventHandler(this.NavBarButton_MouseEnter);
            this.PbIcon.MouseLeave += new System.EventHandler(this.NavBarButton_MouseLeave);
            // 
            // LblCaption
            // 
            this.LblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCaption.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaption.Location = new System.Drawing.Point(51, 0);
            this.LblCaption.Name = "LblCaption";
            this.LblCaption.Size = new System.Drawing.Size(0, 45);
            this.LblCaption.TabIndex = 2;
            this.LblCaption.Text = "Caption";
            this.LblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCaption.MouseEnter += new System.EventHandler(this.NavBarButton_MouseEnter);
            this.LblCaption.MouseLeave += new System.EventHandler(this.NavBarButton_MouseLeave);
            // 
            // NavBarButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblCaption);
            this.Controls.Add(this.PnIcon);
            this.Controls.Add(this.PnLineActive);
            this.Name = "NavBarButton";
            this.Size = new System.Drawing.Size(47, 45);
            this.MouseEnter += new System.EventHandler(this.NavBarButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NavBarButton_MouseLeave);
            this.PnIcon.ResumeLayout(false);
            this.PnIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnLineActive;
        private System.Windows.Forms.Panel PnIcon;
        private System.Windows.Forms.PictureBox PbIcon;
        private System.Windows.Forms.Label LblCaption;
    }
}
