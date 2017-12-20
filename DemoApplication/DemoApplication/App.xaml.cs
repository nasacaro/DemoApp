using DemoApplication.ViewModels;
using DemoApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace DemoApplication
{
    public partial class App : Application
    {
        public App()
        {            
            InitializeComponent();
            RegisterViews();
            MainPage = new NavigationPage((Page)ViewFactory.CreatePage<LogInViewModel, LogInPage>());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void RegisterViews()
        {            
            ViewFactory.Register<LogInPage, LogInViewModel>();
            ViewFactory.Register<MainMasterDetailPage, MainMasterDetailPageViewModel>();
        }
    }
}
