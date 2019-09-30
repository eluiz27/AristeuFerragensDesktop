using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos
{
    class controlEntreg
    {
        private int cod_contEntre;
        private int pedido_contEntre;
        private String vendedor_contEntre;
        private String cliente_contEntre;
        private String situacao_contEntre;
        private int motoboy_contEntre;
        private DateTime dt_expedicao;
        private DateTime dt_aCaminho;
        private DateTime dt_entregue;
        private int alterar;

        public int Alterar
        {
            get { return alterar; }
            set { alterar = value; }
        }
        
        public int Cod_contEntrega
        {
            get { return cod_contEntre; }
            set { cod_contEntre = value; }
        }

        public int Pedido_contEntre
        {
            get { return pedido_contEntre; }
            set { pedido_contEntre = value; }
        }

        public String Vendedor_contEntre
        {
            get { return vendedor_contEntre; }
            set { vendedor_contEntre = value; }
        }

        public String Cliente_contEntre
        {
            get { return cliente_contEntre; }
            set { cliente_contEntre = value; }
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

        public DateTime Dt_expedicao
        {
            get { return dt_expedicao; }
            set { dt_expedicao = value; }
        }

        public DateTime Dt_aCaminho
        {
            get { return dt_aCaminho; }
            set { dt_aCaminho = value; }
        }

        public DateTime Dt_entregue
        {
            get { return dt_entregue; }
            set { dt_entregue = value; }
        }
    }
}
