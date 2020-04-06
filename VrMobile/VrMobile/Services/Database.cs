using System;
using VrMobile.DAL.Services;
using VrMobile.DAL.Services.Services;
using VrMobile.Models;
using XamCore.Services;

namespace VrMobile.DAL.Services
{
    public class Database
    {
        private IRepository<Customers> _customers = null;
        private IRepository<Products> _products = null;
        private IRepository<SalesOrders> _salesOrders = null;
        private IRepository<SalesOrdersDetail> _salesOrdersDetails = null;
        private IRepository<Payments> _payments = null;
        private IRepository<VendorVisits> _vendorVisits = null;
        private IRepository<Invoices> _invoices = null;
        private IRepository<InvoiceDetails> _invoicesDetail = null;
        private IRepository<DeliveryOrders> _deliveryOrders = null;
        private IRepository<Roles> _roles = null;
        private IRepository<Users> _users = null;
        private IRepository<SyncTables> _syncTables = null;
       

        private string _connectionString;
        private DatabaseContext _context;


        public Database(string connectionString)
        {

            this._connectionString = connectionString;
            this._context = new DatabaseContext(connectionString);
            

        }

        public IRepository<Customers> Customers
        {
            get
            {
                if (_customers == null)
                    _customers = new EntityFrameworkRepo<Customers>(_context);

                return _customers;
            }

        }

        public IRepository<Products> Products
        {
            get
            {
                if (_products == null)
                    _products = new EntityFrameworkRepo<Products>(_context);

                return _products;
            }

        }
        public IRepository<Invoices> Invoices
        {
            get
            {
                if (_invoices == null)
                    _invoices = new EntityFrameworkRepo<Invoices>(_context);

                return _invoices;
            }

        }

        public IRepository<InvoiceDetails> InvoiceDetails
        {
            get
            {
                if (_invoicesDetail == null)
                    _invoicesDetail = new EntityFrameworkRepo<InvoiceDetails>(_context);

                return _invoicesDetail;
            }

        }
        public IRepository<VendorVisits> VendorVisits
        {
            get
            {
                if (_vendorVisits == null)
                    _vendorVisits = new EntityFrameworkRepo<VendorVisits>(_context);

                return _vendorVisits;
            }

        }
        public IRepository<DeliveryOrders> DeliveryOrders
        {
            get
            {
                if (_deliveryOrders == null)
                    _deliveryOrders = new EntityFrameworkRepo<DeliveryOrders>(_context);

                return _deliveryOrders;
            }
        }

        public IRepository<SalesOrders> SalesOrders
        {
            get
            {
                if (_salesOrders == null)
                    _salesOrders = new EntityFrameworkRepo<SalesOrders>(_context);

                return _salesOrders;
            }
        }


        public IRepository<SalesOrdersDetail> SalesDetails
        {
            get
            {
                if (_salesOrdersDetails == null)
                    _salesOrdersDetails = new EntityFrameworkRepo<SalesOrdersDetail>(_context);

                return _salesOrdersDetails;
            }
        }


        public IRepository<Payments> Payments
        {
            get
            {
                if (_payments == null)
                    _payments = new EntityFrameworkRepo<Payments>(_context);

                return _payments;
            }
        }

        public IRepository<SyncTables> SyncTables
        {
            get
            {
                if (_syncTables == null)
                    _syncTables = new EntityFrameworkRepo<SyncTables>(_context);

                return _syncTables;
            }
        }

    
        public IRepository<Users> Users
        {
            get
            {
                if (_users == null)
                    _users = new EntityFrameworkRepo<Users>(_context);

                return _users;
            }
        }




      
    }
}
