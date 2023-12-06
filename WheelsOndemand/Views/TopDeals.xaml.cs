namespace WheelsOndemand.Views;

public partial class TopDeals : ContentPage
{
	public TopDeals()
	{
		InitializeComponent();
	}
    private async void Morecar_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new CarList());
    }
    private async void Rav4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Payment());
    }
    private async void Camry_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Payment());

    }
    private async void Elentra_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Payment());

    }
    private async void Rough_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Payment());

    }
    
}