using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlGruposEmail
    {
        private string grpe_dono;
        private string grpe_grupo;
        private string grpe_email;

        public String Grpe_dono
        {
            get { return grpe_dono; }
            set { grpe_dono = value; }
        }
        public String Grpe_grupo
        {
            get { return grpe_grupo; }
            set { grpe_grupo = value; }
        }
        public String Grpe_email
        {
            get { return grpe_email; }
            set { grpe_email = value; }
        }
    }
}
