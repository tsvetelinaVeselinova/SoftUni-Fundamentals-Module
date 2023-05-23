using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "1";
            bool osem = false;
            bool.TryParse(text, out osem);

            Console.WriteLine(osem);

        }
    }
}
