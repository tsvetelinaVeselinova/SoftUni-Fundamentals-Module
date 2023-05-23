using System;

namespace _04._Refact._Prime_Checker
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int range = int.Parse(Console.ReadLine());

            for (int num = 2; num <= range; num++)
            {
                bool flag = true;
                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {flag.ToString().ToLower()}");
            }
        }
    }
}
