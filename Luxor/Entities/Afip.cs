using FE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxor.Entities
{
    class Afip
    {
        private string DEFAULT_URLWSAAWSDL = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?WSDL";
        private string DEFAULT_URLWFEWSDL = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx";
        private string DEFAULT_URLWCIWSDL = "https://awshomo.afip.gov.ar/sr-padron/webservices/personaServiceA5?WSDL";
        private string DEFAULT_SERVICIO = "wsfe";
        private string DEFAULT_CERTSIGNER = String.Format("{0}\\{1}", Application.StartupPath, "certificadoAFIP.pfx");
        private string DEFAULT_PROXY = null;
        private string DEFAULT_PROXY_USER = null;
        private string DEFAULT_PROXY_PASSWORD = null;
        private bool DEFAULT_VERBOSE = true;
        public Persona Persona = new Persona();

        public Boolean GetDatos(long NroCuit)
        {
            Boolean BReturn = false;

            try
            {
                LoginTicket objTicketRespuesta = new LoginTicket();

                SecureString strPasswordSecureString = new SecureString();
                strPasswordSecureString.MakeReadOnly();

                DEFAULT_SERVICIO = "ws_sr_constancia_inscripcion";

                string strTicketRespuesta = objTicketRespuesta.ObtenerLoginTicketResponse(DEFAULT_SERVICIO, DEFAULT_URLWSAAWSDL, DEFAULT_CERTSIGNER, strPasswordSecureString, DEFAULT_PROXY, DEFAULT_PROXY_USER, DEFAULT_PROXY_PASSWORD, DEFAULT_VERBOSE);

                WebServices_AFIP webServices_AFIP = new FE.WebServices_AFIP();

                objTicketRespuesta.Cuit = 20305764044;

                if (webServices_AFIP.GetPersona(DEFAULT_URLWCIWSDL, objTicketRespuesta, NroCuit))
                {
                    this.Persona.datosGenerales = WebServices_AFIP.Persona.datosGenerales;
                    this.Persona.datosMonotributo = WebServices_AFIP.Persona.datosMonotributo;
                    this.Persona.datosRegimenGeneral = WebServices_AFIP.Persona.datosRegimenGeneral;

                    return true;
                }
                else
                    return BReturn;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
