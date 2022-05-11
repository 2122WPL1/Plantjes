using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Plantjes.ViewModels;
using System.Net;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Plantjes.Dao;
using Plantjes.ViewModels.Services;

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
