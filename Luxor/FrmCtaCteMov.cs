using Luxor.BLL;
using Luxor.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmCtaCteMov : FormBase
    {
        public DataRow Data;

        private Int32 Id = 0;

        public FrmCtaCteMov()
        {
            InitializeComponent();
        }

        private void FrmCtaCteMov_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Data["Id_Cliente"]);
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            if (TextDescripcion.Text == string.Empty)
                TextDescripcion.Focus();
            else
            {
                

            }
        }

        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
