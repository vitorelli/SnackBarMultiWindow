using CommunityToolkit.Maui.Alerts;

namespace SnackBarMultiWindow;

public partial class NewPage1 : ContentPage
{
    private readonly MainPage mainPage;

    public NewPage1(MainPage mainPage)
	{
		InitializeComponent();
        this.mainPage = mainPage;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current?.CloseWindow(GetParentWindow());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        using var snack = Snackbar.Make("My msg", duration: TimeSpan.FromSeconds(5), anchor: mainPage);
        snack.Show();
    }
}