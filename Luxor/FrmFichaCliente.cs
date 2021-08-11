using Luxor.BLL;
using Luxor.Controls;
using Luxor.DAL;
using Luxor.Entities;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Luxor
{
    public partial class FrmFichaCliente : FormBase
    {
        private readonly ClienteNegocios ClienteNeg = new ClienteNegocios();
        private readonly ActividadNegocios ActividadNeg = new ActividadNegocios();
        private readonly FormaPagoNegocios FormaPagoNeg = new FormaPagoNegocios();
        private readonly OrganismosNegocios OrganismosNeg = new OrganismosNegocios();
        private readonly Clientes Cliente = new Clientes();
        private readonly TareasNegocios TareaNeg = new TareasNegocios();

        private DataTable ActividadesClientes = new DataTable();
        private DataTable TareasClientes = new DataTable();
        private DataTable ClavesAccesos = new DataTable();
        private Int32 Id_Cliente = 0;

        public FrmFichaCliente()
        {
            InitializeComponent();
        }

        public DataRow Data;

        private Boolean ValidateData()
        {
            

            return true;
        }

        private void AddTask(TareasNegocios.Tareas_Principales Tarea_Principal, TareasNegocios.Tareas_Secundarias Tarea_Secundaria) 
        {
            DataTable Data = TareaNeg.GetDataTareasTipos((Int32)Tarea_Principal, (Int32)Tarea_Secundaria);

            if(Data.Rows.Count > 0)
            {
                foreach (DataRow Dr in Data.Rows)
                    TareasClientes.Rows.Add(Dr["Id"], Dr["Tarea_Principal"], Dr["Tarea_Secundaria"], Dr["Descripcion"], Dr["Periodicidad"]);
            }
        }

        private void RemoveTask(TareasNegocios.Tareas_Principales Tarea_Principal, TareasNegocios.Tareas_Secundarias Tarea_Secundaria)
        {

        }

        private void BtnVerificarAFIP_Click(object sender, System.EventArgs e)
        {
            if (TxtCuit.Text.Length > 0)
            {
                Afip FEafip = new Afip();

                Boolean bReturn = FEafip.GetDatos(Convert.ToInt64(TxtCuit.Text));

                if (bReturn)
                {
                    //TextCliente.Text = String.Format("{0}, {1}", FEafip.Persona.datosGenerales.apellido, FEafip.Persona.datosGenerales.apellido);

                }
                
            }
        }

        private void LoadData()
        {
            ComboTipos.DataSource = ClienteNeg.GetDataTipos();
            ComboTipos.ValueMember = "Id";
            ComboTipos.DisplayMember = "Descripcion";

            if (Data == null)
                TxtCodigo.Text = ClienteNeg.GetCodigo().ToString();
            else
            {
                Id_Cliente = Convert.ToInt32(Data["Id"]);
            }

            ActividadesClientes = ClienteNeg.GetActividades(Id_Cliente);

            DgvActividades.DataSource = ActividadesClientes;
            DgvActividades.Columns["Id"].Visible = false;
            DgvActividades.Columns["Descripcion_Larga"].Visible = false;
            DgvActividades.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataTable DataFormaPago = FormaPagoNeg.GetData();

            foreach (DataRow Dr in DataFormaPago.Rows)
            {
                CheckBox chk = new CheckBox
                {
                    Font = new System.Drawing.Font("Segoe UI Semilight", 10, System.Drawing.FontStyle.Regular),
                    Text = Dr["Descripcion"].ToString(),
                    AutoSize = true
                };

                FlpMonotributo_FormaPago.Controls.Add(chk);
            }

            Monotributo Monotributo = new Monotributo();

            DataTable DataJurisdicciones = Monotributo.GetDataJurisdicciones();

            CboMonoCategorias.DataSource = Monotributo.GetDataCategorias();
            CboMonoCategorias.ValueMember = "Id";
            CboMonoCategorias.DisplayMember = "Descripcion";

            CboMonoRegimen.DataSource = Monotributo.GetDataRegimen();
            CboMonoRegimen.ValueMember = "Id";
            CboMonoRegimen.DisplayMember = "Descripcion";

            CboEmpleadorTipo.DataSource = Monotributo.GetDataEmpleadorTipo();
            CboEmpleadorTipo.ValueMember = "Id";
            CboEmpleadorTipo.DisplayMember = "Descripcion";

            CboRegGral_Categorias.DataSource = Monotributo.GetDataRegGral_Categorias();
            CboRegGral_Categorias.ValueMember = "Id";
            CboRegGral_Categorias.DisplayMember = "Descripcion";

            CboIngBrutos_Jurisdicciones.DataSource = DataJurisdicciones;
            CboIngBrutos_Jurisdicciones.ValueMember = "Id";
            CboIngBrutos_Jurisdicciones.DisplayMember = "Descripcion";

            BindingSource BSourceIngBrutos_FormasPago = new BindingSource();
            BSourceIngBrutos_FormasPago.DataSource = DataFormaPago;

            CboIngBrutos_FormasPago.DataSource = BSourceIngBrutos_FormasPago;
            CboIngBrutos_FormasPago.ValueMember = "Id";
            CboIngBrutos_FormasPago.DisplayMember = "Descripcion";

            ((ListBox)ChkJurisdicciones).DataSource = DataJurisdicciones;
            ((ListBox)ChkJurisdicciones).ValueMember = "Id";
            ((ListBox)ChkJurisdicciones).DisplayMember = "Descripcion";

            BindingSource BSourceConvenioMul_FormasPago = new BindingSource();
            BSourceConvenioMul_FormasPago.DataSource = DataFormaPago;

            CboConvenioMul_FormasPago.DataSource = BSourceConvenioMul_FormasPago;
            CboConvenioMul_FormasPago.ValueMember = "Id";
            CboConvenioMul_FormasPago.DisplayMember = "Descripcion";

            ClavesAccesos.Columns.Add("Id_Organismo", typeof(Int32));
            ClavesAccesos.Columns.Add("Descripcion", typeof(String));
            ClavesAccesos.Columns.Add("Usuario", typeof(String));
            ClavesAccesos.Columns.Add("Clave", typeof(String));
            ClavesAccesos.AcceptChanges();

            DgvClaves.DataSource = ClavesAccesos;
            DgvClaves.Columns["Id_Organismo"].Visible = false;
            DgvClaves.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvClaves.Columns["Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvClaves.Columns["Clave"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            CboOrganismos.DataSource = OrganismosNeg.GetData();
            CboOrganismos.ValueMember = "Id";
            CboOrganismos.DisplayMember = "Descripcion";

            CboFormaFacturacion.DataSource = ClienteNeg.GetDataMetodosFacturacion();
            CboFormaFacturacion.ValueMember = "Id";
            CboFormaFacturacion.DisplayMember = "Descripcion";

            TareasClientes = ClienteNeg.GetTareas(Data == null ? 0 : Id_Cliente);
            DgvTareas.DataSource = TareasClientes;
            DgvTareas.Columns["Id_Tarea_Tipo"].Visible = false;
            DgvTareas.Columns["Tarea_Principal"].HeaderText = "Tarea Principal";
            DgvTareas.Columns["Tarea_Principal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvTareas.Columns["Tarea_Secundaria"].HeaderText = "Tarea Secundaria";
            DgvTareas.Columns["Tarea_Secundaria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvTareas.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvTareas.ReadOnly = false;

        }

        private void FrmFichaCliente_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ComboTipos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                TxtRepresentante.Enabled = Convert.ToInt32(ComboTipos.SelectedValue) != 1;
                TxtRepresentanteCuit.Enabled = Convert.ToInt32(ComboTipos.SelectedValue) != 1;
                TxtRazonSocial.Enabled = Convert.ToInt32(ComboTipos.SelectedValue) != 1;
                TxtApellido.Enabled = Convert.ToInt32(ComboTipos.SelectedValue) == 1;
                TxtNombre.Enabled = Convert.ToInt32(ComboTipos.SelectedValue) == 1;

            }
            catch { }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData()) 
            {
                Cliente.Id = Data == null ? 0 : Id_Cliente;
                Cliente.Codigo = Convert.ToInt32(TxtCodigo.Text);
                Cliente.Id_Clientes_Tipo = Convert.ToInt32(ComboTipos.SelectedValue);
                Cliente.Cuit = TxtCuit.Text;
                Cliente.Apellido = TxtApellido.Text;
                Cliente.Nombre = TxtNombre.Text;
                Cliente.Razon_Social = TxtRazonSocial.Text;
                Cliente.Fecha_Inicio = DtpFechaInicio.Value;
                Cliente.Dni = TxtDni.Text;
                Cliente.Domicilio_1 = TxtDomFiscal.Text;
                Cliente.Domicilio_2 = TxtDomSuc.Text;
                Cliente.Domicilio_3 = TxtDomPart.Text;
                Cliente.Telefono_Comercial = TxtTelComercial.Text;
                Cliente.Telefono_Particular = TxtTelParticular.Text;
                Cliente.Representante = TxtRepresentante.Text;
                Cliente.Representante_Cuit = TxtRepresentanteCuit.Text;
                Cliente.Afip_Monotributo = ChkMonotributo.Checked;
                Cliente.Afip_Empleador = ChkEmpleador.Checked;
                Cliente.Afip_Regimen_Gral = ChkRegimenGral.Checked;
                Cliente.Impuestos_Ing_Brutos = ChkImpProv_IngBrutos.Checked;
                Cliente.Impuestos_Conv_Multi = ChkConveniosMulti.Checked;
                Cliente.Tasas_Municipales = ChkTasasMunicipales.Checked;
                Cliente.Id_Metodo_Facturacion = Convert.ToInt32(CboFormaFacturacion.SelectedValue);
                Cliente.Activo = true;

                String Msj = String.Empty;

                Id_Cliente = ClienteNeg.Save(Cliente, out Msj);

                if (Id_Cliente > 0) 
                {
                    if (Data == null)
                    {
                        if (ActividadesClientes.Rows.Count > 0) 
                        {
                            foreach (DataRow Dr in ActividadesClientes.Rows)
                            {
                                String MsjAct = ActividadNeg.Save(Id_Cliente, Convert.ToInt32(Dr["Id"]));

                                if (MsjAct.Length > 0)
                                    MessageBox.Show(MsjAct);
                            }
                        }

                        if(TareasClientes.Rows.Count > 0) 
                        {
                            DataView DataFilter = TareasClientes.DefaultView;
                            DataFilter.RowFilter = "Seleccionar = true";

                            if(DataFilter.Count > 0)
                            {
                                String MsjAct = ClienteNeg.SaveTasks(Id_Cliente, DataFilter.ToTable());

                                if (MsjAct.Length > 0)
                                    MessageBox.Show(MsjAct);
                            }
                            
                        }
                    }
                }

                MessageBox.Show(Msj);

            }
        }

        private void ChkMonotributo_CheckedChanged(object sender, EventArgs e)
        {
            PnMonotributo.Enabled = ChkMonotributo.CheckState == CheckState.Checked;

            if (ChkMonotributo.CheckState == CheckState.Checked)
                AddTask(TareasNegocios.Tareas_Principales.AFIP, TareasNegocios.Tareas_Secundarias.MONOTRIBUTO);
            else
                RemoveTask(TareasNegocios.Tareas_Principales.AFIP, TareasNegocios.Tareas_Secundarias.MONOTRIBUTO);
        }

        private void ChkEmpleador_CheckedChanged(object sender, EventArgs e)
        {
            PnEmpleador.Enabled = ChkEmpleador.CheckState == CheckState.Checked;

            if (ChkEmpleador.CheckState == CheckState.Checked)
                AddTask(TareasNegocios.Tareas_Principales.AFIP, TareasNegocios.Tareas_Secundarias.EMPLEADOR);
            else
                RemoveTask(TareasNegocios.Tareas_Principales.AFIP, TareasNegocios.Tareas_Secundarias.EMPLEADOR);
        }

        private void BtnAgregarAct_Click(object sender, EventArgs e)
        {
            using (FrmModal Frm = new FrmModal())
            {
                FrmBuscador FrmBuscar = new FrmBuscador();
                FrmBuscar.Data = ActividadNeg.GetData();
                Frm.Form = FrmBuscar;

                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    ActividadesClientes.ImportRow(FrmBuscar.DataSelection);
                    ActividadesClientes.AcceptChanges();
                }
            }
        }

        private void ChkRegimenGral_CheckedChanged(object sender, EventArgs e)
        {
            PnRegimenGeneral.Enabled = ChkRegimenGral.CheckState == CheckState.Checked;

            if (ChkRegimenGral.CheckState == CheckState.Checked)
                AddTask(TareasNegocios.Tareas_Principales.AFIP, TareasNegocios.Tareas_Secundarias.REGIMEN_GENERAL);
            else
                RemoveTask(TareasNegocios.Tareas_Principales.AFIP, TareasNegocios.Tareas_Secundarias.REGIMEN_GENERAL);
        }

        private void ChkImpProv_IngBrutos_CheckedChanged(object sender, EventArgs e)
        {
            PnIngresosBrutos.Enabled = ChkImpProv_IngBrutos.CheckState == CheckState.Checked;

            if (ChkImpProv_IngBrutos.CheckState == CheckState.Checked)
                AddTask(TareasNegocios.Tareas_Principales.IMPUESTOS_PROVINCIALES, TareasNegocios.Tareas_Secundarias.INGRESOS_BRUTOS);
            else
                RemoveTask(TareasNegocios.Tareas_Principales.IMPUESTOS_PROVINCIALES, TareasNegocios.Tareas_Secundarias.INGRESOS_BRUTOS);
        }

        private void ChkConveniosMulti_CheckedChanged(object sender, EventArgs e)
        {
            PnConveniosMulti.Enabled = ChkConveniosMulti.CheckState == CheckState.Checked;

            if (ChkConveniosMulti.CheckState == CheckState.Checked)
                AddTask(TareasNegocios.Tareas_Principales.IMPUESTOS_PROVINCIALES, TareasNegocios.Tareas_Secundarias.CONVENIOS_MULTI);
            else
                RemoveTask(TareasNegocios.Tareas_Principales.IMPUESTOS_PROVINCIALES, TareasNegocios.Tareas_Secundarias.CONVENIOS_MULTI);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FrmMain.Instance().OpenForm(new FrmClientes());
        }

        private void TxtNombre_Validated(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ComboTipos.SelectedValue) == 1)
                TxtRazonSocial.Text = String.Format("{0} {1}", TxtApellido.Text.Trim(), TxtNombre.Text.Trim());
        }

        private void BtnAgregarClave_Click(object sender, EventArgs e)
        {
            if (TextUsuarioAcceso.Text != String.Empty || TextClaveAcceso.Text != String.Empty) 
            {
                ClavesAccesos.Rows.Add((Int32)CboOrganismos.SelectedValue, CboOrganismos.Text, TextUsuarioAcceso.Text, TextClaveAcceso.Text);
                ClavesAccesos.AcceptChanges();
            }
        }
    }
}
