namespace Business.Objects
{
    public class EmptySensor : Business.Objects.Interfaces.Sensor, BaseObjectWithGeometry
    {
        public List<SensorChannel> GetChannels()
        {
            return new List<SensorChannel>();
        } 

        public SensorChannel GetChannelByName(NameAttribute name)
        {
            return SensorChannel.Empty;
        }

        public DateTimeValuePair GetValue(SensorChannel sensorChannel, DateTime at)
        {
            return DateTimeValuePair.Empty;
        }

        public List<DateTimeValuePair> GetValues(SensorChannel sensorChannel, DateTime from, DateTime to)
        {
            if (Sensor.IsEmpty(prototype))
                return new List<DateTimeValuePair>(); // DateTimeValuePairs.Empty
        }
    }
}