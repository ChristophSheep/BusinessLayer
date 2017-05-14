using System;
using System.Linq;
using System.Collections.Generic;

using Library.Objects;
using Library.Attributes;

using Business.Objects.BaseObjects;
using Business.Attributes;

namespace Business.Objects
{
    public abstract class Sensor : BaseObjectWithGeometry
    {

        // This is not necessary
        // public SensorTypeAttribute SensorType { get; }

        public abstract List<SensorChannel> GetChannels()
        {
            /* 
            var sensorChannels = new List<SensorChannel>();

            if (SensorType.HasValue)
            {
                var sensorType = SensorType.Value;
                sensorChannels = SensorChannels.GetChannelsByType(sensorType);
            }

            return sensorChannels;
            */
        }

        public abstract SensorChannel GetChannelByName(NameAttribute name)
        {
            /* 
            var channels = GetChannels();
            
            var foundChannel = channels.FirstOrDefault(channel => channel.Name.Equals(name));

            if (foundChannel == null)
            {
                foundChannel = SensorChannel.Empty;
            }

            return foundChannel;
            */
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