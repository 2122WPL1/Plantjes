using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Dao;

namespace Plantjes.ViewModels
{
    internal class ViewModelUserManagement: ViewModelBase
    {
        private RelayCommand ImportCsvCommand { get; } = new(DAOUser.AddUsersFromCsv);
    }
}
