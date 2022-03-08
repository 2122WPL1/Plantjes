using GalaSoft.MvvmLight.Ioc;
using Plantjes.ViewModels.HelpClasses;
using Plantjes.ViewModels.Interfaces;

namespace Plantjes.ViewModels; 

public class ViewModelMain : ViewModelBase {
    private ViewModelBase _currentViewModel;
    private ISearchService _searchService;

    private readonly ViewModelRepo _viewModelRepo;
    //geschreven door kenny, adhv een voorbeeld van roy

    private readonly SimpleIoc iocc = SimpleIoc.Default;

    public IloginUserService loginUserService;

    public ViewModelMain(IloginUserService loginUserService, ISearchService searchService) {
        loggedInMessage = loginUserService.LoggedInMessage();
        _viewModelRepo = iocc.GetInstance<ViewModelRepo>();
        _searchService = searchService;
        this.loginUserService = loginUserService;

        mainNavigationCommand = new MyICommand<string>(_onNavigationChanged);
        //  dialogService.ShowMessageBox(this, "", "");
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

    private void _onNavigationChanged(string userControlName) {
        currentViewModel = _viewModelRepo.GetViewModel(userControlName);
    }
}