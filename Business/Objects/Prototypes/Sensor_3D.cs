namespace Business.Objects
{
    public class Sensor_3D : Sensor
    {
        // New sensor can only be created by copying the prototype sensor

        protected Sensor_3D()
        {
            Name.Value = "3D";
            Id.Value = 1;

            var channel_xy = new SensorChannel_3D_XY()
            {
                Name.Value = "3D_XY",
                Id.Valie = 1,
            };

            Channels.Add(channel_xy);
        }

        // This class could be loaded at runtime

        private class SensorChannel_3D_XY : SensorChannel
        {
            List<DateTimeValuePair> GetValues(DateTime from, DateTime to)
            {
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