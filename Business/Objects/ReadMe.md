  
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

## SensorChannel

Each Sensor has different SensorChannel with timerelated Values.

A sensor channel is a real channel or a calculated channel.

A calculated channel is calculated from real values or other channels.

e.g. Channel "xy" is xy = sqrt(x*x + y*y)
 
