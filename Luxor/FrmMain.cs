using Luxor.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmMain : Form
    {
        private static FrmMain aForm = null;

        public static FrmMain Instance()
        {
            if (aForm == null)
                aForm = new FrmMain();

            return aForm;
        }

        private FrmMain()
        {
            InitializeComponent();
        }

        public void OpenForm(Form Frm)
        {
            PnNavBar.Width = 47;

            PnContent.Controls.Clear();
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;

            foreach (Control Ctl in PnNavBar.Controls)
            {
                Luxor.Controls.NavBarButton navBarButton;
                
                if (Ctl.GetType() == typeof(Luxor.Controls.NavBarButton))
                {
                    navBarButton = (Luxor.Controls.NavBarButton)Ctl;
                    navBarButton.Active = false;            
                }
            }

            PnContent.Controls.Add(Frm);
            Frm.Show();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            LblUserLogin.Text = CurrentUser.Usuario;
        }

        private void PnClose_MouseEnter(object sender, System.EventArgs e)
        {
            PnClose.BackColor = Color.Coral;
        }

        private void PnClose_MouseLeave(object sender, System.EventArgs e)
        {
            PnClose.BackColor = Color.Transparent;
        }

        private void PnMinimize_MouseEnter(object sender, System.EventArgs e)
        {
            PnMinimize.BackColor = Color.SlateGray;
        }

        private void PnMinimize_MouseLeave(object sender, System.EventArgs e)
        {
            PnMinimize.BackColor = Color.Transparent;
        }

        private void PnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void PnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PnMenu_MouseEnter(object sender, EventArgs e)
        {
            PnMenu.BackColor = Color.SlateGray;
        }

        private void PnMenu_MouseLeave(object sender, EventArgs e)
        {
            PnMenu.BackColor = Color.Transparent;
        }

        private void PnMenu_Click(object sender, EventArgs e)
        {
            PnNavBar.Width = PnNavBar.Width == 47 ? 200 : 47;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmClientes());
            BtnClientes.Active = true;
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmMenuConfig());
            BtnConfig.Active = true;
        }

        private void BtnTareas_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmGestionTareas());
            BtnTareas.Active = true;
        }
    }
}
