using System.Collections.Generic;
using GalaSoft.MvvmLight.Ioc;

namespace Plantjes.ViewModels; 

//geschreven door kenny adhv een voorbeeld van roy
//herschreven door kenny voor gebruik met ioc
public class ViewModelRepo {
    //singleton pattern
    private static readonly SimpleIoc iocc = SimpleIoc.Default;
    //private static ViewModelRepo instance;

    private readonly Dictionary<string, ViewModelBase> _viewModels = new();
    private readonly ViewModelAppearance viewModelAppearance = iocc.GetInstance<ViewModelAppearance>();
    private readonly ViewModelBloom viewModelBloom = iocc.GetInstance<ViewModelBloom>();
    private readonly ViewModelGrooming viewModelGrooming = iocc.GetInstance<ViewModelGrooming>();
    private readonly ViewModelGrow viewModelGrow = iocc.GetInstance<ViewModelGrow>();
    private readonly ViewModelHabitat viewModelHabitat = iocc.GetInstance<ViewModelHabitat>();

    private readonly ViewModelNameResult viewModelNameResult = iocc.GetInstance<ViewModelNameResult>();
    private readonly ViewModelRegister viewModelRegister = iocc.GetInstance<ViewModelRegister>();

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