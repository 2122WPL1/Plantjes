using Microsoft.Toolkit.Mvvm.Input;
using Plantjes.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Plantjes.ViewModels
{
    public class ViewModelFilter : ViewModelBase
    {
        public ViewModelFilter()
        {
            annulerenCommand = new RelayCommand(AnnulerenButtonClick);
        }
        public RelayCommand annulerenCommand { get; set; }

        public void AnnulerenButtonClick()
        {
            //var mainWindow = new MainWindow();
            //mainWindow.Show();
            Application.Current.Windows[2]?.Close();

        }
    }
}
