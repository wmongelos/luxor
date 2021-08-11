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
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();

            foreach (Control Ctl in Controls)
            {
                Ctl.MouseEnter += Borders;
                Ctl.MouseLeave += Borders;
                Ctl.Click += Control_Click;
            }

            MouseEnter += Borders;
            MouseLeave += Borders;
        }

        public Image Icon
        {
            get { return PbIcon.Image; }
            set { PbIcon.Image = value; }
        }

        public String Caption
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }

        public String SubCaption
        {
            get { return LblSubTitle.Text; }
            set { LblSubTitle.Text = value; }
        }

        private void Borders(object sender, EventArgs e) 
        {
            PnLeft.Visible = !PnLeft.Visible;
            PnTop.Visible = !PnTop.Visible;
            PnRight.Visible = !PnRight.Visible;
            PnBottom.Visible = !PnBottom.Visible;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
