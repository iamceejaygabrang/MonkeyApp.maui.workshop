using MonkeyApp.maui.theme.ViewModels;

namespace MonkeyApp.maui.theme.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel detailsViewModel)
	{
		InitializeComponent();
		BindingContext = detailsViewModel;
	}
}