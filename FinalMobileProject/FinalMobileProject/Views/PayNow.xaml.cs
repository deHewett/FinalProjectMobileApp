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
    public partial class PayNow : ContentPage
    {
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
        public PayNow()
        {
            InitializeComponent();
            this.Title = "Pay Now";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            using (conn) {
                conn.DropTable<CartRecord>();
             await   Navigation.PushAsync(new ThankYou());
            }
            
        }
    }
}