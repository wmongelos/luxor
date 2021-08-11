using Luxor.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxor.BLL
{
    class ClienteNegocios
    {
        public DataTable GetData()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                {

                    var query = context.Clientes
                        .Join(
                            context.Clientes_Tipos,
                            cliente => cliente.Id_Clientes_Tipo,
                            cliente_tipo => cliente_tipo.Id,
                            (cliente, cliente_tipo) => new
                            {
                                Id = cliente.Id,
                                Codigo = cliente.Codigo,
                                Tipo = cliente_tipo.Descripcion,
                                Razon_Social = cliente.Razon_Social,
                                Telefono_Particular = cliente.Telefono_Particular,
                                Cuit = cliente.Cuit,
                                Afip_Monotributo = cliente.Afip_Monotributo == true ? "SI": "NO",
                                Afip_Empleador = cliente.Afip_Empleador == true ? "SI" : "NO",
                                Afip_Regimen_Gral = cliente.Afip_Regimen_Gral == true ? "SI" : "NO",
                                Impuestos_Ing_Brutos = cliente.Impuestos_Ing_Brutos == true ? "SI" : "NO",
                                Impuestos_Conv_Multi = cliente.Impuestos_Conv_Multi == true ? "SI" : "NO",
                                Tasas_Municipales = cliente.Tasas_Municipales == true ? "SI" : "NO"
                                
                            }
                        ).ToList();

                    Data = tools.ToDataTable(query);
                }

            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataTipos()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Clientes_Tipos.OrderBy(x => x.Id).ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataMetodosFacturacion()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Metodos_Facturacion.OrderBy(x => x.Id).ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetActividades(Int32 Id_Cliente) 
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                {
                    var query = context.Actividades.SqlQuery(String.Format("Select Id, Codigo, Descripcion, Descripcion_Larga " +
                        "FROM Actividades Where Id IN (Select Id_Actividades FROM Clientes_Actividades WHERE Id_Cliente = {0})", Id_Cliente));

                    Data = tools.ToDataTable(query.ToList());
                }
                    
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetTareas(Int32 Id_Cliente)
        {
            DataTable Data = new DataTable();
            Data.Columns.Add("Id_Tarea_Tipo", typeof(Int32));
            Data.Columns.Add("Tarea_Principal", typeof(String));
            Data.Columns.Add("Tarea_Secundaria", typeof(String));
            Data.Columns.Add("Descripcion", typeof(String));
            Data.Columns.Add("Periodo", typeof(String));
            DataColumn Dc = new DataColumn("Seleccionar", typeof(bool));
            Dc.DefaultValue = false;
            Data.Columns.Add(Dc);
            Data.AcceptChanges();

            try
            {
                if(Id_Cliente > 0)
                {
                    Controls.Tools tools = new Controls.Tools();

                    using (var context = new dbLuxorEntities())
                    {
                        var query = context.Actividades.SqlQuery(String.Format("Select Id, Codigo, Descripcion, Descripcion_Larga " +
                            "FROM Actividades Where Id IN (Select Id_Actividades FROM Clientes_Actividades WHERE Id_Cliente = {0})", Id_Cliente));

                        Data = tools.ToDataTable(query.ToList());
                    }
                }


            }
            catch { return null; }

            return Data;
        }

        public Int32 Save(Clientes Cliente, out String Msj)
        {
            Msj = "Guardado Correctamente";

            try
            {
                using (var context = new dbLuxorEntities())
                {
                    if (Cliente.Id == 0)
                        context.Clientes.Add(Cliente);

                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder Error = new StringBuilder();

                foreach (var eve in e.EntityValidationErrors)
                {
                    Error.AppendLine(String.Format("La entidad de tipo {0} en el estado {1} tiene los siguientes errores de validación:", eve.Entry.Entity.GetType().Name, eve.Entry.State));

                    foreach (var ve in eve.ValidationErrors)
                        Error.AppendLine(String.Format("- Property: {0}, Error: {1}", ve.PropertyName, ve.ErrorMessage));
                }


                Msj = Error.ToString();
              
            }

            return Cliente.Id;
        }

        public String SaveTasks(Int32 Id_Cliente, DataTable DataTask) 
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    foreach (DataRow Dr in DataTask.Rows)
                    {
                        Clientes_Tareas ClientesTareas = new Clientes_Tareas
                        {
                            Id_Cliente = Id_Cliente,
                            Id_Tarea_Tipo = Convert.ToInt32(Dr["Id_Tarea_Tipo"])
                        };

                        context.Clientes_Tareas.Add(ClientesTareas);
                    }
                    
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder Error = new StringBuilder();

                foreach (var eve in e.EntityValidationErrors)
                {
                    Error.AppendLine(String.Format("La entidad de tipo {0} en el estado {1} tiene los siguientes errores de validación:", eve.Entry.Entity.GetType().Name, eve.Entry.State));

                    foreach (var ve in eve.ValidationErrors)
                        Error.AppendLine(String.Format("- Property: {0}, Error: {1}", ve.PropertyName, ve.ErrorMessage));
                }


                return Error.ToString();

            }

            return "";
        }

        public String Delete(Int32 Id) 
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    context.Usuarios_Roles.Where(x => x.Id == Id).FirstOrDefault().Borrado = true;
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { return String.Format("Error al Guardar Datos. {0}", ex.Message); }

            return "";
        }

        public Int32 GetCodigo()
        {
            using (var context = new dbLuxorEntities())
            {
                int? intIdt = context.Clientes.Max(u => (int?)u.Id);

                return intIdt == null ? 1 : Convert.ToInt32(intIdt) + 1;
            }
        }
    }
}
