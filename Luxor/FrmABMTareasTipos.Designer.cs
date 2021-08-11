
namespace Luxor
{
    partial class FrmABMTareasTipos
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
            this.ComboTareasPrincipal = new Luxor.Controls.ComboBoxAdv(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboTareasSecundarias = new Luxor.Controls.ComboBoxAdv(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.ComboOrganismos = new Luxor.Controls.ComboBoxAdv(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ComboTareasPeriodos = new Luxor.Controls.ComboBoxAdv(this.components);
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(314, 413);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 38);
            this.BtnClose.TabIndex = 4;
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
            this.BtnIngresar.Location = new System.Drawing.Point(158, 413);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(150, 38);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Guardar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripción ";
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.BackColor = System.Drawing.Color.Gainsboro;
            this.TextDescripcion.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextDescripcion.Location = new System.Drawing.Point(13, 217);
            this.TextDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Numeric = false;
            this.TextDescripcion.Padding = new System.Windows.Forms.Padding(1);
            this.TextDescripcion.Password = false;
            this.TextDescripcion.Size = new System.Drawing.Size(451, 30);
            this.TextDescripcion.TabIndex = 0;
            // 
            // ComboTareasPrincipal
            // 
            this.ComboTareasPrincipal.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTareasPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTareasPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTareasPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTareasPrincipal.FormattingEnabled = true;
            this.ComboTareasPrincipal.Location = new System.Drawing.Point(13, 82);
            this.ComboTareasPrincipal.Name = "ComboTareasPrincipal";
            this.ComboTareasPrincipal.Size = new System.Drawing.Size(451, 29);
            this.ComboTareasPrincipal.TabIndex = 2;
            this.ComboTareasPrincipal.SelectedValueChanged += new System.EventHandler(this.ComboTareasPrincipal_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tarea Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tarea Secundaria";
            // 
            // ComboTareasSecundarias
            // 
            this.ComboTareasSecundarias.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTareasSecundarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTareasSecundarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTareasSecundarias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTareasSecundarias.FormattingEnabled = true;
            this.ComboTareasSecundarias.Location = new System.Drawing.Point(13, 152);
            this.ComboTareasSecundarias.Name = "ComboTareasSecundarias";
            this.ComboTareasSecundarias.Size = new System.Drawing.Size(451, 29);
            this.ComboTareasSecundarias.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Organismos";
            // 
            // ComboOrganismos
            // 
            this.ComboOrganismos.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboOrganismos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOrganismos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboOrganismos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboOrganismos.FormattingEnabled = true;
            this.ComboOrganismos.Location = new System.Drawing.Point(13, 282);
            this.ComboOrganismos.Name = "ComboOrganismos";
            this.ComboOrganismos.Size = new System.Drawing.Size(451, 29);
            this.ComboOrganismos.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Periodicidad";
            // 
            // ComboTareasPeriodos
            // 
            this.ComboTareasPeriodos.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboTareasPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTareasPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTareasPeriodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTareasPeriodos.FormattingEnabled = true;
            this.ComboTareasPeriodos.Location = new System.Drawing.Point(12, 342);
            this.ComboTareasPeriodos.Name = "ComboTareasPeriodos";
            this.ComboTareasPeriodos.Size = new System.Drawing.Size(190, 29);
            this.ComboTareasPeriodos.TabIndex = 32;
            // 
            // FrmABMTareasTipos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(476, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboTareasPeriodos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboOrganismos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboTareasSecundarias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboTareasPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextDescripcion);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "FrmABMTareasTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmABMTareasTipos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxAdv TextDescripcion;
        private Controls.ComboBoxAdv ComboTareasPrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controls.ComboBoxAdv ComboTareasSecundarias;
        private System.Windows.Forms.Label label4;
        private Controls.ComboBoxAdv ComboOrganismos;
        private System.Windows.Forms.Label label5;
        private Controls.ComboBoxAdv ComboTareasPeriodos;
    }
}