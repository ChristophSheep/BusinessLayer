
using System;
using System.Collections.Generic;

using Business.Attributes;
using Business.Objects.BaseObjects;

using Library;
using Library.Attributes;
using Library.Attributes.BaseAttributes;

namespace Business.Objects
{
    public abstract class SensorChannel : Library.Objects.Object
    {
        public static readonly SensorChannel Empty = new SensorChannel(Sensor.Empty);

        public Sensor Sensor = {get; private set;}

        public static SensorChannel Create(Sensor sensor)
        {
            return new SensorChannel(sensor);
        }

        protected SensorChannel(Sensor sensor)
        {
            Sensor = sensor;
        }

        public abstract DateTimeValuePair GetValue(DateTime at);
      
        public abstract List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
    }
}