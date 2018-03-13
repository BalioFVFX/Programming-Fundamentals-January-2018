using System;

namespace _07._Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumeralType = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            long numeralTypeMax = 0;
            long thiefID = long.MinValue;


            long years = 0;

            switch (inputNumeralType)
            {
                case "sbyte":
                    numeralTypeMax = sbyte.MaxValue;
                    break;
                case "int":
                    numeralTypeMax = int.MaxValue;
                    break;
                case "long":
                    numeralTypeMax = long.MaxValue;
                    break;
                default:
                    break;
            }

            for (byte i = 0; i < n; i++)
            {
                long currentID = long.Parse(Console.ReadLine());
                if(currentID > thiefID && currentID <= numeralTypeMax)
                {
                    thiefID = currentID;
                }
            }

            if(thiefID <= -1)
            {
                years = (long)Math.Ceiling(Math.Abs((double)thiefID / sbyte.MinValue));
            }
            else
            {
                years = (long)Math.Ceiling((double)thiefID / sbyte.MaxValue);
            }
            if(years == 1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to { years} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {years} years");
            }
        }
    }
}
