using System;

namespace _04._Numbers
{
    class Program
    {
        static decimal NumberReverser(decimal number)
        {
            string oldNumberStr = number.ToString();
            string newNumberStr = string.Empty;
            decimal numberLength = oldNumberStr.Length;

            for (int i = 0; i < numberLength; i++)
            {
                newNumberStr += oldNumberStr.Substring(oldNumberStr.Length - 1);
                oldNumberStr = oldNumberStr.Remove(oldNumberStr.Length - 1);

            }

            number = decimal.Parse(newNumberStr);

            return number;
        }

        static string StringReverser(string str)
        {
            string oldStr = str;
            string newStr = string.Empty;
            decimal stringLength = oldStr.Length;

            for (int i = 0; i < stringLength; i++)
            {
                newStr += oldStr.Substring(oldStr.Length - 1);
                oldStr = oldStr.Remove(oldStr.Length - 1);

            }

            str = newStr;

            return str;
        }


        static decimal ConvertNumber(decimal number)
        {
            if (number.ToString().Contains("."))
            {
                string numberStr = number.ToString();
                int dotPosition = numberStr.IndexOf('.');

                string beforeDot = string.Empty;
                string afterDot = string.Empty;
                string finalNumberStr;

                beforeDot = numberStr.Substring(0, dotPosition);
                afterDot = numberStr.Substring(dotPosition + 1);
                finalNumberStr = afterDot + "." + beforeDot;
                number = decimal.Parse(StringReverser(afterDot) + "." + StringReverser(beforeDot));
            }
            else
            {
                number = NumberReverser(number);
            }
            
            

            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertNumber(decimal.Parse(Console.ReadLine())));
        }
    }
}
