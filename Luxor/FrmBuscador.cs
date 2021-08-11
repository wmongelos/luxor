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
    public partial class FrmBuscador : FormBase
    {
        public DataTable Data;
        public DataRow DataSelection;

        public FrmBuscador()
        {
            InitializeComponent();

            dataGrid.Dgv.SelectionChanged += Dgv_SelectionChanged;
            dataGrid.Dgv.CellDoubleClick += Dgv_CellDoubleClick;
            
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 Id = Convert.ToInt32(dataGrid.Dgv.SelectedRows[0].Cells["Id"].Value);

                DataSelection = Data.Select(String.Format("Id = {0}", Id))[0];

            }
            catch { } 
            
        }

        private void FrmBuscador_Load(object sender, EventArgs e)
        {
            dataGrid.Dgv.DataSource = Data;

            for (int i = 0; i < dataGrid.Dgv.ColumnCount; i++)
                dataGrid.Dgv.Columns[i].Visible = false;

            dataGrid.Dgv.Columns["Codigo"].Visible = true;
            dataGrid.Dgv.Columns["Descripcion"].Visible = true;
            dataGrid.Dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void PnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PnClose_MouseEnter(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.Coral;
        }

        private void PnClose_MouseLeave(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.FromArgb(81, 92, 107);
        }
    }
}
