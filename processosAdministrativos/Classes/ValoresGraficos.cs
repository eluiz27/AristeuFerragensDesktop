using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Classes
{
    public class ValoresGraficos
    {
        querys q = new querys();
        List<double> valores = new List<double>();

        public List<double> Valores { get => valores; set => valores = value; }

        public bool Vendedor(int vdd)
        {
            DAO dao = new DAO();
            dao.Query2 = new MySqlCommand();
            dao.Query2.Connection = dao.Conexao2;
            dao.Query2.Parameters.AddWithValue("@vdd", vdd);
            dao.Query2.CommandText = "select Count(vdd_codigo) from vendedores where vdd_codigo = @vdd";

            dao.conecta2();
            object aux = dao.Query2.ExecuteScalar();
            dao.desconecta2();
            dao.Query2.Parameters.Clear();
            if (aux.ToString() == "0")
                return false;
            else
                return true;
        }

        public List<double> graficoFatMes(int vdd, int vdd2)
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.Valor(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), vdd, vdd2);
            else
                q.Valor(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), vdd, vdd2) ;

            double totalVal = Convert.ToDouble(q.VendasL);
            double totalPed = Convert.ToInt32(q.NVendasL);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoFatDia(int vdd, int vdd2)
        {
            q.Valor(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);

            double totalVal = Convert.ToDouble(q.VendasL);
            double totalPed = Convert.ToDouble(q.NVendasL);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoPedAprov(int vdd, int vdd2)
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.Valor(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);
            else
                q.Valor(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);

            double totalVal = Convert.ToDouble(q.VendasL);
            double totalPed = Convert.ToInt32(q.NVendasL);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoPedCanc(int vdd, int vdd2)
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.CanceladosLoja(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);
            else
                q.CanceladosLoja(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);

            double totalVal = Convert.ToDouble(q.Cancelado);
            double totalPed = Convert.ToInt32(q.NCancelado);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoPedDev(int vdd, int vdd2)
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.DevolucaoLoja(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);
            else
                q.DevolucaoLoja(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);

            double totalVal = Convert.ToDouble(q.Devolu);
            double totalPed = Convert.ToInt32(q.NDevolu);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public double graficoMetaFeito(int vdd, int vdd2)
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.Valor(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);
            else
                q.Valor(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"), vdd, vdd2);

            double totalVal = Convert.ToDouble(q.VendasL);

            return totalVal;
        }

        public double graficoMetaSaldo(int vdd, int vdd2)
        {
            q.MetaLoja(vdd, vdd2);

            double meta = 0;

            for (int i = 0; i < q.Meta.Count(); i++)
            {
                meta = meta + q.Meta[i];
            }
            q.Meta.Clear();
            return meta;
        }

        public void graficoLinha(int vdd, int vdd2)
        {
            string dataAux = DateTime.Now.ToString("yyyy-MM-01");
            string dataSup = Convert.ToDateTime(dataAux).AddDays(-1).ToString("yyyy-MM-dd");
            string dataAnt = Convert.ToDateTime(dataAux).AddMonths(-1).ToString("yyyy-MM-26");

            for(int i = 0; i < 6; i++)
            {
                q.Valor(dataAnt, dataSup, vdd, vdd2);
                Valores.Add(Convert.ToDouble(q.VendasL));
                if (Convert.ToInt32(Convert.ToDateTime(dataSup).ToString("dd")) > 25)
                {
                    dataAnt = Convert.ToDateTime(dataSup).AddDays(1).ToString("yyyy-MM-dd");
                    dataSup = Convert.ToDateTime(dataSup).AddMonths(1).ToString("yyyy-MM-05");
                }
                else
                {
                    dataAnt = Convert.ToDateTime(dataSup).AddDays(1).ToString("yyyy-MM-dd");
                    dataSup = Convert.ToDateTime(dataSup).AddDays(5).ToString("yyyy-MM-dd");
                }
            }
        }

        public void EscreveVendedor(string numero)
        {
            string vendedor = Path.GetFullPath("NumVendedor\\vendedor.txt");

            StreamWriter x;

            x = File.CreateText(vendedor);
            x.Write(numero);
            x.Close();
        }

        public string LeVendedor()
        {
            string vendedor = Path.GetFullPath("NumVendedor\\vendedor.txt");

            StreamReader y;

            y = File.OpenText(vendedor);

            string aux = y.ReadLine();
            y.Close();

            return aux;
        }

    }
}
