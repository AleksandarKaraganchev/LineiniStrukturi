using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinadlejiLiDadenoChisloNaMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers separated by spaces:");
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Enter a number to check if it exists in the list:");
            int nToCheck = int.Parse(Console.ReadLine());
            if (n.Contains(nToCheck))
            {
                Console.WriteLine($"{nToCheck} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{nToCheck} Not exists in the List");
            }
        }
    }
}
