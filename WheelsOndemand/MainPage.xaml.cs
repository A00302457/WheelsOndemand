using WheelsOndemand.Views;
using Microsoft.Maui.Controls;

namespace WheelsOndemand
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TopDeals());

        }
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void BookNowButton_Click(object sender, EventArgs e)
        {

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void ContactUsButton_Click(object sender, EventArgs e)
        {

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}