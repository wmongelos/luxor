using Luxor.BLL;
using Luxor.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmABMOrganismos : FormBase
    {
        public DataRow Data;
        private OrganismosNegocios OrgNeg = new OrganismosNegocios();

        private Int32 Id = 0;

        public FrmABMOrganismos()
        {
            InitializeComponent();
        }

        private void FrmABMOrganismos_Load(object sender, EventArgs e)
        {
            if (Data != null)
            {
                Id = Convert.ToInt32(Data["Id"]);
                TextDescripcion.Text = Data["Descripcion"].ToString();
                ChkRequiereAcceso.Checked = Convert.ToBoolean(Data["Requiere_Acceso"]);
            }
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            if (TextDescripcion.Text == string.Empty)
                TextDescripcion.Focus();
            else
            {
                string Msj = OrgNeg.Save(Id, TextDescripcion.Text, ChkRequiereAcceso.Checked);

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
