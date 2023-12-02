namespace WheelsOndemand.Views;

public partial class Payment : ContentPage
{
	public Payment()
	{
		InitializeComponent();
        

    }
    private async void Home_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);

        await Navigation.PushAsync(new TopDeals());
    }
    private async void Submit_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new UserLoginSuccessful());
    }
}