using Luxor.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxor.BLL
{
    class Monotributo
    {
        public DataTable GetDataCategorias()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Monotributo_Categorias.ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataRegimen()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Monotributo_Regimen.ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataEmpleadorTipo()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Empleadores_Tipo.ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataRegGral_Categorias()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.RegimenGral_Categorias.ToList());
            }
            catch { return null; }

            return Data;
        }

        public DataTable GetDataJurisdicciones()
        {
            DataTable Data = new DataTable();

            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Provincias.ToList());
            }
            catch { return null; }

            return Data;
        }


    }
}
