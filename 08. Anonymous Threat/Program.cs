using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split();
                if (command[0] == "merge")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);
                    if (end >= list.Count)
                    {
                        end = list.Count - 1;
                    }
                    if (start >= list.Count)
                    {
                        start = list.Count - 1;
                    }
                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end < 0)
                    {
                        end = 0;
                    }
                    for (int i = start + 1; i <= end; i++)
                    {
                        list[start] += list[i];

                    }
                    list.RemoveRange(start + 1, end - start);
                }
                else if (command[0] == "divide" && int.Parse(command[2]) > 0)
                {
                    int start = int.Parse(command[1]);
                    int parts = int.Parse(command[2]);
                    string devidable = list[start];
                    list.RemoveAt(start);
                    for (int i = 0; i < parts; i++)
                    {
                        if (i == parts - 1)
                        {
                            list.Insert(start + i, (devidable.Substring(i * devidable.Length / parts)));
                        }
                        else
                            list.Insert(start + i, (devidable.Substring(i * devidable.Length / parts, devidable.Length / parts)));
                    }
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
 
//namespace ConsoleApp10
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> input = Console.ReadLine().Split().ToList();

//            while (true)
//            {
//                string[] commands = Console.ReadLine().Split();
//                string command = commands[0];
//                if (command == "3:1")
//                {
//                    break;
//                }
//                int startIndex = int.Parse(commands[1]);
//                int endIndex = int.Parse(commands[2]);
//                string concatWord = string.Empty;
//                if (endIndex > input.Count - 1 || endIndex < 0)
//                {
//                    endIndex = input.Count - 1;
//                }
//                if (startIndex < 0 || startIndex > input.Count)
//                {
//                    startIndex = 0;
//                }

//                if (command == "merge")
//                {
//                    for (int i = startIndex; i <= endIndex; i++)
//                    {
//                        concatWord += input[i];
//                    }
//                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
//                    input.Insert(startIndex, concatWord);
//                }
//                else if (command == "divide")
//                {
//                    List<string> divided = new List<string>();
//                    int divide = int.Parse(commands[2]);
//                    string word = input[startIndex];
//                    input.RemoveAt(startIndex);
//                    int parts = word.Length / divide;
//                    for (int i = 0; i < divide; i++)
//                    {
//                        if (i == divide - 1)
//                        {
//                            divided.Add(word.Substring(i * parts));
//                        }
//                        else
//                        {
//                            divided.Add(word.Substring(i * parts, parts));
//                        }
//                        // string element = word.Substring(0, parts);
//                        // word = word.Substring(parts);
//                        // divided.Add(element);
//                    }
//                    input.InsertRange(startIndex, divided);
//                }
//            }
//            Console.WriteLine(string.Join(" ", input));
//        }
//    }
//}