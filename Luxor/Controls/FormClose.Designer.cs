
namespace Luxor.Controls
{
    partial class FormClose
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
            this.PbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PbClose
            // 
            this.PbClose.Image = global::Luxor.Properties.Resources.icons8_multiply_32;
            this.PbClose.Location = new System.Drawing.Point(10, 2);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(24, 24);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbClose.TabIndex = 1;
            this.PbClose.TabStop = false;
            this.PbClose.MouseEnter += new System.EventHandler(this.FormClose_MouseEnter);
            this.PbClose.MouseLeave += new System.EventHandler(this.FormClose_MouseLeave);
            // 
            // FormClose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.PbClose);
            this.Name = "FormClose";
            this.Size = new System.Drawing.Size(45, 29);
            this.MouseEnter += new System.EventHandler(this.FormClose_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormClose_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbClose;
    }
}
