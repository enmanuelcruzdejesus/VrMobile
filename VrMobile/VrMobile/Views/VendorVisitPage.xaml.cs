using System;
using System.Collections.Generic;
using VrMobile.ViewModel;
using Xamarin.Forms;

namespace VrMobile.Views
{
    public partial class VendorVisitPage : ContentPage
    {

        VendorVisitViewModel viewModel;
        public VendorVisitPage()
        {
            viewModel = new VendorVisitViewModel();
            InitializeComponent();
            this.BindingContext = viewModel.Visitas;
        }
    }
}
