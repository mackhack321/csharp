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
            //set's up the dictionary to hold the movies
            IDictionary<string, string> movies = new Dictionary<string, string>();
            movies.Add("IT", "R");
            movies.Add("Jaws", "PG");
            movies.Add("The SpongeBob Movie: Sponge Out of Water", "PG");
            movies.Add("Killer Joe", "NC-17");
            movies.Add("The Lion King", "G");
            movies.Add("Thor: Ragnarok", "PG-13");
            //makes a list of all movies in dictionary, assigns length to var amt
            List<string> keys = new List<string>(movies.Keys);
            int amt = keys.Count;
            //displays options
            foreach (int i in Enumerable.Range(1, amt))
            {
                Console.WriteLine($"{i} -- {keys[i - 1]}");
            }
            Console.Write("\nPlease select a movie: ");
            try
            {
                //gets user input
                int usrIn = int.Parse(Console.ReadLine());
                //checks user input against movies list, gets rating
                string usrMovie = keys[usrIn - 1];
                string usrRating = movies[usrMovie];
                //displays results
                Console.WriteLine($"{usrMovie} is rated {usrRating}");
                Console.Write("\nPlease enter your age: ");
                //gets age
                int age = Convert.ToInt32(Console.ReadLine());
                //checks against MPAA ratings, writes appropriate responses
                if (usrRating == "R" && age < 17)
                {
                    Console.WriteLine("You must be accompanied by a parent or guardian to watch this film");
                }
                else if (usrRating == "NC-17" && age < 18)
                {
                    Console.WriteLine("You are not permitted to watch this film");
                }
                else if (usrRating == "PG-13" && age < 13)
                {
                    Console.WriteLine("Parents are urged to be cautious of permitting their pre-teen to watch this film");
                }
                else
                {
                    Console.WriteLine("Enjoy the film");
                }
                Console.WriteLine("\nPress enter to exit the program...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentOutOfRangeException)
                {
                    //will be shown if anything goes wrong.  catches int overflow, invalid input, and everything else
                    Console.WriteLine("Invalid input given.  Press enter to exit the program...");
                }
                Console.ReadLine();
            }
        }
    }
}
