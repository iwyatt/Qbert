using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Qbert
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new QbertMain());
            }

            catch (Exception er)
            {
                QError oops = new QError("Game Over! \n" + er.Message + "\n\n"+er.ToString());
                oops.ShowDialog();
            }
        }
    }
}
