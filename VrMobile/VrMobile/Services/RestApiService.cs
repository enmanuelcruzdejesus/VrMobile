using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VrMobile.Models;
using XamCore.Utils.Services;

namespace VrMobile.Services
{
    public class RestApiService
    {
        IHttpClient _service;
        App _app = (App)App.Current;
        string _authorizationToken;
        const string _authorizationMethod = "Basic";
        public RestApiService(IHttpClient client)
        {
            _service = client;
            //  _authorizationToken = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", _app.Settings.UserId, _app.Settings.Password)));

        }


        public async Task<List<Customers>> GetAllCustomers()
        {

            var response = await _service.GetAsync("Customer", "getall");
            List<Customers> data = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<Customers>>(content);
                return data;

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return data;
            }
            else
            {
                //WHEN SERVER RAISE ERROR

                var content = response.Content.ReadAsStringAsync().Result;
                dynamic ex = JsonConvert.DeserializeObject(content);
                //LOG EXCEPTION
                return data;
                throw new Exception(ex.Message);
            }


        }




        public async Task<List<Customers>> DownloadCustomers(string id)
        {

            var response = await _service.GetByIdAsync("Customer", "Download", id);
            List<Customers> data = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<Customers>>(content);
                return data;

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return data;
            }
            else
            {
                //WHEN SERVER RAISE ERROR

                var content = response.Content.ReadAsStringAsync().Result;
                dynamic ex = JsonConvert.DeserializeObject(content);
                //LOG EXCEPTION
                return data;
                throw new Exception(ex.Message);
            }


        }

        public async Task<List<Products>> DownloadProducts(string id)
        {

            var response = await _service.GetByIdAsync("Product", "Download", id);
            List<Products> data = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<Products>>(content);
                return data;

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return data;
            }
            else
            {
                //WHEN SERVER RAISE ERROR

                var content = response.Content.ReadAsStringAsync().Result;
                dynamic ex = JsonConvert.DeserializeObject(content);
                //LOG EXCEPTION
                return data;
                throw new Exception(ex.Message);
            }


        }


        public async Task<List<Invoices>> DownloadInvoices(string id)
        {

            var response = await _service.GetByIdAsync("Invoice", "Download", id);
            List<Invoices> data = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<Invoices>>(content);
                return data;

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return data;
            }
            else
            {
                //WHEN SERVER RAISE ERROR

                var content = response.Content.ReadAsStringAsync().Result;
                dynamic ex = JsonConvert.DeserializeObject(content);
                //LOG EXCEPTION
                return data;
                throw new Exception(ex.Message);
            }


        }

        public async Task<List<VendorVisits>> DownloadVendorVisits(string id)
        {

            var response = await _service.GetByIdAsync("VendorVisit", "Download", id);
            List<VendorVisits> data = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<VendorVisits>>(content);
                return data;

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return data;
            }
            else
            {
                //WHEN SERVER RAISE ERROR

                var content = response.Content.ReadAsStringAsync().Result;
                dynamic ex = JsonConvert.DeserializeObject(content);
                //LOG EXCEPTION
                return data;
                throw new Exception(ex.Message);
            }


        }




        public async Task<List<DeliveryOrders>> DownloadDeliverOrders(string id)
        {

            var response = await _service.GetByIdAsync("DeliverOrder", "Download", id);
            List<DeliveryOrders> data = null;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<List<DeliveryOrders>>(content);
                return data;

            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return data;
            }
            else
            {
                //WHEN SERVER RAISE ERROR

                var content = response.Content.ReadAsStringAsync().Result;
                dynamic ex = JsonConvert.DeserializeObject(content);
                //LOG EXCEPTION
                return data;
                throw new Exception(ex.Message);
            }


        }

        public async Task<List<SalesOrders>> UploadSalesOrders(List<SalesOrders> salesOrders)
        {

            var response = await _service.PostAsync<List<SalesOrders>>("SalesOrder", "Upload", salesOrders);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<SalesOrders>>(content);
                return data;

            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return null;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                // //WHEN THE SERVER RAISE AN EXCEPTION                   
                return null;
            }
            else
            {
                return null;
            }



        }

        public async Task<List<Payments>> UploadPayments(List<Payments> payments)
        {
            var response = await _service.PostAsync<List<Payments>>("Payment", "Upload", payments);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<Payments>>(content);
                return data;

            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return null;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                // //WHEN THE SERVER RAISE AN EXCEPTION                   
                return null;
            }
            else
            {
                return null;
            }



        }


        public async Task<List<DeliveryOrders>> UploadDeliveryOrders(List<DeliveryOrders> deliveryOrders)
        {
            var response = await _service.PostAsync<List<DeliveryOrders>>("Payment", "Upload", deliveryOrders);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<DeliveryOrders>>(content);
                return data;

            }
            else if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return null;
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                // //WHEN THE SERVER RAISE AN EXCEPTION                   
                return null;
            }
            else
            {
                return null;
            }

        }




        public RestApiService()
        {
        }



    }
}
