using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Dao;
using Plantjes.Models.Db;

namespace Plantjes.ViewModels {
    internal class ViewModelUserManagement : ViewModelBase {
        private static ViewModelUserManagement instance;
        private static Gebruiker _currentUser;

        public ViewModelUserManagement() {
            instance = this;
            DAOLogic.context.ChangeTracker.StateChanged += (sender, args) => { args.NewState.PrintDebug(); };
            users.CollectionChanged += (sender, args) => {
                foreach (var argsNewItem in args.NewItems!) {
                    argsNewItem.PrintDebug();
                }
            };
        }

        public ObservableCollection<Gebruiker> users {
            get => new(DAOLogic.context.Gebruikers.AsNoTracking());
        }

        public Gebruiker currentUser {
            get => _currentUser;
            set {
                if (value == null) {
                    Debug.WriteLine("User was null:");

                    foreach (var sf in new StackTrace().GetFrames()) {
                        Debug.WriteLine(sf.ToString());
                    }
                }
                else {
                    //detach if not null
                    DAOLogic.context.Entry(value).State = EntityState.Detached;
                    //set current user
                    _currentUser = value;
                }
                OnPropertyChanged();
            }
        }


        public RelayCommand DeleteCommand { get; } = new(() => {
            //remove user from db
            if (_currentUser.Id != null && _currentUser.Id != 0) DAOLogic.context.Gebruikers.Remove(_currentUser);
            //save
            DAOLogic.context.SaveChanges();
            instance.OnPropertyChanged("users");
        });

        public RelayCommand SaveUserCommand { get; } = new(() => {
            //check if new user
            if (_currentUser != null && _currentUser.Id != 0) {
                //detach, if not detached
                if(DAOLogic.context.Entry(_currentUser).State != EntityState.Detached) DAOLogic.context.Entry(_currentUser).State = EntityState.Detached;
                //attach current instance if not detached
                DAOLogic.context.Attach(_currentUser);
            }
            else if(_currentUser != null)
                //add if not null, and is new user
                DAOLogic.context.Gebruikers.Add(_currentUser);
            //save
            DAOLogic.context.SaveChanges();

            //detach again
            if(DAOLogic.context.Entry(_currentUser).State != EntityState.Detached) DAOLogic.context.Entry(_currentUser).State = EntityState.Detached;
            instance.OnPropertyChanged("users");
        });

        public RelayCommand NewUserCommand { get; } = new(() => {
            //set current user to empty user
            _currentUser = new();
            instance.OnPropertyChanged("currentUser");
        });

        public RelayCommand ImportCsvCommand { get; } = new(DAOUser.AddUsersFromCsv);
    }
}