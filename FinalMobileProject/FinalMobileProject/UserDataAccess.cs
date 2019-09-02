using FinalMobileProject.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FinalMobileProject
{
    class UserDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();

        public ObservableCollection<User> Users { get; set; }

        public UserDataAccess()
        {
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();
            database.CreateTable<User>();

            this.Users = new ObservableCollection<User>(database.Table<User>());
            // if empty
            if (!database.Table<User>().Any())
            {
                AddNewUser();
            }
        }
        public void AddNewUser()
        {
            this.Users.Add(new User
            {
                Username = "Username",
                Password = "Password",
                FullName = "FullName",
                Email = "Email",
                ContactNumber = "Contact Number",
                BillingAddress = "Billing Address",
                UserType = "User Type"
            });
        }
    }
}
