using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string,string> movies = new Dictionary<string,string>();
            movies.Add("IT", "R");
            movies.Add("Jaws", "PG");
            movies.Add("The SpongeBob Movie: Sponge Out of Water", "PG");
            List<string> keys = new List<string>(movies.Keys);
            int amt = keys.Count;
            foreach (int i in Enumerable.Range(1, amt))
            {
                Console.WriteLine($"{i}: {keys[0]}");
            }
            Console.ReadLine();
        }
    }
}
