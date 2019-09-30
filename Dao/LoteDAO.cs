using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using processosAdministrativos.Model;

namespace processosAdministrativos.Dao
{
    public class LoteDAO : Conexao
    {
        MySqlCommand cmd = null;

        public void Salvar(LoteM lote)
        {
            try
            {
                AbrirConexao();

                cmd = new MySqlCommand("INSERT INTO lote_validade(ltv_numLote, ltv_codBarras, ltv_produto, ltv_qtde, ltv_validade, ltv_dataCriacao, ltv_dataAlteracao) VALUES(@ltv_numLote, @ltv_codBarras, @ltv_produto, @ltv_qtde, @ltv_validade, @ltv_dataCriacao, @ltv_dataAlteracao)", conexao);

                cmd.Parameters.AddWithValue("@ltv_numLote", lote.Ltv_numLote);
                cmd.Parameters.AddWithValue("@ltv_codBarras", lote.Ltv_codBarras);
                cmd.Parameters.AddWithValue("@ltv_produto", lote.Ltv_produto);
                cmd.Parameters.AddWithValue("@ltv_qtde", lote.Ltv_qtde);
                cmd.Parameters.AddWithValue("@ltv_validade", lote.Ltv_validade);
                cmd.Parameters.AddWithValue("@ltv_dataCriacao", lote.Ltv_dataCriacao);
                cmd.Parameters.AddWithValue("@ltv_dataAlteracao", lote.Ltv_dataAlteracao);

                cmd.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Alterar(LoteM lote)
        {
            try
            {
                AbrirConexao();

                cmd = new MySqlCommand("UPDATE lote_validade SET ltv_numLote = @ltv_numLote, ltv_codBarras = @ltv_codBarras, ltv_produto = @ltv_produto, ltv_qtde = @ltv_qtde, ltv_validade = @ltv_validade, ltv_dataAlteracao = @ltv_dataAlteracao WHERE ltv_codigo = @ltv_codigo", conexao);

                cmd.Parameters.AddWithValue("@ltv_codigo", lote.Ltv_codigo);
                cmd.Parameters.AddWithValue("@ltv_numLote", lote.Ltv_numLote);
                cmd.Parameters.AddWithValue("@ltv_codBarras", lote.Ltv_codBarras);
                cmd.Parameters.AddWithValue("@ltv_produto", lote.Ltv_produto);
                cmd.Parameters.AddWithValue("@ltv_qtde", lote.Ltv_qtde);
                cmd.Parameters.AddWithValue("@ltv_validade", lote.Ltv_validade);
                cmd.Parameters.AddWithValue("@ltv_dataAlteracao", lote.Ltv_dataAlteracao);

                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public object SelecionarUm(string query)
        {
            try
            {
                AbrirConexao();

                cmd = new MySqlCommand(query, conexao);
                object objeto = cmd.ExecuteScalar();

                if(objeto is null)
                {
                    objeto = 0;
                }
                return objeto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public MySqlDataReader SelecionarVarios(string query)
        {
            try
            {
                AbrirConexao();

                cmd = new MySqlCommand(query, conexao);
                MySqlDataReader vetor = cmd.ExecuteReader();

                return vetor;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
