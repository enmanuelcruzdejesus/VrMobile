using System;
using System.Collections.Generic;
using VrMobile.ViewModel;
using Xamarin.Forms;

namespace VrMobile.Views
{
    public partial class VisitDetailPage : ContentPage
    {
        VisitDetailPageViewModel _viewModel;
        public VisitDetailPage(VisitDetailPageViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
            this.BindingContext = _viewModel;
        }
    }
}
