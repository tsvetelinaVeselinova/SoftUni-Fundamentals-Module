using System;

namespace __07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = NxNMatrix(n);
            Console.WriteLine(result);
        }

        static string NxNMatrix(int n)
        {
            string result = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    result += $"{n} ";
                }

                result += "\n";
            }

            return result;
        }
    }
}