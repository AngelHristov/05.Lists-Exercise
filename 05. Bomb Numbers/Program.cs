using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = commands[0];
            int power = commands[1];

            while (nums.Contains(bomb))
            {
                int index = nums.IndexOf(bomb);
                int start = index - power;
                int end = index + power + 1;
                if (start < 0)
                {
                    start = 0;
                }
                if (end > nums.Count)
                {
                    end = nums.Count;
                }
                nums.RemoveRange(start, end - start);
            }
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
