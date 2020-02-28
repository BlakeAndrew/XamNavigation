using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamMVVMHelloWorld.Navigation.Service;
using XamMVVMHelloWorld.ViewModels;
using XamMVVMHelloWorld.Views;

namespace XamMVVMHelloWorld
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
        public App()
        {

            var nav = new NavigationService();
            nav.Configure(ViewModelLocator.MainPage, typeof(MainPage));
            nav.Configure(ViewModelLocator.DetailsPageView, typeof(DetailsPageView));
            nav.Configure(ViewModelLocator.EndPageView, typeof(EndPageView));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var firstPage = new NavigationPage(new MainPage());

            nav.Initialize(firstPage);

            MainPage = firstPage;

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
    }
}
