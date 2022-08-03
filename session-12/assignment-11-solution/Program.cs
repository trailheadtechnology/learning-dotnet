using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            string itemName = "";
            if (args.Length > 0) command = args[0].ToLower().Trim();

            switch (command)
            {
                case "add":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Missing item name");
                        return;
                    }
                    itemName = args[1];
                    Console.WriteLine(ToDoCommands.Add(itemName));
                    break;
                case "list":
                    Console.WriteLine(ToDoCommands.List());
                    break;
                case "complete":
                    if (args.Length < 2) throw new ArgumentException("Missing item name");
                    itemName = args[1];
                    Console.WriteLine(ToDoCommands.Complete(itemName));
                    break;
                case "incomplete":
                    if (args.Length < 2) throw new ArgumentException("Missing item name");
                    itemName = args[1];
                    Console.WriteLine(ToDoCommands.Incomplete(itemName));
                    break;
                default:
                    Console.WriteLine(ToDoCommands.Help());
                    break;
            }
        }
    }
}
