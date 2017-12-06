using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeneDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there!  You've stumbled upon a dice rolling sim.");
            bool again = true;
            while (again is true)
            {
                Console.Write("How many sides do you want your die to have? ");
                int sides = int.Parse(Console.ReadLine());
                Console.WriteLine($"Okay.  Rolling a die with {sides} sides...");
                Random r = new Random();
                int rolled = r.Next(1, sides + 1);
                Console.WriteLine($"You rolled a {rolled}!");
                Console.Write("Roll again? y or n: ");
                string strAgain = Console.ReadLine();
                if (strAgain == "y") { again = true; }
                else { again = false; }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
