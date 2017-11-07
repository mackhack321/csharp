using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopTesting
{
    class Program
    {
        public static void funcTest(int i)
        {
            foreach (int element in new int[] { 1,2,3,4,5})
            {
                Console.WriteLine($"{i} to the power of {element} is {Math.Pow(i, element)}");
            }

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
            funcTest(num);
            Console.ReadLine();
        }
    }
}
