using System;
using System.Collections.Generic;
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
            var whatToPrint = i.ToString();
            if (i%3 == 0 && i%5 == 0)
            {
                whatToPrint = "FizzBuzz";
            }
            else if (i%3 == 0)
            {
                whatToPrint = "Fizz";
            }
            else if (i%5 == 0)
            {
                whatToPrint = "Buzz";
            }
            return whatToPrint;
        }
    }
}
