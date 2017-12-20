using DemoApplication.ViewModels;
using DemoApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Forms.Services;
using XLabs.Ioc;
using XLabs.Platform.Services;

namespace DemoApplication
{
    public partial class App : Application
    {
        public App()
        {            
            InitializeComponent();
            RegisterViews();
            //var mainPage = new NavigationPage((Page)ViewFactory.CreatePage<LogInViewModel, LogInPage>());
            var mainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainMasterDetailPageViewModel, MainMasterDetailPage>());
            Resolver.Resolve<IDependencyContainer>().Register<INavigationService>(t => new NavigationService(mainPage.Navigation));
            //container.Register<INavigation>();
            Resolver.Resolve<IDependencyContainer>().Register<INavigation>(mainPage.Navigation);
            MainPage = mainPage;
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
