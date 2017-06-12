using EretailApp.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(LabelRenderer), typeof(BorderLabelRender))]
namespace EretailApp.iOS
{
    class BorderLabelRender : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TextColor = UIColor.DarkGray;
                Control.Layer.BorderColor = UIColor.LightGray.CGColor;
                Control.Layer.BorderWidth = 1.0f;
            }
        }
    }
}
