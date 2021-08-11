using Luxor.BLL;
using Luxor.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmClientes : FormBase
    {

        private DataTable Data = new DataTable();
        private ClienteNegocios ClienteNegocios = new ClienteNegocios();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            BgWork.RunWorkerAsync();
        }

        private void dataGrid_ButtonAdd_Click(object sender, EventArgs e)
        {
            FrmFichaCliente FrmAbm = new FrmFichaCliente();
            FrmMain.Instance().OpenForm(FrmAbm);
        }

        private void BgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            Data = ClienteNegocios.GetData();
        }

        private void BgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGrid.Dgv.DataSource = Data;
            dataGrid.Dgv.Columns["Id"].Visible = false;
            dataGrid.Dgv.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGrid.Dgv.Columns["Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Dgv.Columns["Razon_Social"].HeaderText = "Razon Social";
            dataGrid.Dgv.Columns["Razon_Social"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Telefono_Particular"].HeaderText = "Telefono Particular";
            dataGrid.Dgv.Columns["Telefono_Particular"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Dgv.Columns["Telefono_Particular"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGrid.Dgv.Columns["Cuit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGrid.Dgv.Columns["Cuit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            for (int i = 6; i < dataGrid.Dgv.Columns.Count; i++)
                dataGrid.Dgv.Columns[i].Visible = false;
        }

        private void dataGrid_ButtonAction1_Click(object sender, EventArgs e)
        {
            if(dataGrid.Dgv.SelectedRows.Count > 0)
            {
                DataRow[] Dr = Data.Select(String.Format("Id = {0}", dataGrid.Dgv.SelectedRows[0].Cells["Id"].Value));
                FrmCtaCte FrmAbm = new FrmCtaCte();
                FrmAbm.Row = Dr[0];
                FrmMain.Instance().OpenForm(FrmAbm);
            }
        }
    }
}
