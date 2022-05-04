using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Dao;

namespace Plantjes.ViewModels
{
    internal class ViewModelUserManagement: ViewModelBase
    {
        public RelayCommand ImportCsvCommand { get; } = new(DAOUser.AddUsersFromCsv);
    }
}
