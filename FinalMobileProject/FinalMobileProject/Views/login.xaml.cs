using MongoDB.Driver;
using MongoDB.Bson;
using System;
using Xamarin.Forms;


namespace FinalMobileProject.Views
{
    public partial class login : ContentPage
    {
        public login() {
            InitializeComponent();
        }
        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var client = new MongoClient("mongodb+srv://admin:admin@cluster0-gp7ml.mongodb.net/test?retryWrites=true&w=majority");
                var database = client.GetDatabase("WebProject");
                var collection = database.GetCollection<BsonDocument>("User");

                var username = EntryUsername.Text;
                var password = EntryPassword.Text;
                try {
                    var filter = Builders<BsonDocument>.Filter.Eq("username", username);
                    var document = await collection.Find(filter).FirstAsync();
                    BsonValue userPassword;
                    var hashedPW = document.TryGetValue("password", out userPassword);
                    if (Hashing.ValidatePassword(password, userPassword.AsString))
                    {
                        Console.WriteLine("IT WORKED");
                        return; // new NavigationPage(new MainPage());
                    }
                    
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
                /*

                // insert document

                var document = new BsonDocument
                {
                    { "name", "MongoDB" },
                    { "type", "Database" },
                    { "count", 1 },
                    { "info", new BsonDocument
                        {
                            { "x", 203 },
                            { "y", 102 }
                        }}
                };

                collection.InsertOne(document);
                await collection.InsertOneAsync(document);

                // single document filter 
                var filter = Builders<BsonDocument>.Filter.Eq("fullName", "some name");
                var document = await collection.Find(filter).FirstAsync();

                // multiple document filter

                filter = Builders<BsonDocument>.Filter.Gt("userType", "User");
                var cursor = collection.Find(filter).ToCursor();
                foreach (var document in curson.ToEnumerable())
                {
                    Console.WriteLine(document);
                }

                // updating document

                filter = Builder<BsonDocument>.Filter.Eq("contactNumber", "1234");
                var update = Builder<BsonDocument>.Update.Set("contactNumber", "4321");

    */
                
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
            }
        }
    }
}
