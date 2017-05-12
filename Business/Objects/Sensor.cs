using System;
using System.Collections.Generic;
using Business.Objects.BaseObjects;
using Library;
using Library.Attributes;

namespace Business.Objects
{
    public class Sensor : BaseObjectWithGeometry
    {
        public virtual List<SensorChannel> GetChannels()
        {
            var sensorChannels = new List<SensorChannel>();

            // TODO: 
            // Get channels of sensorType
            // If channels are dynamic you also return them also

            return sensorChannels;
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