using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadFormTimeImplementation
{
    public class ClockCan
    {
        private bool shows = true;

        public void Loop(CancellationToken cancToken)
        {
            while (true)
            {
                if (this.shows)
                    Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                if (cancToken.IsCancellationRequested)  Console.WriteLine("Operation cancelled"); return;
            }

        }
        public void Show() { this.shows = true; Console.WriteLine("--- on"); }
        public void DontShow() { this.shows = false; Console.WriteLine("--- off"); }

    }
}
