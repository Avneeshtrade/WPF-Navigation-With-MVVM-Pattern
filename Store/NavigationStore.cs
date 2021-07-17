using MvvmNavigationApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmNavigationApp.Store
{
    public class NavigationStore
    {
        public event Action OnCurrentViewModelChanged;
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel {
            get {
                return _currentViewModel;
            }
            set {
                _currentViewModel = value;
                CurrentViewModelChanged();
            }

        }

        private void CurrentViewModelChanged()
        {
            OnCurrentViewModelChanged?.Invoke();
        }
    }
}
