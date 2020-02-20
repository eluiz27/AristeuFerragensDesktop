using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Config
{
    public class Cargo
    {
        public string NomeCargo(string computador, string usuario)
        {
            string cargo = "";
            switch (computador)
            {
                case "hirieu":
                    if (usuario.Contains("usuario") == true)
                        cargo = "vendas";
                    else if (usuario == "elaine" || usuario == "thalita" || usuario == "luana")
                        cargo = "televendas";
                    else if (usuario == "tamiris" || usuario == "walkiria")
                        cargo = "financeiro";
                    break;
                case "heleno":
                    if (usuario.Contains("usuario") == true)
                        cargo = "vendas";
                    else if (usuario == "elaine" || usuario == "thalita" || usuario == "luana")
                        cargo = "televendas";
                    else if (usuario == "willians" || usuario == "alzira")
                        cargo = "compras";
                    break;
                default:
                    cargo = "adm_system";
                    break;
            }

            return cargo;
        }
    }
}
