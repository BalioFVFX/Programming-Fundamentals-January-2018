using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._8_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> users = new SortedDictionary<string, List<string>>();
            SortedDictionary<string, List<string>> results = new SortedDictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if(users.ContainsKey(input[1]) == false)
                {
                    List<string> info = new List<string>();
                    info.Add(input[2]);
                    info.Add(input[0]);
                    users.Add(input[1], info);
                }
                else
                { 
                    int time = int.Parse(users[input[1]][0]);
                    time += int.Parse(input[2]);
                    users[input[1]][0] = time.ToString();
                    users[input[1]].Add(input[0]);
                }
            }

            foreach (var user in users)
            {
                List<string> distinctedList = user.Value.Distinct().ToList();
                results.Add(user.Key, distinctedList);
            }

            foreach (var user in results)
            {
                int time = int.Parse(user.Value[0]);
                user.Value.RemoveAt(0);
                user.Value.Sort();
                Console.WriteLine($"{user.Key}: {time} [{string.Join(", ", user.Value)}]");
            }
        }
    }
}
