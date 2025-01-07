using MonkeyApp.maui.api.ViewModels;

namespace MonkeyApp.maui.api
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
