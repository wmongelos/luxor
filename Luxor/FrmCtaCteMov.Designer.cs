
namespace Luxor
{
    partial class FrmCtaCteMov
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextDescripcion = new Luxor.Controls.TextBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.NudImporte = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboTipoMov = new Luxor.Controls.ComboBoxAdv(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(314, 310);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 38);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Cancelar";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(158, 310);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(150, 38);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Guardar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripción";
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.TextDescripcion.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextDescripcion.Location = new System.Drawing.Point(13, 137);
            this.TextDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Numeric = false;
            this.TextDescripcion.Padding = new System.Windows.Forms.Padding(1);
            this.TextDescripcion.Password = false;
            this.TextDescripcion.Size = new System.Drawing.Size(451, 30);
            this.TextDescripcion.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(12, 61);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(296, 29);
            this.DtpFecha.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(291, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 21);
            this.label18.TabIndex = 36;
            this.label18.Text = "Importe";
            // 
            // NudImporte
            // 
            this.NudImporte.DecimalPlaces = 2;
            this.NudImporte.Location = new System.Drawing.Point(291, 219);
            this.NudImporte.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NudImporte.Name = "NudImporte";
            this.NudImporte.Size = new System.Drawing.Size(173, 29);
            this.NudImporte.TabIndex = 35;
            this.NudImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tipo de Movimiento";
            // 
            // ComboTipoMov
            // 
            this.ComboTipoMov.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTipoMov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTipoMov.FormattingEnabled = true;
            this.ComboTipoMov.Items.AddRange(new object[] {
            "DEBE",
            "HABER"});
            this.ComboTipoMov.Location = new System.Drawing.Point(13, 219);
            this.ComboTipoMov.Name = "ComboTipoMov";
            this.ComboTipoMov.Size = new System.Drawing.Size(228, 29);
            this.ComboTipoMov.TabIndex = 38;
            // 
            // FrmCtaCteMov
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(476, 360);
            this.Controls.Add(this.ComboTipoMov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.NudImporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextDescripcion);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "FrmCtaCteMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCtaCteMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxAdv TextDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown NudImporte;
        private System.Windows.Forms.Label label2;
        private Controls.ComboBoxAdv ComboTipoMov;
    }
}