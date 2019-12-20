using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage4 : ContentPage
	{
        private ObservableCollection<Contact> _contacts;

		public ListPage4 ()
		{
			InitializeComponent ();

            _contacts = new ObservableCollection<Contact>()
            {
                new Contact{ Name="Mark",Status="Hey",ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact{ Name="Mark",Status="What's Up",ImageUrl="http://lorempixel.com/100/100/people/2" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/4" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/5" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/7" },
            };

            list.ItemsSource = _contacts;

        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact= menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
    }
}