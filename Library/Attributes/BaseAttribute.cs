using System;

namespace Library.Attributes
{
    public abstract class BaseAttribute : Library.Object
    {   
        public bool IsEmpty(Attribute attribute)
        {
            return attribute.IsEmpty();
        }
    }
}
