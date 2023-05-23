using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double fisrtNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal = true;

            if(Math.Abs(fisrtNumber - secondNumber) >= eps)
            {
                equal = false;
                Console.WriteLine(equal);
            }
            else
            {
                Console.WriteLine(equal);
            }
           
        }
    }
}
