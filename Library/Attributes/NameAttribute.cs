using System;

namespace Library.Attributes
{
    public class NameAttribute :  BaseAttribute
    {
        public string Name { get; set; }

        public string LocalizedName { get; set; } // CurrentCultureInfo -> en-en, de-de, de-at
    }
}