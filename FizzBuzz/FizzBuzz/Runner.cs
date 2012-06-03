using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class Runner : IRunner
    {
        private readonly INumberPrinter _numberPrinter;
        
        public Runner()
        {
            _numberPrinter = new NumberPrinter();
        }

        public Runner(INumberPrinter numberPrinter)
        {
            _numberPrinter = numberPrinter;
        }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                _numberPrinter.PrintNumber(i);
            }
        }
    }
}
