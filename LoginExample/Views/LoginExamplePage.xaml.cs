using LoginExample.ViewModels;
using Xamarin.Forms;

namespace LoginExample.Views
{
    public partial class LoginExamplePage : ContentPage
    {
        public LoginExamplePage()
        {
            BindingContext = new LoginExamplePageViewModel();
            InitializeComponent();
        }
    }
}
