
namespace Luxor
{
    partial class FrmABMUser
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
            this.TextUser = new Luxor.Controls.TextBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.TextUserPwd = new Luxor.Controls.TextBoxAdv();
            this.ComboRoles = new Luxor.Controls.ComboBoxAdv(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(314, 250);
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
            this.BtnIngresar.Location = new System.Drawing.Point(158, 250);
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
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre de Usuario";
            // 
            // TextUser
            // 
            this.TextUser.BackColor = System.Drawing.Color.Gainsboro;
            this.TextUser.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextUser.Location = new System.Drawing.Point(13, 76);
            this.TextUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextUser.Name = "TextUser";
            this.TextUser.Numeric = false;
            this.TextUser.Padding = new System.Windows.Forms.Padding(1);
            this.TextUser.Password = false;
            this.TextUser.Size = new System.Drawing.Size(451, 30);
            this.TextUser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clave de Acceso";
            // 
            // TextUserPwd
            // 
            this.TextUserPwd.BackColor = System.Drawing.Color.Gainsboro;
            this.TextUserPwd.BorderColor = System.Drawing.Color.Gainsboro;
            this.TextUserPwd.Location = new System.Drawing.Point(13, 137);
            this.TextUserPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextUserPwd.Name = "TextUserPwd";
            this.TextUserPwd.Numeric = false;
            this.TextUserPwd.Padding = new System.Windows.Forms.Padding(1);
            this.TextUserPwd.Password = false;
            this.TextUserPwd.Size = new System.Drawing.Size(451, 30);
            this.TextUserPwd.TabIndex = 1;
            // 
            // ComboRoles
            // 
            this.ComboRoles.BorderColor = System.Drawing.Color.Gainsboro;
            this.ComboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboRoles.FormattingEnabled = true;
            this.ComboRoles.Location = new System.Drawing.Point(13, 196);
            this.ComboRoles.Name = "ComboRoles";
            this.ComboRoles.Size = new System.Drawing.Size(451, 29);
            this.ComboRoles.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rol de Usuario";
            // 
            // FrmABMUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(476, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextUserPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "FrmABMUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmABMUser_Load);
            this.Controls.SetChildIndex(this.BtnIngresar, 0);
            this.Controls.SetChildIndex(this.BtnClose, 0);
            this.Controls.SetChildIndex(this.TextUser, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TextUserPwd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ComboRoles, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxAdv TextUser;
        private System.Windows.Forms.Label label2;
        private Controls.TextBoxAdv TextUserPwd;
        private Controls.ComboBoxAdv ComboRoles;
        private System.Windows.Forms.Label label3;
    }
}