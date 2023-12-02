namespace WheelsOndemand.Views;

public partial class UserLoginSuccessful : ContentPage
{
	public UserLoginSuccessful()
	{
		InitializeComponent();
	}
    private async void Signin_Clicked(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new TopDeals());
    }
    private async void Exit_Clicked(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        //await Navigation.PushAsync(new TopDeals());
        Environment.Exit(0);
    }
}