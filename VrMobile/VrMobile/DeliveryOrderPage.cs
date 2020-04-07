using System;

using Xamarin.Forms;

namespace VrMobile
{
    public class DeliveryOrderPage : ContentPage
    {
        public DeliveryOrderPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

