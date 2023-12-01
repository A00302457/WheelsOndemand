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
    private void Ram_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void Mazda_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void Dough_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void NissanRough_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void BMW_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void Lembergini_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void Mercedes_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
    private void Home_Click(object sender, EventArgs e)
    {

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }

}