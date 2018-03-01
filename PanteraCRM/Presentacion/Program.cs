using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (sesion.SessionGlobal != null)
            {
                 Application.Run(new PrincipalOpcional());
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            }
        }
    }
}
