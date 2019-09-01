using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FinalMobileProject.Views
{
    public partial class login : ContentPage
    {
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var client = new MongoClient("mongodb+srv://admin:admin@cluster0-gp7ml.mongodb.net/WebProject");
                var database = client.GetDatabase("WebProject");
                InitializeComponent();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }
    }
}