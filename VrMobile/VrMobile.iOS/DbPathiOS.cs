using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SQLite;
using System.IO;
using Xamarin.Forms;
using XamCore.Services;
using VrMobile.iOS;

[assembly: Dependency(typeof(DbPathiOS))]
namespace VrMobile.iOS
{
    public class DbPathiOS : IDbPath
    {
        public string GetConnection()
        {
            var documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryFolder = Path.Combine(documentsFolder, "..", "Library");
            string dbPath = Path.Combine(libraryFolder, App.DbFileName);
            CopyIfNotExist(dbPath);
            return dbPath;

        }

        private static void CopyIfNotExist(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                var app = (App)App.Current;
                var sourcePath = NSBundle.MainBundle.PathForResource(App.DbName, ".db3");
                File.Copy(sourcePath, dbPath);
            }
        }
    }
}