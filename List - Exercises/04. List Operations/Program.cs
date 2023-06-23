using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                List<string> arguments = command.Split().ToList();

                switch (arguments[0])
                {
                    case "Add":
                        AddNumber(numbers, int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[2]);
                        if (ValidIndex(numbers, index))
                        {
                            InsertNumber(numbers, index, int.Parse(arguments[1]));
                        }
                        break;
                    case "Remove":
                        index = int.Parse(arguments[1]);
                        if (ValidIndex(numbers, index))
                        {
                            RemoveAtIndex(numbers, index);
                        }
                        break;
                    case "Shift":
                        switch (arguments[1])
                        {
                            case "left":
                                int count = int.Parse(arguments[2]);
                                ShiftLeft(numbers, count);
                                break;
                            case "right":
                                count = int.Parse(arguments[2]);
                                SiftRight(numbers, count);
                                break;
                        }

                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> SiftRight(List<int> numbers, int count)
        {
            count %= numbers.Count;
            int lastIndex = numbers.Count - count;
            List<int> shifted = numbers.GetRange(lastIndex, count);
            numbers.RemoveRange(lastIndex, count);
            numbers.InsertRange(0, shifted);
            return numbers;
        }

        static List<int> ShiftLeft(List<int> numbers, int count)
        {
            count %= numbers.Count;
            List<int> shifted = numbers.GetRange(0, count);
            numbers.RemoveRange(0, count);
            numbers.InsertRange(numbers.Count, shifted);
            return numbers;
        }

        static List<int> RemoveAtIndex(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
            return numbers;
        }

        static List<int> InsertNumber(List<int> numbers, int index, int number)
        {
            numbers.Insert(index, number);
            return numbers;
        }

        static bool ValidIndex(List<int> numbers, int index)
        {
            if (index >= 0 && index < numbers.Count)
            {
                return true;
            }
            Console.WriteLine("Invalid index");
            return false;

        }

        static List<int> AddNumber(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;

        }
    }
}
