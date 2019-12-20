using MobileApp.Models;
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
	public partial class ListPage3 : ContentPage
	{
		public ListPage3 ()
		{
			InitializeComponent ();

            list.ItemsSource = new List<Contact>()
            {
                new Contact{ Name="Mark",Status="Hey",ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact{ Name="John",Status="What's Up",ImageUrl="http://lorempixel.com/100/100/people/2" },
                new Contact{ Name="Sawer",Status="",ImageUrl="http://lorempixel.com/100/100/people/4" },
                new Contact{ Name="Tommy",Status="",ImageUrl="http://lorempixel.com/100/100/people/5" },
                new Contact{ Name="Bob",Status="",ImageUrl="http://lorempixel.com/100/100/people/7" },
            };
		}

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //list.SelectedItem = null; //to disable selection

            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected",contact.Name,"OK");
        }
    }
}