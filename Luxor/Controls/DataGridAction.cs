using System;
using System.Drawing;
using System.Windows.Forms;

namespace Luxor.Controls
{
    public partial class DataGridAction : UserControl
    {
        public DataGridAction()
        {
            InitializeComponent();

            PbIcon.Click += Control_Click;
            PnActive.Click += Control_Click;
        }

        public Image Icon {
            get { return PbIcon.Image; }
            set { PbIcon.Image = value; }
        }

        public Color Active 
        {
            get { return PnActive.BackColor; }
            set { PnActive.BackColor = value; }
        }

        private void DataGridAction_MouseEnter(object sender, EventArgs e)
        {
            PnActive.Visible = !PnActive.Visible;
        }

        private void DataGridAction_MouseLeave(object sender, EventArgs e)
        {
            PnActive.Visible = !PnActive.Visible;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
