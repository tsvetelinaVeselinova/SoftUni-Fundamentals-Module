using System;
using System.Collections.Generic;

namespace _01._1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            ushort firstNumber = ushort.Parse(Console.ReadLine());
            ushort secondNumber = ushort.Parse(Console.ReadLine());
            ushort thirdNumber = ushort.Parse(Console.ReadLine());
            ushort fourthNumber = ushort.Parse(Console.ReadLine());

            ushort firstOperation = (ushort)(firstNumber + secondNumber);
            ushort secondOperation = (ushort)(firstOperation / thirdNumber);
            ushort thirdOperation = (ushort)(secondOperation * fourthNumber);

            Console.WriteLine(thirdOperation);

        }
    }
}
