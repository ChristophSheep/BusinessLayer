using Library.Attributes;

namespace Business.Attributes
{
    public class ExtNameAttribute :  NameAttribute
    {
        public string AltName { get; set; }
    }

}