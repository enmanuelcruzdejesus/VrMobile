using System;

using Xamarin.Forms;

namespace VrMobile.Views
{
    public class MainVendorPage : TabbedPage
    {
        public MainVendorPage()
        {

            this.Children.Add(new NavigationPage(new VendorVisitPage()) { Title = "Pedidos", Icon = "clientes" });
            this.Children.Add(new NavigationPage(new InvoicePage()) { Title = "Facturas", Icon = "shoppingcarticon" });
            this.Children.Add(new NavigationPage(new SettingsPage()) { Title = "Configuraciones", Icon = "settingsicon" });
        }
    }
}

