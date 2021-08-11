using Luxor.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxor
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfiguracionNegocios ConfigNegocios = new ConfiguracionNegocios();

            if(ConfigNegocios.GetConfiguracion())
            {
                FrmLogin FrmAcceso = new FrmLogin();

                if (FrmAcceso.ShowDialog() == DialogResult.OK)
                    Application.Run(FrmMain.Instance());
                else
                    Application.Exit();
            }
            else
                Application.Exit();
        }
    }
}
