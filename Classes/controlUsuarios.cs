using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class controlUsuarios
    {
        private string res_usuario;
        private string res_compras;
        private string res_senha;
        private string res_expedicao;
        private string res_estoque;
        private string res_financeiro;
        private string res_vendas;
        private string res_marketing;
        private string res_utilitarios;

        public string Res_usuario { get => res_usuario; set => res_usuario = value; }
        public string Res_compras { get => res_compras; set => res_compras = value; }
        public string Res_expedicao { get => res_expedicao; set => res_expedicao = value; }
        public string Res_estoque { get => res_estoque; set => res_estoque = value; }
        public string Res_financeiro { get => res_financeiro; set => res_financeiro = value; }
        public string Res_vendas { get => res_vendas; set => res_vendas = value; }
        public string Res_marketing { get => res_marketing; set => res_marketing = value; }
        public string Res_utilitarios { get => res_utilitarios; set => res_utilitarios = value; }
        public string Res_senha { get => res_senha; set => res_senha = value; }
    }
}
