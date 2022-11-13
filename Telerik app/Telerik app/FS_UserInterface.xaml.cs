namespace Telerik_app;

public partial class FS_UserInterface : ContentPage
{
	public string[] headText = {"First steps", "Label","Buttons", "Images"};

	public string[] mainText = {".Net Maui", "Label text","Buttons text", "Images text"};

	public int clicks = 0;

	public string[] img = new string[6];


    public FS_UserInterface()
	{
		InitializeComponent();

		img[0] = "page_img.png";
		img[1] = "user.png";
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();

		IMage1.Source = img[0];		
	}

	private void NextBtn_Clicked(object sender, EventArgs e)
	{
		clicks ++;

        progressBar.Progress += clicks / 7;

        Questions questions = new Questions();

		questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		clicks--;
        progressBar.Progress -= clicks / 7;

        Questions questions = new Questions();

		questions.QuestionsChange(clicks, headText, mainText, img, First_Text, Second_Text, IMage1);
	}

	private async void ToolbarItem_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Settings());
    }
}