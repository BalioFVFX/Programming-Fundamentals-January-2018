using System;

namespace _09._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteeger = int.Parse(Console.ReadLine());
            int times = 1;
            int result = 0;
            do
            {
                result = theInteeger * times;

                Console.WriteLine($"{theInteeger} X {times} = {result}");

                times++;
            } while (times <= 10);
        }
    }
}
