
namespace Luxor
{
    partial class FrmConfiguracion
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
            this.TbFicha = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.NudImporteAnual = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.NudImporteMensual = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.PnLineMono = new System.Windows.Forms.Panel();
            this.TextIIBB = new Luxor.Controls.TextBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateInicioAct = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TextTelefono = new Luxor.Controls.TextBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboCondIva = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAdv1 = new Luxor.Controls.PanelAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.TextCuit = new Luxor.Controls.TextBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.TextDireccion = new Luxor.Controls.TextBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.TextRazonSocial = new Luxor.Controls.TextBoxAdv();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TbFicha.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudImporteAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudImporteMensual)).BeginInit();
            this.SuspendLayout();
            // 
            // TbFicha
            // 
            this.TbFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFicha.Controls.Add(this.tabPage1);
            this.TbFicha.Location = new System.Drawing.Point(23, 64);
            this.TbFicha.Name = "TbFicha";
            this.TbFicha.SelectedIndex = 0;
            this.TbFicha.Size = new System.Drawing.Size(970, 590);
            this.TbFicha.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.NudImporteAnual);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.NudImporteMensual);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.PnLineMono);
            this.tabPage1.Controls.Add(this.TextIIBB);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.DateInicioAct);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TextTelefono);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ComboCondIva);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panelAdv1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TextCuit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TextDireccion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextRazonSocial);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos del Estudio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Anuales";
            // 
            // NudImporteAnual
            // 
            this.NudImporteAnual.DecimalPlaces = 2;
            this.NudImporteAnual.Location = new System.Drawing.Point(174, 380);
            this.NudImporteAnual.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NudImporteAnual.Name = "NudImporteAnual";
            this.NudImporteAnual.Size = new System.Drawing.Size(120, 29);
            this.NudImporteAnual.TabIndex = 26;
            this.NudImporteAnual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 21);
            this.label18.TabIndex = 25;
            this.label18.Text = "Mensuales";
            // 
            // NudImporteMensual
            // 
            this.NudImporteMensual.DecimalPlaces = 2;
            this.NudImporteMensual.Location = new System.Drawing.Point(20, 380);
            this.NudImporteMensual.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NudImporteMensual.Name = "NudImporteMensual";
            this.NudImporteMensual.Size = new System.Drawing.Size(120, 29);
            this.NudImporteMensual.TabIndex = 24;
            this.NudImporteMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Honorarios";
            // 
            // PnLineMono
            // 
            this.PnLineMono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnLineMono.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLineMono.Location = new System.Drawing.Point(20, 291);
            this.PnLineMono.Name = "PnLineMono";
            this.PnLineMono.Size = new System.Drawing.Size(913, 1);
            this.PnLineMono.TabIndex = 22;
            // 
            // TextIIBB
            // 
            this.TextIIBB.BackColor = System.Drawing.Color.Gainsboro;
            this.TextIIBB.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextIIBB.Location = new System.Drawing.Point(536, 180);
            this.TextIIBB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextIIBB.Name = "TextIIBB";
            this.TextIIBB.Numeric = false;
            this.TextIIBB.Padding = new System.Windows.Forms.Padding(1);
            this.TextIIBB.Password = false;
            this.TextIIBB.Size = new System.Drawing.Size(203, 30);
            this.TextIIBB.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nro. IIBB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Inicio de Actividad";
            // 
            // DateInicioAct
            // 
            this.DateInicioAct.Location = new System.Drawing.Point(536, 115);
            this.DateInicioAct.Name = "DateInicioAct";
            this.DateInicioAct.Size = new System.Drawing.Size(386, 29);
            this.DateInicioAct.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Teléfono";
            // 
            // TextTelefono
            // 
            this.TextTelefono.BackColor = System.Drawing.Color.Gainsboro;
            this.TextTelefono.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextTelefono.Location = new System.Drawing.Point(20, 239);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Numeric = false;
            this.TextTelefono.Padding = new System.Windows.Forms.Padding(1);
            this.TextTelefono.Password = false;
            this.TextTelefono.Size = new System.Drawing.Size(484, 30);
            this.TextTelefono.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Condición de IVA";
            // 
            // ComboCondIva
            // 
            this.ComboCondIva.FormattingEnabled = true;
            this.ComboCondIva.Location = new System.Drawing.Point(20, 181);
            this.ComboCondIva.Name = "ComboCondIva";
            this.ComboCondIva.Size = new System.Drawing.Size(274, 29);
            this.ComboCondIva.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Otros Datos";
            // 
            // panelAdv1
            // 
            this.panelAdv1.Location = new System.Drawing.Point(518, 56);
            this.panelAdv1.Name = "panelAdv1";
            this.panelAdv1.Size = new System.Drawing.Size(414, 213);
            this.panelAdv1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "CUIT";
            // 
            // TextCuit
            // 
            this.TextCuit.BackColor = System.Drawing.Color.Gainsboro;
            this.TextCuit.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextCuit.Location = new System.Drawing.Point(301, 180);
            this.TextCuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextCuit.Name = "TextCuit";
            this.TextCuit.Numeric = true;
            this.TextCuit.Padding = new System.Windows.Forms.Padding(1);
            this.TextCuit.Password = false;
            this.TextCuit.Size = new System.Drawing.Size(203, 30);
            this.TextCuit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dirección";
            // 
            // TextDireccion
            // 
            this.TextDireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.TextDireccion.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextDireccion.Location = new System.Drawing.Point(20, 115);
            this.TextDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextDireccion.Name = "TextDireccion";
            this.TextDireccion.Numeric = false;
            this.TextDireccion.Padding = new System.Windows.Forms.Padding(1);
            this.TextDireccion.Password = false;
            this.TextDireccion.Size = new System.Drawing.Size(484, 30);
            this.TextDireccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Razón Social";
            // 
            // TextRazonSocial
            // 
            this.TextRazonSocial.BackColor = System.Drawing.Color.Gainsboro;
            this.TextRazonSocial.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextRazonSocial.Location = new System.Drawing.Point(20, 56);
            this.TextRazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextRazonSocial.Name = "TextRazonSocial";
            this.TextRazonSocial.Numeric = false;
            this.TextRazonSocial.Padding = new System.Windows.Forms.Padding(1);
            this.TextRazonSocial.Password = false;
            this.TextRazonSocial.Size = new System.Drawing.Size(484, 30);
            this.TextRazonSocial.TabIndex = 0;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(687, 660);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(150, 38);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Guardar Cambios";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(843, 660);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 38);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Cancelar";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1010, 707);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TbFicha);
            this.Name = "FrmConfiguracion";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FrmFichaCliente";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.TbFicha.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudImporteAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudImporteMensual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbFicha;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxAdv TextRazonSocial;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private Controls.TextBoxAdv TextDireccion;
        private System.Windows.Forms.Label label3;
        private Controls.TextBoxAdv TextCuit;
        private Controls.PanelAdv panelAdv1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboCondIva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Controls.TextBoxAdv TextTelefono;
        private System.Windows.Forms.DateTimePicker DateInicioAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Controls.TextBoxAdv TextIIBB;
        private System.Windows.Forms.Panel PnLineMono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown NudImporteMensual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NudImporteAnual;
    }
}