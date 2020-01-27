using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    class querys
    {
        DAO dao = new DAO();
        static MySqlCommand cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmdAux;
        static MySqlCommand cmdValor1, cmdValor2, cmdValor3, cmdMeta, cmdDev, cmdCanc;
        static string Sql1, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7, Sql8, Sql9, SqlAux = string.Empty;
        static string sqlValor1, sqlValor2, sqlValor3, sqlMeta, sqlDev, sqlCanc = string.Empty;
        
        List<double> meta = new List<double>();
        String nVendas;
        String nOrcam;
        double orcam;
        String vendas;
        String nVendasL;
        String nOrcamL;
        double orcamL;
        String vendasL;
        String nCancelado;
        String nDevolu;
        double cancelado;
        double devolu;
        double descIten;
        double descPed;
        String nAtend;
        String nAtendL;
        String itensPed;
        String itensPedL;
        String nItens;
        string nItensLoja;

        public String ItensPedL
        {
            get { return itensPedL; }
            set { itensPedL = value; }
        }
        public String ItensPed
        {
            get { return itensPed; }
            set { itensPed = value; }
        }

        public String NVendas
        {
            get { return nVendas; }
            set { nVendas = value; }
        }
        public String NAtend
        {
            get { return nAtend; }
            set { nAtend = value; }
        }
        public String NAtendL
        {
            get { return nAtendL; }
            set { nAtendL = value; }
        }
        public String NOrcam
        {
            get { return nOrcam; }
            set { nOrcam = value; }
        }
        public double Orcam
        {
            get { return orcam; }
            set { orcam = value; }
        }
        public String Vendas
        {
            get { return vendas; }
            set { vendas = value; }
        }
        public String NVendasL
        {
            get { return nVendasL; }
            set { nVendasL = value; }
        }
        public String NOrcamL
        {
            get { return nOrcamL; }
            set { nOrcamL = value; }
        }
        public double OrcamL
        {
            get { return orcamL; }
            set { orcamL = value; }
        }
        public String VendasL
        {
            get { return vendasL; }
            set { vendasL = value; }
        }
        public String NCancelado
        {
            get { return nCancelado; }
            set { nCancelado = value; }
        }
        public String NDevolu
        {
            get { return nDevolu; }
            set { nDevolu = value; }
        }
        public double Cancelado
        {
            get { return cancelado; }
            set { cancelado = value; }
        }
        public double Devolu
        {
            get { return devolu; }
            set { devolu = value; }
        }
        public double DescIten
        {
            get { return descIten; }
            set { descIten = value; }
        }
        public double DescPed
        {
            get { return descPed; }
            set { descPed = value; }
        }

        public string NItens { get => nItens; set => nItens = value; }
        public string NItensLoja { get => nItensLoja; set => nItensLoja = value; }
        public List<double> Meta { get => meta; set => meta = value; }

        public void selecao(String inferior, String superior, int vendedor)
        {
            double totalVendas;
                
            Sql1 = "SELECT COUNT(Notas.nt_numero) FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo "+
                    "WHERE notas.nt_vendedor = " + vendedor + " AND notas.nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'V' " +
                    "ORDER BY Notas.nt_vendedor ASC, Notas.nt_data ASC, Notas.nt_empresa ASC, Notas.nt_documento ASC";

            Sql2 = "SELECT COUNT(ped_numero) FROM pedidos " +
                    "where ped_data BETWEEN '" + inferior + "' AND '" + superior + "' AND " +
                    "ped_orcamento <> '' AND ped_aprovado = 1 AND ped_cancelado = 0 and ped_vendedor = " + vendedor + "";

            Sql3 = "SELECT SUM(ped_total) FROM pedidos " +
                    "where ped_data BETWEEN '" + inferior + "' AND '" + superior + "' AND " +
                    "ped_orcamento <> '' AND ped_aprovado = 1 AND ped_cancelado = 0 and ped_vendedor = " + vendedor + "";
               
            Sql4 = "SELECT SUM(Notas.nt_total) FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo " +
                    "WHERE notas.nt_vendedor = " + vendedor + " AND notas.nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'V' " +
                    "ORDER BY Notas.nt_vendedor ASC, Notas.nt_data ASC, Notas.nt_empresa ASC, Notas.nt_documento ASC";

            Sql5 = "SELECT COUNT(loe_codigo) FROM loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo WHERE loe_id_vendedor = " + vendedor + " AND loe_data BETWEEN '" + inferior + "' AND '" + superior + "' AND (vdd_cttfuncao like 'VENDEDOR%' OR vdd_cttfuncao like 'TELEVENDEDOR%');";

            Sql6 = "select count(pdi_numero) from peditem inner join pedidos on peditem.pdi_numero = pedidos.ped_numero and peditem.PDI_Cliente = pedidos.PED_Cliente and peditem.pdi_empresa = pedidos.ped_empresa " +
                    "where ped_vendedor = "+vendedor+" and ped_data = '"+inferior+"';";

            Sql9 = "select count(mv_documento) from movimentos m inner join notas n on m.mv_documento = n.nt_documento and m.mv_agente = n.nt_agente and m.mv_empresa = n.nt_empresa " +
                    "where nt_data between '" + inferior + "' AND '" + superior + "' and nt_vendedor = " + vendedor + ";";

            SqlAux = "SELECT SUM(Notas.nt_total) FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo " +
                    "WHERE notas.nt_vendedor = " + vendedor + " AND notas.nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'D' " +
                    "ORDER BY Notas.nt_vendedor ASC, Notas.nt_data ASC, Notas.nt_empresa ASC, Notas.nt_documento ASC";

            cmd1 = new MySqlCommand(Sql1, dao.Conexao);
            cmd2 = new MySqlCommand(Sql2, dao.Conexao);
            cmd3 = new MySqlCommand(Sql3, dao.Conexao);
            cmd4 = new MySqlCommand(Sql4, dao.Conexao);
            cmd5 = new MySqlCommand(Sql5, dao.Conexao);
            cmd6 = new MySqlCommand(Sql6, dao.Conexao);
            cmd9 = new MySqlCommand(Sql9, dao.Conexao);
            cmdAux = new MySqlCommand(SqlAux, dao.Conexao);
            dao.conecta();
            object aux1 = cmd1.ExecuteScalar();
            object aux2 = cmd2.ExecuteScalar();
            object aux3 = cmd3.ExecuteScalar();
            object aux4 = cmd4.ExecuteScalar();
            object aux5 = cmd5.ExecuteScalar();
            object aux6 = cmd6.ExecuteScalar();
            object aux9 = cmd9.ExecuteScalar();
            object auxVendas = cmdAux.ExecuteScalar();

            if (aux3.ToString() == "")
            {
                aux3 = 0;
            }
            if (aux4.ToString() == "")
            {
                aux4 = 0;
            }
            if (auxVendas.ToString() == "")
            {
                auxVendas = 0;
            }

            totalVendas = Convert.ToDouble(aux4) - Convert.ToDouble(auxVendas) - Convert.ToDouble(aux3);

            ItensPed = aux6.ToString();
            NAtend = aux5.ToString();
            NVendas = aux1.ToString();
            NOrcam = aux2.ToString();
            NItens = aux9.ToString();
            Orcam = Convert.ToDouble(aux3);
            Vendas = totalVendas.ToString();
            dao.desconecta();
            
        }

        public void selcTotal(String inferior, String superior)
        {
            double totalVendas;

            Sql1 = "SELECT COUNT(Notas.nt_numero) FROM (Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                    "WHERE notas.nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'V' and nt_empresa <> 91 " +
                    "ORDER BY Notas.nt_vendedor ASC, Notas.nt_data ASC, Notas.nt_empresa ASC, Notas.nt_documento ASC";

            Sql2 = "SELECT COUNT(ped_numero) FROM pedidos inner join vendedores on pedidos.ped_vendedor = vendedores.vdd_codigo " +
                    "where vendedores.vdd_cttfuncao != 'VENDEDOR CHEFE' and ped_data BETWEEN '" + inferior + "' AND '" + superior + "' AND " +
                    "ped_orcamento <> '' AND ped_aprovado = 1 AND ped_cancelado = 0";

            Sql3 = "SELECT SUM(ped_total) FROM pedidos " +
                    "where ped_data BETWEEN '" + inferior + "' AND '" + superior + "' AND " +
                    "ped_orcamento <> '' AND ped_aprovado = 1 AND ped_cancelado = 0";

            Sql4 = "SELECT SUM(Notas.nt_total) FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo " +
                    "WHERE notas.nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'V' and tmv_codigo <> 77 " +
                    "ORDER BY Notas.nt_vendedor ASC, Notas.nt_data ASC, Notas.nt_empresa ASC, Notas.nt_documento ASC";

            Sql5 = "SELECT COUNT(loe_codigo) FROM loe INNER JOIN vendedores ON loe.loe_id_vendedor = vendedores.vdd_codigo WHERE loe_data BETWEEN '" + inferior + "' AND '" + superior + "' AND (vdd_cttfuncao like 'VENDEDOR%' OR vdd_cttfuncao like 'TELEVENDEDOR%');";

            Sql6 = "SELECT count(mv_item) FROM (notas b INNER JOIN movimentos a ON a.mv_documento = b.nt_documento "+
                    "AND a.mv_empresa = b.nt_empresa AND a.mv_agente = b.nt_agente) INNER JOIN tipomovi c ON b.nt_movimento = c.tmv_codigo "+
                    "WHERE nt_vendedor BETWEEN '0' and '999' and nt_data ='" + inferior + "';";

            Sql9 = "select count(mv_documento) from movimentos m inner join notas n on m.mv_documento = n.nt_documento and m.mv_agente = n.nt_agente and m.mv_empresa = n.nt_empresa " +
                    "where nt_data between '" + inferior + "' AND '" + superior + "' and nt_vendedor BETWEEN '0' and '999';";

            SqlAux = "SELECT SUM(Notas.nt_total) FROM Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo " +
                    "WHERE notas.nt_data BETWEEN '" + inferior + "' AND '" + superior + "' AND notas.nt_cancelada = 0 AND tmv_grupo = 'D' and tmv_tipo = 'E' " +
                    "ORDER BY Notas.nt_vendedor ASC, Notas.nt_data ASC, Notas.nt_empresa ASC, Notas.nt_documento ASC";

            cmd1 = new MySqlCommand(Sql1, dao.Conexao);
            cmd2 = new MySqlCommand(Sql2, dao.Conexao);
            cmd3 = new MySqlCommand(Sql3, dao.Conexao);
            cmd4 = new MySqlCommand(Sql4, dao.Conexao);
            cmd5 = new MySqlCommand(Sql5, dao.Conexao);
            cmd6 = new MySqlCommand(Sql6, dao.Conexao);
            cmd9 = new MySqlCommand(Sql9, dao.Conexao);
            cmdAux = new MySqlCommand(SqlAux, dao.Conexao);
            dao.conecta();
            object aux1 = cmd1.ExecuteScalar();
            object aux2 = cmd2.ExecuteScalar();
            object aux3 = cmd3.ExecuteScalar();
            object aux4 = cmd4.ExecuteScalar();
            object aux5 = cmd5.ExecuteScalar();
            object aux6 = cmd6.ExecuteScalar();
            object aux9 = cmd9.ExecuteScalar();
            object auxVendas = cmdAux.ExecuteScalar();
            if(aux3.ToString() == "")
            {
                aux3 = 0;
            }
            if (aux4.ToString() == "")
            {
                aux4 = 0;
            }
            if (auxVendas.ToString() == "")
            {
                auxVendas = 0;
            }

            totalVendas = Convert.ToDouble(aux4) - Convert.ToDouble(auxVendas) - Convert.ToDouble(aux3);

            ItensPedL = aux6.ToString();
            NAtendL = aux5.ToString();
            NVendasL = aux1.ToString();
            NOrcamL = aux2.ToString();
            NItensLoja = aux9.ToString();
            OrcamL = Convert.ToDouble(aux3);
            VendasL = totalVendas.ToString();
            dao.desconecta();
        }

        public void indcaLoja(String inferior, String superior, int vendInf, int vendSup)
        {
            Sql1 = "SELECT count(vendedores.vdd_nome) as 'nome' FROM ((((notas INNER JOIN empresas on notas.nt_empresa = empresas.emp_codigo) inner join pedidos on notas.nt_numpedido = pedidos.ped_numero  and notas.nt_vendedor = pedidos.ped_vendedor and notas.nt_empresa = pedidos.ped_empresa) inner join clientes on notas.nt_agente = clientes.cli_codigo) " +
                    "inner join tipomovi on notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                    "WHERE vdd_codigo between " + vendInf + " and " + vendSup + " and notas.nt_data between '" + inferior + "' and '" + superior + "' and pedidos.ped_cancelado = 1 AND empresas.emp_codigo <> 91 and tipomovi.tmv_grupo = 'v' and notas.nt_cancelada = 1;";

            Sql2 = "SELECT ifnull(sum(notas.nt_total), 0) as 'total' FROM (((notas inner join pedidos on notas.nt_numpedido = pedidos.ped_numero) inner join clientes on notas.nt_agente = clientes.cli_codigo) " +
                    "inner join tipomovi on notas.nt_movimento = tipomovi.tmv_codigo) " +
                    "WHERE notas.nt_data between '" + inferior + "' and '" + superior + "' and pedidos.ped_cancelado = 1 AND nt_empresa <> 91 and tipomovi.tmv_grupo = 'v' and notas.nt_cancelada = 1;";
           
            Sql3 = "SELECT count(vendedores.vdd_nome) as 'nome' FROM (((notas INNER JOIN empresas on notas.nt_empresa = empresas.emp_codigo) inner join clientes on notas.nt_agente = clientes.cli_codigo) " +
                    "inner join tipomovi on notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                    "WHERE vdd_codigo between " + vendInf + " and " + vendSup + " and notas.nt_data between '" + inferior + "' and '" + superior + "' AND notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'D' AND tipomovi.tmv_tipo = 'E'";

            Sql4 = "SELECT ifnull(sum(notas.nt_total), 0) as 'total' FROM (((notas INNER JOIN empresas on notas.nt_empresa = empresas.emp_codigo) inner join clientes on notas.nt_agente = clientes.cli_codigo) " +
                    "inner join tipomovi on notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                    "WHERE vdd_codigo between " + vendInf + " and " + vendSup + " and notas.nt_data between '" + inferior + "' and '" + superior + "' AND notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'D' AND tipomovi.tmv_tipo = 'E'";

            Sql5 = "SELECT ifnull(sum((peditem.pdi_preco-movimentos.mv_preco)*movimentos.mv_quantidade), 0) FROM ((((((((movimentos INNER JOIN notas ON movimentos.mv_empresa = notas.nt_empresa AND movimentos.mv_agente = notas.nt_agente AND movimentos.mv_documento = notas.nt_documento) "+
                    "INNER JOIN itens ON movimentos.mv_item = itens.itm_codigo) INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) INNER JOIN grupos ON itens.itm_grupo = grupos.grp_codigo) "+
                    "INNER JOIN classes ON itens.itm_classe = classes.clg_codigo) INNER JOIN clientes ON movimentos.mv_agente = clientes.cli_codigo) "+
                    "INNER JOIN peditem ON movimentos.mv_empresa = peditem.pdi_empresa AND movimentos.mv_pedido = peditem.pdi_numero AND movimentos.mv_pedidoseq = peditem.pdi_sequencia) "+
                    "INNER JOIN empresas ON empresas.emp_codigo = movimentos.mv_empresa) INNER JOIN vendedores ON vendedores.vdd_codigo = notas.nt_vendedor "+
                    "WHERE vdd_codigo between " + vendInf + " and " + vendSup + " and notas.nt_data between '" + inferior + "' and '" + superior + "' AND notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'V';";

            Sql6 = "SELECT ifnull(sum(pedidos.ped_desconto), 0) FROM "+
                    "(pedidos inner join vendedores on pedidos.ped_vendedor = vendedores.vdd_codigo) inner join empresas on pedidos.ped_empresa = empresas.emp_codigo "+
                    "WHERE vdd_codigo between " + vendInf + " and " + vendSup + " and pedidos.ped_data between '" + inferior + "' and '" + superior + "' AND pedidos.ped_desconto <> 0;";
            
            cmd1 = new MySqlCommand(Sql1, dao.Conexao);
            cmd2 = new MySqlCommand(Sql2, dao.Conexao);
            cmd3 = new MySqlCommand(Sql3, dao.Conexao);
            cmd4 = new MySqlCommand(Sql4, dao.Conexao);
            cmd5 = new MySqlCommand(Sql5, dao.Conexao);
            cmd6 = new MySqlCommand(Sql6, dao.Conexao);

            dao.conecta();
            object aux1 = cmd1.ExecuteScalar();
            object aux2 = cmd2.ExecuteScalar();
            object aux3 = cmd3.ExecuteScalar();
            object aux4 = cmd4.ExecuteScalar();
            object aux5 = cmd5.ExecuteScalar();
            object aux6 = cmd6.ExecuteScalar();
            NCancelado = aux1.ToString();
            Cancelado = Convert.ToDouble(aux2);
            NDevolu = aux3.ToString();
            Devolu = Convert.ToDouble(aux4);
            DescIten = Convert.ToDouble(aux5);
            DescPed = Convert.ToDouble(aux6);
            dao.desconecta();
        }

        public void CanceladosLoja(String inferior, String superior, int vdd, int vdd2)
        {
            cmdCanc = new MySqlCommand();
            cmdCanc.Connection = dao.Conexao2;
            cmdCanc.CommandType = CommandType.StoredProcedure;
            cmdCanc.Parameters.AddWithValue("dataInf", inferior);
            cmdCanc.Parameters.AddWithValue("dataSup", superior);
            cmdCanc.Parameters.AddWithValue("vdd", vdd);
            cmdCanc.Parameters.AddWithValue("vdd2", vdd2);
            cmdCanc.CommandText = "sp_Cancelados";

            dao.conecta2();

            MySqlDataReader aux = cmdCanc.ExecuteReader();
            while (aux.Read())
            {
                NCancelado = aux["nome"].ToString();
                Cancelado = Convert.ToDouble(aux["total"]);
            }
            aux.Close();
            dao.desconecta2();
        }

        public void DevolucaoLoja(String inferior, String superior, int vdd, int vdd2)
        {
            cmdDev = new MySqlCommand();
            cmdDev.Connection = dao.Conexao2;
            cmdDev.Parameters.AddWithValue("@inferior", inferior);
            cmdDev.Parameters.AddWithValue("@superior", superior);
            cmdDev.Parameters.AddWithValue("@vdd", vdd);
            cmdDev.Parameters.AddWithValue("@vdd2", vdd2);
            cmdDev.CommandText = "SELECT ifnull(sum(notas.nt_total), 0) as 'total', count(vendedores.vdd_nome) as 'nome' FROM (((notas INNER JOIN empresas on notas.nt_empresa = empresas.emp_codigo) inner join clientes on notas.nt_agente = clientes.cli_codigo) " +
                                 "inner join tipomovi on notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                                 "WHERE notas.nt_data between @inferior and @superior AND vdd_codigo between @vdd and @vdd2 and notas.nt_cancelada = 0 AND tipomovi.tmv_grupo = 'D' AND tipomovi.tmv_tipo = 'E'";

            dao.conecta2();
            MySqlDataReader aux = cmdDev.ExecuteReader();
            while (aux.Read())
            {
                NDevolu = aux["nome"].ToString();
                Devolu = Convert.ToDouble(aux["total"]);
            }
            aux.Close();
            dao.desconecta2();
        }
        public void MetaLoja(int vdd, int vdd2)
        {
            cmdMeta = new MySqlCommand();
            cmdMeta.Connection = dao.Conexao2;
            cmdMeta.Parameters.AddWithValue("@vdd", vdd);
            cmdMeta.Parameters.AddWithValue("@vdd2", vdd2);
            cmdMeta.CommandText = "select vmet_meta from valor_meta where vmet_vendedor between @vdd and @vdd2";
            dao.conecta2();
            MySqlDataReader aux = cmdMeta.ExecuteReader();
            while (aux.Read())
            {
                Meta.Add(Convert.ToDouble(aux["vmet_meta"]));
            }
            aux.Close();
            dao.desconecta2();
        }

        public void Valor(String inferior, String superior, int vdd, int vdd2)
        {
            cmdValor1 = new MySqlCommand();
            cmdValor3 = new MySqlCommand();

            cmdValor1.Connection = dao.Conexao2;
            cmdValor1.Parameters.AddWithValue("@inferior", inferior);
            cmdValor1.Parameters.AddWithValue("@superior", superior);
            cmdValor1.Parameters.AddWithValue("@vdd", vdd);
            cmdValor1.Parameters.AddWithValue("@vdd2", vdd2);

            cmdValor3.Connection = dao.Conexao2;
            cmdValor3.Parameters.AddWithValue("@inferior", inferior);
            cmdValor3.Parameters.AddWithValue("@superior", superior);
            cmdValor3.Parameters.AddWithValue("@vdd", vdd);
            cmdValor3.Parameters.AddWithValue("@vdd2", vdd2);

            cmdValor1.CommandText = "SELECT COUNT(Notas.nt_numero) as 'qtde', ifnull(SUM(Notas.nt_total), 0) as 'valor'  FROM (Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                                    "WHERE notas.nt_data BETWEEN @inferior AND @superior AND vdd_codigo BETWEEN @vdd and @vdd2 and notas.nt_cancelada = 0 AND tmv_grupo = 'V' and tmv_codigo <> 77 ";

            cmdValor3.CommandText = "SELECT SUM(Notas.nt_total) FROM (Notas INNER JOIN tipomovi ON notas.nt_movimento = tipomovi.tmv_codigo) inner join vendedores on notas.nt_vendedor = vendedores.vdd_codigo " +
                                    "WHERE notas.nt_data BETWEEN @inferior AND @superior AND vdd_codigo BETWEEN @vdd and @vdd2 and notas.nt_cancelada = 0 AND tmv_grupo = 'D' and tmv_tipo = 'E' ";

            dao.conecta2();

            object auxVendas = cmdValor3.ExecuteScalar();
            if (auxVendas.ToString() == "")
            {
                auxVendas = 0;
            }

            MySqlDataReader aux1 = cmdValor1.ExecuteReader();
            while (aux1.Read())
            {
                VendasL = (Convert.ToDouble(aux1["valor"]) - Convert.ToDouble(auxVendas)).ToString();
                NVendasL = aux1["qtde"].ToString();
            }
            aux1.Close();
            dao.desconecta2();
        }

        public string selecJustific(String inferior, String superior, int opcao)
        {
            Sql7 = "SELECT count(loe_codigo) FROM loe WHERE loe_opcao = " + opcao + " AND loe_data between '" + inferior + "' and '" + superior + "'";
            cmd7 = new MySqlCommand(Sql7, dao.Conexao);

            dao.conecta();
            object aux1 = cmd7.ExecuteScalar();

            dao.desconecta();
            return aux1.ToString();
        }

        public int selecJustificTot(String inferior, String superior)
        {
            Sql8 = "SELECT count(loe_codigo) FROM loe WHERE loe_data between '" + inferior + "' and '" + superior + "'";
            cmd8 = new MySqlCommand(Sql8, dao.Conexao);

            dao.conecta();
            object aux1 = cmd8.ExecuteScalar();

            dao.desconecta();
            return Convert.ToInt32(aux1);
        }
    }
}
