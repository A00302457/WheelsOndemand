using WheelsOndemand.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using SQLite;
using WheelsOndemand.Models;


namespace WheelsOndemand
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        private SQLiteConnection conn;
        private string _dbPath =Path.Combine(FileSystem.AppDataDirectory,"cya.db");
        public MainPage()
        {
            InitializeComponent();
        }
        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<User_Info>();
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TopDeals());

        }
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

            
        }
        private void BookNowButton_Click(object sender, EventArgs e)
        {

         
        }
        private void ContactUsButton_Click(object sender, EventArgs e)
        {

           
        }
        private async void Admin_Login_clicked(object sender, EventArgs e)
        {

            
            await Navigation.PushAsync(new Admin_Login());
        }
    }
}