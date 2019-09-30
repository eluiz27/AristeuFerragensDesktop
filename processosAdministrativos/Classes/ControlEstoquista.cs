using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using processosAdministrativos.Telas;

namespace processosAdministrativos.Classes
{
    class ControlEstoquista
    {
        private String estoqusita;
        private DateTime data;
        private int codEstoquista;
        List<int> codClasse = new List<int>();

        public String Estoquista
        {
            get { return estoqusita; }
            set { estoqusita = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public int CodEstoquista
        {
            get { return codEstoquista; }
            set { codEstoquista = value; }
        }
        public List<int> CodClasse
        {
            get { return codClasse; }
            set { codClasse = value; }
        }
    }
}
