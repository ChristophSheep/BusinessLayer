
using System;
using System.Collections.Generic;
using Business.Objects.BaseObjects;
using Library;

namespace Business.Objects
{
    public class SensorChannel : BaseObject
    {
        public DateTimeValuePair GetValue(DateTime at)
        {
            return new DateTimeValuePair();
        }

        public List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
        {
            var dateTimeValues = new List<DateTimeValuePair>();

            return dateTimeValues;
        }
    }
}