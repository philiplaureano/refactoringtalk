using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class NumberPrinter : INumberPrinter
    {
        private readonly INumberDisplay _display;        

        public NumberPrinter(INumberDisplay display)
        {
            _display = display;
        }

        public void PrintNumber(int i)
        {
            var whatToPrint = _display.GetOutputString(i);

            Console.WriteLine(whatToPrint);
        }        
    }
}
