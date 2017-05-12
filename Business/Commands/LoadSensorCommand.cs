using System;
using Library.Attributes;
using Library.Commands;

namespace Business.Commands
{
    public class LoadSensorCommand : BaseCommand
    {
        public IdAttribute Parameter { get; set; }

        public override bool CanExecute()
        {
            // TODO
            // Check if command can be executed

            return true;

            // throw new System.NotImplementedException();
        }

        protected override bool IsAllowed()
        {
            // TODO
            // Check if current user has permission to load a sensor

            return true;

            // throw new System.NotImplementedException();
        }

        protected override void ExecuteOnAllowed()
        {
            Console.WriteLine($"Load sensor with id:{Parameter.Id}");

            // throw new System.NotImplementedException();
        }

        protected override void UndoOnAllowed()
        {
            Console.WriteLine($"Unload sensor with id:{Parameter.Id}");

            //throw new System.NotImplementedException();
        }

    }
}
