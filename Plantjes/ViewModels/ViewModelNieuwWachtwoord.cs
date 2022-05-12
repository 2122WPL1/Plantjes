using System;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Dao;
using Plantjes.Models.Db;
using Plantjes.ViewModels;
using Plantjes.ViewModels.Services;
using Plantjes.Views.Home;
using XSystem.Security.Cryptography;

namespace Plantjes.ViewModels
{
    internal class ViewModelNieuwWachtwoord : ViewModelBase
    {

        public ViewModelNieuwWachtwoord(LoginUserService loginUserService)
        {
            _loginService = loginUserService;

            changePasswordCommand = new RelayCommand(ChangePasswordButtonClick);
        }

        public LoginUserService _loginService { get; }
        public RelayCommand changePasswordCommand { get; set; }

        public void ChangePasswordButtonClick()
        {
            //Als de 2 wachtwoorden overeenkomen dan kan het wachtwoord opgeslaan worden terug naar login window gegaan worden
            if (passwordInput == passwordRepeatInput)
            {
                var passwordBytes = Encoding.ASCII.GetBytes(passwordInput);
                var md5Hasher = new MD5CryptoServiceProvider();
                var passwordHashed = md5Hasher.ComputeHash(passwordBytes);

                _loginService.gebruiker.HashPaswoord = passwordHashed;
                _loginService.gebruiker.LastLogin = DateTime.Now;
                DAOUser.context.SaveChanges();


                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
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
