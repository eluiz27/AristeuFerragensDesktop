using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Dao
{
    public class VendedorDao : Conexao
    {
        private MySqlCommand Query { get; set; }

        public List<string> SelectVendedor()
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.CommandText = "select vdd_nome from vendedores where vdd_cttfuncao like 'vendedor%' and vdd_situacao = 'A';";

            List<string> nome = new List<string>();

            Conecta();
            MySqlDataReader lista = Query.ExecuteReader();
            while (lista.Read())
            {
                nome.Add(lista["vdd_nome"].ToString());
            }
            lista.Close();
            Desconecta();

            return nome;
        }

        public List<int> SelectVendedorCod()
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.CommandText = "select vdd_codigo from vendedores where vdd_cttfuncao like 'vendedor%' and vdd_situacao = 'A';";

            List<int> codigo = new List<int>();
            Conecta();
            MySqlDataReader lista = Query.ExecuteReader();
            while (lista.Read())
            {
                codigo.Add(Convert.ToInt32(lista["vdd_codigo"]));
            }
            lista.Close();
            Desconecta();

            return codigo;
        }
    }
}
