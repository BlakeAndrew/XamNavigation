using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamMVVMHelloWorld.Navigation.Service;
using XamMVVMHelloWorld.ViewModels;

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
            nav.Configure(ViewModelLocator.DetailsPageView, typeof(DetailsPageViewModel));
            nav.Configure(ViewModelLocator.EndPageView, typeof(EndPageViewModel));
            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var firstPage = new NavigationPage(new MainPage());

            nav.Initialize(firstPage);

            //SimpleIoc.Default.Register<INavigationService>(() => nav);

            MainPage = firstPage;
            //InitializeComponent();

            //MainPage = new MainPage();
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
