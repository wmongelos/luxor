using Luxor.BLL;
using Luxor.Controls;
using System;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmConfiguracion : FormBase
    {
        ConfiguracionNegocios ConfigNegocios = new ConfiguracionNegocios();

        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void LoadData() {
            TextRazonSocial.Text = ConfigNegocios.GetValor_C("Razon_Social");
            TextDireccion.Text = ConfigNegocios.GetValor_C("Direccion");
            TextCuit.Text = ConfigNegocios.GetValor_C("Cuit");
            TextTelefono.Text = ConfigNegocios.GetValor_C("Telefono");
            DateInicioAct.Value = ConfigNegocios.GetValor_C("Inicio_Act") == String.Empty ? DateTime.Today : Convert.ToDateTime(ConfigNegocios.GetValor_C("Inicio_Act"));
            TextIIBB.Text = ConfigNegocios.GetValor_C("IngBrutos");
            NudImporteMensual.Value = ConfigNegocios.GetValor_D("Honorario_Mensual");
            NudImporteAnual.Value = ConfigNegocios.GetValor_D("Honorario_Anual");
        }

        private void SaveData()
        {
            ConfigNegocios.SetValor_C("Razon_Social", TextRazonSocial.Text);
            ConfigNegocios.SetValor_C("Direccion", TextDireccion.Text);
            ConfigNegocios.SetValor_C("Cuit", TextCuit.Text);
            ConfigNegocios.SetValor_C("Telefono", TextTelefono.Text);
            ConfigNegocios.SetValor_C("Inicio_Act", DateInicioAct.Value.ToShortDateString());
            ConfigNegocios.SetValor_C("IngBrutos", TextIIBB.Text);
            ConfigNegocios.SetValor_D("Honorario_Mensual", NudImporteMensual.Value);
            ConfigNegocios.SetValor_D("Honorario_Anual", NudImporteAnual.Value);
            ConfigNegocios.GetConfiguracion();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Confirmar la Configuracion del Sistema?", "Mensaje del Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();

                Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
