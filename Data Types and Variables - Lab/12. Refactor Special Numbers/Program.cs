using System;
using System.Xml.Linq;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                int sum = 0;
                int digit = number;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }

                bool flag = false;

                flag = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", number, flag);

            }
        }
    }
}
