using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtlirane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> positiveNumbers = array.Where(num => num >= 0).ToList();
            foreach (int num in positiveNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
