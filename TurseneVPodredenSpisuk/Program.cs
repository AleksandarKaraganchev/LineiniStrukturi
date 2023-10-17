using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurseneVPodredenSpisuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<int> i = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();
            int nToCheck = int.Parse(Console.ReadLine());
            if (i.Contains(nToCheck))
            {
                Console.WriteLine($"|{nToCheck}| Exists in the List");
            }
            else
            {
                Console.WriteLine($"|{nToCheck}| Not exists in the List");
            }
        }
    }
}
