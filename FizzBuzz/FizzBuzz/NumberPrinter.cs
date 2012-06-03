using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class NumberPrinter
    {
        public void PrintNumber(int i)
        {
            var display = new NumberDisplay();
            var whatToPrint = display.GetOutputString(i);

            Console.WriteLine(whatToPrint);
        }        
    }
}
