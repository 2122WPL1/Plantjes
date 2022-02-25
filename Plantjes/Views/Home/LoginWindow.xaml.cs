using Plantjes.ViewModels;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace Plantjes.Views.Home
{/*written by kenny*/
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            DataContext = GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.GetInstance<ViewModelLogin>();
            InitializeComponent();
        }

        private void txtWachtwoord_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Xander - PasswordBox
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext)._passwordInput = new NetworkCredential(string.Empty, ((PasswordBox)sender).SecurePassword).Password;
            }
            // end Xander
        }
    }
}
