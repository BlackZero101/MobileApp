using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MobileApp.iOS;
using MobileApp.Support;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircleView), typeof(CircleViewRenderer))]
namespace MobileApp.iOS
{
    public class CircleViewRenderer : BoxRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
                return;

            Layer.MasksToBounds = true;
            Layer.CornerRadius = (float)((CircleView)Element).CornerRadius / 2.0f;
        }

    }
}