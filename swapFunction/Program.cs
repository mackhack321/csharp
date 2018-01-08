using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapFunction
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string swap(string varA, string varB)
            {
                string tempVar = varA;
                varA = varB;
                varB = tempVar;
                return $"{varA}, {varB}";
            }

            Console.Write("Enter a value for varOne: ");
            string varOne = Console.ReadLine();
            Console.Write("Enter a value for varTwo: ");
            string varTwo = Console.ReadLine();
            Console.WriteLine($"Here are the switched variables: {swap(varOne, varTwo)}");
            Console.ReadLine();
        }
    }
}
