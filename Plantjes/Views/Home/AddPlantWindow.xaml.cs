using Plantjes.ViewModels;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace Plantjes.Views.Home
{
    /// <summary>
    /// Interaction logic for NieuwWachtwoordWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        public AddPlantWindow()
        {
            DataContext = App.Current.Services.GetService(typeof(ViewModelAddPlant));
            InitializeComponent();

            
        }
    }


}
