using System;
using System.Reflection.Metadata;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                int firstNumber = int.Parse(numbers[0]);
                int secondNumber = int.Parse(numbers[1]);

                if (i % 2 == 0)
                {
                    arr1[i] += firstNumber;
                    arr2[i] += secondNumber;

                }
                else
                {
                    arr2[i] += firstNumber;
                    arr1[i] += secondNumber;
                }
            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));

        }
    }
}
