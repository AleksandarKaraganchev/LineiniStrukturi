using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiDulgaPosledovatelnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            List<int> numbers = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            int longestSequenceStart = 0;
            int longestSequenceLength = 1;
            int currentSequenceStart = 0;
            int currentSequenceLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequenceLength++;
                    if (currentSequenceLength > longestSequenceLength)
                    {
                        longestSequenceLength = currentSequenceLength;
                        longestSequenceStart = currentSequenceStart;
                    }
                }
                else
                {
                    currentSequenceStart = i;
                    currentSequenceLength = 1;
                }
            }

            List<int> longestSequence = numbers.GetRange(longestSequenceStart, longestSequenceLength);

            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
