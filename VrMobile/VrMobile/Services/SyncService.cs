using System;
using System.Linq;
using System.Threading.Tasks;

namespace VrMobile.Services
{
    public class SyncService
    {



        public async Task<int> SyncCustomers(string id)
        {
            var app = (App)App.Current;
            var data = await app.RestApi.DownloadCustomers(id);
            var recordsAffected = 0;
            if (data != null)
                app.Db.Customers.BulkMerge(data);



            return recordsAffected;
        }

        public async Task<int> SyncProducts(string id)
        {
            var app = (App)App.Current;
            var data = await app.RestApi.DownloadProducts(id);
            var recordsAffected = 0;
            if (data != null)
                app.Db.Products.BulkMerge(data);



            return recordsAffected;
        }


        public async Task<int> SyncInvoices(string id)
        {
            var app = (App)App.Current;
            var data = await app.RestApi.DownloadInvoices(id);
            var recordsAffected = 0;
            if (data != null)
            {
                app.Db.Invoices.BulkMerge(data);
                foreach (var item in data)
                {
                    var detail = item.InvoiceDetails;
                    app.Db.InvoiceDetails.BulkMerge(detail);


                }
                app.Db.Invoices.BulkMerge(data);
            }
                



            return recordsAffected;
        }



        public async Task<int> SyncVendorVistis(string id)
        {
            var app = (App)App.Current;
            var data = await app.RestApi.DownloadVendorVisits(id);
            var recordsAffected = 0;
            if (data != null)
                app.Db.VendorVisits.BulkMerge(data);



            return recordsAffected;
        }



        public async Task<int> SyncDeliveryOrders(string id)
        {
            var app = (App)App.Current;
            var data = await app.RestApi.DownloadDeliverOrders(id);
            var recordsAffected = 0;
            if (data != null)
                app.Db.DeliveryOrders.BulkMerge(data);



            return recordsAffected;
        }

        public  async Task<int> SyncSalesOrders()
        {
            var app = (App)App.Current;
            var data = app.Db.SalesOrders.Get(o => o.Status == 2);
            var recordsAffected = 0;
            foreach (var item in data)
            {
                var detail = app.Db.SalesDetails.Get(d => d.IdOrder == item.IdOrder).ToList();
                item.SalesOrdersDetails = detail;
               
            }

         
            if (data != null)
            {
               var r =  await app.RestApi.UploadSalesOrders(data);
                recordsAffected = r.Count();
            }


              



            return recordsAffected;
        }


        public async Task<int> SyncPayments()
        {
            var app = (App)App.Current;
            var data = app.Db.Payments.Get(p => p.Status == 2).ToList();
            
            var recordsAffected = 0;
            if (data != null)
            {
                var r = await app.RestApi.UploadPayments(data);
                recordsAffected = r.Count();
            }




            return recordsAffected;
        }










        public SyncService()
        {
        }
    }
}
