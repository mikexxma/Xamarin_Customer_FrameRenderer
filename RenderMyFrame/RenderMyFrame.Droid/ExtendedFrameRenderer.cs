using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using RenderMyFrame;
using RenderMyFrame.Droid;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(ExtendedFrame), typeof(ExtendedFrameRenderer))]
namespace RenderMyFrame.Droid
{
    public class ExtendedFrameRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            var view = e.NewElement as ExtendedFrame;

            if (view != null && ViewGroup != null)
            {
               
                    SetBorderRadius(view);
                
            }

        }

        private void SetBorderRadius(ExtendedFrame view)
        {
            var gd = new GradientDrawable();
            gd.SetShape(ShapeType.Rectangle);
            gd.SetStroke(5, view.OutlineColor.ToAndroid());
           
            gd.SetColor(view.BackgroundColor.ToAndroid());
            Background = gd;

            //NativeView.Layer.CornerRadius = view.BorderRadius;
        }
    }
}