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
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Products())
            {
                BarBackgroundColor = Color.LightGreen
            };
        
            IsPresented = false;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Products());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Bag());
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutPage());
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var button = sender as Button;
            CartRecord cart = new CartRecord();
            if(cart == null)
            {
                button.IsVisible = !button.IsVisible;
            }
            Detail = new NavigationPage(new Cart());
            IsPresented = false;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            
            Detail = new NavigationPage(new Bottles());
            IsPresented = false;
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
            using (conn)
            {
                conn.DropTable<CartRecord>();
                await Navigation.PushAsync(new login());
            }
        }
    }
}