using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ControlTelaAberta
    {
        private static int telaAssistTec = 0;
        private static int telaCadAssistTec = 0;
        private static int telaContEntre = 0;
        private static int telaCadEstoquista = 0;
        private static int telaCadLote = 0;
        private static int telaContEstoq = 0;
        private static int telaMapaVendas = 0;
        private static int telaProcAssistTec = 0;
        private static int telaProcEntre = 0;
        private static int telaProcForn = 0;
        private static int telaProcProd = 0;
        private static int telaProcEstoquista = 0;
        private static int telaCadBanner = 0;
        private static int telaArmazanagem = 0;
        private static int telaConsultaLote = 0;
        private static int telaLOE = 0;
        private static int telaConsultaLOE = 0;
        private static int telaCadastroFallowUp = 0;
        private static int telaCadastroSituacao = 0;
        private static int telaConsultaFallowUp = 0;
        private static int telaCodificacao = 0;
        private static int telaNSerie = 0;
        private static int telaConsultaNSerie = 0;
        private static int telaConsultLOEComple = 0;
        private static int telaCadastraLoe = 0;
        private static int telaEtiquetaPreco = 0;
        private static int telaContagem = 0;
        private static int telaComprasFunc = 0;
        private static int telaConsCodif = 0;
        private static int telaIndicVendas = 0;
        private static int telaOdemCompra = 0;
        private static int telaMediaVenda = 0;
        private static int telaCompra = 0;
        private static int telaCompraProd = 0;
        private static int telaControladoria = 0;
        private static int telaRestricoes = 0;
        private static int telaMeta = 0;
        private static int telaEntrega = 0;
        private static int telaChamadas = 0;
        private static int telaConfRede = 0;
        private static int telaCliForaEstado = 0;

        public int TelaCliForaEstado { get => telaCliForaEstado; set => telaCliForaEstado = value; }
        public int TelaConfRede { get => telaConfRede; set => telaConfRede = value; }

        public int TelaChamadas { get => telaChamadas; set => telaChamadas = value; }

        public int TelaEntrega { get => telaEntrega; set => telaEntrega = value; }

        public int TelaRestricoes { get => telaRestricoes; set => telaRestricoes = value; }
        public int TelaControladoria { get => telaControladoria; set => telaControladoria = value; }

        public int TelaCompraProd
        {
            get { return telaCompraProd; }
            set { telaCompraProd = value; }
        }

        public int TelaMeta
        {
            get { return telaMeta; }
            set { telaMeta = value; }
        }

        public int TelaCompra
        {
            get { return telaCompra; }
            set { telaCompra = value; }
        }

        public int TelaMediaVenda
        {
            get { return telaMediaVenda; }
            set { telaMediaVenda = value; }
        }

        public int TelaOdemCompra
        {
            get { return telaOdemCompra; }
            set { telaOdemCompra = value; }
        }

        public int TelaIndicVendas
        {
            get { return telaIndicVendas; }
            set { telaIndicVendas = value; }
        }

        public int TelaConsCodif
        {
            get { return telaConsCodif; }
            set { telaConsCodif = value; }
        }

        public int TelaComprasFunc
        {
            get { return telaComprasFunc; }
            set { telaComprasFunc = value; }
        }

        public int TelaContagem
        {
            get { return telaContagem; }
            set { telaContagem = value; }
        }

        public int TelaEtiquetaPreco
        {
            get { return telaEtiquetaPreco; }
            set { telaEtiquetaPreco = value; }
        }

        public int TelaCadastraLoe
        {
            get { return telaCadastraLoe; }
            set { telaCadastraLoe = value; }
        }

        public int TelaConsultLOEComple
        {
            get { return telaConsultLOEComple; }
            set { telaConsultLOEComple = value; }
        }

        public int TelaConsultaNSerie
        {
            get { return telaConsultaNSerie; }
            set { telaConsultaNSerie = value; }
        }

        public int TelaNSerie
        {
            get { return telaNSerie; }
            set { telaNSerie = value; }
        }

        public int TelaCodificacao
        {
            get { return telaCodificacao; }
            set { telaCodificacao = value; }
        }

        public int TelaAssistTec
        {
            get { return telaAssistTec; }
            set { telaAssistTec = value; }
        }
        public int TelaCadAssistTec
        {
            get { return telaCadAssistTec; }
            set { telaCadAssistTec = value; }
        }
        public int TelaContEntre
        {
            get { return telaContEntre; }
            set { telaContEntre = value; }
        }
        public int TelaCadEstoquista
        {
            get { return telaCadEstoquista; }
            set { telaCadEstoquista = value; }
        }
            public int TelaCadLote
        {
            get { return telaCadLote; }
            set { telaCadLote = value; }
        }
        public int TelaContEstoq
        {
            get { return telaContEstoq; }
            set { telaContEstoq = value; }
        }
        public int TelaMapaVendas
        {
            get { return telaMapaVendas; }
            set { telaMapaVendas = value; }
        }
        public int TelaProcAssistTec
        {
            get { return telaProcAssistTec; }
            set { telaProcAssistTec = value; }
        }
        public int TelaProcEntre
        {
            get { return telaProcEntre; }
            set { telaProcEntre = value; }
        }
        public int TelaProcForn
        {
            get { return telaProcForn; }
            set { telaProcForn = value; }
        }
        public int TelaProcProd
        {
            get { return telaProcProd; }
            set { telaProcProd = value; }
        }

        public int TelaProcEstoquista
        {
            get { return telaProcEstoquista; }
            set { telaProcEstoquista = value; }
        }
        public int TelaCadBanner
        {
            get { return telaCadBanner; }
            set { telaCadBanner = value; }
        }
        public int TelaArmazanagem
        {
            get { return telaArmazanagem; }
            set { telaArmazanagem = value; }
        }
        public int TelaConsultaLote
        {
            get { return telaConsultaLote; }
            set { telaConsultaLote = value; }
        }
        public int TelaLOE
        {
            get { return telaLOE; }
            set { telaLOE = value; }
        }
        public int TelaConsultaLOE
        {
            get { return telaConsultaLOE; }
            set { telaConsultaLOE = value; }
        }
        public int TelaCadastroFallowUp
        {
            get { return telaCadastroFallowUp; }
            set { telaCadastroFallowUp = value; }
        }
        public int TelaCadastroSituacao
        {
            get { return telaCadastroSituacao; }
            set { telaCadastroSituacao = value; }
        }
        public int TelaConsultaFallowUp
        {
            get { return telaConsultaFallowUp; }
            set { telaConsultaFallowUp = value; }
        }
    }
}
