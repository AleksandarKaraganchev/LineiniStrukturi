using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaredeniDvoiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Въведете число m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Въведете число n: ");
            int n = int.Parse(Console.ReadLine());
            for (int p = 1; p <= m; p++)
            {
                for (int q = 1; q <= n; q++)
                {
                    Console.WriteLine($"({p}, {q})");
                }
            }
        }
    }
}
