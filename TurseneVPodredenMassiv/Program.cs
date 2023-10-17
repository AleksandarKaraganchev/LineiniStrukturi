using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurseneVPodredenMassiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int find = int.Parse(Console.ReadLine());
            int result = -1;
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (arr[middle] == find)
                {
                    result = middle;
                    Console.WriteLine($"|{find}| Exists in the Array at index {result}");
                    break;
                }
                else if (find < arr[middle])
                {
                    end = middle - 1;
                }
                else if (find > arr[middle])
                {
                    start = middle + 1;
                }
            }
            if (result == -1)
            {
                Console.WriteLine($"|{find}| Not exists in the Array");
            }
        }
    }
}
