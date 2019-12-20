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
	public partial class ToolBarItemPage : ContentPage
	{
		public ToolBarItemPage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Clicked","Toolbar Item Clicked","Ok");
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Clicked", "Toolbar Item1 Clicked", "Ok");
        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            DisplayAlert("Clicked", "Toolbar Item2 Clicked", "Ok");
        }
    }
}