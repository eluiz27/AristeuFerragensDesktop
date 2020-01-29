using processosAdministrativos.Telas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processosAdministrativos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //login login = new login();
            //if(login.ShowDialog() == DialogResult.OK)
            //{
                Application.Run(new Principal());
            //}
        }
    }
}
