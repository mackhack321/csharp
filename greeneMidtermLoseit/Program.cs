using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeneMidtermLoseit
{
    class Program
    {
        public static List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

        public static List<int> loseit(List<int> list)
        {
            list.Remove(list[0]);
            list.Remove(list[list.Count - 1]);
            return list;
        }

        static void Main(string[] args)
        {
            Console.Write("Original List: "); Console.WriteLine(string.Join(", ", nums));
            Console.Write("After loseit(): "); Console.Write(string.Join(", ", loseit(nums)));
            Console.ReadLine();
        }
    }
}
