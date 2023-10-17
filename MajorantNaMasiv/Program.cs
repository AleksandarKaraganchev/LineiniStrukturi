using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorantNaMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string inp = Console.ReadLine();
            string[] numsStr = inp.Split(' ');
            int[] arr = new int[numsStr.Length];
            for (int i = 0; i < numsStr.Length; i++)
            {
                arr[i] = int.Parse(numsStr[i].Trim());
            }
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            int threshold = arr.Length / 2 + 1;
            foreach (var pair in counts)
            {
                if (pair.Value >= threshold)
                {
                    Console.WriteLine(pair.Key);
                    return;
                }
            }
            Console.WriteLine("The majorant does not exists!");
        }
    }
}
