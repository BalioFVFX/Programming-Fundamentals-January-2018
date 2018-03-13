using System;

namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            

            long numeralMaxValue = 0;
            long thiefID = long.MinValue;

           

            switch (numeralType)
            {
                case "sbyte":
                    numeralMaxValue = sbyte.MaxValue;
                    break;
                case "int":
                    numeralMaxValue = int.MaxValue;
                    break;
                case "long":
                    numeralMaxValue = long.MaxValue;
                    break;
                default:
                    break;
            }

            for (byte i = 0; i < n; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());

                if(currentNumber > thiefID && currentNumber <= numeralMaxValue)
                {
                    thiefID = currentNumber;
                }
               
            }
            Console.WriteLine(thiefID);
        }
    }
}
