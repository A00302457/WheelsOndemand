using WheelsOndemand.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using SQLite;
using WheelsOndemand.Models;
using CoverYourAss.Views;

namespace WheelsOndemand
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        private SQLiteConnection conn;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Init()
        {
            if (conn != null)
                return;

           // conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<User_Info>();
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
        private async void Admin_Login_clicked(object sender, EventArgs e)
        {

            //SemanticScreenReader.Announce(CounterBtn.Text);
            await Navigation.PushAsync(new Admin_Login());
        }
    }
}