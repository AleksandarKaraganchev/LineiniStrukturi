using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivaneNaSpisuci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<int> l1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> l2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> mergedList = l1.Concat(l2).OrderBy(c => c).ToList();
            Console.WriteLine($"Merged List: {string.Join(" ", mergedList)}");
        }
    }
}
