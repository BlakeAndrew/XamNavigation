using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;
using XamMVVMHelloWorld.Navigation.Service;

namespace XamMVVMHelloWorld.ViewModels
{
    
    public class MainPageViewModel : ViewModelBase
    {
        public RelayCommand NavigateCommand { get; set; }
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigateCommand = new RelayCommand(() => { _navigationService.NavigateTo(ViewModelLocator.DetailsPageView, _navigationService); });
        }
    }

}
