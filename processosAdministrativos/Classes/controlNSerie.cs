using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlNSerie
    {
        private string ns_nSerie;
        private string ns_pedido;
        private string ns_produto;
        private string ns_data;

        public string Ns_nSerie
        {
            get { return ns_nSerie; }
            set { ns_nSerie = value; }
        }
        public string Ns_pedido
        {
            get { return ns_pedido; }
            set { ns_pedido = value; }
        }
        public string Ns_produto
        {
            get { return ns_produto; }
            set { ns_produto = value; }
        }
        public string Ns_data
        {
            get { return ns_data; }
            set { ns_data = value; }
        }
    }
}
