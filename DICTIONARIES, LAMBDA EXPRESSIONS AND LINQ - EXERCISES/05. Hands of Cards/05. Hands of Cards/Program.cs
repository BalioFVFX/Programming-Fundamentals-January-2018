using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static int calculateHand(string currentCard, string currentMultiplier)
        {
            int multiplier = 0;
            int points = 0;

            switch (currentMultiplier)
            {
                case "S":
                    multiplier = 4;
                    break;
                case "H":
                    multiplier = 3;
                    break;
                case "D":
                    multiplier = 2;
                    break;
                case "C":
                    multiplier = 1;
                    break;
                default:
                    break;
            }

            switch (currentCard)
            {
                case "2":
                    points += 2 * multiplier;
                    break;
                case "3":
                    points += 3 * multiplier;
                    break;
                case "4":
                    points += 4 * multiplier;
                    break;
                case "5":
                    points += 5 * multiplier;
                    break;
                case "6":
                    points += 6 * multiplier;
                    break;
                case "7":
                    points += 7 * multiplier;
                    break;
                case "8":
                    points += 8 * multiplier;
                    break;
                case "9":
                    points += 9 * multiplier;
                    break;
                case "10":
                    points += 10 * multiplier;
                    break;
                case "J":
                    points += 11 * multiplier;
                    break;
                case "Q":
                    points += 12 * multiplier;
                    break;
                case "K":
                    points += 13 * multiplier;
                    break;
                case "A":
                    points += 14 * multiplier;
                    break;
                default:
                    break;
            }

            return points;
        }
        static Dictionary<string, int> calculatePoints(Dictionary<string, List<string>> hand, string name)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            string currentCard = string.Empty;
            string currentMultiplier = string.Empty;
            string currentHand = string.Empty;
            foreach (var card in hand)
            {
                int points = 0;
                string[] word = card.Value.ToArray();
                for (int i = 0; i < word.Length; i++)
                {
                    currentHand = word[i].ToString();
                    if (currentHand.Contains("10"))
                    {
                        currentCard = currentHand[0].ToString() + currentHand[1].ToString(); ;
                        currentMultiplier = currentHand[2].ToString();
                        points += calculateHand(currentCard, currentMultiplier);
                    }
                    else
                    {
                        currentCard = currentHand[0].ToString();
                        currentMultiplier = currentHand[1].ToString();
                        points += calculateHand(currentCard, currentMultiplier);
                    }

                }
                string[] currentName = card.Key.Split(new char[] { ':'});
                results.Add(currentName[0], points);
            }

            return results;
        }

        static List<string> getCards(List<string> cards)
        {
            cards.RemoveAt(0);
            return cards;
            
        }

        static void startGame(Dictionary<string, List<string>> hand)
        {

            string inputStr = Console.ReadLine();
            List<string> input = new List<string>();
            string[] nameе = inputStr.Split(':');
            input = inputStr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            input[0] = nameе[0];
            while (input[0] != "JOKER")
            {
                if (hand.ContainsKey(input[0]) == true)
                {
                    string name = input[0];
                    input.RemoveAt(0);
                    foreach (var card in input)
                    {
                        hand[name].Add(card);
                    }
                }
                else
                {
                    hand.Add(input[0], getCards(input));
                }
                inputStr = Console.ReadLine();
                nameе = inputStr.Split(':');
                input = inputStr.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                input[0] = nameе[0];
            }
        }

        static Dictionary<string, List<string>> discardCards(Dictionary<string, List<string>> hand)
        {
            Dictionary<string, List<string>> cardsDictionary = new Dictionary<string, List<string>>();

            foreach (var cards in hand)
            {
                cardsDictionary.Add(cards.Key, cards.Value.Distinct().ToList());
            }

            return cardsDictionary;
        }

        static void printResults(Dictionary<string,int> results)
        {
            foreach (var player in results)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
        static void Main(string[] args)
        {


            Dictionary<string, List<string>> hand = new Dictionary<string, List<string>>();
            Dictionary<string, int> results = new Dictionary<string, int>();
            string name = string.Empty;
            startGame(hand);
            hand = discardCards(hand);
            results = calculatePoints(hand, name);
            printResults(results);

    
        }
    }
}
