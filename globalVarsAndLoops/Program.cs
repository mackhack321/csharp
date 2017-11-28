using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace globalVarsAndLoops
{
    class Program
    {
        static void fe()
        {
            List<string> list = new List<string>{ "mack" };
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        static void f()
        {
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        static void w()
        {
            int i = 1;
            while (i < 1001)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static int count;

        static void dw()
        {
            count = 1;
            do
            {              
                Console.WriteLine($"This is time number {count}!");
                count++;
            }
            while (count < 101);
        }

        static string meme;
        static int globalint;
        static double globaldub;
        static float globalfloat;

        static void Main(string[] args)
        {
            fe();
            f();
            w();
            dw();
            meme = "meme";
            globalint = 21;
            globaldub = 2.5939843;
            globalfloat = 6.2F;
            Console.WriteLine($"{meme},{globalint},{globaldub},{globalfloat}");
            Console.Read();
        }
    }
}
