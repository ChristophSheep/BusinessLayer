using System.Collections.Generic;
using Library.Attributes;

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


        public List<BaseAttribute> Attributes { get; set; }

        public List<BaseAttribute> AdditionalAttributes { get; set; } 

    }


}
