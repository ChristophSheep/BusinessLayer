using Library.Attributes;

namespace Business.Attributes
{
    public class ExtNameAttribute :  NameAttribute
    {
        public string AltName { get; set; }
    }

    public class SensorTypeAttribute : BaseAttribute
    {

        public SensorTypeAttribute ()
        {
            Value = SensorType.Empty;
        }

        public SensorType Value {get; set;}

    }
}