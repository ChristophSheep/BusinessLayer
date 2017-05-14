using System;

namespace Library.Attributes
{
    public abstract class Attribute : Library.Object
    {
        public static readonly Attribute Empty = new Attribute();
        
        public static bool IsEmpty (Attribute attribute)
        {
            return attribute.Equals(Attribute.Empty);
        }
    }
}
