
using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class BoolAttribute : BaseAttribute<bool>
    {
        public static readonly BoolAttribute Empty = new BoolAttribute() { HasValue = false };
    }
}