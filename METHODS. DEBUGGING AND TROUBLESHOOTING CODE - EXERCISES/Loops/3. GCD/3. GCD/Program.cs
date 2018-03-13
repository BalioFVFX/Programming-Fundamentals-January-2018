using System;

namespace _3._GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (true)
            {
                int answer = a % b;
                int answerb = 0;
                if(answer == 0)
                {
                    Console.WriteLine(b);
                    return;
                }

                if(b % answer == 0)
                {
                    Console.WriteLine(answer);
                    return;
                }
                else
                {
                    answerb = b % answer;
                }
                
                if(answer % answerb == 0)
                {
                    Console.WriteLine(answerb);
                    return;
                }
                a = answer;
                b = answerb;
            }
        }
    }
}
