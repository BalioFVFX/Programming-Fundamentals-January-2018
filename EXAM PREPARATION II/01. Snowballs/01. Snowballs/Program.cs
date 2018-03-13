using System;
using System.Numerics;

namespace _01._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowBallTime = 0;
            BigInteger bestSnowBallQuality = 0;
            BigInteger bestResult = 0;

            for (int i = 0; i < n; i++)
            {
                BigInteger currentSnowBallSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger currentSnowBallTime = BigInteger.Parse(Console.ReadLine());
                BigInteger currentSnowBallQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger currentResult = 0;

                currentResult = BigInteger.Pow((currentSnowBallSnow / currentSnowBallTime), (int)currentSnowBallQuality);

                if(currentResult > bestResult)
                {
                     bestSnowballSnow = currentSnowBallSnow;
                     bestSnowBallTime = currentSnowBallTime;
                     bestSnowBallQuality = currentSnowBallQuality;
                     bestResult = currentResult;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowBallTime} = {bestResult} ({bestSnowBallQuality})");
        }
    }
}
