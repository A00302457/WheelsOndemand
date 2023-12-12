namespace WheelsOndemand.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private async void SigninClicked(object sender, EventArgs e)
        {
           // await Application.Current.MainPage.DisplayAlert("Success", "Signin successfully", "OK");
            await Navigation.PushAsync(new CarListView());
        }
        private async void CreateNewAccountClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CreateAccount());
        }
    }
}