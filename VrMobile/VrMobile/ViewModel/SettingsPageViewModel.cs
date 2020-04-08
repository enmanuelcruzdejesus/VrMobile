using System;
using System.Windows.Input;
using VrMobile.Services;
using Xamarin.Forms;

namespace VrMobile.ViewModel
{
    public class SettingsPageViewModel: BaseViewModel
    {
        string _syncLog;
        ICommand _syncCommand;
        ICommand _saveCommand;
        ICommand _logoutCommand;

        public string UserName
        {
            get
            {
                var app = (App)App.Current;
                return app.CurrentUser.UserName.ToUpper();
            }
        }


        public ICommand SyncCommand
        {
            get
            {
                _syncCommand = _syncCommand ?? new Command(new Action(OnSync));
                return _syncCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                _saveCommand = _saveCommand ?? new Command(new Action(()=> { }));
                return _saveCommand;
            }
        }

        public ICommand LogOutCommand
        {
            get
            {
                _logoutCommand = _logoutCommand ?? new Command(new Action(()=> { }));
                return _logoutCommand;
            }
        }

        public string SyncLog
        {
            get
            {
                return _syncLog;
            }
            set
            {
                _syncLog = value;
                OnPropertyChanged("SyncLog");
            }
        }


        private async void OnSync()
        {

            var app = (App)App.Current;
            

            if(app.CurrentUser.IdRole == 2)
            {
                SyncLog += String.Format("Customers downloaded with {0} records \n", await SyncService.SyncCustomers(app.CurrentUser.IdUser.ToString()));

                SyncLog += String.Format("Products downloaded with {0} records \n", await SyncService.SyncProducts(app.CurrentUser.IdUser.ToString()));

             //   SyncLog += String.Format("Invoices downloaded with {0} records \n", await SyncService.SyncInvoices(app.CurrentUser.IdUser.ToString()));

                SyncLog += String.Format("visits downloaded with {0} records \n", await SyncService.SyncVendorVistis(app.CurrentUser.IdUser.ToString()));

                SyncLog += String.Format("Orders uploaded with {0} records \n", await SyncService.SyncSalesOrders());

//                SyncLog += String.Format("Payments uploaded with {0} records \n", await SyncService.SyncPayments());

            }

            if(app.CurrentUser.IdRole == 3)
            {
                SyncLog += String.Format("Customers downloaded with {0} records \n", await SyncService.SyncCustomers(app.CurrentUser.IdUser.ToString()));

                SyncLog += String.Format("Products downloaded with {0} records \n", await SyncService.SyncProducts(app.CurrentUser.IdUser.ToString()));

                SyncLog += String.Format("Invoices downloaded with {0} records \n", await SyncService.SyncInvoices(app.CurrentUser.IdUser.ToString()));

                SyncLog += String.Format("deliveryorders downloaded with {0} records \n", await SyncService.SyncDeliveryOrders(app.CurrentUser.IdUser.ToString()));


            }

        }

        public SettingsPageViewModel()
        {
        }
    }
}
