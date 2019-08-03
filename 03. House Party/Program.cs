using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                if (input[2] == "going!")
                {
                    if (guests.Contains(input[0]))
                    {
                        Console.WriteLine("{0} is already in the list!", input[0]);
                    }
                    else
                    {
                        guests.Add(input[0]);
                    }                   
                }
                else if (input[2] == "not")
                {
                    if (guests.Contains(input[0]))
                    {
                        guests.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not in the list!", input[0]);
                    }
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
