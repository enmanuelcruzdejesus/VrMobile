using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using VrMobile.Models;
using Xamarin.Forms;

namespace VrMobile.ViewModel
{
    public class OrdersToDeliverPageViewModel
    {
        ObservableCollection<string> InvoicesAssigned = new ObservableCollection<string>();
        public ICommand GoToMapCommand { get; set; }
        public ICommand DeliverOrderCommand { get; set; }
        public ICommand SortListByBestRouteCommand { get; set; }
        App _app = (App)App.Current;
        public OrdersToDeliverPageViewModel()
        {
            // 1. Get InvoicesAssigned
            // 2. Implement SortListByBestRouteCommand
            // 3. DeliverOrderCommand : push to other page
            // 4. implement detailed page
            // 5. implement GoToMapCommand


            var x = _app.Db.DeliveryOrders.GetAll();
            foreach(var f in x)
            {
                Console.WriteLine(f);
            }

            GoToMapCommand = new Command<string>((param) =>
            {
                Console.WriteLine("Go to map");
            });

            DeliverOrderCommand = new Command<string>((param) =>
            {
                Console.WriteLine("Deliver Order ");
            });

            SortListByBestRouteCommand = new Command<string>((param) =>
            {
                Console.WriteLine("Sort List By Best Route ");
            });
        }
    }
}
