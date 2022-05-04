using System.Net;
using System.Windows;
using System.Windows.Controls;
using Plantjes.ViewModels;

namespace Plantjes.Views.Home; 

/*written by kenny*/
/// <summary>
///     Interaction logic for LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window {
    public LoginWindow() {
        DataContext = App.Current.Services.GetService(typeof(ViewModelLogin));
        InitializeComponent();
    }
        // Entering password
    private void txtWachtwoord_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (DataContext != null) ((dynamic)DataContext)._passwordInput = new NetworkCredential(string.Empty, ((PasswordBox)sender).SecurePassword).Password;
        
    }
    // Password show/Hide using checkbox in login window <Written by Andang Kloran>
    
    private void ckbShowPassword_Checked(object sender, RoutedEventArgs e) => ShowPasswordFunction();

    private void ckbShowPassword_Unchecked(object sender, RoutedEventArgs e) => HidePasswordFunction();


    private void ShowPasswordFunction()
    {
        if (ckbShowPassword.IsChecked == true)
        {
            txbUnmaskPassword.Visibility = Visibility.Visible;
            txtWachtwoord.Visibility = Visibility.Hidden;
            txbUnmaskPassword.Text = txtWachtwoord.Password;
        }
    }
    private void HidePasswordFunction()
    {
        if (ckbShowPassword.IsChecked != true)
        {
            txbUnmaskPassword.Visibility = Visibility.Hidden;
            txtWachtwoord.Visibility = Visibility.Visible;
            txbUnmaskPassword.Text = txtWachtwoord.Password;
        }
    }
}