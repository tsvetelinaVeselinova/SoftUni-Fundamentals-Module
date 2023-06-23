using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split().ToList();
            string commands = String.Empty;

            while ((commands = Console.ReadLine()) != "3:1")
            {
                string[] arguments = commands.Split();

                switch (arguments[0])
                {
                    case "merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        array = Merge(array, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        array = Divide(array, index, partitions);
                        break;
                }
            }



            Console.WriteLine(string.Join(" ", array));
        }
        
        static List<string> Divide(List<string> array, int index, int partitions)
        {
            string substring = array[index];

            if (partitions <= 0)
            {
                return array;
            }
            array.RemoveRange(index, 1);
            int partsLength =  substring.Length / partitions;
            int remainingSubstrings = substring.Length % partitions;

            List<string> newSubstrings = new List<string>();

            int substringIndex = 0;

            for (int i = 0; i < partitions; i++)
            {
                string newSubstring = String.Empty;
                for (int j = 0; j < partsLength; j++)
                {
                    newSubstring += substring[substringIndex];
                    substringIndex++;
                }
                newSubstrings.Add(newSubstring);
            }

            if (remainingSubstrings > 0 && newSubstrings.Count > 0)
            {
                for (int i = substringIndex; i < substring.Length; i++)
                {
                    newSubstrings[newSubstrings.Count - 1] += substring[i];
                }
            }
            array.InsertRange(index, newSubstrings);
            return array;
        }

        static List<string> Merge(List<string> array, int startIndex, int endIndex)
        {
            startIndex = Clamp(startIndex, 0, array.Count);
            endIndex = Clamp(endIndex, 0, array.Count - 1);

            string mergedSubstrings = string.Join("",array.GetRange(startIndex, endIndex - startIndex + 1));
            array.RemoveRange(startIndex,endIndex - startIndex + 1);
            array.Insert(startIndex, mergedSubstrings);

            return array;
        }
        
        static int Clamp(int index, int min, int max)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index > max)
            {
                index = max;
            }
            return index;
        }
    }
}
