using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                int passengers = 0;
                bool successParse = int.TryParse(input, out passengers);
                if (successParse)
                {
                    for (int i = 0; i < wagons.Capacity; i++)
                    {
                        if (passengers + wagons[i] <= capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    List<string> command = input.Split().ToList();
                    if (command[0] == "Add")
                    {
                        int wagon = int.Parse(command[1]);
                        wagons.Add(wagon);
                    }
                }               
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
