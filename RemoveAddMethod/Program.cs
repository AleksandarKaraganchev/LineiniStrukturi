using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAddMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            List<int> sortedList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int nToCheck = int.Parse(Console.ReadLine());
            if (sortedList.Contains(nToCheck))
            {
                sortedList.Remove(nToCheck);
            }
            else
            {
                int i = 0;
                while (i < sortedList.Count && sortedList[i] < nToCheck)
                {
                    i++;
                }
                sortedList.Insert(i, nToCheck);
            }
            Console.WriteLine("New List: " + string.Join(" ", sortedList));
            Console.WriteLine("Input List: " + string.Join(" ", sortedList));
        }
    }
}
