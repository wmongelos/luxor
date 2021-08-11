
namespace Luxor.Controls
{
    partial class PanelAdv
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
            this.SuspendLayout();
            // 
            // PnLeft
            // 
            this.PnLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnLeft.Location = new System.Drawing.Point(0, 0);
            this.PnLeft.Name = "PnLeft";
            this.PnLeft.Size = new System.Drawing.Size(1, 150);
            this.PnLeft.TabIndex = 0;
            // 
            // PnRight
            // 
            this.PnRight.BackColor = System.Drawing.Color.Gainsboro;
            this.PnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnRight.Location = new System.Drawing.Point(149, 0);
            this.PnRight.Name = "PnRight";
            this.PnRight.Size = new System.Drawing.Size(1, 150);
            this.PnRight.TabIndex = 1;
            // 
            // PnTop
            // 
            this.PnTop.BackColor = System.Drawing.Color.Gainsboro;
            this.PnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTop.Location = new System.Drawing.Point(1, 0);
            this.PnTop.Name = "PnTop";
            this.PnTop.Size = new System.Drawing.Size(148, 1);
            this.PnTop.TabIndex = 2;
            // 
            // PnBottom
            // 
            this.PnBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.PnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBottom.Location = new System.Drawing.Point(1, 149);
            this.PnBottom.Name = "PnBottom";
            this.PnBottom.Size = new System.Drawing.Size(148, 1);
            this.PnBottom.TabIndex = 3;
            // 
            // PanelAdv
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnBottom);
            this.Controls.Add(this.PnTop);
            this.Controls.Add(this.PnRight);
            this.Controls.Add(this.PnLeft);
            this.Name = "PanelAdv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnLeft;
        private System.Windows.Forms.Panel PnRight;
        private System.Windows.Forms.Panel PnTop;
        private System.Windows.Forms.Panel PnBottom;
    }
}
