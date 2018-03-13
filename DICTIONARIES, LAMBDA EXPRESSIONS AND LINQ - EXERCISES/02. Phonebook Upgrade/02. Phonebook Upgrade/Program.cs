using System;
using System.Collections.Generic;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else if (command[0] == "S")
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
                else if(command[0] == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine(contact.Key + " -> " + contact.Value);
                    }
                }

                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
