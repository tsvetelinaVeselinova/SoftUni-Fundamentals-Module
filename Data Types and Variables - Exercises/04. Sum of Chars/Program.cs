﻿using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;

;           }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
