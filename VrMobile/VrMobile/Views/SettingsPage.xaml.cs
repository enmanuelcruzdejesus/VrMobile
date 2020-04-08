using System;
using System.Collections.Generic;
using VrMobile.ViewModel;
using Xamarin.Forms;

namespace VrMobile.Views
{
    public partial class SettingsPage : ContentPage
    {
        SettingsPageViewModel _viewModel;
        public SettingsPage()
        {
            _viewModel = new SettingsPageViewModel();
            InitializeComponent();
            this.BindingContext = _viewModel;
        }
    }
}
