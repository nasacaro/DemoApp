using CoreGraphics;
using DemoApplication;
using DemoApplication.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LogInEntry), typeof(LogInEntryRenderer))]
namespace DemoApplication.iOS.Renderer
{
    public class LogInEntryRenderer : EntryRenderer
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var uiView = new UIView()
            {

            };

            //SetNativeControl(uiView);
        }        
    }
}