using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrMobile.Services;
using Xamarin.Forms;

namespace VrMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btnSync.Clicked += async (s, e) =>
            {


                var sync = new SyncService();
                var r1 = await sync.SyncCustomers("2");
                var r2 = await sync.SyncProducts("2");
                var r3 = await sync.SyncInvoices("2");
                var r4 = await sync.SyncSalesOrders();
                var r5 = await sync.SyncDeliveryOrders("2");
                var r6 = await sync.SyncVendorVistis("2");



            };

            this.btnPrint.Clicked += (s, e) =>
            {
                var app = (App)App.Current;
                var cust = app.Db.Customers.GetAll().ToList();
                var prod = app.Db.Products.GetAll().ToList();
                var inv = app.Db.Invoices.GetAll().ToList();
                var invdetail = app.Db.InvoiceDetails.GetAll().ToList();
                var visit = app.Db.VendorVisits.GetAll().ToList();
                var deliveryOrders = app.Db.DeliveryOrders.GetAll().ToList();

                Console.WriteLine("Customers = {0}",cust.Count);
                Console.WriteLine("Products = {0}", prod.Count);
                Console.WriteLine("Invoices = {0}", inv.Count);
                Console.WriteLine("invoicesDetail = {0}", invdetail.Count);
                Console.WriteLine("deliveryorders = {0}", deliveryOrders.Count);
                Console.WriteLine("visits = {0}", visit.Count);
            };
        }
    }
}
