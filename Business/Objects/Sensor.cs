using System;
using System.Collections.Generic;

using Business.Objects.BaseObjects;
using Business.Attributes;

using Library;
using Library.Attributes;

namespace Business.Objects
{
    public class Sensor : BaseObjectWithGeometry
    {
        public SensorTypeAttribute SensorType { get; }

        public virtual List<SensorChannel> GetChannels()
        {
            var sensorChannels = new List<SensorChannel>();

            if (SensorType.HasValue == false)
            {
                return sensorChannels;
            }

            var sensorType = SensorType.Value;
            return sensorChannels.GetChannelsByType(sensorType);


        }

        public virtual SensorChannel GetChannelByName(NameAttribute name)
        {
            return new SensorChannel();
        }

        public virtual DateTimeValuePair GetValue(SensorChannel sensorChannel, DateTime at)
        {
            return sensorChannel.GetValue(at);
        }

        public virtual List<DateTimeValuePair> GetValues(SensorChannel sensorChannel, DateTime from, DateTime to)
        {
            return sensorChannel.GetValues(from, to);
        }
    }
}