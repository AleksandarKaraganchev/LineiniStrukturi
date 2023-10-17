using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestotaNaSreshtaniq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }
            foreach (var item in frequency)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
