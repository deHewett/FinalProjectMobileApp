using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalMobileProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace FinalMobileProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);

        public SignUp()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string hash = Hashing.HashPassword(Password.Text);
            User user = new User()
            {
                Username = Username.Text,
                Password = hash,
                FullName = FullName.Text,
                Email = Email.Text,
                BillingAddress = Address.Text,
            };

            Console.WriteLine("THIS IS PRE INSERT USER OBJECT: " + user.Username);


            using (conn)
            {
                conn.CreateTable<User>();
                var numberOfRows = conn.Insert(user);
                if (numberOfRows > 0)
                {
                    await DisplayAlert("Success", "User has been added", "Return");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Failure", "Something went wrong, the User wasn't added", "Return");
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            conn.CreateTable<User>();
            var users = conn.Table<User>().ToList();
            Datalist.ItemsSource = users;
        }
    }
}