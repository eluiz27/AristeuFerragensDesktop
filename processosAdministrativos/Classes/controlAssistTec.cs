using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlAssistTec
    {
        private String nome_assistTec;
        private String telefone_assistTec;
        private String endereco_assistTec;
        private String lat_assistTec;
        private String long_assistTec;
        private int fornecedor_assistTec;
        public String Nome_assistTec
        {
            get { return nome_assistTec; }
            set { nome_assistTec = value; }
        }
        public String Telefone_assistTec
        {
            get { return telefone_assistTec; }
            set { telefone_assistTec = value; }
        }
        public String Endereco_assistTec
        {
            get { return endereco_assistTec; }
            set { endereco_assistTec = value; }
        }
        public String Lat_assistTec
        {
            get { return lat_assistTec; }
            set { lat_assistTec = value; }
        }
        public String Long_assistTec
        {
            get { return long_assistTec; }
            set { long_assistTec = value; }
        }
        public int Fornecedor_assistTec
        {
            get { return fornecedor_assistTec; }
            set { fornecedor_assistTec = value; }
        }

    }
}
