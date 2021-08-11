using Luxor.BLL;
using Luxor.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmGestionTareas : FormBase
    {
        private TareasNegocios TareasNeg = new TareasNegocios();
        private DataTable Data = new DataTable();
        private DataTable DataTareasSecundarias;
        private DataTable DataTareasTipos = new DataTable();
        private String Campo = String.Empty;
        private ClienteNegocios ClienteNegocios = new ClienteNegocios();

        private int Id_Tarea_Principal;
        private int Id_Tarea_Secundaria;
        private int Id_Tarea_Tipo;
        private int Mes;
        private int Año;

        public FrmGestionTareas()
        {
            InitializeComponent();
        }

        private void FrmTareas_Load(object sender, EventArgs e)
        {

            ComboTareasPrincipal.DataSource = TareasNeg.GetDataTareasPrincipales();
            ComboTareasPrincipal.DisplayMember = "Descripcion";
            ComboTareasPrincipal.ValueMember = "Id";

            DataTareasSecundarias = TareasNeg.GetDataTareasSecundarias();
            DataTareasSecundarias.DefaultView.RowFilter = String.Format("Id_Tarea_Principal = {0}", ComboTareasPrincipal.SelectedValue);

            ComboTareasSecundarias.DataSource = DataTareasSecundarias;
            ComboTareasSecundarias.DisplayMember = "Descripcion";
            ComboTareasSecundarias.ValueMember = "Id";


            DataTareasTipos = TareasNeg.GetDataTareasTipos();
            DataTareasTipos.DefaultView.RowFilter = String.Format("Id_Tarea_Principal = {0} and Id_Tarea_Secundaria = {1}", ComboTareasPrincipal.SelectedValue, ComboTareasSecundarias.SelectedValue);


            ComboTareasTipos.DataSource = DataTareasTipos;
            ComboTareasTipos.DisplayMember = "Descripcion";
            ComboTareasTipos.ValueMember = "Id";

            ComboMeses.DataSource = TareasNeg.GetDataMeses();
            ComboMeses.DisplayMember = "Mes";
            ComboMeses.ValueMember = "Id";

            ComboMeses.SelectedValue = DateTime.Now.Month;
            NudAño.Value = DateTime.Now.Year;
        }

        private void dataGrid_ButtonAdd_Click(object sender, EventArgs e)
        {
            FrmFichaCliente FrmAbm = new FrmFichaCliente();
            FrmMain.Instance().OpenForm(FrmAbm);
        }

        private void BgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            Data = TareasNeg.GetDataTareasClientes(Id_Tarea_Principal, Id_Tarea_Principal, Id_Tarea_Tipo, Mes, Año);
        }

        private void BgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGrid.Dgv.DataSource = Data;

            for (int i = 0; i < dataGrid.Dgv.Columns.Count; i++)
                dataGrid.Dgv.Columns[i].Visible = false;

            dataGrid.Dgv.Columns["Codigo"].Visible = true;
            dataGrid.Dgv.Columns["Apellido"].Visible = true;
            dataGrid.Dgv.Columns["Apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Nombre"].Visible = true;
            dataGrid.Dgv.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Estado"].Visible = true;

            //dataGrid.Dgv.Columns["Id"].Visible = false;
            //dataGrid.Dgv.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGrid.Dgv.Columns["Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGrid.Dgv.Columns["Razon_Social"].HeaderText = "Razon Social";
            //dataGrid.Dgv.Columns["Razon_Social"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGrid.Dgv.Columns["Telefono_Particular"].HeaderText = "Telefono Particular";
            //dataGrid.Dgv.Columns["Telefono_Particular"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGrid.Dgv.Columns["Telefono_Particular"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGrid.Dgv.Columns["Cuit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGrid.Dgv.Columns["Cuit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //for (int i = 6; i < dataGrid.Dgv.Columns.Count; i++)
            //    dataGrid.Dgv.Columns[i].Visible = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Id_Tarea_Principal = Convert.ToInt32(ComboTareasPrincipal.SelectedValue);
            Id_Tarea_Secundaria = Convert.ToInt32(ComboTareasSecundarias.SelectedValue);
            Id_Tarea_Tipo =Convert.ToInt32(ComboTareasTipos.SelectedValue);
            Mes = Convert.ToInt32(ComboMeses.SelectedValue);
            Año = Convert.ToInt32(NudAño.Value);


            BgWork.RunWorkerAsync();
        }

        private void ComboTareasPrincipal_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataTareasSecundarias != null)
                    DataTareasSecundarias.DefaultView.RowFilter = String.Format("Id_Tarea_Principal = {0}", ComboTareasPrincipal.SelectedValue);
            }
            catch { }
        }

        private void ComboTareasSecundarias_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataTareasTipos != null)
                    DataTareasTipos.DefaultView.RowFilter = String.Format("Id_Tarea_Principal = {0} and Id_Tarea_Secundaria = {1}", ComboTareasPrincipal.SelectedValue, ComboTareasSecundarias.SelectedValue);
            }
            catch { }
        }
    }
}
