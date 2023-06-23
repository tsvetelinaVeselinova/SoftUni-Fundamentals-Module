using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = Console.ReadLine().Split(", ").ToList();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] tokens = command.Split(" - ").ToArray();

                if (tokens[0] == "Collect")
                {
                    string item = tokens[1];
                    if (!collectingItems.Contains(item))
                    {
                        collectingItems.Add(item);
                    }
                }
                else if (tokens[0] == "Drop")
                {
                    string item = tokens[1];
                    if (collectingItems.Contains(item))
                    {
                        collectingItems.Remove(item);
                    }
                }
                else if (tokens[0] == "Combine Items")
                {
                    string[] oldNew = tokens[1].Split(":").ToArray();
                    string oldItem = oldNew[0];
                    string newItem = oldNew[1];

                    if (collectingItems.Contains(oldItem))
                    {
                        int oldItemIndex = collectingItems.IndexOf(oldItem);
                        collectingItems.Insert(oldItemIndex + 1, newItem);
                    }

                }
                else if (tokens[0] == "Renew")
                {
                    string item = tokens[1];
                    if (collectingItems.Contains(item))
                    {
                        string temp = item;
                        collectingItems.Remove(item);
                        collectingItems.Add(temp);
                    }
                }
            }

            Console.WriteLine(string.Join(", ",collectingItems));
        }
    }
}
