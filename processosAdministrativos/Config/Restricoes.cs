using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processosAdministrativos.Config
{
    public class Restricoes
    {
        public List<int> RestricMenu()
        {
            string user = Environment.UserName.ToLower();
            string computer = Environment.MachineName.ToLower();

            List<int> restrict = new List<int>();

            Cargo c = new Cargo();

            switch (c.NomeCargo(computer, user))
            {
                case "vendas":
                    for(int i = 0; i < 7; i++)
                    {
                        if(i == 4)
                            restrict.Add(1);
                        else
                            restrict.Add(0);
                    }
                    break;
                default:
                    for (int i = 0; i < 7; i++)
                    {
                            restrict.Add(1);                     
                    }
                    break;
            }
            return restrict;
        }
    }
}
