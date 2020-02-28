using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamMVVMHelloWorld.ViewModels
{
    public class EndPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public RelayCommand NavigateCommand { get; set; }
        private string _parameterText;

        public EndPageViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigateCommand = new RelayCommand(() => { _navigationService.GoBack(); });
        }

        public string ParameterText
        {
            get { return _parameterText; }
            set
            {
                if (_parameterText == value) return;
                _parameterText = value;
                RaisePropertyChanged(() => ParameterText);
            }
        }

    }
}
