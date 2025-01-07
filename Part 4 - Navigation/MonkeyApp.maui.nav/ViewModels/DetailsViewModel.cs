using CommunityToolkit.Mvvm.ComponentModel;
using MonkeyApp.maui.nav.Models;

namespace MonkeyApp.maui.nav.ViewModels
{
    [QueryProperty(nameof(Monkey), nameof(Monkey))]
    public partial class DetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        Monkey monkey;

        public DetailsViewModel()
        {

        }
    }
}
