using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Forms.Mvvm;

namespace DemoApplication.ViewModels
{
    public class LogInViewModel : ViewModel
    {
        public LogInViewModel()
        {
            Message = "Hello Tung";
        }

        private string _message = "";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
