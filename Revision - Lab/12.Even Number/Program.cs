using System;
using System.Security.Cryptography;

namespace _12.Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Create a program that reads a sequence of numbers. If the number is even, print its absolute value in the
        //followin format: "The number is: {number}" and terminate the program. If the number is odd, print
        //"Please write an even number." and continue reading numbers.

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(n)}");
        
            }

            while (n % 2 != 0)
            {

                Console.WriteLine("Please write an even number.");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
        }
    }
}
