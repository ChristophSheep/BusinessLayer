
using Library.Attributes.BaseAttributes;
using Business.Objects;

namespace Business.Attributes
{
    public class SensorTypeAttribute : BaseAttribute
    {

        public SensorTypeAttribute ()
        {
            Value = SensorType.Empty;
        }

        public SensorType Value { get; set; }

    }
}