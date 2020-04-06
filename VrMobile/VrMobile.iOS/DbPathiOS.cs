using System;
using System.IO;
using Foundation;
using VrMobile;
using VrMobile.iOS;
using Xamarin.Forms;
using XamCore.Services;

[assembly: Dependency(typeof(DbPathiOS))]
namespace VrMobile.iOS
{
    public class DbPathiOS : IDbPath
    {
        public DbPathiOS()
        {
        }

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
                var sourcePath = NSBundle.MainBundle.PathForResource(App.DbName, ".db3");
                File.Copy(sourcePath, dbPath);
            }
        }
    }
}
