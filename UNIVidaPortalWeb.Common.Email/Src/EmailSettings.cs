using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIVidaPortalWeb.Common.Email.Src
{
    public class EmailSettings
    {
        public string Endpoint { get; set; }
        public string SmtpCliente { get; set; }
        public int Puerto { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
