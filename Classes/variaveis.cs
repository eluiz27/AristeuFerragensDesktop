using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class variaveis
    {
        private static int codProdAssistTec = 0;
        private static int aux1AssistTec = 0;
        private static int aux2AssistTec = 0;
        private static int aux3AssistTec = 0;
        private static String codEstoquista = string.Empty;
        private static int codFornAssistTec = 0;
        private static int codAssistTec = 0;
        private static String nomeFornAssistTec = string.Empty;
        private static int codBanner = 0;
        private static String codProdLote = string.Empty;
        private static String nomeProdLote = string.Empty;
        private static int auxLote;
        private static int auxLote2;
        private static String codLote = string.Empty;
        private static String nomeProdArmaze = string.Empty;
        private static int auxArmaze = 0;
        private static int codProdArmaze = 0;
        private static int auxLOE1 = 0;
        private static int auxLOE2 = 0;
        private static int auxLOE3 = 0;
        private static int auxLOE4 = 0;
        private static String nomeProdLOE = string.Empty;
        private static String codProdLOE = string.Empty;
        private static String codOrdemComp = string.Empty;
        private static int codFalowUp = 0;
        private static int auxFallowUp = 0;
        private static string numNota = string.Empty;
        private static int auxCodifica = 0;
        private static int auxCompFunc = 0;
        private static int qtdeCompFunc = 0;
        private static int auxAssistTex = 0;
        private static string codForn = string.Empty;
        private static string codGrupo = string.Empty;
        private static string codCampanha = string.Empty;
        private static string prodCampanha = string.Empty;
        private static int auxCampanha = 0;
        private static int codCamp = 0;
        private static int auxCampanhas = 0;
        private static string codUsuario = string.Empty;
        private static int auxUsuario = 0;
        private static int auxMapaVendas = 0;
        private static string auxSenha = string.Empty;
        private static string docCodific = string.Empty;
        private static string codFornCodific = string.Empty;

        public string CodFornCodific { get => codFornCodific; set => codFornCodific = value; }
        public string DocCodific { get => docCodific; set => docCodific = value; }
        public string AuxSenha { get => auxSenha; set => auxSenha = value; }
        public int AuxMapaVendas { get => auxMapaVendas; set => auxMapaVendas = value; }
        public int AuxUsuario { get => auxUsuario; set => auxUsuario = value; }
        public string CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int AuxCampanhas { get => auxCampanhas; set => auxCampanhas = value; }
        public int CodCamp { get => codCamp; set => codCamp = value; }
        public int AuxCampanha { get => auxCampanha; set => auxCampanha = value; }
        public string CodCampanha { get => codCampanha; set => codCampanha = value; }
        public string ProdCampanha { get => prodCampanha; set => prodCampanha = value; }

        public string CodGrupo
        {
            get { return codGrupo; }
            set { codGrupo = value; }
        }
       

        public string CodForn
        {
          get { return codForn; }
          set { codForn = value; }
        }
        public int AuxAssistTex
        {
            get { return auxAssistTex; }
            set { auxAssistTex = value; }
        }

        public int QtdeCompFunc
        {
            get { return qtdeCompFunc; }
            set { qtdeCompFunc = value; }
        }


        public int AuxCompFunc
        {
            get { return auxCompFunc; }
            set { auxCompFunc = value; }
        }

        public int AuxCodifica
        {
            get { return auxCodifica; }
            set { auxCodifica = value; }
        }

        public string NumNota
        {
            get { return numNota; }
            set { numNota = value; }
        }

        public int CodProdAssistTec
        {
            get { return codProdAssistTec; }
            set { codProdAssistTec = value; }
        }
        public int Aux1AssistTec
        {
            get { return aux1AssistTec; }
            set { aux1AssistTec = value; }
        }
        public int Aux2AssistTec
        {
            get { return aux2AssistTec; }
            set { aux2AssistTec = value; }
        }
        public int Aux3AssistTec
        {
            get { return aux3AssistTec; }
            set { aux3AssistTec = value; }
        }
        public String CodEstoquista
        {
            get { return codEstoquista; }
            set { codEstoquista = value; }
        }
        public int CodFornAssistTec
        {
            get { return codFornAssistTec; }
            set { codFornAssistTec = value; }
        }
        public int CodAssistTec
        {
            get { return codAssistTec; }
            set { codAssistTec = value; }
        }
        public String NomeFornAssistTec
        {
            get { return nomeFornAssistTec; }
            set { nomeFornAssistTec = value; }
        }
        public int CodBanner
        {
            get { return codBanner; }
            set { codBanner = value; }
        }
        public String CodProdLote
        {
            get { return codProdLote; }
            set { codProdLote = value; }
        }
        public String NomeProdLote
        {
            get { return nomeProdLote; }
            set { nomeProdLote = value; }
        }
        public int AuxLote
        {
            get { return auxLote; }
            set { auxLote = value; }
        }
        public int AuxLote2
        {
            get { return auxLote2; }
            set { auxLote2 = value; }
        }
        public String CodLote
        {
            get { return codLote; }
            set { codLote = value; }
        }
        public String NomeProdArmaze
        {
            get { return nomeProdArmaze; }
            set { nomeProdArmaze = value; }
        }
        public int AuxArmaze
        {
            get { return auxArmaze; }
            set { auxArmaze = value; }
        }
        public int CodProdArmaze
        {
            get { return codProdArmaze; }
            set { codProdArmaze = value; }
        }
        public int AuxLOE1
        {
            get { return auxLOE1; }
            set { auxLOE1 = value; }
        }
        public int AuxLOE2
        {
            get { return auxLOE2; }
            set { auxLOE2 = value; }
        }
        public int AuxLOE3
        {
            get { return auxLOE3; }
            set { auxLOE3 = value; }
        }
        public int AuxLOE4
        {
            get { return auxLOE4; }
            set { auxLOE4 = value; }
        }
        public String NomeProdLOE
        {
            get { return nomeProdLOE; }
            set { nomeProdLOE = value; }
        }
        public string CodProdLOE
        {
            get { return codProdLOE; }
            set { codProdLOE = value; }
        }
        public String CodOrdemComp
        {
            get { return codOrdemComp; }
            set { codOrdemComp = value; }
        }
        public int CodFalowUp
        {
            get { return codFalowUp; }
            set { codFalowUp = value; }
        }
        public int AuxFallowUp
        {
            get { return auxFallowUp; }
            set { auxFallowUp = value; }
        }
    }
}
