using System;
using Library.Attributes.BaseAttributes;

namespace Library.Attributes
{
    public class NameAttribute : Attribute, BaseAttribute
    {
        public string Value { get; set; }
    }
}