using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.ViewModels;
using Plantjes.ViewModels.Services;
using Xunit;
using Xunit.Sdk;

namespace Plantjes.ViewModels
{
    internal class ViewModelNieuwWachtwoord : ViewModelBase
    {
        public ViewModelNieuwWachtwoord(LoginUserService loginUserService)
        {
            _loginService = loginUserService;
            changePasswordCommand = new RelayCommand(ChangePasswordButtonClick);
        }

        private LoginUserService _loginService { get; }
        public RelayCommand changePasswordCommand { get; set; }

        public void ChangePasswordButtonClick()
        {
            errorMessage = _loginService.ChangePasswordButton(passwordInput, _passwordRepeatInput);
            //xander - close register window if no error
            if (errorMessage == null || errorMessage == string.Empty)
            {
                //xander - clear input on register
                passwordInput = string.Empty;
                Application.Current.Windows[0]?.Close();
                Window.
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
