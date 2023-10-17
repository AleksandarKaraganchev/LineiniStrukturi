using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestotaNaSreshtaniq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                Stack<string> stack = new Stack<string>();
                stack.Push(directoryPath);

                while (stack.Count > 0)
                {
                    string currentDirectory = stack.Pop();
                    Console.WriteLine(currentDirectory);

                    string[] subdirectories = Directory.GetDirectories(currentDirectory);
                    foreach (string subdirectory in subdirectories)
                    {
                        stack.Push(subdirectory);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong way to the directory.");
            }
        }
    }
}
