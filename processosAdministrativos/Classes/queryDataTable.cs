using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace processosAdministrativos.Classes
{
    class queryDataTable
    {
        public BindingSource procura(string sql)
        {
            DAO dao = new DAO();
            DataTable table = new DataTable();
            MySqlDataAdapter da;
            BindingSource bs = new BindingSource();

            da = new MySqlDataAdapter(sql, dao.Conexao);
            da.Fill(table);

            bs.DataSource = table;
            return bs;
        }
    }
}
