using System;
using System.Reflection.Metadata.Ecma335;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a, @operator, b));
        }

        static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = a / (double)b;
                    break;
                case "*":
                    result = a * (double)b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }      
            return result;
        }

        
    }
}
