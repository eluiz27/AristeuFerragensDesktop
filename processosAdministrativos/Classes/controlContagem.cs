using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlContagem
    {
        private string cont_produto;
        private string cont_data;

        public string Cont_produto
        {
            get { return cont_produto; }
            set { cont_produto = value; }
        }
        public string Cont_data
        {
            get { return cont_data; }
            set { cont_data = value; }
        }
    }
}
