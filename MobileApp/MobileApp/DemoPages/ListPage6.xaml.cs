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
	public partial class ListPage6 : ContentPage
	{
        IEnumerable<Contact> GetContacts(string searchText=null)
        {
            var contacts= new List<Contact>()
            {
                new Contact{ Name="Mark",Status="Hey",ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact{ Name="Mark",Status="What's Up",ImageUrl="http://lorempixel.com/100/100/people/2" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/3" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/4" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/5" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/6" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/7" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/8" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/9" },
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c=>c.Name.StartsWith(searchText));        
        }

		public ListPage6 ()
		{
			InitializeComponent ();

            list.ItemsSource = GetContacts();
		}

        private void List_Refreshing(object sender, EventArgs e)
        {
            list.ItemsSource = GetContacts();
            list.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            list.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}