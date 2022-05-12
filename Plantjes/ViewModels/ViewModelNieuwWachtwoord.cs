using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels
{
    //Written by Kjell
    internal class ViewModelNieuwWachtwoord : ViewModelBase
    {
        public string _passwordInput;
        public string _passwordRepeatInput;
        Gebruiker _gebruiker;

        public ViewModelNieuwWachtwoord(LoginUserService loginUserService)
        {
            _loginService = loginUserService;
            _gebruiker = _loginService.gebruiker;
            changePasswordCommand = new RelayCommand(ChangePasswordButtonClick);
        }

        public LoginUserService _loginService { get; }
        public RelayCommand changePasswordCommand { get; set; }

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

        public void ChangePasswordButtonClick()
        {
            //Als de 2 wachtwoorden overeenkomen dan kan het wachtwoord opgeslaan worden terug naar login window gegaan worden
            if (passwordInput == passwordRepeatInput)
            { 
                DAOUser.ChangePassword(passwordInput, _gebruiker);

                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                Application.Current.Windows[0]?.Close();
            }
        }


    }
    //------------------------------------------------------------------------------------
}
