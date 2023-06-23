using Microsoft.VisualBasic;
using System;
using System.Dynamic;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                string currentElement = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = currentElement;

            }

            Console.WriteLine(string.Join(" ",input));


        }
    }
}
