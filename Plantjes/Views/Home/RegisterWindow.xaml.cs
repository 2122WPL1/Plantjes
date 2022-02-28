using System.Net;
using Plantjes.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Plantjes.Views.Home
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            this.DataContext = GalaSoft.MvvmLight.Ioc.SimpleIoc.Default.GetInstance<ViewModelRegister>();
            InitializeComponent();
        }

        private void txtWachtwoord_PasswordChanged(object sender, RoutedEventArgs e) {// Xander - PasswordBox
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext)._passwordInput = new NetworkCredential(string.Empty, ((PasswordBox)sender).SecurePassword).Password;
            }
            // end Xander
        }
        private void txtWachtwoordHerhaal_OnPasswordChanged(object sender, RoutedEventArgs e) {
            // Xander - PasswordBox
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext)._passwordRepeatInput = new NetworkCredential(string.Empty, ((PasswordBox)sender).SecurePassword).Password;
            }
            // end Xander
        }
    }
}
