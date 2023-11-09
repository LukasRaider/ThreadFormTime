using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTimeImplementation;

namespace ThreadFormTime
{
    internal static class Program2
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        public static void Mainx()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Control_panel());
            //ThreadFormTimeImplementation.Clock.loop();
            Clock clock1 = new Clock();

            Application.Run(new Control_panel2(clock1));
            clock1.Loop();
            Thread.Sleep(1000);
        }
    }
}
