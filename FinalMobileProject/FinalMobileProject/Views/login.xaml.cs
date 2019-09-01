using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject.Views
{
    class login
    {
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var client = new MongoClient("mongodb+srv://admin:admin@cluster0-gp7ml.mongodb.net/WebProject");
                var database = client.GetDatabase("WebProject");
                
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
            }
        }
    }
}
