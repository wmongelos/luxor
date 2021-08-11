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
    class CtaCteNegocios
    {
        public enum Type { DEBE = 1, HABER = 2}
        public DataTable GetCtaCte(Int32 Id_Cliente)
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Clientes_CtaCte.Where(x => x.Id_Cliente == Id_Cliente).OrderBy(x => x.Id).ToList());
            }
            catch { return null; }

            return Data;
        }

        public string Save(DateTime Fecha, string Descripcion, Type Type, Decimal Importe) 
        {
            try
            {
                using (var context = new dbLuxorEntities())
                {
                    Clientes_CtaCte CtaCte = new Clientes_CtaCte();
                    CtaCte.Fecha = Fecha;
                    CtaCte.Descripcion = Descripcion;
                    CtaCte.Debe = Type == Type.DEBE ? Importe : 0;
                    CtaCte.Haber = Type == Type.HABER ? Importe : 0;

                    context.Clientes_CtaCte.Add(CtaCte);

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
