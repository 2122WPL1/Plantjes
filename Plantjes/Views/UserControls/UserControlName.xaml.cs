using Plantjes.ViewModels;
using System.Windows.Controls;

namespace Plantjes.Views.UserControls; 

/// <summary>
///     Interaction logic for UserControlName.xaml
/// </summary>
public partial class UserControlName : UserControl {
    public UserControlName() {
        DataContext = App.Current.Services.GetService(typeof(ViewModelNameResult));
        InitializeComponent();
    }
}