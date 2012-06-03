using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                var whatToPrint = GetOutputString(i);

                Console.WriteLine(whatToPrint);
            }
        }

        private static string GetOutputString(int i)
        {
            var whatToPrint = i.ToString(CultureInfo.InvariantCulture);
            var isFizz = i%3 == 0;
            var isBuzz = i%5 == 0;

            if (isFizz && isBuzz)
            {
                whatToPrint = "FizzBuzz";
            }
            else if (isFizz)
            {
                whatToPrint = "Fizz";
            }
            else if (isBuzz)
            {
                whatToPrint = "Buzz";
            }
            return whatToPrint;
        }
    }
}
