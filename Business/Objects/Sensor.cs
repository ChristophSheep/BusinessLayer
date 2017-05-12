using System;
using System.Collections.Generic;

using Business.Objects.BaseObjects;
using Business.Attributes;

using Library;
using Library.Attributes;
using System.Linq;

namespace Business.Objects
{
    public class Sensor : BaseObjectWithGeometry
    {
        public SensorTypeAttribute SensorType { get; }
        public virtual List<SensorChannel> GetChannels()
        {
            var sensorChannels = new List<SensorChannel>();

            if (SensorType.HasValue)
            {
                var sensorType = SensorType.Value;
                sensorChannels = SensorChannels.GetChannelsByType(sensorType);
            }

            return sensorChannels;
        }
        public virtual SensorChannel GetChannelByName(NameAttribute name)
        {
            var channels = GetChannels();
            
            var foundChannel = channels.FirstOrDefault(channel => channel.Name.Equals(name));

            if (foundChannel == null)
            {
                foundChannel = SensorChannel.Empty;
            }

            return foundChannel;
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