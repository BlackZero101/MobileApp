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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //var imageSource = new UriImageSource { Uri=new Uri("http://lorempixel.com/1920/1080/sports/2") };
            //imageSource.CachingEnabled = false;
            //image.Source = imageSource;

            //image.Source = ImageSource.FromResource("MobileApp.Images.selective-focus-photography-of-tree-leaves-754082.jpg");

        }
	}
}