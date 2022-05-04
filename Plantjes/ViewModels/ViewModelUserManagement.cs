using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Dao;
using Plantjes.Models.Db;

namespace Plantjes.ViewModels
{
    internal class ViewModelUserManagement: ViewModelBase {
        private static ViewModelUserManagement instance;
        private static Gebruiker _currentUser;
        
        public ViewModelUserManagement() {
            instance = this;
            DAOLogic.context.ChangeTracker.StateChanged += (sender, args) => {
                args.NewState.PrintDebug();
                
            };
            users.CollectionChanged += (sender, args) => {
                foreach (var argsNewItem in args.NewItems!) {
                    argsNewItem.PrintDebug();
                }
            };
        }
        
        public ObservableCollection<Gebruiker> users { get => new(DAOLogic.context.Gebruikers);  }

        public Gebruiker currentUser {
            get => _currentUser;
            set {
                _currentUser = value;
                OnPropertyChanged();
            }
        }

        
        public RelayCommand DeleteCommand { get; } = new(()=> {
            DAOLogic.context.Gebruikers.Remove(_currentUser);
            DAOLogic.context.SaveChanges();
            instance.OnPropertyChanged("users");
        });
        public RelayCommand ImportCsvCommand { get; } = new(DAOUser.AddUsersFromCsv);
        
    }
}
