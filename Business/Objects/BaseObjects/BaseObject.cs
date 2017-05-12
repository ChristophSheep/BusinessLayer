using System.Collections.Generic;
using Library.Attributes;
using Library.Attributes.Interfaces;

namespace Business.Objects.BaseObjects
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


    public class BaseObject
    {
        protected BaseObject() { }


        public IdAttribute Id { get; set; }

        public ParentIdAttribute ParentId { get; set; }


        public NameAttribute Name { get; set; }

        public TypeAttribute Type { get; set; }

        public List<Attribute> Attributes { get; set; }

        public List<Attribute> AdditionalAttributes { get; set; } 

    }


}
