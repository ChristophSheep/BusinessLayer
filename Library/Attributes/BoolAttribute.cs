
using Library.Attributes.BaseAttributes;
using Library.Attributes.Interfaces;

namespace Library.Attributes
{
    public class BoolAttribute : BaseAttribute
    {
        public static readonly BoolAttribute Empty = new BoolAttribute() 
        { 
            HasValue = false 
        };

        public bool Value {get; set;}
    }
}