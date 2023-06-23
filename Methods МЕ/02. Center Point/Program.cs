using Microsoft.VisualBasic;
using System;

namespace _02._Center_Point
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            int result = FindPointClosestToZero(FindFirstPoint(x1, y1), FindSecondPoint(x2, y2));
            if (result < 0)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (result > 0)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        static int FindPointClosestToZero(double result1, double result2)
        {
            if (result1 < result2)
            {
                return -1;
            }
            else if (result2 < result1)
            {
                return 1;
            }
            return 0;
        }
        static double FindFirstPoint(double x1, double y1)
        {
            double result = Math.Sqrt(Math.Abs(Math.Pow(x1,2)) + Math.Abs(Math.Pow(y1, 2)));
            return result;
        }

       static double FindSecondPoint(double x2, double y2)
        {
            double result = Math.Sqrt(Math.Abs(Math.Pow(x2, 2)) + Math.Abs(Math.Pow(y2, 2)));
            return result;
        }


    }
}