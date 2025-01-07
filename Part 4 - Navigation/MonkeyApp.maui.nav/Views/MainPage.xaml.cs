using MonkeyApp.maui.nav.ViewModels;

namespace MonkeyApp.maui.nav
{
    public partial class MainPage : ContentPage
    {    
        public MainPage(MonkeysViewModel monkeysViewModel)
        {
            InitializeComponent();
            BindingContext = monkeysViewModel;
        }
    }

}
