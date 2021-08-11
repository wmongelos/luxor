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
    public partial class FormClose : UserControl
    {
        public FormClose()
        {
            InitializeComponent();

            PbClose.Click += Control_Click;
        }

        private void FormClose_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Coral;
        }

        private void FormClose_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(81, 92, 107);
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
