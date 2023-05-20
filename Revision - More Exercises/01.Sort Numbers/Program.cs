using System;
using System.ComponentModel.Design;
using System.Threading;

namespace _01.Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int max = 0;
            int mid = 0;
            int min = 0;

            if(num1 > num2 && num1 > num3)
            {
                max = num1;
                if (num2 > num3)
                {
                    mid = num2;
                    min = num3;
                }
                else
                {
                    mid = num3;
                    min = num2;
                }
                
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
                if (num1 > num3)
                {
                    mid = num1;
                    min = num3;
                }
                else
                {
                    mid = num3;
                    min = num1;
                }

            }
            else if (num3 > num1 && num3 > num2)
            {
                max = num3;
                if (num1 > num2)
                {
                    mid = num1;
                    min = num2;
                }
                else
                {
                    mid = num2;
                    min = num1;
                }

            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);


        }
    }
}
