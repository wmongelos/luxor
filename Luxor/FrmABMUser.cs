using Luxor.BLL;
using Luxor.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmABMUser : FormBase
    {
        public enum TypeABM { ROLES = 1, FORMAS_DE_PAGO = 2}
        public TypeABM Type;
        public DataRow Data;

        private Int32 Id = 0;

        public FrmABMUser()
        {
            InitializeComponent();
        }

        private void FrmABMUser_Load(object sender, EventArgs e)
        {
            RolNegocios RolNeg = new RolNegocios();
            ComboRoles.DataSource = RolNeg.GetData();
            ComboRoles.DisplayMember = "Descripcion";
            ComboRoles.ValueMember = "Id";

            if (Data != null)
            {
                Id = Convert.ToInt32(Data["Id"]);
                TextUser.Text = Data["Usuario"].ToString();
                TextUserPwd.Text = Data["Clave"].ToString();
                ComboRoles.SelectedValue = Data["Id_Usuario_Rol"].ToString();
            }
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            if (TextUser.Text == string.Empty || TextUserPwd.Text == string.Empty)
            {
                if (TextUser.Text == string.Empty)
                    TextUser.Focus();
                else
                    TextUserPwd.Focus();
            }
            else
            {
                UsuarioNegocios UsuarioNeg = new UsuarioNegocios();

                string Msj = UsuarioNeg.Save(Id, TextUser.Text, TextUserPwd.Text, Convert.ToInt32(ComboRoles.SelectedValue));

                if (Msj.Length > 0)
                    MessageBox.Show(Msj, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    DialogResult = DialogResult.OK;
            }
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
