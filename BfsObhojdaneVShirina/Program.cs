using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BfsObhojdaneVShirina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string directoryPath = Console.ReadLine();
            if (Directory.Exists(directoryPath))
            {
                Queue<string> queue = new Queue<string>();
                queue.Enqueue(directoryPath);

                while (queue.Count > 0)
                {
                    string currentDirectory = queue.Dequeue();
                    Console.WriteLine(currentDirectory);

                    string[] subdirectories = Directory.GetDirectories(currentDirectory);
                    foreach (string subdirectory in subdirectories)
                    {
                        queue.Enqueue(subdirectory);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong way to the directory!.");
            }
        }
    }
}
