using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Give me a word with three consecutive double letters. I’ll give you a couple of words that almost qualify,
but don’t. For example, the word committee, c-o-m-m-i-t-t-e-e. It would be great except for the ‘i’ that
sneaks in there. Or Mississippi: M-i-s-s-i-s-s-ip-p-i. If you could take out those i’s it would work. But there
is a word that has three consecutive pairs of letters and to the best of my knowledge this may be the only
word. Of course there are probably 500 more but I can only think of one. What is the word? Write a
program to find it.
*/

namespace greeneDoubleLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] words = System.IO.File.ReadAllLines("C:/Users/mlgpr/Desktop/CSharp/greeneDoubleLetters/dictionary.txt");
            Console.ReadLine();
        }
    }
}
