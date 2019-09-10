using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalMobileProject.Services;
using FinalMobileProject.Views;
using MongoDB.Bson;
using MongoDB.Driver;
using FinalMobileProject.Models;


namespace FinalMobileProject
{
    public partial class App : Application
    {
      
        public static String db_path = string.Empty;
        public App()
        {
            try {
                InitializeComponent();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Page1());
            
        }

        public App(string DB_PATH)
        {
            InitializeComponent();
            db_path = DB_PATH;
            MainPage = new NavigationPage(new login())
            {
                BarBackgroundColor = Color.LightGreen
            }; 
        }
        protected override void OnStart()
        {
            // Handle when your app starts
            InitDB();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void InitDB()
        {
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path))
            {
                conn.CreateTable<User>();
                //conn.CreateTable<Product>();
            }
        }
    }
}
