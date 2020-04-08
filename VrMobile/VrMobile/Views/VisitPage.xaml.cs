using System;
using System.Collections.Generic;
using VrMobile.ViewModel;
using Xamarin.Forms;

namespace VrMobile.Views
{
    public partial class VisitPage : ContentPage
    {
        VendorVisitPageViewModel _viewModel;
        public VisitPage()
        {
            _viewModel = new VendorVisitPageViewModel();
            InitializeComponent();
            this.BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            this.visitListView.ItemsSource = _viewModel.Visits;
           
        }
    }
}
