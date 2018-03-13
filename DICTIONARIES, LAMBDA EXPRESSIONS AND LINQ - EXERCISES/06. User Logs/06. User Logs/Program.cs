using System;
using System.Collections.Generic;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string output = string.Empty;
            SortedDictionary<string, Dictionary<string, int>> usersLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while(input[0] != "end")
            {
                input[0] = input[0].Remove(0, 3);
                input[2] = input[2].Remove(0, 5);
                if (usersLogs.ContainsKey(input[2]) == false)
                {
                    Dictionary<string, int> userInfo = new Dictionary<string, int>();
                    userInfo.Add(input[0], 1);
                    usersLogs.Add(input[2], userInfo);
                }
                else
                {
                    if (usersLogs[input[2]].ContainsKey(input[0]) == true)
                    {
                        usersLogs[input[2]][input[0]] += 1;
                    }
                    else
                    {
                        usersLogs[input[2]].Add(input[0], 1);
                    }
                }
                input = Console.ReadLine().Split(' ');
            }

            foreach (var username in usersLogs)
            {
                Console.WriteLine($"{username.Key}:");
                foreach (var userInfo in username.Value)
                {
                    output += userInfo.Key + " => " + userInfo.Value + ", ";
                }
                output = output.Remove(output.Length - 1);
                output = output.Remove(output.Length - 1);
                Console.WriteLine(output + ".");
                output = string.Empty;
            }
        }
    }
}
