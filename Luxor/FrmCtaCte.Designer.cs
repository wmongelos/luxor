namespace Luxor
{
    partial class FrmCtaCte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCtaCte));
            this.dataGrid = new Luxor.Controls.DataGrid();
            this.BgWork = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.PnLine = new System.Windows.Forms.Panel();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackColor = System.Drawing.Color.White;
            this.dataGrid.CustomAction_1 = true;
            this.dataGrid.CustomAction_2 = false;
            this.dataGrid.CustomAction_3 = false;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGrid.IconCustonAction_1 = global::Luxor.Properties.Resources.icons8_check_book_32;
            this.dataGrid.IconCustonAction_2 = ((System.Drawing.Image)(resources.GetObject("dataGrid.IconCustonAction_2")));
            this.dataGrid.IconCustonAction_3 = ((System.Drawing.Image)(resources.GetObject("dataGrid.IconCustonAction_3")));
            this.dataGrid.Location = new System.Drawing.Point(12, 106);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ShowAction = false;
            this.dataGrid.ShowExport = true;
            this.dataGrid.ShowPrinter = true;
            this.dataGrid.Size = new System.Drawing.Size(989, 332);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.ButtonAction1_Click += new System.EventHandler(this.dataGrid_ButtonAction1_Click);
            // 
            // BgWork
            // 
            this.BgWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWork_DoWork);
            this.BgWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWork_RunWorkerCompleted);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 29);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(252, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(234, 29);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(492, 45);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(136, 42);
            this.BtnConsultar.TabIndex = 34;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // PnLine
            // 
            this.PnLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnLine.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLine.Location = new System.Drawing.Point(12, 99);
            this.PnLine.Name = "PnLine";
            this.PnLine.Size = new System.Drawing.Size(989, 1);
            this.PnLine.TabIndex = 35;
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCliente.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(662, 26);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(339, 29);
            this.LblCliente.TabIndex = 36;
            this.LblCliente.Text = "[Cliente]";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSaldo
            // 
            this.LblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSaldo.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(662, 58);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(339, 29);
            this.LblSaldo.TabIndex = 37;
            this.LblSaldo.Text = "[Saldo]";
            this.LblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.PnLine);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGrid);
            this.Name = "FrmCtaCte";
            this.Text = "FrmCtaCte";
            this.Load += new System.EventHandler(this.FrmCtaCte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DataGrid dataGrid;
        private System.ComponentModel.BackgroundWorker BgWork;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Panel PnLine;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblSaldo;
    }
}