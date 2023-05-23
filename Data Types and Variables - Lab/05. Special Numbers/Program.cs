using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            bool b = false;
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    b = true;
                }
                Console.WriteLine($"{num} -> {b}");
                b = false;
            }

        }
    }
}
