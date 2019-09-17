using FinalMobileProject.ViewModels;
using FinalMobileProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMobileProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bag : ContentPage
	{
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
        public Bag ()
		{
			InitializeComponent ();
            BindingContext = new BagViewModel();
            
            this.BackgroundImage = "background.jpg";
        }
        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myDetails = e.Item as Bags;
            await Navigation.PushAsync(new ProductId(myDetails.Image, myDetails.Title, myDetails.Price, myDetails.Description));
        }
    }
}