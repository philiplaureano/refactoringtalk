using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class Runner
    {
        public void Run()
        {
            var numberPrinter = new NumberPrinter();
            for (int i = 0; i < 100; i++)
            {
                numberPrinter.PrintNumber(i);
            }
        }
    }
}
