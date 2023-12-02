namespace WheelsOndemand.Views;

public partial class CarList : ContentPage
{
	public CarList()
	{
		InitializeComponent();
	
	}
    private async void Audi_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());

    }
    private async void Ram_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void Mazda_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void Dough_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void NissanRough_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void BMW_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void Lembergini_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void Mercedes_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new Payment());
    }
    private async void Home_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
        await Navigation.PushAsync(new TopDeals());
    
    }

}