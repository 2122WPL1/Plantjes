using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Views.Home;
using System.Windows;

namespace Plantjes.ViewModels
{
    public class ViewModelAddPlant : ViewModelBase
    {
        public ViewModelAddPlant()
        {
            annulerenCommand = new RelayCommand(AnnulerenButtonClick);
        }


        public RelayCommand addPlantCommand { get; set; }
        public RelayCommand annulerenCommand { get; set; }

        public void AnnulerenButtonClick()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Application.Current.Windows[0]?.Close();
        }
    }
}