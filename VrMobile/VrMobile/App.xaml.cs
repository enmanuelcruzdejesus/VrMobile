using System;
using VrMobile.DAL.Services;
using VrMobile.Models;
using VrMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCore.Services;

namespace VrMobile
{
    public partial class App : Application
    {


        string BASE_URL = "https://apiquickbooksdemo20200402140023.azurewebsites.net/api/{0}/{1}";

        private Database _db;


        string _uri = null;
        string _authorizationToken;
        string _authorizationMethod = "Basic";




        bool _isLogin = false;
        //Database _database;
      
       


        public static string DbName { get { return "ventasrancherasdb"; } }
        public static string DbFileName { get { return "ventasrancherasdb.db3"; } }
        public static string DbPath { get { return DependencyService.Get<IDbPath>().GetConnection(); } }





        Users _currentUser;





        //public int Cia { get { return _currentUser.cia; } }
        //public string DescripSucursal { get; private set; }
        public Users CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
            }
        }

        public string Uri
        {
            get
            {

                return _uri;
            }
            set
            {
                _uri = value;
            }
        }


        public Database Db
        {
            get
            {
                if(_db == null)
                    _db = new Database(DbPath);

                return _db;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
