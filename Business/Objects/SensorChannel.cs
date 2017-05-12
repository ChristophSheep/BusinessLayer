
using System;
using System.Collections.Generic;

using Business.Attributes;
using Business.Objects.BaseObjects;

using Library;
using Library.Attributes;
using Library.Attributes.BaseAttributes;

namespace Business.Objects
{
    public class SensorChannel : BaseObject
    {
        public static readonly SensorChannel Empty = new SensorChannel();
        public SensorTypeAttribute SensorType { get; }
        public BoolAttribute IsCalculated { get; }
        public BoolAttribute IsDynamic { get; } 
        protected virtual DateTimeValuePair CalcValue()
        {
            return DateTimeValuePair.Empty;
        }
        protected virtual List<DateTimeValuePair> CalcValues()
        {
            return new List<DateTimeValuePair>();
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