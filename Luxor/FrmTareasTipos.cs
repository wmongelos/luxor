using Luxor.BLL;
using Luxor.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmTareasTipos : FormBase
    {
        private TareasNegocios TareasNeg = new TareasNegocios();
        private DataTable Table = new DataTable();
        private DataRow Row;

        public FrmTareasTipos()
        {
            InitializeComponent();
        }

        private void OpenForm()
        {
            using (FrmModal Frm = new FrmModal())
            {
                FrmABMTareasTipos FrmAbm = new FrmABMTareasTipos();
                FrmAbm.Data = Row;
                Frm.Form = FrmAbm;

                if (Frm.ShowDialog() == DialogResult.OK)
                    BgWork.RunWorkerAsync();
            }
        }
        private void FrmTareasTipos_Load(object sender, EventArgs e)
        {
            BgWork.RunWorkerAsync();
        }
        private void dataGrid_ButtonAdd_Click(object sender, EventArgs e)
        {
            Row = null;

            OpenForm();
        }
        private void dataGrid_ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGrid.Dgv.SelectedRows.Count > 0)
            {
                Row = Table.Select(String.Format("Id = {0}", dataGrid.Dgv.SelectedRows[0].Cells["Id"].Value))[0];

                OpenForm();
            }
            else
                MessageBox.Show("Debe Seleccionar un Registro", "Mensaje del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void dataGrid_ButtonDelete_Click(object sender, EventArgs e)
        {

        }
        private void BgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            Table = TareasNeg.GetDataTareasTipos();
        }
        private void BgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGrid.Dgv.DataSource = Table;

            for (int i = 0; i < dataGrid.Dgv.Columns.Count; i++)
                dataGrid.Dgv.Columns[i].Visible = false;

            dataGrid.Dgv.Columns["Id"].Visible = true;
            dataGrid.Dgv.Columns["Id"].HeaderText = "#";
            dataGrid.Dgv.Columns["Tarea_Principal"].Visible = true;
            dataGrid.Dgv.Columns["Tarea_Principal"].HeaderText = "Tarea Principal";
            dataGrid.Dgv.Columns["Tarea_Principal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Tarea_Secundaria"].Visible = true;
            dataGrid.Dgv.Columns["Tarea_Secundaria"].HeaderText = "Tarea Secundaria";
            dataGrid.Dgv.Columns["Tarea_Secundaria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Descripcion"].Visible = true;
            dataGrid.Dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Periodicidad"].Visible = true;
            dataGrid.Dgv.Columns["Periodicidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

    }
}
