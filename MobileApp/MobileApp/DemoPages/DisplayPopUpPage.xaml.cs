using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DisplayPopUpPage : ContentPage
	{
		public DisplayPopUpPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning","Are You Sure","Yes","No");
            if (response)
            {
                await DisplayAlert("Done", "Your Response will be Saved!", "Ok");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            //if not want destructive button just add null instead of Delete
            var response = await DisplayActionSheet("Title","Cancel","Delete","Copy Link","Message","Call","Email");
            await DisplayAlert("Response", response, "Ok");
        }
    }
}