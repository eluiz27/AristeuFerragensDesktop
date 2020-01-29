using System;
using System.Windows.Forms;
using processosAdministrativos.Dao;
using processosAdministrativos.Models;

namespace processosAdministrativos.Controllers
{
    public class RestricaoController : RestricaoDao
    {
        RestricaoModel rm = new RestricaoModel();


        public BindingSource SelectRestricao()
        {
            return SelectTable();
        }
        public int selectPesquisaDash()
        {
            rm.Computador = Environment.MachineName.ToLower();
            rm.Usuario = Environment.UserName.ToLower();

            return SelectVendedor(rm);
        }

        public void InsertRestricao(string cargo, string computador, string usuario, int dashboard)
        {
            rm.Cargo = cargo;
            rm.Computador = computador;
            rm.Usuario = usuario;
            rm.Dashboard = dashboard;

            Insert(rm);
        }
        public void UpdateRestricao(int cod, string cargo, string computador, string usuario, int dashboard)
        {
            rm.Codigo = cod;
            rm.Cargo = cargo;
            rm.Computador = computador;
            rm.Usuario = usuario;
            rm.Dashboard = dashboard;

            Update(rm);
        }
        public void UpdateRestricaoVendedor(string computador, string usuario, int vendedor)
        {
            rm.Computador = computador;
            rm.Usuario = usuario;
            rm.Pesquisa = vendedor;

            UpdateVendedor(rm);
        }
        public void DeleteRestricao(int cod)
        {
            rm.Codigo = cod;

            Delete(rm);
        }
    }
}
