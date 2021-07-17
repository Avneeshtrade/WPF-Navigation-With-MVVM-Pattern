using MvvmNavigationApp.Commands.Generic;
using MvvmNavigationApp.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MvvmNavigationApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        public ICommand GoToAccountView { get { return new RelayCommand<string>(CanExecute, Execute); } }
        public HomeViewModel(NavigationStore navigate)
        {
            this.Title = "Home View";
            _navigationStore = navigate;
        }
        private bool CanExecute(object obj)
        {
            return true;
        }

        private void Execute(object obj)
        {
            _navigationStore.CurrentViewModel = new AccountViewModel(_navigationStore);
        }
    }
}
