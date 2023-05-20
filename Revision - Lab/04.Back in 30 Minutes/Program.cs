using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace _04.Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 59)
            {
                minutes -= 60;
                hours++;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");



        }
    }
}
