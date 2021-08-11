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
    class RolNegocios
    {
        public DataTable GetData()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Usuarios_Roles.Where(x => x.Borrado == false).OrderBy(x => x.Descripcion).ToList());
            }
            catch { return null; }

            return Data;
        }

        public String Save(Int32 Id, String Descripcion)
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    Usuarios_Roles UsuarioRol = Id > 0 ? context.Usuarios_Roles.Where(x => x.Id == Id).FirstOrDefault() : new Usuarios_Roles();
                    UsuarioRol.Descripcion = Descripcion;


                    if (UsuarioRol.Id == 0)
                        context.Usuarios_Roles.Add(UsuarioRol);

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
    }
}
