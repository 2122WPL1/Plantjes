using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.ViewModels;
using Plantjes.ViewModels.Services;
using Plantjes.Views.Home;

namespace Plantjes.ViewModels
{
    internal class ViewModelNieuwWachtwoord : ViewModelBase
    {

        public ViewModelNieuwWachtwoord(LoginUserService loginUserService, Gebruiker gebruiker)
        {
            _loginService = loginUserService;
            changePasswordCommand = new RelayCommand(ChangePasswordButtonClick);
            _gebruiker = gebruiker;
        }

        private Gebruiker _gebruiker;
        private LoginUserService _loginService { get; }
        public RelayCommand changePasswordCommand { get; set; }

        //Kjell -- Based on Xander
        public void ChangePasswordButtonClick()
        {
            if (passwordInput == passwordRepeatInput)
            {
                _loginService.ChangePasswordButton(passwordInput, passwordRepeatInput);
                //_loginService.ChangePasswordButton(passwordInput, passwordRepeatInput);
                DAOLogic.context.SaveChanges();

                var niewWachtwoordWindow = new NieuwWachtwoordWindow();
                niewWachtwoordWindow.Show();
                Application.Current.Windows[0]?.Close();
            }
        }

        #region MVVM TextFieldsBinding

        private string _vivesNrInput;
        private string _firstNameInput;
        private string _lastNameInput;
        private string _emailAdresInput;
        public string _passwordInput;
        public string _passwordRepeatInput;
        private string _errorMessage;

        public string errorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;

                RaisePropertyChanged("errorMessage");
            }
        }

        public string vivesNrInput
        {
            get => _vivesNrInput;
            set
            {
                _vivesNrInput = value;
                OnPropertyChanged();
            }
        }

        public string firstNameInput
        {
            get => _firstNameInput;
            set
            {
                _firstNameInput = value;
                OnPropertyChanged();
            }
        }

        public string lastNameInput
        {
            get => _lastNameInput;
            set
            {
                _lastNameInput = value;
                OnPropertyChanged();
            }
        }

        public string emailAdresInput
        {
            get => _emailAdresInput;
            set
            {
                _emailAdresInput = value;
                OnPropertyChanged();
            }
        }

        public string passwordInput
        {
            get => _passwordInput;
            set
            {
                _passwordInput = value;
                OnPropertyChanged();
            }
        }

        public string passwordRepeatInput
        {
            get => _passwordRepeatInput;
            set
            {
                _passwordRepeatInput = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
