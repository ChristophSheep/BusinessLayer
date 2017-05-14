using System;

namespace Library.Commands
{
    
    // Interface vs. abstract base class

    public interface Command
    {
        bool CanExecute();

        void Execute();

        void Undo();
    }
}
