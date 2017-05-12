using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{

    public class IdAttribute : BaseAttribute<int>
    {
        public int Id { get; set; }
    }
}
