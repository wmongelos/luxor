namespace Luxor
{
    partial class FrmTareasTipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareasTipos));
            this.dataGrid = new Luxor.Controls.DataGrid();
            this.BgWork = new System.ComponentModel.BackgroundWorker();
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
            this.dataGrid.Location = new System.Drawing.Point(12, 40);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ShowAction = true;
            this.dataGrid.ShowExport = false;
            this.dataGrid.ShowPrinter = false;
            this.dataGrid.Size = new System.Drawing.Size(776, 398);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.ButtonAdd_Click += new System.EventHandler(this.dataGrid_ButtonAdd_Click);
            this.dataGrid.ButtonEdit_Click += new System.EventHandler(this.dataGrid_ButtonEdit_Click);
            this.dataGrid.ButtonDelete_Click += new System.EventHandler(this.dataGrid_ButtonDelete_Click);
            // 
            // BgWork
            // 
            this.BgWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWork_DoWork);
            this.BgWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWork_RunWorkerCompleted);
            // 
            // FrmTareasTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Name = "FrmTareasTipos";
            this.Text = "FrmTareasTipos";
            this.Load += new System.EventHandler(this.FrmTareasTipos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DataGrid dataGrid;
        private System.ComponentModel.BackgroundWorker BgWork;
    }
}