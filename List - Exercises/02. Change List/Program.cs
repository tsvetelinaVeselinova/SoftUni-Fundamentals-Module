using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split().ToArray();

                if (arguments[0] == "Delete")
                {
                    int element = int.Parse(arguments[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (arguments[0] == "Insert")
                {
                    int element = int.Parse(arguments[1]);
                    int position = int.Parse(arguments[2]);
                    numbers.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
