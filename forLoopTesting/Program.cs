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
        public static void funcTest(int i, int rang)
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

        static void Main(string[] args)
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
            Console.Write("Give a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give a range: ");
            int rang = Convert.ToInt32(Console.ReadLine());
            funcTest(num,rang);
            Console.ReadLine();
        }
    }
}
