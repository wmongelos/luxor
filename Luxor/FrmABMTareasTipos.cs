using Luxor.BLL;
using Luxor.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmABMTareasTipos : FormBase
    {
        public DataRow Data;

        private Int32 Id = 0;
        private DataTable DataTareasSecundarias;

        public FrmABMTareasTipos()
        {
            InitializeComponent();
        }

        private void FrmABMTareasTipos_Load(object sender, EventArgs e)
        {
            TareasNegocios TareasNeg = new TareasNegocios();
            OrganismosNegocios OrgNeg = new OrganismosNegocios();

            ComboTareasPrincipal.DataSource = TareasNeg.GetDataTareasPrincipales();
            ComboTareasPrincipal.DisplayMember = "Descripcion";
            ComboTareasPrincipal.ValueMember = "Id";

            DataTareasSecundarias = TareasNeg.GetDataTareasSecundarias();
            DataTareasSecundarias.DefaultView.RowFilter = String.Format("Id_Tarea_Principal = {0}", ComboTareasPrincipal.SelectedValue);

            ComboTareasSecundarias.DataSource = DataTareasSecundarias;
            ComboTareasSecundarias.DisplayMember = "Descripcion";
            ComboTareasSecundarias.ValueMember = "Id";

            ComboOrganismos.DataSource = OrgNeg.GetData();
            ComboOrganismos.DisplayMember = "Descripcion";
            ComboOrganismos.ValueMember = "Id";

            ComboTareasPeriodos.DataSource = TareasNeg.GetDataTareasPeriodicidad();
            ComboTareasPeriodos.DisplayMember = "Periodo";
            ComboTareasPeriodos.ValueMember = "Id";

            if (Data != null)
            {
                Id = Convert.ToInt32(Data["Id"]);
                ComboTareasPrincipal.SelectedValue = Convert.ToInt32(Data["Id_Tarea_Principal"]);
                ComboTareasSecundarias.SelectedValue = Convert.ToInt32(Data["Id_Tarea_Secundaria"]);
                ComboOrganismos.SelectedValue = Convert.ToInt32(Data["Id_Organismo"]);
                ComboTareasPeriodos.SelectedValue = Convert.ToInt32(Data["Id_Tarea_Periodo"]);
                TextDescripcion.Text = Data["Descripcion"].ToString();
            }
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            if (TextDescripcion.Text == String.Empty)
                TextDescripcion.Focus();
            else
            {
                TareasNegocios TareasNeg = new TareasNegocios();
                String Msj = TareasNeg.Save(Id, Convert.ToInt32(ComboTareasPrincipal.SelectedValue), Convert.ToInt32(ComboTareasSecundarias.SelectedValue), 
                    TextDescripcion.Text, Convert.ToInt32(ComboOrganismos.SelectedValue), Convert.ToInt32(ComboTareasPeriodos.SelectedValue));

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

        private void ComboTareasPrincipal_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(DataTareasSecundarias != null)
                    DataTareasSecundarias.DefaultView.RowFilter = String.Format("Id_Tarea_Principal = {0}", ComboTareasPrincipal.SelectedValue);
            }
            catch { }
        }
    }
}
