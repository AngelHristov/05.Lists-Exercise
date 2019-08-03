using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('|');
            List<string> list = new List<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                List<string> list1 = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in list1)
                {
                    list.Add(item);
                }             
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
