using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Plantjes.ViewModels.Services;

namespace Plantjes.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
{
    //xander - global services
    public LoginUserService loginUserService;
    public SearchService searchService;
    public DetailService detailService;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }

    protected virtual void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
    {
        if (Equals(member, val)) return;

        member = val;
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual void RaisePropertyChanged(string propName)
    {
        if (PropertyChanged != null) Task.Run(() => PropertyChanged(this, new PropertyChangedEventArgs(propName)));
    }

    //xander - global binding properties
    public Visibility ShowEditPlants => loginUserService.gebruiker.Rol.CanEditPlants.AsVisibility();
    public Visibility ShowUserManagement => loginUserService.gebruiker.Rol.CanManageUsers.AsVisibility();
}