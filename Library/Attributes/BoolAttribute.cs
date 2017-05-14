
using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class BoolAttribute : Attribute
    {
        public static readonly BoolAttribute Empty = new BoolAttribute();
        
        public bool Value {get; set;}
        
        // public bool HasValue { get; set; }

    }
}