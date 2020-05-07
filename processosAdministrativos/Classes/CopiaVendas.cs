using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class CopiaVendas
    {
        DAO dao = new DAO();
        public void Copia()
        {
            dao.Query.Connection = dao.Conexao;
            dao.Query.CommandText = "Call sp_getNotas";
            dao.Conecta();
            dao.Query.ExecuteNonQuery();
            dao.Desconecta();
        }
    }
}
