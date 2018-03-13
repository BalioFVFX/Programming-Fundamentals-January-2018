using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, long> resources = new Dictionary<string, long>();
            int counter = 1;
            long quantity = 0;
            string resourceStr = string.Empty;
            while(true)
            {
                if(counter % 2 == 0)
                {
                    resources[resourceStr] += long.Parse(Console.ReadLine());
                }
                else
                {
                    resourceStr = Console.ReadLine();
                    if(resourceStr == "stop")
                    {
                        break;
                    }
                    if(resources.ContainsKey(resourceStr) == false)
                    {
                        resources.Add(resourceStr, 0);
                    }

                }
                counter++;
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
