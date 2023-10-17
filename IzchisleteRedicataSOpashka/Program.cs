using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzchisleteRedicataSOpashka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int n = int.Parse(Console.ReadLine());
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);
            int count = 1;
            while (count <= 50)
            {
                int currentNumber = sequence.Dequeue();
                Console.Write($"{currentNumber} ");

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue(2 * currentNumber + 1);
                sequence.Enqueue(currentNumber + 2);

                count += 3;
            }
        }
    }
}
