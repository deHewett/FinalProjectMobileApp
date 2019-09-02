using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalMobileProject.iOS;
using Foundation;
using UIKit;
using SQLite;
using System.IO;


[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_IOS))]
namespace FinalMobileProject.iOS
{
    class DatabaseConnection_IOS : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "Users.db3";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}