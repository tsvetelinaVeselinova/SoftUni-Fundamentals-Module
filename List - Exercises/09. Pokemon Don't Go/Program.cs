using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sum = 0;

            while (distances.Count != 0)
            {
                if (index < 0)
                {
                    sum += distances[0];
                    int removedElement = distances[0];
                    distances.RemoveAt(0);
                    if (distances.Count > 0)
                    {
                        distances.Insert(0, distances[distances.Count - 1]);
                    }

                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i] <= removedElement)
                        {
                            distances[i] += removedElement;
                        }
                        else
                        {
                            distances[i] -= removedElement;
                        }
                    }
                }
                else if (index >= distances.Count)
                {
                    sum += distances[distances.Count - 1];
                    int removedElement = distances[distances.Count - 1];
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(distances[0]);
                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i] <= removedElement)
                        {
                            distances[i] += removedElement;
                        }
                        else
                        {
                            distances[i] -= removedElement;
                        }
                    }
                }
                else
                {
                    int elementAtGivenIndex = distances[index];
                    sum += elementAtGivenIndex;
                    distances.RemoveAt(index);
                    if (distances.Count == 0)
                    {
                        break;
                    }

                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i] <= elementAtGivenIndex)
                        {
                            distances[i] += elementAtGivenIndex;
                        }
                        else
                        {
                            distances[i] -= elementAtGivenIndex;
                        }
                    }

                }
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }

    }
}
