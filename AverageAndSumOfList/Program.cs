using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAndSumOfList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine($"Average: {input.Average()}");
            Console.WriteLine($"Sum: {input.Sum()}");
        }
    }
}
