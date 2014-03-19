using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GestionEtudiants.Forms;

namespace GestionEtudiants
{
    static class Program
    {
//test de merde jhgbkuhnl
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListeEtudiantsForm());
        }
    }
}
