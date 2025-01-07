using CommunityToolkit.Mvvm.ComponentModel;
using MonkeyApp.maui.theme.Models;

namespace MonkeyApp.maui.theme.ViewModels
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
