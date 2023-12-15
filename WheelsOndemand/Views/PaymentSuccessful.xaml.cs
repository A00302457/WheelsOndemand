namespace WheelsOndemand.Views;

public partial class PaymentSuccessful : ContentPage
{
	public PaymentSuccessful()
	{
		InitializeComponent();
	}
    private async void HomeClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.CarListView());

    }
    private async void ExitClicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new Views.PaymentSuccessful());
        Environment.Exit(0);

    }

}