using System;

namespace _10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int theInteeger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
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
