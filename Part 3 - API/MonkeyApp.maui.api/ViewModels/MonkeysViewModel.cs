using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyApp.maui.api.Models;
using MonkeyApp.maui.api.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MonkeyApp.maui.api.ViewModels
{
    public partial class MonkeysViewModel : ObservableObject
    {
        MonkeyService monkeyService;
        public ObservableCollection<Monkey> Monkeys { get; } = new();

        [ObservableProperty]
        bool isBusy;
        public MonkeysViewModel(MonkeyService monkeyService)
        {
            this.monkeyService = monkeyService;
        }

        [RelayCommand]
        async Task GetMonkey()
        {
            try
            {
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();
                if (Monkeys.Count != 0)
                    Monkeys.Clear();

                foreach (var monkey in monkeys)
                    Monkeys.Add(monkey);

                IsBusy = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error", $"Unable to get monkeys: {ex.Message}", "Ok");
                IsBusy = false;
            }
        }
    }
}
