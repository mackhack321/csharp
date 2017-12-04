using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySandbox
{
    class arrayClass
    {
        public static int[] array = new int[10];
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Give an int to fill index {i}: ");
                try
                {
                    arrayClass.array[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    i--;
                }
            }
            Console.WriteLine(arrayClass.array);
            Console.ReadLine();
        }
    }
}
