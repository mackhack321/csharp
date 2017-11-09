using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using greeneInputAssignment;

namespace greeneInputAssignment
{
    class Mack
    {
        public static void sum(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {sum}!");
        }

        public static void product(float a, float b)
        {
            float product = a * b;
            Console.WriteLine($"The product of {a} and {b} is {product}!");
        }

        public static void quotient(float a, float b)
        {
            float quotient = a/b;
            if (b != 0)
            {
                Console.WriteLine($"The quotient of {a} and {b} is {quotient}!");
            }
            else
            {
                Console.WriteLine("I would try and divide those numbers, but I can't divide by zero!");
            }
        }

        public static void subtract(float a, float b)
        {
            float subtract = a - b;
            Console.WriteLine($"{a} minus {b} is {subtract}!");
        }

        public static void raise(float a, float b)
        {
            double raise = Math.Pow(a, b);
            Console.WriteLine($"{a} to the power of {b} is {raise}!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello there!  What is your name?");
            string name = Console.ReadLine();
            if (name == "bob")
            {
                Console.WriteLine("I feel like I've seen you before...");
            }
            Console.WriteLine($"Greetings, {name}!  I am a computer.  I am going to walk you through some sicc math");
            Console.Write("We're going to do some funky stuff with numbers.  Give the first number: ");
            float numOne = Convert.ToSingle(Console.ReadLine());
            Console.Write("Give the second number: ");
            float numTwo = Convert.ToSingle(Console.ReadLine());
            sum(numOne, numTwo);
            product(numOne, numTwo);
            quotient(numOne, numTwo);
            subtract(numOne, numTwo);
            raise(numOne, numTwo);
            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
