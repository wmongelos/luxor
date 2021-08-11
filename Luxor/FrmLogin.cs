using Luxor.BLL;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void PnClose_MouseEnter(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.Coral;
        }

        private void PnClose_MouseLeave(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.FromArgb(81, 92, 107);
        }

        private void PnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TextUser.Text == String.Empty || TextUserPass.Text == String.Empty)
            {
                if (TextUser.Text == String.Empty)
                    TextUser.Focus();
                else
                    TextUserPass.Focus();
            }
            else
            {
                UsuarioNegocios UsuarioNegocios = new UsuarioNegocios();


                bool result = UsuarioNegocios.ValidAccess(TextUser.Text, TextUserPass.Text);

                if (result)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    TextUser.Text = "";
                    TextUserPass.Text = "";

                    TextUser.Focus();
                }
            }
        }
    }
}
