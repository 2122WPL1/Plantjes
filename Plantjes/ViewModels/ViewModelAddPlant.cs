using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Views.Home;
using System.Windows;

namespace Plantjes.ViewModels
{
    public class ViewModelAddPlant : ViewModelBase
    {
        // Written by Andang -- Changed by Kjell
        public ViewModelAddPlant()
        {
            cancelCommand = new RelayCommand(cancelButton);
        }


        public RelayCommand cancelCommand { get; set; }

        public void cancelButton()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Application.Current.Windows[0]?.Close();
        }
    }
}
//End----------------------------------------------------------------------------------------------