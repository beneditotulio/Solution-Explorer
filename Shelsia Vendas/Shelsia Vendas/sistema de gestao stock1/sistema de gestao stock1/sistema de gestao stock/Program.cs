using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_gestao_stock
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
           // Application.Run(new Telas.Menu());


           // Application.Run(new Telas.FrmLogin());

            Application.Run(new Telas.FrmMenuPrincipal());

            // Application.Run(new Telas.FrmCliente());
            //pplication.Run(new Form1());
            //  Application.Run(new Telas.Funcionario());
        }
    }
}
