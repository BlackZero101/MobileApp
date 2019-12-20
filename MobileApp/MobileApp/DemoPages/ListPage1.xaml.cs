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
	public partial class ListPage1 : ContentPage
	{
		public ListPage1 ()
		{
			InitializeComponent ();

            list.ItemsSource = new List<Contact>()
            {
                new Contact{ Name="Mark",Status="Hey",ImageUrl="http://lorempixel.com/100/100/people/1" },
                new Contact{ Name="Mark",Status="What's Up",ImageUrl="http://lorempixel.com/100/100/people/2" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/4" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/5" },
                new Contact{ Name="Mark",Status="",ImageUrl="http://lorempixel.com/100/100/people/7" },
            };
		}
	}
}