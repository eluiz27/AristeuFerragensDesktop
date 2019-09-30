using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlTmpMeta
    {
        private string tmet_dia;
        private string tmet_semana;
        private string tmet_meta;
        private string tmet_feriado;

        public string Tmet_dia { get => tmet_dia; set => tmet_dia = value; }
        public string Tmet_meta { get => tmet_meta; set => tmet_meta = value; }
        public string Tmet_feriado { get => tmet_feriado; set => tmet_feriado = value; }
        public string Tmet_semana { get => tmet_semana; set => tmet_semana = value; }
    }
}
