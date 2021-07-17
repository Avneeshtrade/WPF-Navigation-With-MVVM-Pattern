using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmNavigationApp.Commands.Generic
{
    public class RelayCommand<TParameter> : ICommand
    {
        private Predicate<TParameter> canExecute;
        private Action<TParameter> execute;
        public event EventHandler CanExecuteChanged;
        public RelayCommand(Predicate<TParameter> canExecute, Action<TParameter> execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecute == null) return true;

            return this.canExecute((TParameter)parameter);
        }

        public void Execute(object parameter)
        {
            if (execute != null) {
                this.execute((TParameter)parameter);
            }
        }
    }
}
