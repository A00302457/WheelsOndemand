namespace WheelsOndemand.Views;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
        InitializeComponent();
	}
    private async void CreateNewAccount_Click(object sender, EventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Success", "Account created successfully", "OK");
        await Navigation.PushAsync(new LoginView());

    }
}