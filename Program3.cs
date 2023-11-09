using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTimeImplementation;

namespace ThreadFormTime
{
    internal static class Program3
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Control_panel());
            //ThreadFormTimeImplementation.Clock.loop();
            Clock clock1 = new Clock();
            Thread vlakno1 = new Thread(clock1.Loop);
            vlakno1.Start();
            Control_panel2 op = new Control_panel2(clock1);
            //Application.Run(new Control_panel2(clock1));
            Application.Run(op);
            //clock1.Loop();
            //Thread.Sleep(1000);
            vlakno1.Abort();
        }
    }
}
