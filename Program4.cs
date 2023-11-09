using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadFormTimeImplementation;

namespace ThreadFormTime
{
    internal static class Program4
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
            ClockCan clock2 = new ClockCan();
            Task task = Task.Run(() => clock2.Loop(CancellationTokenSource.Token), CancellationTokenSource.Token);
            //Thread vlakno1 = new Thread(clock1.Loop);
            //vlakno1.Start();
            Control_panel3 op = new Control_panel2(clock2);
            //Application.Run(new Control_panel2(clock1));
            Application.Run(op);
            //clock1.Loop();
            //Thread.Sleep(1000);
            Console.WriteLine( "Press any key to cancel the operation");
            Console.ReadKey();
            CancellationTokenSource.Cancel();
            task.Wait();
        }
    }
}
