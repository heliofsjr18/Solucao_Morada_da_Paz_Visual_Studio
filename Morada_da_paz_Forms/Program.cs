using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morada_da_paz_Forms
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
            LoginWindow login = new LoginWindow();

            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new PrincipalWindow(login.resultadoU));
        }
    }
}
