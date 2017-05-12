
using System;
using System.Collections.Generic;

using Business.Attributes;
using Business.Objects.BaseObjects;

using Library;
using Library.Attributes;

namespace Business.Objects
{
    public class SensorChannel : BaseObject
    {
        public SensorTypeAttribute SensorType { get; }
        public BoolAttribute IsCalculated { get; }
        public BoolAttribute IsDynamic { get;} // TODO Should be BoolAttribute
        protected virtual DateTimeValuePair CalcValue()
        {
            return new DateTimeValuePair();
        }
        protected virtual List<DateTimeValuePair> CalcValues()
        {
            var dateTimeValues = new List<DateTimeValuePair>();

            // TODO

            return dateTimeValues;
        }
        public DateTimeValuePair GetValue(DateTime at)
        {
            if (IsCalculated.HasValue && IsCalculated.Value)
            {
                return CalcValue();
            }
            else
            {
                return new DateTimeValuePair();
            } 
        }
        public List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
        {
            if (IsCalculated.Value)
            {
                return CalcValues();
            }
            else
            {
                var dateTimeValues = new List<DateTimeValuePair>();

                return dateTimeValues;
            }
        }

    }
}