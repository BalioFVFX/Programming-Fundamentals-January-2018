using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._9_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedDictionary<string, long> items = new SortedDictionary<string, long>();
            SortedDictionary<string, long> junks = new SortedDictionary<string, long>();

            bool shadowmourneWin = false;
            bool valanyrWin = false;
            bool dragonwrathWin = false;

            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);

            while (shadowmourneWin == false && valanyrWin == false && dragonwrathWin == false)
            {
                List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
                if(input.Count % 2 != 0)
                {
                    input = Console.ReadLine().ToLower().Split(' ').ToList();
                    continue;
                }

                for (int i = 0; i < input.Count; i += 2)
                {
                    if (items.ContainsKey(input[i + 1]) == false && input[i + 1] == "motes" && input[i + 1] == "shards" && input[i + 1] == "fragments")
                    {
                    
                    items.Add(input[i + 1], long.Parse(input[i]));
                        
                    }
                    else if(junks.ContainsKey(input[i + 1]) == false && input[i + 1] != "motes" && input[i + 1] != "shards" && input[i + 1] != "fragments")
                    {
                        junks.Add(input[i + 1], long.Parse(input[i]));
                    }
                    else
                    {
                        if (input[i + 1] == "shards" || input[i + 1] == "fragments" || input[i + 1] == "motes")
                        {
                            items[input[i + 1]] += long.Parse(input[i]);
                        }
                        else
                        {
                            junks[input[i + 1]] += long.Parse(input[i]);
                        }

                    }


                    if (items.ContainsKey("shards") && items["shards"] >= 250)
                    {
                        items["shards"] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        shadowmourneWin = true;
                        break;
                    }
                    else if (items.ContainsKey("fragments") && items["fragments"] >= 250)
                    {
                        items["fragments"] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        valanyrWin = true;
                        break;
                    }
                    else if (items.ContainsKey("motes") && items["motes"] >= 250)
                    {
                        items["motes"] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        dragonwrathWin = true;
                        break;
                    }
                }

            }


            foreach (var item in items.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
