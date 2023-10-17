using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SborISrednoAritmetichno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<int> i = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            int count = i.Count;
            foreach (int number in i)
            {
                sum += number;
            }
            double avg = count > 0 ? (double)sum / count : 0;
            avg = Math.Round(avg, 2);
            Console.WriteLine($"Sum= |{sum}|; Average= |{avg.ToString("F2")}|");
        }
    }
}
