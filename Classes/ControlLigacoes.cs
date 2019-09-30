using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlLigacoes
    {
        private string liga_data;
        private string liga_hora;
        private string liga_cliente;
        private string liga_para;
        private string liga_situacao;
        private string liga_obs;

        public string Liga_data { get => liga_data; set => liga_data = value; }
        public string Liga_hora { get => liga_hora; set => liga_hora = value; }
        public string Liga_cliente { get => liga_cliente; set => liga_cliente = value; }
        public string Liga_para { get => liga_para; set => liga_para = value; }
        public string Liga_situacao { get => liga_situacao; set => liga_situacao = value; }
        public string Liga_obs { get => liga_obs; set => liga_obs = value; }

    }
}
