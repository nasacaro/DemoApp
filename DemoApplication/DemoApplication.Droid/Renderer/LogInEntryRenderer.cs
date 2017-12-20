using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using DemoApplication;
using DemoApplication.Droid.Renderer;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LogInEntry), typeof(LogInEntryRenderer))]
namespace DemoApplication.Droid.Renderer
{
    class LogInEntryRenderer : EntryRenderer
    {
        public LogInEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var view = (LogInEntry) Element;
            if(view != null)
            {
                SetBorderColor(view);
                SetIcon(view);
            }
        }

        private void SetIcon(LogInEntry view)
        {
            if (string.IsNullOrEmpty(view.Icon))
            {
                Control.SetCompoundDrawablesWithIntrinsicBounds(0, 0, 0, 0);
            }
            else
            {
                try
                {
                    var context = Forms.Context;
                    var resId = context.Resources.GetIdentifier(System.IO.Path.GetFileNameWithoutExtension(view.Icon), "drawable", context.PackageName);
                    Control.SetCompoundDrawablesWithIntrinsicBounds(resId, 0, 0, 0);
                } catch (Exception) { }                
            }
        }

        private void SetBorderColor(LogInEntry view)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(Android.Graphics.Color.White);
            gd.SetStroke(view.BorderThinkness, view.BorderColor.ToAndroid());
            gd.SetCornerRadius(10);
            Control.SetBackgroundDrawable(gd);
            Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
        }
    }
}