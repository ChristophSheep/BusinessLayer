using System;

namespace Library.Commands
{
    // ReSharper disable once InconsistentNaming
    public interface Command
    {
        bool CanExecute();

        void Execute();

        void Undo();
    }
}
