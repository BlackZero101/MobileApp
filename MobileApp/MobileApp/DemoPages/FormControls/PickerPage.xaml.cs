using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.FormControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
        private IList<ContactMethod> _contactMathods;
		public PickerPage ()
		{
			InitializeComponent ();

            _contactMathods = GetContactMethods();

            foreach (var item in _contactMathods)
            {
                picker.Items.Add(item.Name);
            }
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMathods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "Ok");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod{ Id=1,Name="SMS" },
                new ContactMethod{Id=2,Name="EMail"}
            };
        }

    }

    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}