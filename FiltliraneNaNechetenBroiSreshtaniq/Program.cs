using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltliraneNaNechetenBroiSreshtaniq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> count = new Dictionary<int, int>();

            foreach (int num in n)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            List<int> filteredNumbers = n.Where(num => count[num] % 2 == 0).ToList();

            foreach (int num in filteredNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
