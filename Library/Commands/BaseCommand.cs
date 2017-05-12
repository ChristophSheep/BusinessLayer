using System;

namespace Library.Commands
{
    public abstract class BaseCommand: Command
    {
        public virtual bool CanExecute()
        {
            return false;
        }

        public void Execute()
        {
            if (IsAllowed())
            {
                ExecuteOnAllowed();
            }
            else
            {
                ExecuteOnDenied();
            }
        }

        public void Undo()
        {
            if (IsAllowed())
            {
                UndoOnAllowed();
            }
            else
            {
                UndoOnDenied();
            }
        }

        protected virtual bool IsAllowed()
        {
            return false;
        }

        protected virtual void ExecuteOnAllowed()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void ExecuteOnDenied()
        {
            // TODO
            // Wrap around a logger
            // Log.AccessDenied

            Console.WriteLine("You are not allowed");
        }

        protected virtual void UndoOnAllowed()
        {

        }

        protected virtual void UndoOnDenied()
        {
            // TODO
            // Wrap around a logger
            // Log.AccessDenied
            Console.WriteLine("You are not allowed");
        }
    }
}