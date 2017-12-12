using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcTest
{
    class Program
    {
        static bool checkIfAlpha(string input)
        {
            if (input.All(Char.IsLetter)){ return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give an input: ");
            string input = Console.ReadLine().ToString();
            if (checkIfAlpha(input)) { Console.WriteLine("Function returned true"); }
            else { Console.WriteLine("Function returned false"); }
            Console.ReadLine();
        }
    }
}
