using System.Net;
using System.Windows;
using System.Windows.Controls;
using Plantjes.ViewModels;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels
{
    internal class ViewModelNieuwWachtwoord : ViewModelBase
    {
        public ViewModelNieuwWachtwoord(LoginUserService loginUserService)
        {
            _loginService = loginUserService;
        }
        private LoginUserService _loginService { get; }

        
    }
}
