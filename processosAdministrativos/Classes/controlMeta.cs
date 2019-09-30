using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlMeta
    {
        private string vmet_vendedor;
        private string vmet_meta;
        private string vmet_periodo;
        private string vmet_situacao;
        private string vmet_tipo;


        public string Vmet_vendedor { get => vmet_vendedor; set => vmet_vendedor = value; }
        public string Vmet_meta { get => vmet_meta; set => vmet_meta = value; }
        public string Vmet_periodo { get => vmet_periodo; set => vmet_periodo = value; }
        public string Vmet_situacao { get => vmet_situacao; set => vmet_situacao = value; }
        public string Vmet_tipo { get => vmet_tipo; set => vmet_tipo = value; }

    }
}
