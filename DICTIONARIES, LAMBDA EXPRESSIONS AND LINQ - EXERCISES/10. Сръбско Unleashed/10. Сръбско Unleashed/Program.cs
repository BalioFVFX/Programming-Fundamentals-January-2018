using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static string getName(string str)
        {
            string name = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                name += str[i];
            }


            return name;
        }

        static string getPlace(string str)
        {
            string place = string.Empty;
            int startPosition = str.IndexOf('@');
            startPosition++;
            for (int i = startPosition; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    break;
                }
                place += str[i];
            }
            place = place.Remove(place.Length - 1);

            return place;
        }

        static int getNumbers(List<string> inputList)
        {
            int number = 0;
            while (number == 0)
            {


                try
                {
                    foreach (var item in inputList)
                    {
                        number = int.Parse(item);
                        inputList.RemoveAt(0);
                        break;
                    }

                }
                catch (Exception)
                {
                    inputList.RemoveAt(0);
                }
            }
            return number;

        }

        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> places = new Dictionary<string, Dictionary<string, int>>();


            string input = Console.ReadLine();


            while (input.StartsWith("End") == false)
            {
                List<string> inputList = input.Split(' ').ToList();
                if(inputList.Count < 4)
                {
                    input = Console.ReadLine();
                    continue;
                }
                    string name = getName(input);
                if (name.Contains("@"))
                {
                    input = Console.ReadLine();
                    continue;
                }
                    if (name.EndsWith(" ") == true)
                    {
                        name = name.Remove(name.Length - 1);
                        

                        string place = getPlace(input);

                        int ticketPrice = getNumbers(inputList);
                        int ticketCount = getNumbers(inputList);

                        if (places.ContainsKey(place) == false)
                        {
                            Dictionary<string, int> placeInfo = new Dictionary<string, int>();
                            int sales = ticketCount * ticketPrice;
                            placeInfo.Add(name, sales);
                            places.Add(place, placeInfo);
                        }
                        else
                        {
                            Dictionary<string, int> placeInfo = new Dictionary<string, int>();
                            int sales = ticketCount * ticketPrice;
                            placeInfo.Add(name, sales);

                            if (places[place].ContainsKey(name) == false)
                            {
                                places[place].Add(name, sales);
                            }
                            else
                            {
                                places[place][name] += sales;
                            }
                        }
                        
                }
                input = Console.ReadLine();
            }

            foreach (var place in places)
            {
                Console.WriteLine(place.Key);
                foreach (var person in place.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {person.Key} -> {person.Value}");
                }
            }

        }
    }
}