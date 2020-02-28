using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;
using XamMVVMHelloWorld.Navigation.Service;

namespace XamMVVMHelloWorld.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public RelayCommand NavigationCommand { get; set; }

        public DetailsPageViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigationCommand =
                new RelayCommand(() => { _navigationService.NavigateTo(ViewModelLocator.EndPageView, Parameter ?? string.Empty); });
        }

        public string Parameter { get; set; }
    }
}
