using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.Support
{
    public class FontAwesomeIcon : Label
    {
        public static string Typeface => Device.RuntimePlatform == Device.Android ? "fa-solid-900" : "FontAwesome5Free-Solid";

        public FontAwesomeIcon()
        {
            FontFamily = Typeface;
        }

        public FontAwesomeIcon(string fontAwesomeIcon = null)
        {
            FontFamily = Typeface; //iOS is happy with this, Android needs a renderer to add ".ttf"
            Text = fontAwesomeIcon;
        }
    }

    public static class Icons
    {
        public static readonly string Plus = "\uf067";
        public static readonly string ChevronLeft = "\uf053";
        public static readonly string ChevronRight = "\uf054";
        public static readonly string PlusCircle = "\uf055";
        public static readonly string MinusCircle = "\uf056";
        public static readonly string Edit = "\uf044";
        public static readonly string Trash = "\uf1f8";
        public static readonly string ChartBar = "\uf080";
        public static readonly string Save = "\uf0c7";
        public static readonly string Cancel = "\uf05e";
        public static readonly string Dollar = "\uf155";
        public static readonly string Profile = "\uf2bb";
        public static readonly string Feather = "\uf56b";
        public static readonly string CreditCard = "\uf09d";
    }
}
