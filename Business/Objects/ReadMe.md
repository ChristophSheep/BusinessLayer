  
# Example of a Tree of Business Objects 

The tree represents the model of the Business

    Root

        |-> Projects
            -> AllUsers
            -> ProjectWideSettings

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
 
