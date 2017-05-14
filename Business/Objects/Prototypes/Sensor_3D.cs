namespace Business.Objects
{
    public class Sensor_3D : PrototypeSensor, Sensor 
    {
        protected static bool created = false;

        protected static Sensor sensorSingleton;

        public Sensor CreatePrototype()
        {
            if (created == false) 
            {
                sensorSingleton = new Sensor3D(); created = true;
            }

            return sensorSingleton;
        }

        protected Sensor_3D()
        {
            Name.Value = "3D";
            Id.Value = 1000;        // Should be a unique id similar to a GUID - Get Number from Registrar office
            ParentId.Value = -1;    // Has no parent is a prototype

            // Create BuiltIn channels
            
            var channel_x  = SensorChannel_3D_X.Create(this);
            var channel_y  = SensorChannel_3D_Y.Create(this);
            var channel_xy = SensorChannel_3D_XY.Create(this);

            AddChannel(channel_x);
            AddChannel(channel_y);
            AddChannel(channel_xy);

        }

        protected class SensorChannel_3D_X : SensorChannel
        {
            public SensorChannel_3D_X ()
            {
                Name.Value = "3D_X",
                Id.Value = 10000001,
            }

            public List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
            {
                var values = Storage.GetChannelValues(this, from, to);
                return values;
            }
        }

        protected class SensorChannel_3D_Y : SensorChannel
        {
            public SensorChannel_3D_Y ()
            {
                Name.Value = "3D_Y";
                Id.Value = 10000002, 
            }

            public List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
            {
                var values = Storage.GetChannelValues(this, from, to);
                return values;
            }
        }

        protected class SensorChannel_3D_XY : SensorChannel
        {
            public SensorChannel_3D_XY()
            {
                Name.Value = "3D_XY";
                Id.Value = 10000003,
            }

            public override List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
            {
                // Get the values from Storage for x and y channel
                // and calculate the xy value by xy is sqrt(x^2 + y^2)

                var values = new List<DateTimeValuePair>();

                var channel_x = GetChannel("3D_X");
                var channel_y = GetChannel("3D_Y");

                var dates = GetDates(from, to);

                foreach(var date in dates)
                {
                    var value_x = GetValue(channel_x, date);
                    var value_y = GetValue(channel_y, date);
                
                    var value_xy = Math.sqrt(value_x * value_x + value_y + value_y);

                    values.Add(new DateTimeValuePair(date, value_xy));
                }

                return values;
            }
        }
    }
}