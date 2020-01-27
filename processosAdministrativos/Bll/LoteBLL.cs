using System;
using processosAdministrativos.Dao;
using processosAdministrativos.Model;
using MySql.Data.MySqlClient;

namespace processosAdministrativos.Bll
{
    public class LoteBLL
    {
        LoteDao lotedao = new LoteDao();

        public void Salvar(LoteM lotem)
        {
            try
            {
                lotedao.Salvar(lotem);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Alterar(LoteM lotem)
        {
            try
            {
                lotedao.Alterar(lotem);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public object SelecionarUm(string query)
        {
            try
            {
                return lotedao.SelecionarUm(query);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public MySqlDataReader SelecionarVarios(string query)
        {
            try
            {
                return lotedao.SelecionarVarios(query);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
