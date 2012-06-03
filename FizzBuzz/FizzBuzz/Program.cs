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
            var isFizz = i%3 == 0;
            var isBuzz = i%5 == 0;

            if (isFizz && isBuzz)
                return "FizzBuzz";

            if (isFizz)
                return "Fizz";
            
            if (isBuzz)
                return "Buzz";

            return i.ToString(CultureInfo.InvariantCulture);
        }
    }
}
