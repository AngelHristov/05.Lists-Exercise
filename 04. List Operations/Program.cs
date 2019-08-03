using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add": numbers.Add(int.Parse(command[1]));break;
                    case "Insert":
                        {
                            int index = int.Parse(command[2]);
                            if (index < numbers.Count && index >= 0)
                            {
                                numbers.Insert(index, int.Parse(command[1]));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }                          
                        }
                    case "Remove":
                        {
                            int index = int.Parse(command[1]);
                            if (index < numbers.Count && index >= 0)
                            {
                                numbers.RemoveAt(index);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }
                            
                        }
                    case "Shift":
                        {
                            int count = int.Parse(command[2]);
                            if (command[1] == "left")
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    numbers.Add(numbers[0]);
                                    numbers.RemoveAt(0);
                                }
                                break;
                            }
                            else if (command[1] == "right")
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    numbers.Insert(0, numbers[numbers.Count - 1]);
                                    numbers.RemoveAt(numbers.Count - 1);
                                }
                                break;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
