using System.Diagnostics;
using Plantjes.ViewModels.HelpClasses;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels; 

public class ViewModelMain : ViewModelBase {
    private ViewModelBase _currentViewModel;

    private readonly ViewModelRepo _viewModelRepo;
    //geschreven door kenny, adhv een voorbeeld van roy
    

    public ViewModelMain(LoginUserService loginUserService, SearchService searchService) {
        loggedInMessage = loginUserService.LoggedInMessage();
        
        _viewModelRepo = (ViewModelRepo)App.Current.Services.GetService(typeof(ViewModelRepo));
        this.searchService = (SearchService) searchService;
        this.loginUserService = loginUserService;

        mainNavigationCommand = new MyICommand<string>(_onNavigationChanged);
    }

    public MyICommand<string> mainNavigationCommand { get; set; }

    public ViewModelBase currentViewModel {
        get => _currentViewModel;
        set => SetProperty(ref _currentViewModel, value);
    }

    private string _loggedInMessage { get; set; }

    public string loggedInMessage {
        get => _loggedInMessage;
        set {
            _loggedInMessage = value;

            RaisePropertyChanged("loggedInMessage");
        }
    }
    public string rol
    {
        get => loginUserService.gebruiker.Rol.Omschrijving;
    }

    private void _onNavigationChanged(string userControlName) {
        currentViewModel = _viewModelRepo.GetViewModel(userControlName);
    }
}