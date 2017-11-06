using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopTesting
{
    class Program
    {
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
            Console.ReadLine();
        }
    }
}
