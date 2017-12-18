using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Halfway through writing this, I realize that this is the one that's mindlessly easy in Python.
//Oh well, my C# kung-fu seems to be strong enough to handle it

namespace greeneMidtermDigits
{
    class Program
    {
        public static char[] toList(double number)
        {
            string strNumber = number.ToString();
            if (strNumber.Contains(".")) { strNumber = strNumber.Replace(".", "");}
            if (strNumber.Contains("-")) { strNumber = strNumber.Replace("-", ""); }
            char[] chars = strNumber.ToCharArray();
            return chars; 
        }

        static void Main(string[] args)
        {
            bool valid = false;
            while (valid is false)
            {
                try
                {
                    Console.Write("Give a number to turn into a list of digits: ");
                    double num = double.Parse(Console.ReadLine());
                    if (num.ToString().Length > 15) { Console.WriteLine("Numbers that big make me sad :("); throw new FormatException(); }
                    valid = true;
                    Console.Write("Here is a list of the digits in that number: ");
                    Console.Write(string.Join(", ", toList(num)));
                    Console.ReadLine();
                }
                catch (FormatException) { continue; }
            }
        }
    }
}
