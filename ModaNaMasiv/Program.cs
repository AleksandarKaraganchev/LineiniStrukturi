using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaNaMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string inp = Console.ReadLine();
            string[] numsStr = inp.Split(' ');
            int[] array = new int[numsStr.Length];
            for (int i = 0; i < numsStr.Length; i++)
            {
                array[i] = int.Parse(numsStr[i].Trim());
            }
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }
            int maxFr = counts.Values.Max();
            List<int> modes = counts.Where(pair => pair.Value == maxFr).Select(pair => pair.Key).ToList();
            if (modes.Count == 1)
            {
                Console.WriteLine($"Fashion: {modes[0]}");
            }
            else
            {
                double average = modes.Average();
                Console.WriteLine($"Fashions: {string.Join(", ", modes)}");
                Console.WriteLine($"Average value of the fashions: {average}");
            }
        }
    }
}
