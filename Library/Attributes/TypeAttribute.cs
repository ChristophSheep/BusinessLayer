using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class TypeAttribute : BaseAttribute<string>
    {
        public string Type { get; set; }
    }
}