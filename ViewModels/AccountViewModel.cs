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
    public class AccountViewModel : BaseViewModel
    {
        #region private Members
        private readonly NavigationStore _navigationStore;
        private string _userName; 
        private string _password;
        #endregion
        #region public Members
        public string UserName
        {
            get { return _userName; }
            set { _userName = value;OnProperyChanged(nameof(UserName)); }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value;OnProperyChanged(nameof(Password)); }
        }

        #endregion
        #region Constructor
        public AccountViewModel(NavigationStore navigate)
        {

            this.Title = "Account View";
            _navigationStore = navigate;
        }
        #endregion
        #region ICommands
        public ICommand GoToHomeView { get { return new RelayCommand<string>(CanExecute, Execute); } }

        private bool CanExecute(object obj)
        {
            return true;
        }

        private void Execute(object obj)
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
        }
        #endregion
    }
}
