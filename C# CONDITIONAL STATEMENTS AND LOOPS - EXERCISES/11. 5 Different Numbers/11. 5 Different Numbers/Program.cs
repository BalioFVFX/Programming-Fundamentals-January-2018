using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool satisfiedCondition = false;

            for (int firstNumber = a; firstNumber <= b; firstNumber++)
            {
                for (int secondNumber = a; secondNumber <= b; secondNumber++)
                {
                    for (int thirdNumber = a; thirdNumber <= b; thirdNumber++)
                    {
                        for (int fourthNumber = a; fourthNumber <= b; fourthNumber++)
                        {
                            for (int fifthNumber = a; fifthNumber <= b; fifthNumber++)
                            {
                                if(a <= firstNumber && firstNumber < secondNumber && secondNumber < thirdNumber && thirdNumber < fourthNumber && fourthNumber < fifthNumber && fifthNumber <= b)
                                {
                                    Console.WriteLine($"{firstNumber} {secondNumber} { thirdNumber} { fourthNumber} { fifthNumber}");
                                    satisfiedCondition = true;
                                }
                            }
                        }
                    }
                }
            }
            if(satisfiedCondition == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
