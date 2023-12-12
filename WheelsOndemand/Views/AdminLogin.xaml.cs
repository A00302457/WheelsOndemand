namespace WheelsOndemand.Views;

public partial class AdminLogin : ContentPage
{
	public AdminLogin()
	{
		InitializeComponent();
	}
    private async void Insert_clicked(object sender, EventArgs e)
    {


        await Application.Current.MainPage.DisplayAlert("Success", "Insert completed successfully", "OK");

    }
    private async void Modify_clicked(object sender, EventArgs e)
    {


        await Application.Current.MainPage.DisplayAlert("Success", "Modify completed successfully", "OK");

    }
    private async void Delete_clicked(object sender, EventArgs e)
    {

        await Application.Current.MainPage.DisplayAlert("Success", "Delete completed successfully", "OK");

    }
    private async void BackButton_clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new LoginView());


    }
    private void Exit_clicked(object sender, EventArgs e)
    {

        Environment.Exit(0);

    }
}