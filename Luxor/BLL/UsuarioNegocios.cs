using Luxor.DAL;
using Luxor.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxor.BLL
{
    class UsuarioNegocios
    {
        public Boolean ValidAccess(String UserName, String UserPass) 
        {
            using (var context = new dbLuxorEntities())
            {
                Usuarios Usuario = context.Usuarios.Where(x => x.Usuario == UserName && x.Clave == UserPass && x.Borrado == false).FirstOrDefault();

                if (Usuario != null)
                {
                    CurrentUser.Id_Usuario = Usuario.Id;
                    CurrentUser.Usuario = Usuario.Usuario;

                    return true;
                }
            }

            return false;
        }
        public DataTable GetData()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                {
                    var query = (from u in context.Usuarios
                                 join ur in context.Usuarios_Roles on u.Id_Usuario_Rol equals ur.Id
                                 where u.Borrado == false && ur.Borrado == false
                                 select new
                                 {
                                     u.Id,
                                     u.Usuario,
                                     u.Clave,
                                     Rol = ur.Descripcion,
                                     u.Id_Usuario_Rol
                                 }).ToList();

                    Data = tools.ToDataTable(query);
                }
            }
            catch { return null; }

            return Data;
        }

        public String Save(Int32 Id, String UserName, String UserPass, Int32 IdUsuarioRol)
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    Usuarios Usuario = Id > 0 ? context.Usuarios.Where(x => x.Id == Id).FirstOrDefault() : new Usuarios();
                    Usuario.Usuario = UserName;
                    Usuario.Clave = UserPass;
                    Usuario.Id_Usuario_Rol = IdUsuarioRol;

                    if (Usuario.Id == 0)
                        context.Usuarios.Add(Usuario);

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
                    context.Usuarios.Where(x => x.Id == Id).FirstOrDefault().Borrado = true;
                    context.SaveChanges();
                }
            }
            catch (Exception ex) { return String.Format("Error al Guardar Datos. {0}", ex.Message); }

            return "";
        }
    }
}
