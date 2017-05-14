using System;
using System.Linq;
using System.Collections.Generic;

using Library.Objects;
using Library.Attributes;

using Business.Objects.BaseObjects;
using Business.Attributes;

namespace Business.Objects
{
    public /*abstract*/ class Sensor : BaseObjectWithGeometry
    {

        public static Sensor Create(Sensor prototype, IdAttribute id, NameAttribute name, ParentIdAttribute parentId)
        {
            var newSensor = new Sensor(prototype); 

            newSensor.IdAttribute.Value = id;
            newSensor.NameAttribute.Value = name;
            newSensor.ParentId = IdAttribute.Empty; // Root
        }

        public static Sensor Create(Sensor prototype, List<Attribute> parameters)
        {
            var newSensor = new Sensor(prototype);  

            foreach (var param in parameters)
            {
                newSensor.SetAttributeValue(param);
            }
        }

        protected Sensor(Sensor prototype) 
        {
            Prototype = prototype;
        }

        protected Sensor Prototype = new EmptySensor();

        public virtual List<SensorChannel> GetChannels()
        {
            return prototype.GetChannels();
        }

        public virtual SensorChannel GetChannelByName(NameAttribute name)
        {
            return prototype.GetChannelByName(name);
        }
        
        public virtual DateTimeValuePair GetValue(SensorChannel sensorChannel, DateTime at)
        {
            return prototype.GetValue(sensorChannel, at);
        }

        public virtual List<DateTimeValuePair> GetValues(SensorChannel sensorChannel, DateTime from, DateTime to)
        {
            return prototype.GetValues(sensorChannel, from, to);
        }
    }
}