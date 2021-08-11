
namespace Luxor.Controls
{
    partial class DataGridAction
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
            this.PnActive = new System.Windows.Forms.Panel();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PnActive
            // 
            this.PnActive.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnActive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnActive.Location = new System.Drawing.Point(0, 40);
            this.PnActive.Name = "PnActive";
            this.PnActive.Size = new System.Drawing.Size(45, 5);
            this.PnActive.TabIndex = 0;
            this.PnActive.Visible = false;
            // 
            // PbIcon
            // 
            this.PbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbIcon.Location = new System.Drawing.Point(6, 5);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(32, 32);
            this.PbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbIcon.TabIndex = 1;
            this.PbIcon.TabStop = false;
            this.PbIcon.MouseEnter += new System.EventHandler(this.DataGridAction_MouseEnter);
            this.PbIcon.MouseLeave += new System.EventHandler(this.DataGridAction_MouseLeave);
            // 
            // DataGridAction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PbIcon);
            this.Controls.Add(this.PnActive);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DataGridAction";
            this.Size = new System.Drawing.Size(45, 45);
            this.MouseEnter += new System.EventHandler(this.DataGridAction_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DataGridAction_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnActive;
        private System.Windows.Forms.PictureBox PbIcon;
    }
}
