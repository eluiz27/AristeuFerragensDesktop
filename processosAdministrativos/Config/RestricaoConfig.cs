using processosAdministrativos.Dao;
using processosAdministrativos.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Config
{
    public class RestricaoConfig : RestricaoDao
    {
        public List<string> Cargos { get; set; }
        public List<string> Computadores { get; set; }
        public List<string> Usuarios { get; set; }
        public string Dash { get; set; }


        public List<int> RestricMenu()
        {
            List<int> restrict = new List<int>();

            string a = SelectCargo()[0];

            Dash = SelectCargo()[1];

            switch (a)
            {
                case "compras":
                    for(int i = 0; i < 8; i++)
                    {
                        if(i == 0)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                case "expedição":
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 1 || i == 2)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                case "estoque":
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 2)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                case "financeiro":
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 3)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                case "vendas":
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 4)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                case "recepção":
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 6)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                default:
                    for (int i = 0; i < 8; i++)
                    {
                            restrict.Add(1);                     
                    }
                    break;
            }
            return restrict;
        }
    }
}
