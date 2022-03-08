using System.Net;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Ioc;
using Plantjes.ViewModels;

namespace Plantjes.Views.Home; 

/*written by kenny*/
/// <summary>
///     Interaction logic for LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window {
    public LoginWindow() {
        DataContext = SimpleIoc.Default.GetInstance<ViewModelLogin>();
        InitializeComponent();
    }

    private void txtWachtwoord_PasswordChanged(object sender, RoutedEventArgs e) {
        // Xander - PasswordBox
        if (DataContext != null) ((dynamic)DataContext)._passwordInput = new NetworkCredential(string.Empty, ((PasswordBox)sender).SecurePassword).Password;
        // end Xander
    }
}