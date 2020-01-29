using MySql.Data.MySqlClient;
using processosAdministrativos.Config;
using processosAdministrativos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace processosAdministrativos.Dao
{
    public class RestricaoDao : Conexao
    {
        private MySqlCommand Query { get; set; }

        public BindingSource SelectTable()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter da;
            BindingSource bs = new BindingSource();

            da = new MySqlDataAdapter("SELECT * FROM restrict_cargo", Conec);
            da.Fill(table);

            bs.DataSource = table;
            return bs;
        }
        public List<string> SelectCargo()
        {
            string user = Environment.UserName.ToLower();
            string computer = Environment.MachineName.ToLower();
            List<string> carg = new List<string>();

            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.CommandText = "SELECT * FROM restrict_cargo";

            List<string> cargo = new List<string>();
            List<string> computador = new List<string>();
            List<string> usuario = new List<string>();
            List<string> dashboard = new List<string>();

            conecta();
            MySqlDataReader lista = Query.ExecuteReader();
            while (lista.Read())
            {
                cargo.Add(lista["restC_cargo"].ToString());
                computador.Add(lista["restC_computador"].ToString());
                usuario.Add(lista["restC_usuario"].ToString());
                dashboard.Add(lista["restC_dash"].ToString());
            }
            lista.Close();
            desconecta();

            for (int i = 0; i < usuario.Count; i++)
            {
                if (computer == computador[i] && user.Contains(usuario[i]))
                {
                    carg.Clear();
                    carg.Add(cargo[i]);
                    carg.Add(dashboard[i]);
                    break;
                }
                else
                {
                    carg.Clear();
                    carg.Add("Adm_system");
                    carg.Add("1");
                }
            }

            return carg;

        }
        public int SelectVendedor(RestricaoModel rm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.Parameters.AddWithValue("@computador", rm.Computador);
            Query.Parameters.AddWithValue("@usuario", rm.Usuario);

            Query.CommandText = "SELECT restC_pesquisa FROM restrict_cargo WHERE restC_computador = @computador AND restC_usuario = @usuario";

            conecta();
            object vendedor = Query.ExecuteScalar();
            desconecta();
            if (vendedor != null && vendedor.ToString() != "")
                return Convert.ToInt32(vendedor);
            else
                return 0;
        }
        public void Insert(RestricaoModel rm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.Parameters.AddWithValue("@cargo", rm.Cargo);
            Query.Parameters.AddWithValue("@computador", rm.Computador);
            Query.Parameters.AddWithValue("@usuario", rm.Usuario);
            Query.Parameters.AddWithValue("@dashboard", rm.Dashboard);

            Query.CommandText = "INSERT INTO restrict_cargo (restC_cargo, restC_computador, restC_usuario, restC_dash) VALUES (@cargo, @computador, @usuario, @dashboard)";

            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        
        public void Update(RestricaoModel rm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.Parameters.AddWithValue("@codigo", rm.Codigo);
            Query.Parameters.AddWithValue("@cargo", rm.Cargo);
            Query.Parameters.AddWithValue("@computador", rm.Computador);
            Query.Parameters.AddWithValue("@usuario", rm.Usuario);
            Query.Parameters.AddWithValue("@dashboard", rm.Dashboard);

            Query.CommandText = "UPDATE restrict_cargo SET restC_cargo = @cargo, restC_computador = @computador, restC_usuario = @usuario, restC_dash = @dashboard WHERE restC_codigo = @codigo";

            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
        public void UpdateVendedor(RestricaoModel rm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.Parameters.AddWithValue("@computador", rm.Computador);
            Query.Parameters.AddWithValue("@usuario", rm.Usuario);
            Query.Parameters.AddWithValue("@pesquisa", rm.Pesquisa);

            Query.CommandText = "UPDATE restrict_cargo SET restC_pesquisa = @pesquisa WHERE restC_computador = @computador and restC_usuario = @usuario";

            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }

        public void Delete(RestricaoModel rm)
        {
            Query = new MySqlCommand();
            Query.Connection = Conec;
            Query.Parameters.AddWithValue("@codigo", rm.Codigo);

            Query.CommandText = "DELETE FROM restrict_cargo WHERE restC_codigo = @codigo";

            conecta();
            Query.ExecuteNonQuery();
            desconecta();
        }
    }
}
