using System;
using System.Collections.Generic;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            string name = string.Empty;
            int counter = 1;

            while (true)
            {
               if(counter % 2 == 0)
                {
                    string email = Console.ReadLine();
                    if(email.EndsWith("us") == false)
                    {
                        users.Add(name, email);
                    }
                }
                else
                {
                    name = Console.ReadLine();
                    if(name == "stop")
                    {
                        break;
                    }
                }
                counter++;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}
