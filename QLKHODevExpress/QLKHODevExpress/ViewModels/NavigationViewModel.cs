using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLKHODevExpress.Utilities;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLKHODevExpress.ViewModels
{
    class NavigationViewModel : Utilities.ViewModelBase
    {
        private object _currentView;
        public object CurrentView 
        { 
            get { return _currentView; } 
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand UnitCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand ObjectCommand { get; set; }
        public ICommand UserCommand { get; set; }

        private void Unit(object obj) => CurrentView = new UnitViewModel();
        private void Suplier(object obj) => CurrentView = new SuplierViewModel();
        private void Customer(object obj) => CurrentView = new CustomerViewModel();
        private void Object(object obj) => CurrentView = new ObjectViewModel();
        private void User(object obj) => CurrentView = new UserViewModel();

        public NavigationViewModel()
        {
            UnitCommand = new RelayCommand(Unit);
            CustomerCommand = new RelayCommand(Customer);
            SuplierCommand = new RelayCommand(Suplier);
            ObjectCommand = new RelayCommand(Object);
            UserCommand = new RelayCommand(User);

            //Startup Page
            CurrentView = new MainViewModel();
        }
    }
}
