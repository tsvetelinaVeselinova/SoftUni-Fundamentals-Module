
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').Reverse().ToList();

            for (int i = 0; i < arrays.Count; i++)
            {
                List<string> values = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


                for (int j = 0; j < values.Count; j++)
                {

                    Console.Write($"{values[j]} ");


                }
            }
        }
    }
}

