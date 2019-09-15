using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalMobileProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Reflection;
using Octokit;
using User = FinalMobileProject.Models.User;

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
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            //string hash = Hashing.HashPassword(Password.Text);
            User contributor = new User()
            {
                Username = Username.Text,
                Password = Password.Text,
                FullName = FullName.Text,
                Email = Email.Text,
                BillingAddress = Address.Text,
            };

            Console.WriteLine("THIS IS PRE INSERT USER OBJECT: " + contributor.Username);

            using (conn)
            {
                if(CheckContributor(contributor))
                {
                    conn.CreateTable<User>();
                    contributor.Password = Hashing.HashPassword(contributor.Password);
                    conn.Insert(contributor);
                    DisplayAlert("ADDED", "User has been added", "Go back");
                    Navigation.PopAsync();
                }
                else
                {
                    DisplayAlert("Sorry", "There was an error uploading the user", "back");
                }
            }
        }
        private bool CheckContributor(User contributor)
        {
            foreach(PropertyInfo contributee in contributor.GetType().GetProperties())
            {
                if(contributee.PropertyType == typeof(string))
                {
                    string value = (string)contributee.GetValue(contributor);
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            }
            return true;
        }


        //not using this button
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            conn.CreateTable<User>();
            var users = conn.Table<User>().ToList();
            Datalist.ItemsSource = users;
        }
    }
}