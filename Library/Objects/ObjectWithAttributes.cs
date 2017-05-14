using System.Collections.Generic;
using Library.Attributes;
using LAI = Library.Attributes.Interfaces;

namespace Business.Objects
{

    /*
    
        Root

         |-> Projects

            |-> Project 'Shared' 
                -> SharedUsers
                -> SharedSettings

            |-> Project 'Foo' 

                |-> SubProjects
                    |- Project 'Foo.A'
                    
                |-> Users
                |-> Sensors

            |-> Project 'Bar' 

                |-> Users
                |-> Sensors
 
    */


    public abstract class ObjectWithAttributes
    {
        public IdAttribute Id { get; set; }

        public ParentIdAttribute ParentId { get; set; }

        public NameAttribute Name { get; set; }

        // Not sure about this
        // A type is in the class name
        // We polyphormisn we need not to know a concrete type

        public TypeAttribute Type { get; set; }

        public List<LAI.Attribute> Attributes { get; set; }

        // If a Attribute is dynamic or not does not matter
        // Attributes can be created and added at runtime

        // public List<LAI.Attribute> AdditionalAttributes { get; set; } 

    }


}
