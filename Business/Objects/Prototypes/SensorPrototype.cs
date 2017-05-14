namespace Business.Objects.Prototypes
{
    public abstract PrototypeSensor
    {
        protected Dictionary<NameAttribute, SensorChannel> Channels = new Dictionary<NameAttribute, SensorChannel>;

        public Sensor CreatePrototype();

        public virtual void AddChannel(SensorChannel channel)
        {
            Channels.Add(channel.Name, channel);
        }

        public virtual List<SensorChannel> GetChannels()
        {
            return Channels.Values;
        }

        public virtual SensorChannel GetChannelByName(NameAttribute name)
        {
            SensorChannel channel;
            if (Channels.TryGet(name, out channel))
                return channel;
            else
                return SensorChannel.Empty;
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