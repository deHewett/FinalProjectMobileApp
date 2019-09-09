using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalMobileProject.Models;
using FinalMobileProject.ViewModels;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMobileProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Products : ContentPage
    {
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
        public Products()
        {
            InitializeComponent();
            BindingContext = new ProductViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myDetails = e.Item as Product;
            await Navigation.PushAsync(new ProductId(myDetails.Image, myDetails.Title, myDetails.Price, myDetails.Description));
        }
    }
}