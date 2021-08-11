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
    public partial class FrmModal : FormBase
    {
        public DataRow Data;
        public Form Form;

        public FrmModal()
        {
            InitializeComponent();

            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void FrmModal_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            this.DialogResult = Form.ShowDialog();
        }
    }
}
