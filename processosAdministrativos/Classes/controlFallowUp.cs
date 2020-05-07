using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlFallowUp
    {
        private string fup_ordCompra;
        private DateTime fup_dataPed;
        private string fup_fornecedor;
        private string fup_comprador;
        private DateTime fup_dataEntrega;
        private string fup_situacao;
        private string fup_dataAlteracao;

        public string Fup_ordCompra
        {
            get { return fup_ordCompra; }
            set { fup_ordCompra = value; }
        }

        public DateTime Fup_dataPed
        {
            get { return fup_dataPed; }
            set { fup_dataPed = value; }
        }

        public string Fup_fornecedor
        {
            get { return fup_fornecedor; }
            set { fup_fornecedor = value; }
        }

        public string Fup_comprador
        {
            get { return fup_comprador; }
            set { fup_comprador = value; }
        }

        public DateTime Fup_dataEntrega
        {
            get { return fup_dataEntrega; }
            set { fup_dataEntrega = value; }
        }

        public string Fup_situacao
        {
            get { return fup_situacao; }
            set { fup_situacao = value; }
        }
        public string Fup_dataAlteracao
        {
            get { return fup_dataAlteracao; }
            set { fup_dataAlteracao = value; }
        }
    }
}
