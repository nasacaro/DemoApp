using DemoApplication.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;
using XLabs.Platform.Services;

namespace DemoApplication.ViewModels
{
    public class LogInViewModel : ViewModel
    {
        public LogInViewModel()
        {
            logInCommand = new Command(DoLogIn);
        }

        private Command logInCommand;
        public Command LogInCommand
        {
            get { return logInCommand; }
            set { SetProperty(ref logInCommand, value); }
        }

        private async void DoLogIn(object obj)
        {
            try
            {
                //await Navigation.PopToRootAsync();
                //await Navigation.PushAsync(new MainMasterDetailPage());
                //NavigationService.NavigateTo<MainMasterDetailPageViewModel>();

                //await Resolver.Resolve<INavigation>().PopAsync();
                //await Resolver.Resolve<INavigation>().PushAsync((Page)ViewFactory.CreatePage<MainMasterDetailPageViewModel, MainMasterDetailPage>(), true);

                //await Navigation.PushModalAsync((Page)ViewFactory.CreatePage<MainMasterDetailPageViewModel, MainMasterDetailPage>());

                //Resolver.Resolve<INavigationService>().NavigateTo<MainMasterDetailPageViewModel>();
                //NavigationService.NavigateTo<MainMasterDetailPageViewModel>();

                //Application.Current.MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainMasterDetailPageViewModel, MainMasterDetailPage>());
                //await Navigation.PopToRootAsync();
                Application.Current.MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainMasterDetailPageViewModel, MainMasterDetailPage>());

            }
            catch (Exception e)
            {

            }
            
        }
    }
}
