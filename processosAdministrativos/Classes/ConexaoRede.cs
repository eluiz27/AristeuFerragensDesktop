using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class ConexaoRede
    {
        public static string caminhosRede = Path.GetFullPath("Conexão\\ConexaoRede.txt");
        public static string[] linhas;

        public static string[] RecuperaConexao()
        {
            linhas = File.ReadAllLines(caminhosRede);
            return linhas;
        }
    }
}
