using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlBanner
    {
        private String banrot_campanha;
        private String banrot_img;
        private String banrot_validade;

        public String Banrot_img
        {
            get { return banrot_img; }
            set { banrot_img = value; }
        }
        public String Banrot_campanha
        {
            get { return banrot_campanha; }
            set { banrot_campanha = value; }
        }
        public String Banrot_validade
        {
            get { return banrot_validade; }
            set { banrot_validade = value; }
        }
    }
}
