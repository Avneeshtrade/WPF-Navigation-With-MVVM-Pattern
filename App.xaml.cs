using MvvmNavigationApp.Store;
using MvvmNavigationApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmNavigationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigate = new NavigationStore();
            MainWindow startup = new MainWindow
            {
                DataContext = new MainViewModel(navigate)
            };
            startup.Show();
        }

    }
}
