using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamMVVMHelloWorld.Navigation.Service;
using XamMVVMHelloWorld.ViewModels;

namespace XamMVVMHelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndPageView : ContentPage
    {
        public EndPageView()
        {
            InitializeComponent();
        }
        public EndPageView(string parameter)
        {
            InitializeComponent();
            var viewModel = App.Locator.EndPage;
            BindingContext = viewModel;

            //if (string.IsNullOrEmpty(parameter))
            //{
            //    viewModel = "No parameter set";
            //}
            //else
            //{
            //    viewModel = parameter
            //}

            viewModel.ParameterText = string.IsNullOrEmpty(parameter) ? "No parameter set" : parameter;
        }
    }
}