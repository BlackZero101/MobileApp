using MobileApp.DemoPages.LoginSystem.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.DemoPages.LoginSystem
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.entryPassword.HorizontalTextAlignment = TextAlignment.Center;
            this.entryUsername.HorizontalTextAlignment = TextAlignment.Center;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryUsername.Text) || string.IsNullOrWhiteSpace(entryPassword.Text))
            {
                await DisplayAlert("Alert", "Username & Password is Required", "Ok");
                return;
            }

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userdatabase.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<User>().Where(u=>u.Username.Equals(entryUsername.Text) && u.Password.Equals(entryPassword.Text)).FirstOrDefault();

            if (query!=null)
            {
                App.Current.MainPage =new AppShell();
            }
            else
            {
                await DisplayAlert("Error", "Incorrect Username or Password", "Ok");
                return;
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}