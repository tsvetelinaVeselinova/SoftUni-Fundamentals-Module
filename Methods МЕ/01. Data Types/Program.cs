using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            string input = Console.ReadLine();

            Console.WriteLine(Result(type, input));
        }


        static string Result(string type, string input)
        {
            string result = "";
            if (type == "int")
            {
                int number = int.Parse(input) * 2;
                result = number.ToString();

            }
            else if (type == "real")
            {
                double number = double.Parse(input) * 1.5;
                result = $"{number:f2}";
            }
            else if (type == "string")
            {
                result = $"${input}$";
            }

            return result;
        }
    }
}

