using System.Collections.Generic;

namespace Plantjes.ViewModels;

//geschreven door kenny adhv een voorbeeld van roy
//herschreven door kenny voor gebruik met ioc
public class ViewModelRepo {
    //singleton pattern
    //private static ViewModelRepo instance;

    private readonly Dictionary<string, ViewModelBase> _viewModels = new();
    private readonly ViewModelAppearance viewModelAppearance = (ViewModelAppearance)App.Current.Services.GetService(typeof(ViewModelAppearance));
    private readonly ViewModelBloom viewModelBloom = (ViewModelBloom)App.Current.Services.GetService(typeof(ViewModelBloom));
    private readonly ViewModelGrooming viewModelGrooming = (ViewModelGrooming)App.Current.Services.GetService(typeof(ViewModelGrooming));
    private readonly ViewModelGrow viewModelGrow = (ViewModelGrow)App.Current.Services.GetService(typeof(ViewModelGrow));
    private readonly ViewModelHabitat viewModelHabitat = (ViewModelHabitat)App.Current.Services.GetService(typeof(ViewModelHabitat));

    private readonly ViewModelNameResult viewModelNameResult = (ViewModelNameResult)App.Current.Services.GetService(typeof(ViewModelNameResult));
    private readonly ViewModelRegister viewModelRegister = (ViewModelRegister)App.Current.Services.GetService(typeof(ViewModelRegister));

    public ViewModelRepo() {
        //hier een extra lijn code per user control
        _viewModels.Add("VIEWNAME", viewModelNameResult);
        _viewModels.Add("VIEWHABITAT", viewModelHabitat);
        _viewModels.Add("VIEWBLOOM", viewModelBloom);
        _viewModels.Add("VIEWGROW", viewModelGrow);
        _viewModels.Add("VIEWAPPEARANCE", viewModelAppearance);
        _viewModels.Add("VIEWGROOMING", viewModelGrooming);
        _viewModels.Add("VIEWREGISTER", viewModelRegister);
    }

    //
    public ViewModelBase GetViewModel(string modelName) {
        ViewModelBase result;
        var ok = _viewModels.TryGetValue(modelName, out result);
        return ok ? result : null;
    }
}