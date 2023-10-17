using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodrejdaneNaDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<string> w = new List<string>(Console.ReadLine().Split(' '));
            for (int i = 0; i < w.Count - 1; i++)
            {
                string minimum = w[i];
                int minimumPosition = i;
                for (int j = i + 1; j < w.Count; j++)
                {
                    if (string.Compare(w[j], minimum) < 0)
                    {
                        minimum = w[j];
                        minimumPosition = j;
                    }
                }
                w[minimumPosition] = w[i];
                w[i] = minimum;
            }
            Console.WriteLine(string.Join(" ", w));
        }
    }
}
