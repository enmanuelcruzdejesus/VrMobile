using System;
using System.Collections.Generic;
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

            var response = await _service.GetAsync("Customer","getall");
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

            var response = await _service.GetByIdAsync("Customer","Download",id);
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




        public RestApiService()
        {
        }



    }
}
