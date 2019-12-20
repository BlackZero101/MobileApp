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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryUsername.Text) || string.IsNullOrWhiteSpace(entryPassword.Text))
            {
                await DisplayAlert("Congrats", "User Register Successfuly", "Ok");
                return;
            }
            else
            {
                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userdatabase.db");
                var db = new SQLiteConnection(dbPath);
                db.CreateTable<User>();
                var item = new User()
                {
                    Username = entryUsername.Text,
                    Password = entryPassword.Text,
                    Email = entryEmail.Text,
                    Phone = entryPhone.Text,
                };
                db.Insert(item);
                await Navigation.PushAsync(new LoginPage());
            }
            
        }
    }
}