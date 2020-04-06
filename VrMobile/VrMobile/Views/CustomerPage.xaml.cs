using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VrMobile.Views
{
    public partial class CustomerPage : ContentPage
    {
        public CustomerPage()
        {
            InitializeComponent();

            this.btnDownloadCust.Clicked += async (s, e) =>
            {
                var app = (App)App.Current;

                var customers = await app.RestApi.GetAllCustomers();
                var c = app.Db.Customers.BulkMerge(customers);
                Console.WriteLine("customers downloaded with {0} ", customers.Count);

            };
            this.btnPrint.Clicked += (s, e) =>
            {
                var app = (App)App.Current;
                var customers = app.Db.Customers.GetAll();
                foreach (var item in customers)
                {
                    Console.WriteLine("CustomerId = {0} CompanyName = {1}", item.IdCustomer, item.CompanyName);
                }

            };
        }
    }
}
