using System;
using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class NameAttribute : Attribute
    {
        public string Name { get; set; }
        
        public string LocalizedName { get; set; } // TODO: CurrentCultureInfo -> en-en, de-de, de-at
    }
}