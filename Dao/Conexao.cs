using MySql.Data.MySqlClient;
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
        string conecta = "server=10.0.0.210; database=gs_aristeus; uid=Luiz; password=GEN@#0996";
        protected MySqlConnection conexao = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
