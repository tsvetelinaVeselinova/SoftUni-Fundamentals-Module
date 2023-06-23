using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "course start")
            {
                
                List<string> arguments = commands.Split(":").ToList();

                switch (arguments[0])
                {
                    case "Add":
                        Add(schedule, arguments[1]);
                        break;
                    case "Insert":
                        Insert(schedule, arguments[1], int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        Remove(schedule, arguments[1]);
                        break;
                    case "Swap":
                        Swap(schedule, arguments[1], arguments[2]);
                        break;
                    case "Exercise":
                        Exercise(schedule, arguments[1]);
                        break;

                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static List<string> Exercise(List<string> schedule, string title)
        {

            if (!schedule.Contains(title))
            {
                Add(schedule, title);
            }
            string execiseTitle = $"{title}-Exercise";
            if (schedule.Contains(title) && !schedule.Contains(execiseTitle))
            {
                int titleIndex = schedule.IndexOf(title);
                Insert(schedule, execiseTitle, titleIndex + 1);
            }
            return schedule;
        }

        static List<string> Swap(List<string> schedule, string titleOne, string titleTwo)
        {
        
            if ((schedule.Contains(titleOne)) && schedule.Contains(titleTwo))
            {
                int fistTitleIndex = schedule.IndexOf(titleOne);
                int secondTitleIndex = schedule.IndexOf(titleTwo);

                string temp = schedule[fistTitleIndex];
                schedule[fistTitleIndex] = schedule[secondTitleIndex];
                schedule[secondTitleIndex] = temp;

                schedule = SwapExercise(schedule, titleOne, secondTitleIndex);
                schedule = SwapExercise(schedule, titleTwo, fistTitleIndex);


            }

            return schedule;
        }

       static List<string> SwapExercise(List<string> schedule, string title, int titleIndex)
        {
            string execiseTitle = $"{title}-Exercise";
            int exerciseIndex = schedule.IndexOf(execiseTitle);

            if (exerciseIndex >= 0)
            {
                Remove(schedule, execiseTitle);
                Insert(schedule, execiseTitle, titleIndex + 1);
            }
            return schedule;
        }

        static List<string> Remove(List<string> schedule, string title)
        {
            if (schedule.Contains(title))
            {
                schedule.Remove(title);
            }
            string execiseTitle = $"{title}-Exercise";
            int exerciseIndex = schedule.IndexOf(execiseTitle);

            if (exerciseIndex >= 0)
            {
                Remove(schedule, execiseTitle);
            }
            return schedule;
        }

        static List<string> Insert(List<string> schedule, string title, int index)
        {
            if (!schedule.Contains(title))
            {
                schedule.Insert(index, title);
            }
            return schedule;
        }
        
        static List<string> Add(List<string> schedule, string title)
        {
            if (schedule.Contains(title) == false)
            {
                schedule.Add(title);
            }
            return schedule;
        }
    }
}

