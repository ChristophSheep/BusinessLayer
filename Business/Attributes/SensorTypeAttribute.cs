
using Library.Attributes.BaseAttributes;
using Business.Objects;

namespace Business.Attributes
{
    public class SensorTypeAttribute : BaseAttribute<SensorType>
    {

        public SensorTypeAttribute ()
        {
            Value = SensorType.Empty;
        }


    }
}