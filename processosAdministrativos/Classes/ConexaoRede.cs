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
        public static string userSenha = Path.GetFullPath("Conexão\\UserSenha.txt");
        public static string[] linhas = new string[3];
        public static string[] linhas2 = new string[2];
        public static string[] linhas3 = new string[5];

        public static string[] RecuperaConexao()
        {
            linhas = File.ReadAllLines(caminhosRede);
            linhas2 = File.ReadAllLines(userSenha);

            for(int i = 0; i < linhas.Length; i++)
            {
                linhas3[i] = linhas[i];
            }

            for (int i = 0; i < linhas2.Length; i++)
            {
                linhas3[i+3] = linhas2[i];
            }

            return linhas3;
        }
    }
}
