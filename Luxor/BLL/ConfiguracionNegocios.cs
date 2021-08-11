using Luxor.DAL;
using System;
using System.Data;
using System.Linq;

namespace Luxor.BLL
{
    class ConfiguracionNegocios
    {
        public static DataTable Data;
        public bool GetConfiguracion() 
        {
            try
            {
                Controls.Tools tools = new Controls.Tools();

                using (var context = new dbLuxorEntities())
                    Data = tools.ToDataTable(context.Configuracion.ToList());

                return true;
            }
            catch { return false; }
        }

        public string GetValor_C(string VarName) 
        {
            using (var context = new dbLuxorEntities())
            {
                DataRow[] DataFilter = Data.Select(string.Format("Variable = '{0}'", VarName));

                if (DataFilter.Length == 0)
                {
                    Configuracion Config = new Configuracion();
                    Config.Variable = VarName;
                    Config.Valor_C = string.Empty;
                    context.Configuracion.Add(Config);
                    context.SaveChanges();

                    return Config.Valor_C;
                }
                else
                    return DataFilter[0]["Valor_C"].ToString();
            }
        }

        public void SetValor_C(string VarName, string VarValue)
        {
            using (var context = new dbLuxorEntities())
            {
                Configuracion Config = context.Configuracion.SingleOrDefault(x => x.Variable == VarName);
                Config.Valor_C = VarValue;
                context.SaveChanges();
            }
        }

        public Int32 GetValor_N(string VarName)
        {
            using (var context = new dbLuxorEntities())
            {
                DataRow[] DataFilter = Data.Select(string.Format("Variable = '{0}'", VarName));

                if (DataFilter.Length == 0)
                {
                    Configuracion Config = new Configuracion();
                    Config.Variable = VarName;
                    Config.Valor_N = 0;
                    context.Configuracion.Add(Config);
                    context.SaveChanges();

                    return Convert.ToInt32(Config.Valor_N);
                }
                else
                    return Convert.ToInt32(DataFilter[0]["Valor_N"].ToString());
            }
        }

        public void SetValor_N(string VarName, int VarValue)
        {
            using (var context = new dbLuxorEntities())
            {
                Configuracion Config = context.Configuracion.SingleOrDefault(x => x.Variable == VarName);
                Config.Valor_N = VarValue;
                context.SaveChanges();
            }
        }

        public decimal GetValor_D(string VarName)
        {
            using (var context = new dbLuxorEntities())
            {
                DataRow[] DataFilter = Data.Select(string.Format("Variable = '{0}'", VarName));

                if (DataFilter.Length == 0)
                {
                    Configuracion Config = new Configuracion();
                    Config.Variable = VarName;
                    Config.Valor_D = 0;
                    context.Configuracion.Add(Config);
                    context.SaveChanges();

                    return Convert.ToDecimal(Config.Valor_D);
                }
                else
                    return Convert.ToDecimal(DataFilter[0]["Valor_D"].ToString());
            }
        }

        public void SetValor_D(string VarName, decimal VarValue)
        {
            using (var context = new dbLuxorEntities())
            {
                Configuracion Config = context.Configuracion.SingleOrDefault(x => x.Variable == VarName);
                Config.Valor_D = VarValue;
                context.SaveChanges();
            }
        }

    }
}
