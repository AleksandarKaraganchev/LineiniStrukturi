using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrushtaneNaChislaSusSteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string inp = Console.ReadLine();
            string[] numbersString = inp.Split(' ');
            Stack<int> steck = new Stack<int>();
            foreach (var item in numbersString)
            {
                if (int.TryParse(item, out int number))
                {
                    steck.Push(number);
                }
            }
            while (steck.Count > 0)
            {
                int num = steck.Pop();
                Console.Write(num + " ");
            }
        }
    }
}
