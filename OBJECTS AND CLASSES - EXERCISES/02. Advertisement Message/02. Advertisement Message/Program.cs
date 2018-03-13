using System;

namespace _02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                message += phrases[rnd.Next(0, phrases.Length)];
                message += " ";
                message += events[rnd.Next(0, events.Length)];
                message += " ";
                message += authors[rnd.Next(0, authors.Length)];
                message += " ";
                message += cities[rnd.Next(0, cities.Length)];
                message += " ";
            }

            message = message.Remove(message.Length - 1);
            Console.WriteLine(message);


        }
    }
}
