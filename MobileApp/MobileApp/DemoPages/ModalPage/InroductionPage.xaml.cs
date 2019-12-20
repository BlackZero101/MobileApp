using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.ModalPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InroductionPage : ContentPage
	{
		public InroductionPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        //to disable go back functionality for android phones 
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}