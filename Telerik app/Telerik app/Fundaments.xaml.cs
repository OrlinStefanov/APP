namespace Telerik_app;

public partial class Fundaments : ContentPage
{
	public Fundaments()
	{
		InitializeComponent();
	}

    private async void SettingsBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Settings());
    }

}