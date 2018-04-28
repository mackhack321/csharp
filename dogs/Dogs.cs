using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogs
{
    [Serializable]
    public class Dog
    {
        public string name;
        public int age;
        public int rating;

        public Dog(string name, int age, int rating)
        {
            this.name = name;
            this.age = age;
            this.rating = rating;
        }

        public void Eval()
        {
            Console.Write($"{this.name} is {this.age} years old and has a rating of {this.rating}/10.");
            if (rating < 5) { Console.Write("  Not a very good pupper."); }
            else { Console.Write("  Such a good boy!"); }
        }
        static void Main(string[] args)
        {
            Dog fido = new Dog("Fido", 13, 2);
            fido.Eval();
        }
    }
}
