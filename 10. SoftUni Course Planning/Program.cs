using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":").ToArray();
                switch (commands[0])
                {
                    case "Add":
                        {
                            if (!lessons.Contains(commands[1]))
                            {
                                lessons.Add(commands[1]);
                            }
                            break;
                        }
                    case "Insert":
                        {
                            if (!lessons.Contains(commands[1]) && int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < lessons.Count)
                            {
                                lessons.Insert(int.Parse(commands[2]), commands[1]);
                            }
                            break;
                        }
                    case "Remove":
                        {
                            if (lessons.Contains(commands[1]))
                            {
                                lessons.Remove(commands[1]);
                            }
                            if (lessons.Contains(commands[1] + "-Exercise"))
                            {
                                lessons.Remove(commands[1] + "-Exercise");
                            }
                            break;
                        }
                    case "Swap":
                        {
                            if (lessons.Contains(commands[1]) && lessons.Contains(commands[2]))
                            {
                                int index1 = lessons.IndexOf(commands[1]);
                                int index2 = lessons.IndexOf(commands[2]);
                                string temp = commands[1];
                                lessons[index1] = commands[2];
                                lessons[index2] = temp;
                                if (lessons.Contains(commands[1] + "-Exercise"))
                                {
                                    lessons.RemoveAt(lessons.IndexOf(commands[1] + "-Exercise"));
                                    if (index2 + 2 >= lessons.Count)
                                    {
                                        lessons.Add(commands[1] + "-Exercise");
                                    }
                                    else
                                    lessons.Insert(index2+1, commands[1] + "-Exercise");
                                    
                                }
                                if (lessons.Contains(commands[2] + "-Exercise"))
                                {
                                    lessons.RemoveAt(lessons.IndexOf(commands[2] + "-Exercise"));
                                    if (index1 + 2 >= lessons.Count)
                                    {
                                        lessons.Add(commands[2] + "-Exercise");
                                    }
                                    else
                                        lessons.Insert(index1 + 1, commands[2] + "-Exercise");
                                    
                                }
                            }
                            break;
                        }
                    case "Exercise":
                        {
                            if (lessons.Contains(commands[1]) && lessons.IndexOf(commands[1]) + 1 == lessons.Count)
                            {
                                lessons.Add(commands[1] + "-Exercise");
                            }
                            if (lessons.Contains(commands[1]) && !lessons.Contains(commands[1] + "-Exercise"))
                            {
                                lessons.Insert(lessons.IndexOf(commands[1]) + 1, commands[1] + "-Exercise");
                            }
                            else
                            {
                                lessons.Add(commands[1]);
                                lessons.Add(commands[1] + "-Exercise");
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
