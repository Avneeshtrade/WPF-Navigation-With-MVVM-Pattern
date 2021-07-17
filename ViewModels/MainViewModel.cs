using MvvmNavigationApp.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmNavigationApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;
        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;
        public MainViewModel(NavigationStore navigationStore)
        { 
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
            _navigationStore.OnCurrentViewModelChanged += CurrentVieModelChanged;

        }

        private void CurrentVieModelChanged()
        {
            MessageBox.Show("Navigate to : "+_navigationStore.CurrentViewModel.Title);
            OnProperyChanged(nameof(CurrentViewModel));
        }
    }
}
