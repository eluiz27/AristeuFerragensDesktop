using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Models
{
    public class RestricaoModel
    {
        public int Codigo { get; set; }
        public string Cargo { get; set; }
        public string Computador { get; set; }
        public string Usuario { get; set; }
        public int Dashboard { get; set; }
        public int Pesquisa { get; set; }


    }
}
