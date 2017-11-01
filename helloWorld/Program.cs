using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            var input = Console.ReadLine();
            Console.WriteLine($"I got the input: {input}");
            try
            {
                Console.WriteLine("Give the first number to add:");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give the second number to add:");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                int sum = numOne + numTwo;
                Console.WriteLine($"{numOne} plus {numTwo} is {sum}.");
                if (sum > 100)
                    Console.WriteLine("That's bigger than 100, too!");
                else
                    Console.WriteLine("That's not bigger than 100");
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong type!");
                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
