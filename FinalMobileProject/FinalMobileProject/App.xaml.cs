using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FinalMobileProject.Services;
using FinalMobileProject.Views;
using MongoDB.Bson;
using MongoDB.Driver;


namespace FinalMobileProject
{
    public partial class App : Application
    {
        public static string DB_PATH = string.Empty;
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
            MainPage = new NavigationPage( new login());
        }

        public App(string DB_path)
        {
            InitializeComponent();
            DB_PATH = DB_path;
            MainPage = new NavigationPage(new login());
        }
        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
