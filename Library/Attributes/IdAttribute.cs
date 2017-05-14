using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{

    public class IdAttribute : Attribute, BaseAttribute
    {
        public int Value { get; set; }
    }
}
