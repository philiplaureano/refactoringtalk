using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class NumberDisplay : INumberDisplay
    {
        private readonly ActualNumberDisplay _numberDisplay;

        public NumberDisplay()
        {
            _numberDisplay = new ActualNumberDisplay();
        }

        public string GetOutputString(int i)
        {
            var isFizz = i % 3 == 0;
            var isBuzz = i % 5 == 0;

            if (isFizz && isBuzz)
                return "FizzBuzz";

            if (isFizz)
                return "Fizz";

            if (isBuzz)
                return "Buzz";

            return _numberDisplay.GetOutputString(i);
        }        
    }
}
