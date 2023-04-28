using System;
using System.Windows.Forms;

namespace proiect
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
            login_form login = new login_form();
            Application.Run(login);
        }
    }
}
