namespace WheelsOndemand.Views;

public partial class Payment : ContentPage
{
	public Payment()
	{
		InitializeComponent();
	}
    private async void SubmitClicked(object sender, EventArgs e)
    {


        await Application.Current.MainPage.DisplayAlert("Success", "Submit successfully", "OK");

    }
    private async void HomeClicked(object sender, EventArgs e)
    {


        //await Application.Current.MainPage.DisplayAlert("Success", "Submit successfully", "OK");
        await Navigation.PushAsync(new CarListView());

    }
}