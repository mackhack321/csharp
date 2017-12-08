using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
            “Recently I had a visit with my mom and we realized that the two digits that make up my age when
            reversed resulted in her age. For example, if she’s 73, I’m 37.We wondered how often this has happened
            over the years but we got sidetracked with other topics and we never came up with an answer. “When I
            got home I figured out that the digits of our ages have been reversible six times so far.I also figured out
            that if we’re lucky it would happen again in a few years, and if we’re really lucky it would happen one
            more time after that.In other words, it would have happened 8 times over all.So the question is, how old
            am I now ?”
            Write a program that searches for solutions to this problem.
*/

//
//ANSWER: 79
//

namespace greeneReversedAge
{
    class Program
    {
        public static string reverse(string s)
        {
            char[] ageArray = s.ToCharArray();
            Array.Reverse(ageArray);
            return new string(ageArray);
        }

        static void Main(string[] args)
        {
            string myAge = "0";
            string momAge = "18";
            for (int i = 0; i < 200; i++)
            {
                if (myAge.Length == 1)
                {
                    myAge = 0 + myAge;
                }
                if (reverse(myAge) == momAge)
                {
                    Console.WriteLine($"My age is {myAge} and mom's age is {momAge}");
                }
                /*
                else
                {
                    Console.WriteLine($"{myAge} and {momAge} don't work");
                }
                */
                myAge = (int.Parse(myAge) + 1).ToString();
                momAge = (int.Parse(momAge) + 1).ToString();
            }
            Console.ReadLine();
        }
    }
}
