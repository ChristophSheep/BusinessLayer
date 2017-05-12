using System.Collections.Generic;
using System.Linq;

namespace Business.Objects
{
    public class SensorChannels
    {
        private static List<SensorChannel> allSensorChannels = new List<SensorChannel>(); 

        public static List<SensorChannel> GetChannelsByType(SensorType sensorType)
        {
            
            if (allSensorChannels.Any() == false)
            {
                // TODO:
                // allSensorChannels = DAL.GetAllSensorChannels();
            }

            return allSensorChannels
                .Where(channel => channel.SensorType.Value == sensorType)
                .ToList();
        }
    }
}