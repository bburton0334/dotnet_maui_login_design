using MauiApp1.Pages;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
    private async void OnSignupClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }
}

