using System;

namespace _10.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string input = string.Empty;
            int integer;
            float floatingPoint;
            char character;
            bool isBoolean;

            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatingPoint))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out isBoolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
               
            }
        }
    }
}