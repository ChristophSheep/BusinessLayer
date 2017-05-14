using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class TypeAttribute : Attribute, BaseAttribute
    {
        public string Value { get; set; }
    }
}