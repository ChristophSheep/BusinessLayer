using System;
using Library.Attributes.Interfaces;

namespace Library.Attributes.BaseAttributes
{
    public class BaseAttribute<T> : Object, Library.Attributes.Interfaces.Attribute<T> 
    {
        public BaseAttribute() 
        {
            HasValue = false;
        }
        public bool HasValue { get; set; }

        public T Value { get; set; }

        public int AttributeTypeId 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

    }
}
