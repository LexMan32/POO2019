using System;
using System.Windows.Forms;

namespace ExPeleMele
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Introduction());
            Application.Run(new Menu());
        }
    }
}
