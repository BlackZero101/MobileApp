﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.DemoPages.ContentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BadgeView : Grid
    {
        public static BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(BadgeView), "0", propertyChanged: (bindable, oldVal, newVal) =>
        {
            var view = (BadgeView)bindable;
            view.BadgeLabel.Text = (string)newVal;
        });

        public static BindableProperty BadgeColorProperty = BindableProperty.Create("BadgeColor", typeof(Color), typeof(BadgeView), Color.Blue, propertyChanged: (bindable, oldVal, newVal) =>
        {
            var view = (BadgeView)bindable;
            view.BadgeCircle.BackgroundColor = (Color)newVal;
        });

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }
        public Color BadgeColor
        {
            get
            {
                return (Color)GetValue(BadgeColorProperty);
            }
            set
            {
                SetValue(BadgeColorProperty, value);
            }
        }
        public BadgeView()
        {
            InitializeComponent();
            BadgeLabel.Text = Text;
            BadgeCircle.BackgroundColor = BadgeColor;
        }
    }
}