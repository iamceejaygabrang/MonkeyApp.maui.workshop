using MonkeyApp.maui.mvvm.ViewModels;

namespace MonkeyApp.maui.mvvm
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
