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
            MainPage = new MainPage();
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
