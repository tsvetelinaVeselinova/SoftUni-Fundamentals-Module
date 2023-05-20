using System;
using System.Runtime.Intrinsics.X86;

namespace _08.Divisible_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
