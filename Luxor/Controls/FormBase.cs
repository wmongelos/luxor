using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxor.Controls
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();

            KeyPreview = true;
        }

        public Boolean RequiereResult { get; set; }

        private void CloseForm()
        {
            if (RequiereResult)
                DialogResult = DialogResult.Cancel;
            else
                Close();
        }

        private void FormBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                CloseForm();
        }
    }
}
