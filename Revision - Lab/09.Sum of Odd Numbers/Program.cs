﻿using System;

namespace _09.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(num);
                sum += num;
                num += 2;

            }

            Console.WriteLine($"Sum: {sum}");


        }
    }
}
