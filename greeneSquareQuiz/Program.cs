using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeneSquareQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string usrInput = "null";

            List<double> list = new List<double> { };
            while (usrInput != "done")
            {
                Console.Write("Input a number or type 'done': ");
                usrInput = Console.ReadLine();
                try
                {
                    list.Add(double.Parse(usrInput));
                }
                catch (FormatException)
                {
                    continue;
                }
            }
            for (int index = 0; index < list.Count(); index++)
            {
                list[index] = Math.Pow(list[index], 2);
            }
            Console.WriteLine($"The sum of the squares of the numbers you gave is: {list.Sum()}");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
