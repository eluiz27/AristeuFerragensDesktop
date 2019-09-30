using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos
{
    class controlEntreg
    {
        private int pedido_contEntre;
        private String cliente_contEntre;
        private int vendedor_contEntre;
        private String situacao_contEntre;
        private int motoboy_contEntre;
        private String dt_aCaminho;
        private String dt_entregue;
        private String obs_contEntre;
       
        public int Pedido_contEntre
        {
            get { return pedido_contEntre; }
            set { pedido_contEntre = value; }
        }

        public String Cliente_contEntre
        {
            get { return cliente_contEntre; }
            set { cliente_contEntre = value; }
        }

        public int Vendedor_contEntre
        {
            get { return vendedor_contEntre; }
            set { vendedor_contEntre = value; }
        }

        public String Situacao_contEntre
        {
            get { return situacao_contEntre; }
            set { situacao_contEntre = value; }
        }
        public int Motoboy_contEntre
        {
            get { return motoboy_contEntre; }
            set { motoboy_contEntre = value; }
        }

        public String Dt_aCaminho
        {
            get { return dt_aCaminho; }
            set { dt_aCaminho = value; }
        }

        public String Dt_entregue
        {
            get { return dt_entregue; }
            set { dt_entregue = value; }
        }
        public String Obs_contEntre
        {
            get { return obs_contEntre; }
            set { obs_contEntre = value; }
        }
    }
}
