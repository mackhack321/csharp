using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace forLoopTesting
{
    class Program
    {
        public static void funcTest(long i, long rang)
        {
            int p = 1;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (p<=rang)
            {
                Console.WriteLine($"{i} to the power of {p} is {Math.Pow(i, p)}");
                p++;
            }
            stopwatch.Stop();
            TimeSpan time = stopwatch.Elapsed;
            Console.WriteLine($"That took {time}");
        }

        public static void bottles()
        {
            int bottleCount = 99;
            while (bottleCount > 1)
            {
                Console.WriteLine($"{bottleCount} bottles of beer on the wall,");
                Console.WriteLine($"{bottleCount} bottles of beer!");
                Console.WriteLine($"Take one down, pass it around,");
                bottleCount--;
                Console.WriteLine($"{bottleCount} bottles of beer on the wall!");
                Console.ReadLine();
            }
        }

        public static void forTesting()
        {
            int[] list = new int[] { 0, 1, 2, 3, 4 };
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            string[] strlist = new string[] { "foo", "bar", "apple" };
            foreach (string i in strlist)
            {
                Console.WriteLine(i);
            }
        }

        public static void chaos()
        {
            double x = .3;
            foreach (int i in Enumerable.Range(1, 1000000000))
            {
                x = 3.9 * x * (1 - x);
                Console.WriteLine(x);
            }
        }

        public static void launcher()
        {
            Console.WriteLine("Raise x to the power of y -- 1");
            Console.WriteLine("Bottles -- 2");
            Console.WriteLine("For Loop Testing -- 3");         
            Console.WriteLine("Chaos -- 4");
            Console.WriteLine("Exit -- 5");
            Console.Write("Select a function: ");
            string choice = Console.ReadLine();
            if (choice is "1")
            {
                try
                {
                    Console.Write("Give a number: ");
                    long num = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Give a range: ");
                    long rang = Convert.ToInt64(Console.ReadLine());
                    funcTest(num, rang);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid input received!");
                }
            }
            else if (choice is "2")
            {
                bottles();
            }
            else if (choice is "3")
            {
                forTesting();
            }
            else if (choice is "4")
            {
                chaos();
            }
            else if (choice is "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                launcher();
                Console.WriteLine("");
            }           
        }
    }
}