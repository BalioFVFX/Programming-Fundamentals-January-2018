using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ');


            while(command[0] != "print")
            {

                if(command[0] == "add")
                {
                    numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }

                else if (command[0] == "addMany")
                {
                    int insertPosition = int.Parse(command[1]);
                    for (int i = 2; i < command.Length; i++)
                    {
                        numbers.Insert(insertPosition, int.Parse(command[i]));
                        insertPosition++;
                    }
                }

                else if(command[0] == "contains")
                {
                    if(numbers.Contains(int.Parse(command[1])) == true)
                    {
                        Console.WriteLine(numbers.IndexOf(int.Parse(command[1])));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                else if(command[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                
                else if(command[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        int firstNumber = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Insert(numbers.Count, firstNumber);
                    }
                }

                else if(command[0] == "sumPairs")
                {
                    string numbersStr = string.Empty;
                    while(numbers.Count != 0)
                    {
                        if(numbers.Count == 1)
                        {
                            numbersStr += numbers[0] + " ";
                            numbers.Remove(0);
                            break;
                        }
                        numbersStr += (numbers[0] + numbers[1]).ToString() + " ";
                        numbers.RemoveAt(0);
                        numbers.RemoveAt(0);
                    }
                    numbersStr = numbersStr.Remove(numbersStr.Length - 1);
                    numbers = numbersStr.Split(' ').Select(int.Parse).ToList();
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
     
        }
    }
}
