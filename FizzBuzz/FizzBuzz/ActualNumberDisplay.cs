using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class ActualNumberDisplay : INumberDisplay
    {
        public string GetOutputString(int i)
        {
            return i.ToString(CultureInfo.InvariantCulture);
        }
    }
}
