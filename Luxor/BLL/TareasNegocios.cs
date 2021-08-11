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
    class TareasNegocios
    {

        public enum Tareas_Principales { AFIP = 1, IMPUESTOS_PROVINCIALES = 2, MUNICIPIO = 3}
        public enum Tareas_Secundarias { MONOTRIBUTO = 1, REGIMEN_GENERAL = 2, EMPLEADOR = 3, INGRESOS_BRUTOS = 4, CONVENIOS_MULTI = 5, TASAS_MUNICIPALES = 6 }

        public DataTable GetDataMeses() 
        {
            DataTable DataMeses = new DataTable();

            DataMeses.Columns.Add("Id", typeof(Int32));
            DataMeses.Columns.Add("Mes", typeof(String));

            DataMeses.Rows.Add(1, "Enero");
            DataMeses.Rows.Add(2, "Febrero");
            DataMeses.Rows.Add(3, "Marzo");
            DataMeses.Rows.Add(4, "Abril");
            DataMeses.Rows.Add(5, "Mayo");
            DataMeses.Rows.Add(6, "Junio");
            DataMeses.Rows.Add(7, "Julio");
            DataMeses.Rows.Add(8, "Agosto");
            DataMeses.Rows.Add(9, "Septiembre");
            DataMeses.Rows.Add(10, "Octubre");
            DataMeses.Rows.Add(11, "Noviembre");
            DataMeses.Rows.Add(12, "Diciembre");
            DataMeses.AcceptChanges();

            return DataMeses;
        }

        public DataTable GetDataTareasPrincipales()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Tareas_Principales.OrderBy(x => x.Descripcion).ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataTareasSecundarias()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Tareas_Secundarias.OrderBy(x => x.Descripcion).ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataTareasPeriodicidad()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Tareas_Periodos.OrderBy(x => x.Id).ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataTareasTipos()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                {
                    var query = (from u in context.Tareas_Tipos
                                 join ur in context.Tareas_Principales on u.Id_Tarea_Principal equals ur.Id
                                 join ul in context.Tareas_Secundarias on u.Id_Tarea_Secundaria equals ul.Id
                                 join p in context.Tareas_Periodos on u.Id_Tarea_Periodo equals p.Id
                                 where u.Borrado == false orderby ur.Descripcion, u.Descripcion
                                 select new
                                 {
                                     u.Id,
                                     u.Id_Tarea_Principal,
                                     u.Id_Tarea_Secundaria,
                                     u.Id_Tarea_Periodo,
                                     u.Id_Organismo,
                                     Tarea_Principal = ur.Descripcion,
                                     Tarea_Secundaria = ul.Descripcion,
                                     u.Descripcion,
                                     Periodicidad = p.Periodo
                                 }).ToList();

                    Data = tools.ToDataTable(query);
                }
            }
            catch { return null; }

            return Data;
        }

        public String Save(Int32 Id, Int32 Id_Tarea_Principal, Int32 Id_Tarea_Secundaria, String Descripcion, Int32 Id_Organismo, Int32 Id_Tarea_Periodo)
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    Tareas_Tipos Tareas_Tipos = Id > 0 ? context.Tareas_Tipos.Where(x => x.Id == Id).FirstOrDefault() : new Tareas_Tipos();
                    Tareas_Tipos.Id_Tarea_Principal = Id_Tarea_Principal;
                    Tareas_Tipos.Id_Tarea_Secundaria = Id_Tarea_Secundaria;
                    Tareas_Tipos.Id_Organismo = Id_Organismo;
                    Tareas_Tipos.Id_Tarea_Periodo = Id_Tarea_Periodo;
                    Tareas_Tipos.Descripcion = Descripcion;

                    if (Tareas_Tipos.Id == 0)
                        context.Tareas_Tipos.Add(Tareas_Tipos);

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

        public DataTable GetDataTareasTipos(int Id_Tarea_Principal, int Id_Tarea_Secundaria) 
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                {
                    var query = (from u in context.Tareas_Tipos
                                 join ur in context.Tareas_Principales on u.Id_Tarea_Principal equals ur.Id
                                 join ul in context.Tareas_Secundarias on u.Id_Tarea_Secundaria equals ul.Id
                                 join p in context.Tareas_Periodos on u.Id_Tarea_Periodo equals p.Id
                                 where u.Borrado == false && u.Id_Tarea_Principal == Id_Tarea_Principal && u.Id_Tarea_Secundaria == Id_Tarea_Secundaria
                                 orderby ur.Descripcion, u.Descripcion
                                 select new
                                 {
                                     u.Id,
                                     u.Id_Tarea_Principal,
                                     u.Id_Tarea_Secundaria,
                                     u.Id_Tarea_Periodo,
                                     u.Id_Organismo,
                                     Tarea_Principal = ur.Descripcion,
                                     Tarea_Secundaria = ul.Descripcion,
                                     u.Descripcion,
                                     Periodicidad = p.Periodo
                                 }).ToList();

                    Data = tools.ToDataTable(query);
                }
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataTareasClientes(int Id_Tarea_Principal, int Id_Tarea_Secundaria, int Id_Tarea_Tipo, int mes, int año) 
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                {

                    var query = context.GetTareas(Id_Tarea_Principal, Id_Tarea_Secundaria, Id_Tarea_Tipo, mes, año);

                    Data = tools.ToDataTable(query.ToList());
                }
            }
            catch { return null; }

            return Data;
        }
    }
}
