using MonkeyApp.maui.theme.ViewModels;

namespace MonkeyApp.maui.theme
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
