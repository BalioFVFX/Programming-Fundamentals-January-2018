using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char firstLetterCounter = firstLetter; firstLetterCounter <= secondLetter; firstLetterCounter++)
            {
                for (char secondLetterCounter = firstLetter; secondLetterCounter <= secondLetter; secondLetterCounter++)
                {
                    for (char thirdLetterCounter = firstLetter; thirdLetterCounter <= secondLetter; thirdLetterCounter++)
                    {
                        if(firstLetterCounter != thirdLetter && secondLetterCounter != thirdLetter && thirdLetterCounter != thirdLetter)
                        {
                            Console.Write($"{firstLetterCounter}{secondLetterCounter}{thirdLetterCounter} ");
                        }
                    }
                }
            }
        }
    }
}
