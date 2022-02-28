using GalaSoft.MvvmLight.Ioc;
using Plantjes.ViewModels.Interfaces;

namespace Plantjes.ViewModels.HelpClasses; 

/*written by kenny*/
/// <summary>
///     Provider van viewmodels
///     De views worden in de SimpleIoc IoC (Inversion of Control) container geregistreerd
/// </summary>
public class ViewModelProvider {
    public ViewModelProvider() {
        RegisterViewModels();
    }

    private void RegisterViewModels() {
        //basisstructuur kenny, mede gebruikt door Robin
        // gebruik de default instantie (singleton van de SimpleIoc class)
        var iocc = SimpleIoc.Default;

        // haal singletons (elke keer dezelfde instantie) van de services om de viewmodels te voorzien van de nodige services(service locator)
        var loginService = iocc.GetInstance<IloginUserService>();
        var searchService = iocc.GetInstance<ISearchService>();
        var detailService = iocc.GetInstance<IDetailService>();


        // registreer de viewmodels in de IoC Container
        // factory pattern om een instantie te maken van de viewmodels
        // Dependency Injection: constructor injection: injecteer  de services in the constructors van de viewmodels;

        iocc.Register(() => new ViewModelLogin(loginService));
        iocc.Register(() => new ViewModelRegister(loginService));

        iocc.Register(() => new ViewModelBloom(detailService));
        iocc.Register(() => new ViewModelGrooming(detailService));
        iocc.Register(() => new ViewModelGrow(detailService));
        iocc.Register(() => new ViewModelHabitat(detailService));

        iocc.Register(() => new ViewModelAppearance(detailService));
        iocc.Register(() => new ViewModelNameResult(searchService));

        //SimpleIoc.Default.Unregister<ViewModelMain>();
        iocc.Register(() => new ViewModelBase());
        iocc.Register(() => new ViewModelMain(loginService, searchService));
        iocc.Register(() => new ViewModelRepo());
    }
}