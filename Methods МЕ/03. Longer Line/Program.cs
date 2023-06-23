using Microsoft.VisualBasic;
using System;

namespace _03._Longer_Line
{
    class CenterPoint
    {
        class Program
        {
            static void Main()
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                double x3 = double.Parse(Console.ReadLine());
                double y3 = double.Parse(Console.ReadLine());
                double x4 = double.Parse(Console.ReadLine());
                double y4 = double.Parse(Console.ReadLine());

                LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
            }

            static void FindClosestToZero(double a, double b, double c, double d)
            {
                double first = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                double second = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));
                if (first > second)
                {
                    Console.WriteLine($"({c}, {d})({a}, {b})");
                }
                else
                {
                    Console.WriteLine($"({a}, {b})({c}, {d})");
                }
            }

            static void LongestLine(double a, double b, double c, double d, double e, double f,
                                         double g, double h)
            {
                double firstLine = Math.Sqrt(Math.Pow((a - c), 2) + Math.Pow((b - d), 2));
                double secondLine = Math.Sqrt(Math.Pow((e - g), 2) + Math.Pow((f - h), 2));
                if (firstLine >= secondLine)
                {
                    FindClosestToZero(a, b, c, d);
                }
                else
                {
                    FindClosestToZero(e, f, g, h);
                }
            }


        }
    }
}
