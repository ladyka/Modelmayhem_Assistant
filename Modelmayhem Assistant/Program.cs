using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Modelmayhem_Assistant
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var forma1 = new Form1();
            //Application.Run(
              //  forma1.Show();
              //  );
            Application.Run(new mainwin());
        }
    }
}
