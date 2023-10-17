using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamiraneNaNai_MalkoChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            if (numbers.Length == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }
            int minimum = int.Parse(numbers[0]);
            for (int i = 1; i < numbers.Length; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                if (currentNumber < minimum)
                {
                    minimum = currentNumber;
                }
            }
            Console.WriteLine($"Minimum number: {minimum}");
        }
    }
}
