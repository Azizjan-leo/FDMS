using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FDMS.UI.Commands
{
    public class RelayCommand : ICommand
    {
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute=execute;
            this.canExecute=canExecute;
        }

        public event EventHandler CanExecuteChanged;

        Action<object> execute {  get; set; }
        Predicate<object> canExecute { get; set; }

        

        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
