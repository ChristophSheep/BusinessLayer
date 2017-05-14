  
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

## Sensor

Each sensor type has a prototyp sensor.

Sensor should be created from prototypes.

e.g.

- SensorPrototypes
    - Sensor_3D
    - Sensor_LV
    - Sensor_LLV

- Sensor "3D"
    - Prototype = Sensor.Empty; // or Prototype = ObjectWithGeometry;
    - GetChannels();

- Sensor "3D_123"
    - ProtoType.GetChannels();

A sensor prototype exists only one time.

Sensor is an abstract class. the whole code works with this class.

There are never should be any cast to concrete sensor (e.g. Sensor_3D)

Sensors are loaded at start time from plugins (could be from db or file system).

A Sensor could be loaded at runtime.

To create a new concrete sensor object you copy the template sensor.

## SensorChannel

A sensor channel could not be instantiated outside of a sensor.

e.g.
    Sensor_3D
        - Channel_X (built in)
        - Channel_Y (built in)
        - Channel_Z (built in)
        - Channel_Dyn_Lat (dynamic)
        - Channel_Dyn_Lng (dynamic)

A sensor channel could be dynamically loaded/unloaded at runtime.

Property SensorChannel.IsCalculated is not necessary.

Property SensorChannel.IsDynamic is not necessary.

Each Sensor has different SensorChannel with timerelated Values.

A sensor channel is a real channel or a calculated channel.

A calculated channel is calculated from real values or other channels.

e.g. Channel "xy" is xy = sqrt(x*x + y*y)

## SensorChannels

The class SensorChannels is not neccessary.

To get all sensorchannel you go to all sensors a get the channel of each sensor.

## SensorType

The class SensorType is not neccessary.

The user do not need to get a type property.

It only leads to long switch-case constructs.

 