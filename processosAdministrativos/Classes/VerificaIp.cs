using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class VerificaIp
    {
        public static bool ip()
        {
            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);

            if (ip[1].ToString().Substring(0, 6) == "10.0.0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
