using MySql.Data.MySqlClient;
using processosAdministrativos.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Dao
{
    public class Conexao
    {
        private static MySqlConnection conexaoInterna = new MySqlConnection("server=" + ConexaoRede.RecuperaConexao()[0] + ";port=" + ConexaoRede.RecuperaConexao()[1] + ";database=" + ConexaoRede.RecuperaConexao()[2] + ";userid=" + ConexaoRede.RecuperaConexao()[3] + ";password=" + ConexaoRede.RecuperaConexao()[4] + ";");

        public MySqlConnection Conec { get => conexaoInterna; set => conexaoInterna = value; }

        public void conecta()
        {
            try
            {
                if (Conec.State == System.Data.ConnectionState.Closed)
                    Conec.Open();
            }
            catch (Exception error)
            {
                
            }
        }

        public void desconecta()
        {
            if (Conec.State == System.Data.ConnectionState.Open)
                Conec.Close();
        }

        public int TesteConexao(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            MySqlConnection teste = new MySqlConnection("server=" + servidor + ";port=" + porta + ";database=" + baseDados + ";userid=" + usuario + ";password=" + senha + ";");
            try
            {
                teste.Open();
                teste.Close();
                return 1;
            }
            catch (Exception error)
            {
                return 0;
            }
        }
    }
}
