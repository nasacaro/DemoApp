using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApplication
{
    public class LogInEntry : Entry
    {
        public static readonly BindableProperty FontProperty =
            BindableProperty.Create("Font", typeof(Font), typeof(LogInEntry), new Font());

        public Font Font
        {
            get { return (Font)GetValue(FontProperty); }
            set { SetValue(FontProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create("BorderColor", typeof(Color), typeof(LogInEntry), Color.White);

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderThinknessProperty =
            BindableProperty.Create("BorderThinkness", typeof(int), typeof(LogInEntry), 0);

        public int BorderThinkness
        {
            get { return (int)GetValue(BorderThinknessProperty); }
            set { SetValue(BorderThinknessProperty, value); }
        }

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create("Icon", typeof(string), typeof(LogInEntry), "");

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public LogInEntry()
        {
            this.BackgroundColor = Color.Transparent;
        }
    }
}
