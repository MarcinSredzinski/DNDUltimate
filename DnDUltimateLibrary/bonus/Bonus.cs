using System;
using System.Collections.Generic;
using System.Text;

namespace DnDUltimateLibrary.bonus
{
    public class Bonus
    {
        public Bonus(short numericValue, Source source)
        {
            NumericValue = numericValue;
            Source = source;
        }
        public Int16 NumericValue { get; }
        public Source Source { get; }
    }
}
