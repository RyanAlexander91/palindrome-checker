using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PalindromeChecker.SharedCode.Commands
{
    public class CheckPalindromeCommand : ICommand
    {
        // Constructor
        public CheckPalindromeCommand(Action<string> Execute)
        {
            execute = Execute;
        }

        private Action<string> execute;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter as string);
        }
    }
}
