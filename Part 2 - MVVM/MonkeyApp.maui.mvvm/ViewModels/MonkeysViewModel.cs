using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyApp.maui.mvvm.Models;
using System.Collections.ObjectModel;

namespace MonkeyApp.maui.mvvm.ViewModels
{
    public partial class MonkeysViewModel : ObservableObject
    {
        public ObservableCollection<Monkey> Monkeys { get; } = new();

        [ObservableProperty]
        bool isBusy;
        public MonkeysViewModel()
        {
           
        }
    }
}
