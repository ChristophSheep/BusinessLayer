using System;

namespace Library
{
    public class DateTimeValuePair : Object
    {
        public static readonly DateTimeValuePair Empty = new DateTimeValuePair()
        {
            DateTime = DateTime.MinValue,
            Value = Decimal.MinValue,
        };

        public DateTime DateTime { get; set; }

        public decimal Value { get; set; }
    }
}