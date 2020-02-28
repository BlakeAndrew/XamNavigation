using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;
using XamMVVMHelloWorld.ViewModels;

namespace XamMVVMHelloWorld.ViewModels
{
    public class ViewModelLocator
    {
        public const string MainPage = "MainPage";
        public const string DetailsPageView = "DetailsPageView";
        public const string EndPageView = "EndPageView";
        static ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<DetailsPageViewModel>();
            SimpleIoc.Default.Register<EndPageViewModel>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]

        public MainPageViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainPageViewModel>();
            }
        }

        public DetailsPageViewModel DetailsPage
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DetailsPageViewModel>();
            }
        }
        public EndPageViewModel EndPage
        {
            get
            {
                return SimpleIoc.Default.GetInstance<EndPageViewModel>();
            }
        }
    }
}
