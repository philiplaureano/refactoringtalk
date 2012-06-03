using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class ActualNumberDisplay
    {
        public string DisplayTheActualNumber(int i)
        {
            return i.ToString(CultureInfo.InvariantCulture);
        }
    }
}
