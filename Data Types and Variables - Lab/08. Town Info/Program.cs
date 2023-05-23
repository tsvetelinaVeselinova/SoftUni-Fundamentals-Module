using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            ushort area = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
