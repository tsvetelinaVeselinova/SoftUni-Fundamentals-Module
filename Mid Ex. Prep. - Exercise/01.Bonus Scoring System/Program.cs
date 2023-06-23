using System;

namespace _01.Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsNum = int.Parse(Console.ReadLine());
            int lecturesNum = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double bestBonus = 0;
            int bestattendances = 0;


            for (int i = 1; i <= studentsNum; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double bonus = ((double)attendances / lecturesNum) * (5 + additionalBonus);
                if (bonus > bestBonus)
                {
                    bestBonus = bonus;
                    bestattendances = attendances;

                }
            }

            Console.WriteLine($"Max Bonus: {(int)Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {bestattendances} lectures.");
        }
    }
}
