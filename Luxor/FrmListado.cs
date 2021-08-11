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
using Luxor.BLL;

namespace Luxor
{
    public partial class FrmListado : FormBase
    {
        public enum TypeList { Roles = 1, Usuarios = 2, Entidades_Bancarias = 3, Formas_Pago = 4, Medios_Comunicacion = 5, Organismos = 6 }
        public TypeList List;

        private DataRow Row;

        public FrmListado()
        {
            InitializeComponent();
        }

        private DataTable Table = new DataTable();

        private void OpenForm()
        {
            using (FrmModal Frm = new FrmModal())
            {
                if(List != TypeList.Usuarios && List != TypeList.Organismos)
                {
                    FrmABMGeneric FrmAbm = new FrmABMGeneric();

                    switch (List)
                    {
                        case TypeList.Roles:
                            FrmAbm.Type = FrmABMGeneric.TypeABM.ROLES;
                            break;
                        case TypeList.Entidades_Bancarias:
                            FrmAbm.Type = FrmABMGeneric.TypeABM.ENTIDADES_BANCARIAS;
                            break;
                        case TypeList.Formas_Pago:
                            FrmAbm.Type = FrmABMGeneric.TypeABM.FORMAS_DE_PAGO;
                            break;
                        case TypeList.Medios_Comunicacion:
                            FrmAbm.Type = FrmABMGeneric.TypeABM.MEDIOS_COMUNICACION;
                            break;
                        default:
                            break;
                    }

                    FrmAbm.Data = Row;
                    Frm.Form = FrmAbm;
                }
                else
                {
                    if (List == TypeList.Usuarios)
                    {
                        FrmABMUser FrmAbm = new FrmABMUser();
                        FrmAbm.Data = Row;
                        Frm.Form = FrmAbm;
                    }
                    else {
                        FrmABMOrganismos FrmAbm = new FrmABMOrganismos();
                        FrmAbm.Data = Row;
                        Frm.Form = FrmAbm;
                    }
                    
                }
                

                if (Frm.ShowDialog() == DialogResult.OK)
                    BgWork.RunWorkerAsync();
            }

        }

        private void BgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (List)
            {
                case TypeList.Roles:
                    RolNegocios RolNegocios = new RolNegocios();
                    Table = RolNegocios.GetData();
                    break;
                case TypeList.Usuarios:
                    UsuarioNegocios UsuNegocios = new UsuarioNegocios();
                    Table = UsuNegocios.GetData();
                    break;
                case TypeList.Entidades_Bancarias:
                    EntidadesBancNegocios EBancariasNegocios = new EntidadesBancNegocios();
                    Table = EBancariasNegocios.GetData();
                    break;
                case TypeList.Formas_Pago:
                    FormaPagoNegocios FPagoNegocios = new FormaPagoNegocios();
                    Table = FPagoNegocios.GetData();
                    break;
                case TypeList.Medios_Comunicacion:
                    FComunicacionNegocios FComunNegocios = new FComunicacionNegocios();
                    Table = FComunNegocios.GetData();
                    break;
                case TypeList.Organismos:
                    OrganismosNegocios OrgNegocios = new OrganismosNegocios();
                    Table = OrgNegocios.GetData();
                    break;
                default:
                    break;
            }
        }

        private void BgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGrid.Dgv.DataSource = Table;

            for (int i = 0; i < dataGrid.Dgv.Columns.Count; i++)
                dataGrid.Dgv.Columns[i].Visible = false;

            dataGrid.Dgv.Columns["Id"].Visible = true;
            dataGrid.Dgv.Columns["Id"].HeaderText = "#";

            switch (List)
            {
                case TypeList.Roles:
                    dataGrid.Dgv.Columns["Descripcion"].Visible = true;
                    dataGrid.Dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGrid.CustomAction_1 = true;
                    dataGrid.IconCustonAction_1 = Properties.Resources.icons8_window_secured_32;
                    break;
                case TypeList.Usuarios:
                    dataGrid.Dgv.Columns["Usuario"].Visible = true;
                    dataGrid.Dgv.Columns["Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGrid.Dgv.Columns["Clave"].Visible = true;
                    dataGrid.Dgv.Columns["Rol"].Visible = true;
                    break;
                case TypeList.Entidades_Bancarias:
                case TypeList.Formas_Pago:
                case TypeList.Medios_Comunicacion:
                case TypeList.Organismos:
                    dataGrid.Dgv.Columns["Descripcion"].Visible = true;
                    dataGrid.Dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                default:
                    break;
            }
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {
            BgWork.RunWorkerAsync();
        }

        private void DataGrid_ButtonAdd_Click(object sender, EventArgs e)
        {
            Row = null;

            OpenForm();
        }

        private void DataGrid_ButtonEdit_Click(object sender, EventArgs e)
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

        private void DataGrid_ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.Dgv.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Int32 Id = Convert.ToInt32(Table.Select(String.Format("Id = {0}", dataGrid.Dgv.SelectedRows[0].Cells["Id"].Value))[0]["Id"]);

                    String Msj = String.Empty;

                    switch (List)
                    {
                        case TypeList.Roles:
                            RolNegocios Rol = new RolNegocios();
                            Msj = Rol.Delete(Id);
                            break;
                        case TypeList.Usuarios:
                            UsuarioNegocios Usu = new UsuarioNegocios();
                            Msj = Usu.Delete(Id);
                            break;
                        case TypeList.Entidades_Bancarias:
                            EntidadesBancNegocios EBan = new EntidadesBancNegocios();
                            Msj = EBan.Delete(Id);
                            break;
                        case TypeList.Formas_Pago:
                            FormaPagoNegocios FPag = new FormaPagoNegocios();
                            Msj = FPag.Delete(Id);
                            break;
                        case TypeList.Medios_Comunicacion:
                            FComunicacionNegocios FCom = new FComunicacionNegocios();
                            Msj = FCom.Delete(Id);
                            break;
                        case TypeList.Organismos:
                            OrganismosNegocios Org = new OrganismosNegocios();
                            Msj = Org.Delete(Id);
                            break;
                        default:
                            break;
                    }

                    if (Msj != String.Empty)
                        MessageBox.Show(Msj, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        BgWork.RunWorkerAsync();
                }
            }
            else
                MessageBox.Show("Debe Seleccionar un Registro", "Mensaje del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void DataGrid_ButtonAction1_Click(object sender, EventArgs e)
        {
            switch (List)
            {
                case TypeList.Roles:
                    using (FrmModal Frm = new FrmModal())
                    {
                        FrmPermisos FrmPerm = new FrmPermisos();
                        Frm.Form = FrmPerm;
                        Frm.ShowDialog();
                    }
                    break;
                case TypeList.Usuarios:
                    break;
                case TypeList.Entidades_Bancarias:
                    break;
                case TypeList.Formas_Pago:
                    break;
                default:
                    break;
            }
        }
    }
}
