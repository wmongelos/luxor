using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxor.Controls
{
    public partial class NavBarButton : UserControl
    {
        public NavBarButton()
        {
            InitializeComponent();

            LblCaption.Click += Control_Click;
            PbIcon.Click += Control_Click;
            PnIcon.Click += Control_Click;
        }

        [
            Category("Apariencia"),
            Description("Define si es el boton activo de la Navegacion")
        ]
        public Boolean Active
        {
            set {
                PnLineActive.Visible = value;
            }
            get {
                return PnLineActive.Visible;
            }
        }

        [
            Category("Aparencia"),
            Description("Text del boton")
        ]
        public String Caption
        {
            set { LblCaption.Text = value; }
            get { return LblCaption.Text; }
        }

        public Image Icon 
        {
            set { PbIcon.Image = value; }
            get { return PbIcon.Image; }
        }


        private void NavBarButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(219, 219,219);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void NavBarButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
