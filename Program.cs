using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(1000);
            myTimer.Elapsed += myTimer_Elapsed;
            myTimer.Elapsed += myTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press Enter to remove the red event.");
            Console.ReadLine();

            myTimer.Elapsed -= myTimer_Elapsed1;

            Console.ReadLine();

        }

        private static void myTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
        private static void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
