
using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class BoolAttribute : Attribute, BaseAttribute
    {
        public static readonly BoolAttribute Empty = new BoolAttribute();

        public bool IsEmpty()
        {
            return true;
        }
        public bool Value {get; set;}
        
    }
}