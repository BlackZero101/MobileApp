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
	public partial class ListPage2 : ContentPage
	{
		public ListPage2 ()
		{
			InitializeComponent ();

            list.ItemsSource = new List<ContactGroup>()
            {
                new ContactGroup("A","A")
                {
                    new Contact { Name = "Aladin", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Amber", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("B","B")
                {
                    new Contact { Name = "Boss", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Bilal", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("C","C")
                {
                    new Contact { Name = "Charlie", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("D","D")
                {
                    new Contact { Name = "Daemon", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Donald", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "David", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("E","E")
                {
                    new Contact { Name = "Estell", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("F","F")
                {
                    new Contact { Name = "Freddy", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("G","G")
                {
                    new Contact { Name = "George", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Gill", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("H","H")
                {
                    new Contact { Name = "Hannah", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("I","I")
                {
                    new Contact { Name = "Imran", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },
                new ContactGroup("K","K")
                {
                    new Contact { Name = "Kamran", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Kaleem", Status = "Hey", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                }
            };
		}
	}
}