using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool areDifferent = false;

            for(int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i];
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areDifferent = true;
                    break;
                }
            }

            if(areDifferent == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
