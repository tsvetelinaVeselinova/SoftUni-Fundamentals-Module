using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
          char firstSymbol = char.Parse(Console.ReadLine());
          char secondSymbol = char.Parse(Console.ReadLine());
          char thirdSymbol = char.Parse(Console.ReadLine());

            Console.Write($"{firstSymbol}{secondSymbol}{thirdSymbol}");

        }
    }
}
