using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlLote
    {
        private string ltv_numLote;
        private string ltv_codBarras;
        private String ltv_produto;
        private int ltv_qtde;
        private String ltv_validade;
        private String ltv_dataCriacao;
        private String ltv_dataAlteracao;

        public string Ltv_numLote
        {
            get { return ltv_numLote; }
            set { ltv_numLote = value; }
        }
        public string Ltv_codBarras
        {
            get { return ltv_codBarras; }
            set { ltv_codBarras = value; }
        }
        public String Ltv_produto
        {
            get { return ltv_produto; }
            set { ltv_produto = value; }
        }
        public int Ltv_qtde
        {
            get { return ltv_qtde; }
            set { ltv_qtde = value; }
        }
        public String Ltv_validade
        {
            get { return ltv_validade; }
            set { ltv_validade = value; }
        }
        public String Ltv_dataCriacao
        {
            get { return ltv_dataCriacao; }
            set { ltv_dataCriacao = value; }
        }
        public String Ltv_dataAlteracao
        {
            get { return ltv_dataAlteracao; }
            set { ltv_dataAlteracao = value; }
        }
    }
}
