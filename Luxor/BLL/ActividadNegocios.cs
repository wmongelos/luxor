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
    class ActividadNegocios
    {
        public DataTable GetData() {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Actividades.ToList());
            }
            catch { return null; }

            return Data;
        }

        public String Save(Int32 Id_Cliente, Int32 Id_Actividad) 
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    Clientes_Actividades ClientesActividades = new Clientes_Actividades
                    {
                        Id_Cliente = Id_Cliente,
                        Id_Actividades = Id_Actividad
                    };

                    context.Clientes_Actividades.Add(ClientesActividades);
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
    }
}
