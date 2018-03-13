using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatSymbol = char.Parse(Console.ReadLine());
            char secondBoatSymbol = char.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            byte firstBoatPosition = 0;
            byte secondBoatPosition = 0;

            for (byte row = 1; row <= n; row++)
            {
                string word = Console.ReadLine();

                if(firstBoatPosition >= 50 || secondBoatPosition >= 50)
                {
                    continue;
                }

                if(word != "UPGRADE")
                {
                    if (row % 2 == 0)
                    {
                        secondBoatPosition += (byte)word.Length;
                    }
                    else
                    {
                        firstBoatPosition += (byte)word.Length;
                    }
                }
                else
                {
                    firstBoatSymbol += (char)3;
                    secondBoatSymbol += (char)3;
                }
            }
            if(firstBoatPosition > secondBoatPosition)
            {
                Console.WriteLine(firstBoatSymbol);
            }
            else
            {
                Console.WriteLine(secondBoatSymbol);
            }
        }
    }
}
