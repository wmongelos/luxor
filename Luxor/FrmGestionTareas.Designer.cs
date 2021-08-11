namespace Luxor
{
    partial class FrmGestionTareas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionTareas));
            this.dataGrid = new Luxor.Controls.DataGrid();
            this.BgWork = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboTareasTipos = new Luxor.Controls.ComboBoxAdv(this.components);
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.ComboMeses = new Luxor.Controls.ComboBoxAdv(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NudAño = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboTareasSecundarias = new Luxor.Controls.ComboBoxAdv(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ComboTareasPrincipal = new Luxor.Controls.ComboBoxAdv(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NudAño)).BeginInit();
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
            this.dataGrid.Location = new System.Drawing.Point(373, 30);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ShowAction = false;
            this.dataGrid.ShowExport = false;
            this.dataGrid.ShowPrinter = false;
            this.dataGrid.Size = new System.Drawing.Size(851, 568);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.ButtonAdd_Click += new System.EventHandler(this.dataGrid_ButtonAdd_Click);
            // 
            // BgWork
            // 
            this.BgWork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWork_DoWork);
            this.BgWork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWork_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tarea";
            // 
            // ComboTareasTipos
            // 
            this.ComboTareasTipos.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTareasTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTareasTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTareasTipos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTareasTipos.FormattingEnabled = true;
            this.ComboTareasTipos.Location = new System.Drawing.Point(12, 166);
            this.ComboTareasTipos.Name = "ComboTareasTipos";
            this.ComboTareasTipos.Size = new System.Drawing.Size(339, 29);
            this.ComboTareasTipos.TabIndex = 9;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(215, 276);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(136, 42);
            this.BtnConsultar.TabIndex = 10;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // ComboMeses
            // 
            this.ComboMeses.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMeses.FormattingEnabled = true;
            this.ComboMeses.Location = new System.Drawing.Point(12, 225);
            this.ComboMeses.Name = "ComboMeses";
            this.ComboMeses.Size = new System.Drawing.Size(202, 29);
            this.ComboMeses.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Período";
            // 
            // NudAño
            // 
            this.NudAño.Location = new System.Drawing.Point(231, 226);
            this.NudAño.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.NudAño.Name = "NudAño";
            this.NudAño.Size = new System.Drawing.Size(120, 29);
            this.NudAño.TabIndex = 14;
            this.NudAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tarea Secundaria";
            // 
            // ComboTareasSecundarias
            // 
            this.ComboTareasSecundarias.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTareasSecundarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTareasSecundarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTareasSecundarias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTareasSecundarias.FormattingEnabled = true;
            this.ComboTareasSecundarias.Location = new System.Drawing.Point(12, 110);
            this.ComboTareasSecundarias.Name = "ComboTareasSecundarias";
            this.ComboTareasSecundarias.Size = new System.Drawing.Size(339, 29);
            this.ComboTareasSecundarias.TabIndex = 32;
            this.ComboTareasSecundarias.SelectedValueChanged += new System.EventHandler(this.ComboTareasSecundarias_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tarea Principal";
            // 
            // ComboTareasPrincipal
            // 
            this.ComboTareasPrincipal.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTareasPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTareasPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTareasPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTareasPrincipal.FormattingEnabled = true;
            this.ComboTareasPrincipal.Location = new System.Drawing.Point(12, 54);
            this.ComboTareasPrincipal.Name = "ComboTareasPrincipal";
            this.ComboTareasPrincipal.Size = new System.Drawing.Size(339, 29);
            this.ComboTareasPrincipal.TabIndex = 30;
            this.ComboTareasPrincipal.SelectedValueChanged += new System.EventHandler(this.ComboTareasPrincipal_SelectedValueChanged);
            // 
            // FrmGestionTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboTareasSecundarias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboTareasPrincipal);
            this.Controls.Add(this.NudAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboMeses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboTareasTipos);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.dataGrid);
            this.Name = "FrmGestionTareas";
            this.Text = "FrmTareas";
            this.Load += new System.EventHandler(this.FrmTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DataGrid dataGrid;
        private System.ComponentModel.BackgroundWorker BgWork;
        private System.Windows.Forms.Label label2;
        private Controls.ComboBoxAdv ComboTareasTipos;
        private System.Windows.Forms.Button BtnConsultar;
        private Controls.ComboBoxAdv ComboMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudAño;
        private System.Windows.Forms.Label label3;
        private Controls.ComboBoxAdv ComboTareasSecundarias;
        private System.Windows.Forms.Label label4;
        private Controls.ComboBoxAdv ComboTareasPrincipal;
    }
}