using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class NumberPrinter
    {
        private readonly NumberDisplay _display;

        public NumberPrinter()
        {
            _display = new NumberDisplay();
        }

        public void PrintNumber(int i)
        {
            var whatToPrint = _display.GetOutputString(i);

            Console.WriteLine(whatToPrint);
        }        
    }
}
