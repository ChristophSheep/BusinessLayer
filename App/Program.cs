using System;
using Library;
using Library.Attributes;
using Business.Attributes;
using Business.Commands;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Business Layer with Commands");
            Console.WriteLine("");

            Console.WriteLine("Execute a LoadSensorCommand:");

            var id = new IdAttribute {Id = 123};
            var cmd = new LoadSensorCommand {Parameter = id};

            cmd.Execute();
            cmd.Undo();

            var name = new NameAttribute() {Name = "FooBarr"};
            
            Console.WriteLine($"Name: {name:Name}");

            var boolean = BoolAttribute.Empty;

            Console.WriteLine("boolean = BoolAttribute.Empty");

            if (boolean.HasValue)
            {
                Console.WriteLine($"boolean.HasValue: {boolean.HasValue}");
            } 
            else
            {
                Console.WriteLine($"boolean.HasValue: {boolean.HasValue}");
            }

            Console.WriteLine();
            Console.Write("Hit <enter> to exit.");
            Console.ReadLine();
        }
    }
}
