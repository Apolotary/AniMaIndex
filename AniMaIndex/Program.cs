using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AniMaIndex
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
            FormMain main = FormMain.Instance(); 
            Application.Run(main);
        }
    }
}
