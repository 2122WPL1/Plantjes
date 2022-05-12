using System.Windows;

namespace Plantjes.Views.Home
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml 
    /// Written by Andang Kloran
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
