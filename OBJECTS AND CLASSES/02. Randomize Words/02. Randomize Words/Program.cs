using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randNum = rnd.Next(0, words.Length);
                string temp = words[i];
                string randomWord = words[randNum];
                words[i] = randomWord;
                words[randNum] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
