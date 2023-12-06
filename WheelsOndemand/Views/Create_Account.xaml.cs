namespace WheelsOndemand.Views;

public partial class Create_Account : ContentPage
{
	public Create_Account()
	{
		InitializeComponent();
	}
    private async void CreateNewAccount_Click(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Success", "Insert completed successfully", "OK");
        await Navigation.PushAsync(new MainPage());

    }
}