using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static bool good = false;

        public static void run()
        {
            double num = -1;
            Console.Write("Hey bud.  Give me a number between 1 and 100: ");
            while (num < 1 || num > 100)
            {
                num = double.Parse(Console.ReadLine());
                good = true;
                Console.WriteLine($"Your number is {num}.  Press enter to close...");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {     
            while (good is false)
            {
                try
                {
                    run();
                }
                catch (FormatException) { }
            }
        }
    }
}
