using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlCompNComp
    {
        private string cnc_item;
        private int cnc_comprar;
        private string cnc_qtde;
        private string cnc_grupo;
        private string cnc_fornecedor;

        public string Cnc_fornecedor
        {
            get { return cnc_fornecedor; }
            set { cnc_fornecedor = value; }
        }

        public string Cnc_grupo
        {
            get { return cnc_grupo; }
            set { cnc_grupo = value; }
        }

        public string Cnc_qtde
        {
            get { return cnc_qtde; }
            set { cnc_qtde = value; }
        }

        public int Cnc_comprar
        {
            get { return cnc_comprar; }
            set { cnc_comprar = value; }
        }

        public string Cnc_item
        {
            get { return cnc_item; }
            set { cnc_item = value; }
        }
    }
}
