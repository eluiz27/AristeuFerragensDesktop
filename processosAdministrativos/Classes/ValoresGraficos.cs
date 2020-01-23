using System;
using System.Collections.Generic;
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

        public List<double> graficoFatMes()
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.Valor(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"));
            else
                q.Valor(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")) ;

            double totalVal = Convert.ToDouble(q.VendasL);
            double totalPed = Convert.ToInt32(q.NVendasL);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoFatDia()
        {
            q.Valor(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));

            double totalVal = Convert.ToDouble(q.VendasL);
            double totalPed = Convert.ToDouble(q.NVendasL);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoPedAprov()
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.Valor(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));
            else
                q.Valor(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));

            double totalVal = Convert.ToDouble(q.VendasL);
            double totalPed = Convert.ToInt32(q.NVendasL);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoPedCanc()
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.CanceladosLoja(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));
            else
                q.CanceladosLoja(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));

            double totalVal = Convert.ToDouble(q.Cancelado);
            double totalPed = Convert.ToInt32(q.NCancelado);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public List<double> graficoPedDev()
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.DevolucaoLoja(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));
            else
                q.DevolucaoLoja(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));

            double totalVal = Convert.ToDouble(q.Devolu);
            double totalPed = Convert.ToInt32(q.NDevolu);

            List<double> totais = new List<double>();
            totais.Add(totalVal);
            totais.Add(totalPed);

            return totais;
        }

        public double graficoMetaFeito()
        {
            if (Convert.ToInt32(DateTime.Now.ToString("dd")) > 25)
                q.Valor(DateTime.Now.ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));
            else
                q.Valor(DateTime.Now.AddMonths(-1).ToString("yyyy-MM-26"), DateTime.Now.ToString("yyyy-MM-dd"));

            double totalVal = Convert.ToDouble(q.VendasL);

            return totalVal;
        }

        public double graficoMetaSaldo()
        {
            q.MetaLoja();

            double meta = 0;

            for (int i = 0; i < q.Meta.Count(); i++)
            {
                meta = meta + q.Meta[i];
            }
            q.Meta.Clear();
            return meta;
        }

        public void graficoLinha()
        {
            string dataAux = DateTime.Now.ToString("yyyy-MM-01");
            string dataSup = Convert.ToDateTime(dataAux).AddDays(-1).ToString("yyyy-MM-dd");
            string dataAnt = Convert.ToDateTime(dataAux).AddMonths(-1).ToString("yyyy-MM-26");

            for(int i = 0; i < 6; i++)
            {
                q.Valor(dataAnt, dataSup);
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

    }
}
