using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryUsername.Text) || string.IsNullOrWhiteSpace(entryPassword.Text))
            {
                DisplayAlert("Alert","Username & Password is Required...","Ok");
            }
            else if (entryUsername.Text=="admin" && entryPassword.Text=="12345")
            {
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                DisplayAlert("Alert","Incorrect Username or Password...","Ok");
            }
        }
    }
}