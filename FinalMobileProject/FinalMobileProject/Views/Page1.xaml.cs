using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using FinalMobileProject.Models;
using Xamarin.Forms.Xaml;

namespace FinalMobileProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
        public Page1()
        {
            InitializeComponent();
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Image = Image.Text,
                Title = Title.Text,
                Price = Price.Text,
                Description = Description.Text
            };

            Console.WriteLine("THIS IS PRE INSERT USER OBJECT: " + product.Title);
            using (conn)
            {
                conn.CreateTable<Product>();
                var numberOfRows = conn.Insert(product);
                if(numberOfRows > 0)
                {
                    await DisplayAlert("sucess", "Product has been added", "okay!");
                    await Navigation.PushAsync(new Products());
                }
                else
                {
                    await DisplayAlert("Failure", "Something went wrong, the product wasn't added", "Return");
                }
            }

        }
    }
}