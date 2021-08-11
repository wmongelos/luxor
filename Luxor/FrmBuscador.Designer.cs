
namespace Luxor
{
    partial class FrmBuscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscador));
            this.dataGrid = new Luxor.Controls.DataGrid();
            this.PnClose = new System.Windows.Forms.Panel();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PnClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackColor = System.Drawing.Color.White;
            this.dataGrid.CustomAction_1 = false;
            this.dataGrid.CustomAction_2 = false;
            this.dataGrid.CustomAction_3 = false;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGrid.IconCustonAction_1 = ((System.Drawing.Image)(resources.GetObject("dataGrid.IconCustonAction_1")));
            this.dataGrid.IconCustonAction_2 = ((System.Drawing.Image)(resources.GetObject("dataGrid.IconCustonAction_2")));
            this.dataGrid.IconCustonAction_3 = ((System.Drawing.Image)(resources.GetObject("dataGrid.IconCustonAction_3")));
            this.dataGrid.Location = new System.Drawing.Point(12, 57);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ShowAction = false;
            this.dataGrid.ShowExport = false;
            this.dataGrid.ShowPrinter = false;
            this.dataGrid.Size = new System.Drawing.Size(721, 516);
            this.dataGrid.TabIndex = 0;
            // 
            // PnClose
            // 
            this.PnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.PnClose.Controls.Add(this.PbClose);
            this.PnClose.Location = new System.Drawing.Point(684, 0);
            this.PnClose.Name = "PnClose";
            this.PnClose.Size = new System.Drawing.Size(45, 29);
            this.PnClose.TabIndex = 17;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Actividades";
            // 
            // FrmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PnClose);
            this.Controls.Add(this.dataGrid);
            this.Name = "FrmBuscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscador";
            this.Load += new System.EventHandler(this.FrmBuscador_Load);
            this.PnClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DataGrid dataGrid;
        private System.Windows.Forms.Panel PnClose;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Label label3;
    }
}