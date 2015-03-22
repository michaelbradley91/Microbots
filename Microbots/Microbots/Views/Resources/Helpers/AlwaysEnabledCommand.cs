using System;
using System.Windows.Input;

namespace Microbots.Views.Resources.Helpers
{
    public class AlwaysEnabledCommand : ICommand
    {
        private readonly Action _command; 

        public AlwaysEnabledCommand(Action command)
        {
            _command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _command();
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }

    public class AlwaysEnabledCommand<T> : ICommand
    {
        private readonly Func<object, T> _converter;
        private readonly Action<T> _command; 

        public AlwaysEnabledCommand(Action<T> command) : this(command, parameter => (T)parameter) { }

        public AlwaysEnabledCommand(Action<T> command, Func<object, T> converter)
        {
            _command = command;
            _converter = converter;
        }  

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _command(_converter(parameter));
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}
