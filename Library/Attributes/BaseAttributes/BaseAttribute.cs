using System;
using Library.Attributes.Interfaces;

namespace Library.Attributes.BaseAttributes
{
    public class BaseAttribute : Object, Library.Attributes.Interfaces.Attribute 
    {
        public BaseAttribute() 
        {
            HasValue = false;
        }
        public bool HasValue { get; set; }
        public int AttributeTypeId 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

    }
}
