//using Android.Provider;

namespace WheelsOndemand.Views;

public partial class Admin_Login : ContentPage
{
	public Admin_Login()
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

            await Navigation.PushAsync(new MainPage());
        

    }
    private  void Exit_clicked(object sender, EventArgs e)
    {

        Environment.Exit(0);

    }
}