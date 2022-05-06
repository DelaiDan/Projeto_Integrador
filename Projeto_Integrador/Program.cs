using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
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

            Login frmLogin = new Login();

            frmLogin.ShowDialog();

            if (frmLogin.logado)
            {
                Application.Run(new TelaInicial());
            }

        }
    }
}
