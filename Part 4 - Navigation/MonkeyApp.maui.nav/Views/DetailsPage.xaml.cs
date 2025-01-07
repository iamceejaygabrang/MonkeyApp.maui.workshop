using MonkeyApp.maui.nav.ViewModels;

namespace MonkeyApp.maui.nav.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel detailsViewModel)
	{
		InitializeComponent();
		BindingContext = detailsViewModel;
	}
}