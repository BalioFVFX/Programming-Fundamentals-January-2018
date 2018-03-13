using System;
using System.Collections.Generic;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while(command[0] != "END")
            {
                if(command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else if(command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }

                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
