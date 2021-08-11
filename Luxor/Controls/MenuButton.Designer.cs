
namespace Luxor.Controls
{
    partial class MenuButton
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
            this.PnLeft = new System.Windows.Forms.Panel();
            this.PnRight = new System.Windows.Forms.Panel();
            this.PnTop = new System.Windows.Forms.Panel();
            this.PnBottom = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.LblSubTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnLeft
            // 
            this.PnLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnLeft.Location = new System.Drawing.Point(0, 0);
            this.PnLeft.Name = "PnLeft";
            this.PnLeft.Size = new System.Drawing.Size(1, 100);
            this.PnLeft.TabIndex = 0;
            this.PnLeft.Visible = false;
            // 
            // PnRight
            // 
            this.PnRight.BackColor = System.Drawing.Color.Gainsboro;
            this.PnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnRight.Location = new System.Drawing.Point(229, 0);
            this.PnRight.Name = "PnRight";
            this.PnRight.Size = new System.Drawing.Size(1, 100);
            this.PnRight.TabIndex = 1;
            this.PnRight.Visible = false;
            // 
            // PnTop
            // 
            this.PnTop.BackColor = System.Drawing.Color.Gainsboro;
            this.PnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTop.Location = new System.Drawing.Point(1, 0);
            this.PnTop.Name = "PnTop";
            this.PnTop.Size = new System.Drawing.Size(228, 1);
            this.PnTop.TabIndex = 2;
            this.PnTop.Visible = false;
            // 
            // PnBottom
            // 
            this.PnBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBottom.Location = new System.Drawing.Point(1, 99);
            this.PnBottom.Name = "PnBottom";
            this.PnBottom.Size = new System.Drawing.Size(228, 1);
            this.PnBottom.TabIndex = 3;
            this.PnBottom.Visible = false;
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(62, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(150, 23);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "[ Caption ]";
            // 
            // PbIcon
            // 
            this.PbIcon.Image = global::Luxor.Properties.Resources.icons8_contact_details_32;
            this.PbIcon.Location = new System.Drawing.Point(14, 34);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(32, 32);
            this.PbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbIcon.TabIndex = 5;
            this.PbIcon.TabStop = false;
            // 
            // LblSubTitle
            // 
            this.LblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblSubTitle.Location = new System.Drawing.Point(64, 45);
            this.LblSubTitle.Name = "LblSubTitle";
            this.LblSubTitle.Size = new System.Drawing.Size(150, 51);
            this.LblSubTitle.TabIndex = 6;
            this.LblSubTitle.Text = "[ SubCaption ]";
            // 
            // MenuButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblSubTitle);
            this.Controls.Add(this.PbIcon);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PnBottom);
            this.Controls.Add(this.PnTop);
            this.Controls.Add(this.PnRight);
            this.Controls.Add(this.PnLeft);
            this.Name = "MenuButton";
            this.Size = new System.Drawing.Size(230, 100);
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnLeft;
        private System.Windows.Forms.Panel PnRight;
        private System.Windows.Forms.Panel PnTop;
        private System.Windows.Forms.Panel PnBottom;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PbIcon;
        private System.Windows.Forms.Label LblSubTitle;
    }
}
