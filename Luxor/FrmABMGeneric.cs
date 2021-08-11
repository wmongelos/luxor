using Luxor.BLL;
using Luxor.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmABMGeneric : FormBase
    {
        public enum TypeABM { ROLES = 1, ENTIDADES_BANCARIAS = 2, FORMAS_DE_PAGO = 3, MEDIOS_COMUNICACION = 4, ORGANISMOS = 5}
        public TypeABM Type;
        public DataRow Data;

        private Int32 Id = 0;

        public FrmABMGeneric()
        {
            InitializeComponent();
        }

        private void FrmABMGeneric_Load(object sender, EventArgs e)
        {
            if (Data != null)
            {
                Id = Convert.ToInt32(Data["Id"]);
                TextDescripcion.Text = Data["Descripcion"].ToString();
            }
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            if (TextDescripcion.Text == string.Empty)
                TextDescripcion.Focus();
            else
            {
                string Msj = String.Empty;

                switch (Type)
                {
                    case TypeABM.ROLES:
                        RolNegocios RolNeg = new RolNegocios();
                        Msj = RolNeg.Save(Id, TextDescripcion.Text);
                        break;
                    case TypeABM.FORMAS_DE_PAGO:
                        FormaPagoNegocios FPagoNeg = new FormaPagoNegocios();
                        Msj = FPagoNeg.Save(Id, TextDescripcion.Text);
                        break;
                    case TypeABM.ENTIDADES_BANCARIAS:
                        EntidadesBancNegocios EBancariasNeg = new EntidadesBancNegocios();
                        Msj = EBancariasNeg.Save(Id, TextDescripcion.Text);
                        break;
                    case TypeABM.MEDIOS_COMUNICACION:
                        FComunicacionNegocios FComunNeg = new FComunicacionNegocios();
                        Msj = FComunNeg.Save(Id, TextDescripcion.Text);
                        break;
                    default:
                        break;
                }


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
