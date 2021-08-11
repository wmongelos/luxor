using Luxor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmMenuConfig : FormBase
    {
        public FrmMenuConfig()
        {
            InitializeComponent();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().OpenForm(new FrmConfiguracion());
        }

        public void OpenForm(FrmListado.TypeList TypeList) 
        {
            FrmListado Frm = new FrmListado
            {
                List = TypeList
            };

            FrmMain.Instance().OpenForm(Frm);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            OpenForm(FrmListado.TypeList.Roles);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm(FrmListado.TypeList.Usuarios);
        }

        private void BtnEntidades_Click(object sender, EventArgs e)
        {
            OpenForm(FrmListado.TypeList.Entidades_Bancarias);
        }

        private void BtnMediosPagos_Click(object sender, EventArgs e)
        {
            OpenForm(FrmListado.TypeList.Formas_Pago);
        }

        private void BtnMediosComu_Click(object sender, EventArgs e)
        {
            OpenForm(FrmListado.TypeList.Medios_Comunicacion);
        }

        private void BtnOrganismos_Click(object sender, EventArgs e)
        {
            OpenForm(FrmListado.TypeList.Organismos);
        }

        private void BtnTareas_Tipos_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().OpenForm(new FrmTareasTipos());
        }
    }
}
