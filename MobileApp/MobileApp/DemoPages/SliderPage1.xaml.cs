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
	public partial class SliderPage1 : ContentPage
	{
		public SliderPage1()
		{
			InitializeComponent ();
            slider.Value = 0.5;
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = string.Format("Value is {0:F2}",e.NewValue);
        }
    }
}