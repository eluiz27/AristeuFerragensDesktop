using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlCodifica
    {
        private string codf_nota;
        private string codf_codForn;
        private string codf_codEstoquista1;
        private string codf_codEstoquista2;
        private string codf_situacao;
        private string codf_data;

        public string Codf_nota
        {
            get { return codf_nota; }
            set { codf_nota = value; }
        }
        public string Codf_codForn
        {
            get { return codf_codForn; }
            set { codf_codForn = value; }
        }
        public string Codf_codEstoquista1
        {
            get { return codf_codEstoquista1; }
            set { codf_codEstoquista1 = value; }
        }
        public string Codf_codEstoquista2
        {
            get { return codf_codEstoquista2; }
            set { codf_codEstoquista2 = value; }
        }
        public string Codf_situacao
        {
            get { return codf_situacao; }
            set { codf_situacao = value; }
        }
        public string Codf_data
        {
            get { return codf_data; }
            set { codf_data = value; }
        }
    }
}
