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

using FinalMobileProject.Validation;
using FluentValidation.Results;

namespace FinalMobileProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //string hash = Hashing.HashPassword(Password.Text);
            User user = new User()
            {
                Username = Username.Text,
                Password = Password.Text,
                FullName = FullName.Text,
                Email = Email.Text,
                ContactNumber = Number.Text,
                BillingAddress = Address.Text,
            };

            Console.WriteLine("THIS IS PRE INSERT USER OBJECT: " + user.Username);

               // User customer = new User();
                CustomerValidator validator = new CustomerValidator();
                ValidationResult results = validator.Validate(user);

                Console.WriteLine("RESULTS: " + results);

                if (!results.IsValid)
                {
                    Console.WriteLine("RESULTS in IF: " + results);
                    await DisplayAlert("Sorry", "Error: "+results, "Okay");

                }
                else {
                SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
                using (conn) { 
                    Console.WriteLine("This is the user: " + user.Password);

                    user.Password = Hashing.HashPassword(Password.Text);
                    Console.WriteLine("This is the user: " + user.Password);

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
                
            }
        }
      
    }
