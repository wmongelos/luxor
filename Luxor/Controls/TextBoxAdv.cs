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
    public partial class TextBoxAdv : UserControl
    {
        private TextBox textBox = new TextBox();

        private Color borderColor = Color.Gainsboro;
        private Boolean isNumeric = false;
        private Boolean isPassword = false;

        public TextBoxAdv()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(TextBoxEx_Paint);
            this.Resize += new EventHandler(TextBoxEx_Resize);
            textBox.KeyPress += TextBox_KeyPress;
            textBox.KeyDown += TextBox_KeyDown;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
            textBox.Multiline = true;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI Semilight", 13, FontStyle.Regular);
            textBox.CharacterCasing = CharacterCasing.Upper;
            textBox.TextChanged += TextBox_TextChanged;
            this.Controls.Add(textBox);

            InvalidateSize();
        }

        public event EventHandler TextChangeEvent;

        protected void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextChangeEvent != null)
                TextChangeEvent(this, e);
        }


        private void TextBox_Leave(object sender, EventArgs e)
        {
            textBox.BackColor = Color.White;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            textBox.BackColor = Color.WhiteSmoke;
        }

        public override String Text 
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public Boolean Numeric 
        {
            get { return isNumeric; } 
            set { 
                isNumeric = value; 
                textBox.TextAlign = value == true ? HorizontalAlignment.Right : HorizontalAlignment.Left; 
            } 
        }

        public Boolean Password
        {
            get { return isPassword; }
            set
            {
                isPassword = value;

                if(value)
                    textBox.PasswordChar = '*';
            }

        }

        public event EventHandler TextBoxClick
        {
            add { textBox.Click += value; }
            remove { textBox.Click -= value; }
        }

        private void TextBoxEx_Resize(object sender, EventArgs e)
        {
            InvalidateSize();
        }
        private void TextBoxEx_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }
        private void InvalidateSize()
        {
            textBox.Size = new Size(this.Width - 2, this.Height - 2);
            textBox.Location = new Point(1, 1);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numeric)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }



    }
}
